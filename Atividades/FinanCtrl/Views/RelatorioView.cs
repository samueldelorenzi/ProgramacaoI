using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanCtrl.Controllers;
using FinanCtrl.Data;

namespace FinanCtrl.Views
{
    enum MenuRelatorio { Saldo = 1, MaiorGasto, GastoNoDia, Sair = 0 }
    public class RelatorioView
    {
        public RelatorioView()
        {
            RelatorioController relatorioController = new RelatorioController();
            this.Init();
        }
        public void Init()
        {
            bool rodar = true;
            do
            {
                Console.WriteLine("Menu relatório");
                Console.WriteLine("--------------");

                Console.WriteLine("1 - Relatório saldo");
                Console.WriteLine("2 - Relatório maior gasto");
                Console.WriteLine("3 - Relatório gasto no dia");
                Console.WriteLine("0 - Retornar");

                if (int.TryParse(Console.ReadLine(), out int escolha))
                {
                    MenuRelatorio opcao = (MenuRelatorio)escolha;
                    
                    switch(opcao)
                    {
                        case MenuRelatorio.Saldo:
                            Console.Clear();
                            if (DataSet.despesas.Count() != 0 && DataSet.lucros.Count() != 0)
                            Console.Clear();
                            break;

                        case MenuRelatorio.MaiorGasto:
                            Console.Clear();
                            if (DataSet.despesas.Count() != 0)
                            Console.Clear();
                            break;
                        
                        case MenuRelatorio.GastoNoDia:
                            Console.Clear();
                            if (DataSet.despesas.Count() != 0)
                            Console.Clear();
                            break;

                        case MenuRelatorio.Sair:
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
                    Console.Clear();
                }

            } while (rodar); 
        }
    }
}