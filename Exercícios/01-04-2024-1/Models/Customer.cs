
namespace _01_04_2024_1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public override string ToString()
        {
            return $"{CustomerId} - {Name} - {EmailAddress}";
        }
    }
}