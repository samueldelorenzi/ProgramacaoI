using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanCtrl.Controllers;
using FinanCtrl.Data;
using FinanCtrl.Models;
using FinanCtrl.Utils;

namespace FinanCtrl.Views
{
    enum MenuDespesa { Cadastrar = 1, Listar, Soma, Excluir, Sair = 0 }
    
    public class DespesaView
    {
        public DespesaView()
        {
            DespesaController despesaController = new DespesaController();
            this.Init();
        }
        public void Init()
        {
            bool rodar = true;
            do
            {
                Console.WriteLine("Menu despesa");
                Console.WriteLine("--------------");

                Console.WriteLine("1 - Cadastrar despesa");
                Console.WriteLine("2 - Listar despesas");
                Console.WriteLine("3 - Soma das despesas");
                Console.WriteLine("4 - Excluir despesa");
                Console.WriteLine("0 - Retornar");

                if (int.TryParse(Console.ReadLine(), out int escolha))
                {
                    MenuDespesa opcao = (MenuDespesa)escolha;
                    
                    switch(opcao)
                    {
                        case MenuDespesa.Cadastrar:
                            Console.Clear();
                            CadastrarDespesa();
                            Console.Clear();
                            break;

                        case MenuDespesa.Listar:
                            Console.Clear();
                            if (DataSet.despesas.Count() != 0)
                                ListarDespesa();
                            Console.Clear();
                            break;
                        
                        case MenuDespesa.Soma:
                            Console.Clear();
                            if (DataSet.despesas.Count() != 0)
                                SomarDespesa();
                            Console.Clear();
                            break;

                        case MenuDespesa.Sair:
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
        private void CadastrarDespesa()
        {

        }
        private void ListarDespesa()
        {

        }
        private void SomarDespesa()
        {
            
        }
        private void ErroDespesaVazia()
        {
            Console.WriteLine("Você não possui nenhuma despesa cadastrada");
        }
    }
}