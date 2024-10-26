using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entities;
using Microsoft.IdentityModel.Tokens;

namespace AirConditionerShop_NguyenThanhNam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AirConService _airConService = new();
        public StaffMember AccountMember { get; set; }
        public bool _andOperator = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillDataGrid();

            HelloLabel.Content = "Hello, "+AccountMember.FullName;

            if (AccountMember.Role == 2)
            {
                CreateButton.IsEnabled = false;
                UpdateButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }
        }

        private void FillDataGrid()
        {
            AirConsDataGrid.ItemsSource = null;
            AirConsDataGrid.ItemsSource = _airConService.GetAllAirConditioners();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detailWindow = new DetailWindow();
            detailWindow.ShowDialog();
            FillDataGrid();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            AirConditioner? selected = AirConsDataGrid.SelectedItem as AirConditioner;
            if (selected == null)
            {
                MessageBox.Show("Please select a row before editing", "Select a row",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            DetailWindow detailWindow = new DetailWindow();
            detailWindow.EditConditioner = selected;
            detailWindow.ShowDialog();
            FillDataGrid();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            AirConditioner? selected = AirConsDataGrid.SelectedItem as AirConditioner;
            if (selected == null)
            {
                MessageBox.Show("Please select a row before deleting", "Select a row",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            MessageBoxResult answer = MessageBox.Show("Do you really want to delete?", "Confirm?"
                , MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                _airConService.DeleteAirCon(selected);
                FillDataGrid();
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Validate input data
            int? quantity = null;
            int tmpQuantity;
            bool quantityStatus = int.TryParse(QuantityTextBox.Text, out tmpQuantity);
            if (!quantityStatus && !QuantityTextBox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Incorrect Quantity. Please type an integer!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (quantityStatus) 
            {
                quantity = tmpQuantity;
            }
            // Search Content
            List<AirConditioner> airConditioners = _airConService.SearchByFeatureAndQuantity(FeatureTextBox.Text, quantity, _andOperator);
            // Fill in data grid
            AirConsDataGrid.ItemsSource = null;
            AirConsDataGrid.ItemsSource = airConditioners;
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            _andOperator = !_andOperator;
            if (_andOperator)
            {
                OperatorButton.Content = "And";
            }
            else
            {
                OperatorButton.Content = "Or";
            }
        }
    }
}