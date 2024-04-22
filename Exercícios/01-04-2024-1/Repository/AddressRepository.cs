using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_04_2024_1.Data;
using _01_04_2024_1.Models;

namespace _01_04_2024_1.Repository
{
    public class AddressRepository
    {
        public void Save(Address address)
        {
            DataSet.Addresses?.Add(address);
        }
        public Address Retrieve(int id)
        {
            foreach (var a in DataSet.Addresses)
            {
                if (a.Id == id)
                {
                    return a;
                }
            }
            return null;
        }
    }
}