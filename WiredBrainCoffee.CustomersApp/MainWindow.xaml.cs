using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WiredBrainCoffee.CustomersApp.DataProvider;
using WiredBrainCoffee.CustomersApp.Model;
using WiredBrainCoffee.CustomersApp.ViewModel;

namespace WiredBrainCoffee.CustomersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            this.InitializeComponent();
            ViewModel = new MainViewModel(new CustomerDataProvider());
            DataContext = ViewModel;
            this.Loaded += MainWindow_Loaded;
            this.Closing += MainWindow_ClosingAsync; ;
        }
        public MainViewModel ViewModel { get; }

        private  void MainWindow_ClosingAsync(object sender, System.ComponentModel.CancelEventArgs e)
        {
             ViewModel.SaveAsync();
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadAsync();
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
            ViewModel.AddCustomer();
        }

        private void ButtonDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.DeleteCustomer();
        }
    }
}
