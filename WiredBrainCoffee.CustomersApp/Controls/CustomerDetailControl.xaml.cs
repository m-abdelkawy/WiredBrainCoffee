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
    [ContentProperty(name: nameof(Customer))]
    public partial class CustomerDetailControl : UserControl
    {
        // Using a DependencyProperty as the backing store for Customer.  
        //This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomerProperty =
            DependencyProperty.Register("Customer", typeof(Customer), typeof(CustomerDetailControl), new PropertyMetadata(null, null));
        private bool _isSettingCustomer = false;

        public CustomerDetailControl()
        {
            InitializeComponent();
        }



        public Customer Customer
        {
            get { return (Customer)GetValue(CustomerProperty); }
            set { SetValue(CustomerProperty, value); }
        }
    }
}
