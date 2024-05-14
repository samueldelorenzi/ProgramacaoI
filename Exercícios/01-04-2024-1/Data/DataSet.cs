using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_04_2024_1.Models;

namespace _01_04_2024_1.Data
{
    public class DataSet
    {
        public static List<Address> Addresses { get; set; } = new List<Address>();
        public static List<Customer> Customers { get; set; } = new List<Customer>();
    }
}