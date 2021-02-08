using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WiredBrainCoffee.CustomersApp.DataProvider;
using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerDataProvider _customerDataProvider;

        public MainWindow()
        {
            this.InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.Closing += MainWindow_ClosingAsync; ;
            _customerDataProvider = new CustomerDataProvider();
        }

        private void MainWindow_ClosingAsync(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _customerDataProvider.SaveCustomersAsync(customerListView.Items.OfType<Customer>()).Wait();
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            customerListView.Items.Clear();
            var lstCustomer = await _customerDataProvider.LoadCustomersAsync();
            foreach (var customer in lstCustomer)
            {
                customerListView.Items.Add(customer);
            }
        }

        private void ButtonMove_Click(object sender, RoutedEventArgs e)
        {
            //int colPropValue = (int)gridCustomerList.GetValue(Grid.ColumnProperty) == 0 ? 2 : 0;
            int colPropValue = Grid.GetColumn(gridCustomerList) == 0 ? 2 : 0;

            //gridCustomerList.SetValue(Grid.ColumnProperty, colPropValue);
            Grid.SetColumn(gridCustomerList, colPropValue);

            string iconLeftRight = colPropValue == 0 ? "right" : "left";

            string srcIconPath = Path.Combine(Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"))
                    , $@"Assets/Icons/arrow_{iconLeftRight}.png");

            leftRightIconImg.Source = new BitmapImage(new Uri(srcIconPath));
        }

        private void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer { FirstName = "New" };
            customerListView.Items.Add(customer);
            customerListView.SelectedItem = customer;
        }

        private void ButtonDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            var customer = customerListView.SelectedItem as Customer;
            if(customer != null)
            {
                customerListView.Items.Remove(customer);
            }
        }

    }
}
