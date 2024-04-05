using _01_04_2024_1.Models;

Customer c1 = new(1)
{
    Name = "Saci",
    EmailAdress = "saci@entendi.com"
};

Console.WriteLine($"{c1.CustomerId} {c1.Name} {c1.EmailAdress}");
