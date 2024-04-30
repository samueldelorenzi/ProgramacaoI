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
        public void Save(Customer customer)
        {
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
        private int GetNextId()
        {
            int n = 0;
            foreach (var c in DataSet.Customers)
            {
                if (c.CustomerId > n) n = c.CustomerId;
            }
            return n++;
        }
    }
}