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
        private RelatorioController relatorioController;
        public RelatorioView()
        {
            relatorioController = new RelatorioController();
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
                            if (DataSet.despesas.Count != 0 && DataSet.lucros.Count != 0)
                                Saldo();
                            else
                                ErroFaltaDados();
                            Console.Clear();
                            break;

                        case MenuRelatorio.MaiorGasto:
                            if (DataSet.despesas.Count != 0)
                                MaiorGasto();
                            else
                                ErroFaltaDados();
                            Console.Clear();
                            break;
                        
                        case MenuRelatorio.GastoNoDia:
                            if (DataSet.despesas.Count != 0)
                            {
                                Console.Clear();
                                GastoNoDia();
                            }
                            else
                                ErroFaltaDados();
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
        private void ErroFaltaDados()
        {
            Console.WriteLine("Você não possui dados suficientes para gerar esse relatório");
            Thread.Sleep(1000);
        }
        private void Saldo()
        {
            Console.WriteLine("Após um cálculo detalhado analisando seus lucros e despesas cadastrados...");
            Console.Write($"Seu saldo é de ");

            float saldo = relatorioController.RetornarSaldo();

            if (saldo > 0)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"R${saldo}");

            Console.ResetColor();

            Console.WriteLine("");
            Console.WriteLine("Pressione ENTER para retornar...");
            Console.ReadLine();
        }
        private void MaiorGasto()
        {

        }
        private void GastoNoDia()
        {
            
        }
    }
}