using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18_03_2024.Models
{
    public class Address
    {
        public int AdressId {get; set;}
        public string ? Street {get; set;}
        public string ? District {get; set;}
        public int Number {get; set;}
        public string ? City {get; set;}
        public string ? FederalState {get; set;}
        public string ? Country {get; set;}
        public string ? ZipCode {get; set;}
        public AdressType AdressType {get; set;}
    }
    public enum AdressType
    {
        Commercial,
        Residential
    }
}