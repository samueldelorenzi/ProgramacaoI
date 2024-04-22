using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_04_2024_1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer? Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string? ShippingAddress { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
        public bool Validate()
        {
            return true;
        }
    }
}