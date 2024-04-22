using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_04_2024_1.Data;
using _01_04_2024_1.Models;

namespace _01_04_2024_1.Repository
{
    public class CustomerRepository
    {

        public void Save(Customer customer)
        {
            DataSet.Customers?.Add(customer);
        }
        public Customer Retrieve(int id)
        {
            foreach (var c in DataSet.Customers)
            {
                if (c.CustomerId == id)
                {
                    return c;
                }
            }
            return null;
        }
    }
}