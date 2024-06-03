
namespace _01_04_2024_1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public string PrintToExportDelimited()
        {
            return $"{CustomerId};{Name};{EmailAddress}";
        }
        public string PrintToExportComposed()
        {
            return string.Format("{0,-10} {1,-40} {2,-40}", CustomerId, Name, EmailAddress);
        }
        public override string ToString()
        {
            return $"{CustomerId} - {Name} - {EmailAddress}";
        }
    }
}
