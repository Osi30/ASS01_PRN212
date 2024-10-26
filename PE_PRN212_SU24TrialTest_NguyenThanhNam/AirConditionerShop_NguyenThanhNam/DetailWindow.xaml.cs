using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entities;

namespace AirConditionerShop_NguyenThanhNam
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        private AirConService _airConService = new();
        private SupplierService _supplierService = new();

        // A Flag attribute to know when to update (!null) or add (null)
        public AirConditioner? EditConditioner { get; set; } = null;

        public DetailWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Validate here
                
            // Save process
            AirConditioner airConditioner = new();
            // ID will automatically increase and not to be in Update function
            airConditioner.AirConditionerId = int.Parse(AirConIDTextBox.Text);
            //
            airConditioner.AirConditionerName = AirConNameTextBox.Text;
            airConditioner.Warranty = WarrantyTextBox.Text;
            airConditioner.SoundPressureLevel = SoundLevelTextBox.Text;
            airConditioner.FeatureFunction = FeatureFunctionTextBox.Text;
            airConditioner.Quantity = int.Parse(QuantityTextBox.Text);
            airConditioner.DollarPrice = float.Parse(PriceTextBox.Text);
            airConditioner.SupplierId = SupplierIDComboBox.SelectedValue.ToString();

            if (EditConditioner==null)
                _airConService.AddAirCons(airConditioner);
            else 
                _airConService.UpdateAirCon(airConditioner);

            this.Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboBox();
            FillElements(EditConditioner);
            if (EditConditioner == null)
                DetailWindowLabel.Content = "Add New Air Conditioner";
            else
                DetailWindowLabel.Content = "Update Air Conditioner";
        }

        private void FillElements(AirConditioner? airConditioner)
        {
            if (airConditioner != null)
            {
                AirConIDTextBox.Text = airConditioner.AirConditionerId.ToString();
                AirConIDTextBox.IsEnabled = false;
                AirConNameTextBox.Text = airConditioner.AirConditionerName;
                WarrantyTextBox.Text = airConditioner.Warranty;
                SoundLevelTextBox.Text = airConditioner.SoundPressureLevel;
                FeatureFunctionTextBox.Text = airConditioner.FeatureFunction;
                QuantityTextBox.Text = airConditioner.Quantity.ToString();
                PriceTextBox.Text = airConditioner.DollarPrice.ToString();
                SupplierIDComboBox.SelectedValue = airConditioner.SupplierId;
            }
        }

        private void FillComboBox()
        {
            SupplierIDComboBox.ItemsSource = _supplierService.GetAll();
            // Hiển thị column nào
            SupplierIDComboBox.DisplayMemberPath = "SupplierName";
            // Chọn column nào là FK tới bảng Air Conditioner
            SupplierIDComboBox.SelectedValuePath= "SupplierId";
            // Khi user chọn thì value của cột supplier ID sẽ được đổ vào prop Selected Value

        }
    }
}
