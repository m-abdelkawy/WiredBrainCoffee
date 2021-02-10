using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WiredBrainCoffee.CustomersApp.Base;
using WiredBrainCoffee.CustomersApp.Commands;
using WiredBrainCoffee.CustomersApp.DataProvider;
using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp.ViewModel
{
    public class MainViewModel : Observable
    {
        private Customer _selectedCustomer;
        private ICustomerDataProvider _customerDataProvider;
        public MainViewModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider;
            Customers = new ObservableCollection<Customer>();

            DeleteCustomerCommand = new DelegateCommand(OnDeleteCustomerExecute, OnDeleteCustomerCanExecute);
        }

        private bool OnDeleteCustomerCanExecute(object arg)
        {
            return IsCustomerSelected;
        }

        private void OnDeleteCustomerExecute(object obj)
        {
            if (IsCustomerSelected)
            {
                Customers.Remove(SelectedCustomer);
                SelectedCustomer = null;
            }
        }

        public ICommand DeleteCustomerCommand { get; private set; }

        public bool IsCustomerSelected => SelectedCustomer != null;
        public ObservableCollection<Customer> Customers { get; private set; }

        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                if (_selectedCustomer != value)
                {
                    _selectedCustomer = value;
                    //to notify data binding with changes to this propert
                    //worked fine without it actually!
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(IsCustomerSelected));
                }
            }
        }

        public async Task LoadAsync()
        {
            Customers.Clear();
            var lstCustomer = await _customerDataProvider.LoadCustomersAsync();
            foreach (var customer in lstCustomer)
            {
                Customers.Add(customer);
            }
        }

        internal void SaveAsync()
        {
            _customerDataProvider.SaveCustomersAsync(Customers).Wait();
        }

        public void AddCustomer()
        {
            var customer = new Customer { FirstName = "New" };
           Customers.Add(customer);
            SelectedCustomer = customer;
        }

        public void DeleteCustomer()
        {
            var customer = SelectedCustomer;
            if (customer != null)
            {
                Customers.Remove(customer);
                SelectedCustomer = null;
            }
        }
    }
}
