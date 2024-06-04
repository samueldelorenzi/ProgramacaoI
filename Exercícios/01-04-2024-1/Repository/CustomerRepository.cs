using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_04_2024_1.Models;
using _01_04_2024_1.Data;

namespace _01_04_2024_1.Repository
{
    public class CustomerRepository
    {                
        public void Save(Customer customer, bool autoGenId = true)
        {
            if(autoGenId)
                customer.CustomerId = this.GetNextId();
            DataSet.Customers.Add(customer);
        }

        public Customer Retrieve(int id)
        {            
            foreach(var c in DataSet.Customers)
            {
                if( c.CustomerId == id )                
                    return c;                
            }

            return null;
        }

        public List<Customer> Retrieve()
        {
            return DataSet.Customers;
        }
        public List<Customer> RetrieveByName(string nome)
        {
            List<Customer> retorno = new List<Customer>();
            foreach( var c in DataSet.Customers)
            {
                if(c.Name.Contains(nome))
                {
                    retorno.Add(c);
                }
            }
            return retorno;
        }

        public bool ImportFromTxt(string line, string delimiter)
        {
            if (string.IsNullOrWhiteSpace(line))
                return false;

            string[] data = line.Split(delimiter);
            


            if (data.Count() < 1)
                return false;

            Customer c = new Customer
            {
                CustomerId = Convert.ToInt32(data[0]),
                Name = (data[1] == null ? string.Empty : data[1]),
                EmailAddress = data[2] ?? string.Empty
            };

            Save(c, false);

            return true;
        }
        private int GetNextId()
        {
            int n = 0;
            foreach (var c in DataSet.Customers)
            {
                if (c.CustomerId > n) n = c.CustomerId;
            }
            return ++n;
        }
    }
}