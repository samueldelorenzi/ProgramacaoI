using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_04_2024_1.Models;
using _01_04_2024_1.Repository;
using _01_04_2024_1.Utils;

namespace _01_04_2024_1.Controllers
{
    public class CustomerController
    {
        private CustomerRepository customerRepository;
        public CustomerController()
        {
            customerRepository = new CustomerRepository();
        }
        public void Insert(Customer customer)
        {
            customerRepository.Save(customer);
        }
        public Customer GetCustomerById(int id)
        {
            return customerRepository.Retrieve(id);
        }
        public List<Customer> Get()
        {
            return customerRepository.Retrieve();
        }
        public List<Customer> GetByName(string nome)
        {
            return customerRepository.RetrieveByName(nome);
        }
        public void ExportToDelimited()
        {
            List<Customer> list = customerRepository.Retrieve();

            string fileContent = string.Empty;
            foreach (var c in list)
            {
                fileContent += $"{c.PrintToExportDelimited()}\n";
            }

            string fileName = $"Customer_{DateTimeOffset.Now.ToUnixTimeSeconds()}.txt";
            ExportToFile.SaveToDelimitedTxt(fileName, fileContent);

        }
    }
}