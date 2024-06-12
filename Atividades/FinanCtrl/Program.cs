using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanCtrl
{
    enum Menu { MenuDespesa = 1, MenuLucro, MenuPerfil, MenuRelatorios, Sair = 0 }
    internal class Program
    {
        static void Main()
        {
            bool rodar = true;
            do
            {
                Console.WriteLine("Bem vindo ao gerenciador de finanças pessoas FinanCtrl");
                Console.WriteLine("Menu principal");
                Console.WriteLine("--------------");

                Console.WriteLine("1 - Cadastrar despesa");
                Console.WriteLine("2 - Cadastrar lucro");
                Console.WriteLine("3 - Perfis");
                Console.WriteLine("4 - Relatórios");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out int escolha))
                {
                    Menu opcao = (Menu)escolha;
                    
                    switch(opcao)
                    {
                        case Menu.MenuLucro:
                            Console.Clear();
                            break;

                        case Menu.MenuDespesa:
                            Console.Clear();
                            break;

                        case Menu.MenuPerfil:
                            Console.Clear();
                            break;  
                        
                        case Menu.MenuRelatorios:
                            Console.Clear();
                            break;

                        case Menu.Sair:
                            rodar = false;
                            break;
                        
                        default:
                            Console.WriteLine("Opção inválida");
                            Thread.Sleep(1000);
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                    Thread.Sleep(1000);
                }

            } while (rodar);
        }
    }
}

