using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WiredBrainCoffee.CustomersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var msgBox = MessageBox.Show("Customer Added~");

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

        private void ButtonDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
