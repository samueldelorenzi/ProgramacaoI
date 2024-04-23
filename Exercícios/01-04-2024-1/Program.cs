using _01_04_2024_1.Models;
using _01_04_2024_1.Views;
using System.Threading;

/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Marcos";
c1.EmailAddress = "marcos@mion.net";

// Construtor de Instanciação
Customer c2 = new Customer(2);
c1.Name = "Michel";
c1.EmailAddress = "michel@telo.net";

// Construtor por atribuição
Customer c3 = new Customer{
    CustomerId = 3,
    Name = "Shrek",
    EmailAddress = "shrek@fiona.com"
};*/



bool aux = true;
do{
    Console.WriteLine("MENU GERAL");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Menu consumidor");
    Console.WriteLine("2 - Menu produto");
    Console.WriteLine("3 - Menu pedido");
    Console.WriteLine("0 - Sair");

    int menu = 0;
    try
    {
        menu = Convert.ToInt32(Console.ReadLine());
        switch(menu)
        {
            case 0:
                aux = false;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Volte sempre!");
                Console.ResetColor();
                Console.WriteLine("");
            break;
            case 1:
                Console.WriteLine("");
                CustomerView customerView = new CustomerView();
            break;
            case 2:
                Console.WriteLine("");
                ProductView productView = new ProductView();
            break;
            case 3:
                Console.WriteLine("");
                OrderView orderView = new OrderView();
            break;
            default:
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção inválida.");
                Console.ResetColor();
                Console.WriteLine("");
                await Task.Delay(1000);
            break;
        }
    }
    catch
    {
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Opção inválida.");
        Console.ResetColor();
        Console.WriteLine("");
        await Task.Delay(1000);
        menu = -1;
    }

}while(aux);