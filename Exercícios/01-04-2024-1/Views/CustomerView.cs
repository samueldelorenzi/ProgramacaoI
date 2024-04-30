using System;
using System.Collections.Generic;
using System.Linq;
using _01_04_2024_1.Models;
using _01_04_2024_1.Controllers;

namespace _01_04_2024_1.Views
{
    public class CustomerView
    {
        private CustomerController customerController;
        private AddressView addressView;
        public CustomerView()
        {
            addressView = new AddressView();
            customerController = new CustomerController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("MENU CLIENTES");
            Console.WriteLine("------------------------------------");
            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir cliente");
                Console.WriteLine("2 - Consultar cliente");
                Console.WriteLine("3 - Listar clientes");
                Console.WriteLine("0 - Retornar");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                            Console.WriteLine("");
                        break;
                        case 1:
                        break;
                        case 2:
                        break;
                        case 3:
                        break;
                        default:
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção inválida.");
                            Console.ResetColor();
                            Console.WriteLine("");
                            aux = true;
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
                    menu = -1;
                }
            }while(aux);
        }
        private void insertCustomer()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("INSERIR NOVO CONSUMIDOR");
            Console.WriteLine("-----------------------");
            Customer customer = new Customer();
            Console.Write("Nome:");
            customer.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Nome:");
            customer.EmailAddress = Console.ReadLine();
            Console.WriteLine("");

            int aux = 0;
            do{
                Console.WriteLine("Deseja informar endereço?");
                Console.WriteLine("0 - Não");
                Console.WriteLine("1 - Sim");
                try
                {
                    aux = Convert.ToInt32(Console.ReadLine());
                    if(aux == 1)
                    {
                        customer.Addresses.Add(addressView.Insert());
                    }
                    else if(aux == 0)
                    {
                        break;
                    }
                    else
                    {
                        aux = -1;
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                catch
                {
                    aux = -1;
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            }while(aux != 0);
        }
    }
}