using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_04_2024_1.Models;
using _01_04_2024_1.Repository;

namespace _01_04_2024_1.Controllers
{
    public class AddressController
    {
        private AddressRepository addressRepository;

        public AddressController()
        {
            this.addressRepository = new AddressRepository();
        }

        public Address Insert(Address address)
        {
            this.addressRepository.Save(address);
            return address;
        }
        public Address Get(int id)
        {
            return addressRepository.Retrieve(id);
        }
        public List<Address> Get()
        {
            return addressRepository.Retrieve();
        }
    }
}