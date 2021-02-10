using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp.DataProvider
{
    public class CustomerDataProvider : ICustomerDataProvider
    {
        private static readonly string _customersFileName = "customers.json";

        public Task<IEnumerable<Customer>> LoadCustomersAsync()
        {
            IEnumerable<Customer> customerList;
            if (!File.Exists(_customersFileName))
            {
                customerList = new List<Customer>
                {
                  new Customer{FirstName="Thomas",LastName="Huber",IsDeveloper=true},
                  new Customer{FirstName="Anna",LastName="Rockstar",IsDeveloper=true},
                  new Customer{FirstName="Julia",LastName="Master"},
                  new Customer{FirstName="Urs",LastName="Meier",IsDeveloper=true},
                  new Customer{FirstName="Sara",LastName="Ramone"},
                  new Customer{FirstName="Elsa",LastName="Queen"},
                  new Customer{FirstName="Alex",LastName="Baier", IsDeveloper=true},
                };
            }
            else
            {
                var json = File.ReadAllText(_customersFileName);
                customerList = JsonConvert.DeserializeObject<List<Customer>>(json);
            }

            return Task.FromResult(customerList);
        }

        public Task SaveCustomersAsync(IEnumerable<Customer> customers)
        {
            var json = JsonConvert.SerializeObject(customers, Formatting.Indented);
            File.WriteAllText(_customersFileName, json);
            return Task.CompletedTask;
        }


        #region old code
        /*private static readonly string _customerFileName = "customers.json";
        private static readonly string _storageFile = Path
            .Combine(Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"))
                    , $@"Storage/{_customerFileName}");

        public async Task<IEnumerable<Customer>> LoadCustomersAsync()
        {
            List<Customer> lstCustomer = null;
            if (_storageFile == null)
            {
                lstCustomer = new List<Customer>
                {
                    new Customer{FirstName="Thomas",LastName="Huber",IsDeveloper=true},
                    new Customer{FirstName="Anna",LastName="Rockstar",IsDeveloper=true},
                    new Customer{FirstName="Julia",LastName="Master"},
                    new Customer{FirstName="Urs",LastName="Meier",IsDeveloper=true},
                    new Customer{FirstName="Sara",LastName="Ramone"},
                    new Customer{FirstName="Elsa",LastName="Queen"},
                    new Customer{FirstName="Alex",LastName="Baier",IsDeveloper=true},
                };
            }
            else
            {
                using (var sr = new StreamReader(_storageFile))
                {
                    string json = await sr.ReadToEndAsync();
                    lstCustomer = JsonConvert.DeserializeObject<List<Customer>>(json);
                }
            }

            return lstCustomer;
        }

        public async Task SaveCustomersAsync(IEnumerable<Customer> customers)
        {
            using (var streamWriter = new StreamWriter(_storageFile))
            {
                var json = JsonConvert.SerializeObject(customers, Formatting.Indented);
                await streamWriter.WriteAsync(json);
            }
        }*/

        #endregion
    }
}
