using _18_03_2024.Models;

Customer c1 = new Customer();

c1.CustomerId = 1;
c1.FirstName = "Samuel";
c1.Lastname = "Ribeiro";
c1.BirthDate = new DateTime();
c1.EmailAdress = "samueldelorenziribeiro@gmail.com";

Address address1 = new Address();
address1.AdressId = 1;
address1.Street = "Mogi das cruzes";
address1.District = "Lagoas";
address1.City = "Rio de Janeiro";
address1.Number = 12;
address1.FederalState = "RJ";
address1.Country = "Brazilian";
address1.ZipCode = "12345-000";

Address address2 = new()
{
    AdressId = 2,
    Street = "Rua das cerejas",
    District = "Laranjeiras",
    City = "Belo Horizonte",
    Number = 223,
    FederalState = "MG",
    Country = "Brazilian",
    ZipCode = "12321-222",
};

c1.Addresses.Add(address1);
c1.Addresses.Add(address2);

Console.WriteLine($"Nome: {c1.FirstName} {c1.Lastname}\nEmail: {c1.EmailAdress}");

Console.WriteLine("Endereços:");
foreach(var ad in c1.Addresses)
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Rua: {ad.Street}\nBairro: {ad.District}\nEstado: {ad.FederalState}\nPaís: {ad.Country}\nNúmero: {ad.Number}");
}

