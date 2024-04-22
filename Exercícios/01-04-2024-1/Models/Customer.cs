using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace _01_04_2024_1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? EmailAdress { get; set; }
        public List<Address>? Adresses { get; set; }

        public Customer(int id)
        {
            CustomerId = id;
        }
        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;
            return isValid;
        }
    }
}