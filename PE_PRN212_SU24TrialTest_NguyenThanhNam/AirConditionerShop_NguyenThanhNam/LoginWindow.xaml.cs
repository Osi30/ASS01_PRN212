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
using Microsoft.IdentityModel.Tokens;

namespace AirConditionerShop_NguyenThanhNam
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private MemberService _memberService = new();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // No input email or password
            if (EmailTextBox.Text.IsNullOrEmpty() || PasswordTextBox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Both email and password are required", "Required fields", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            StaffMember? account = _memberService.Authenticate(EmailTextBox.Text, PasswordTextBox.Text);
            // Null account
            if (account == null)
            {
                MessageBox.Show("Invalid email or password", "Wrong credentials", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            // Account with role 3 (Manager) 
            if (account.Role == 3)
            {
                MessageBox.Show("You have no permission to access this function!", "Access Denied", MessageBoxButton.OK, MessageBoxImage.Warning);
                return ;
            }
            // Account found
            MainWindow mainWindow = new MainWindow();
            mainWindow.AccountMember = account;
            mainWindow.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
