using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_04_2024_1.Views
{
    public class CustomerView
    {
        public CustomerView()
        {
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
    }
}