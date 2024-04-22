using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_04_2024_1.Models;
using _01_04_2024_1.Data;

namespace _01_04_2024_1.Repository
{
    public class OrderRepository
    {
        public void Save(Order order)
        {
            DataSet.Orders?.Add(order);
        }
        public Customer Retrieve(int id)
        {
            foreach(var o in DataSet.Orders)
            {
                if(o.Id == id)
                {
                    return o;
                }
            }
            return null;
        }
    }
}