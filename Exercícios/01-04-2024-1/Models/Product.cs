using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_04_2024_1.Models
{
    public class Product
    {
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public string? CurrentPrice { get; set; }
        public bool Validate()
        {
            return true;
        }
    }
}