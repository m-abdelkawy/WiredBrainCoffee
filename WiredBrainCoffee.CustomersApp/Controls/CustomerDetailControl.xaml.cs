using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp.Controls
{
    /// <summary>
    /// Interaction logic for CustomerDetailControl.xaml
    /// </summary>
    [ContentProperty(name:nameof(Customer))]
    public partial class CustomerDetailControl : UserControl
    {
        private Customer _customer;
        private bool _isSettingCustomer = false;

        public CustomerDetailControl()
        {
            InitializeComponent();
        }

        public Customer Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                _isSettingCustomer = true;

                //populate text box values with customer properties
                txtFirstName.Text = _customer?.FirstName ?? "";
                txtLastName.Text = _customer?.LastName ?? "";
                chkIsDeveloper.IsChecked = _customer?.IsDeveloper;

                _isSettingCustomer = false;
            }
        }

        private void CheckBox_IsCheckedChanged(object sender, RoutedEventArgs e)
        {
            UpdateCustomer();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateCustomer();
        }

        private void UpdateCustomer()
        {
            if (_isSettingCustomer)
            {
                return;
            }

            if (Customer != null)
            {
                Customer.FirstName = txtFirstName.Text;
                Customer.LastName = txtLastName.Text;
                Customer.IsDeveloper = chkIsDeveloper.IsChecked.GetValueOrDefault();
            }
        }
    }
}
