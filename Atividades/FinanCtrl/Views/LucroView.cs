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
    enum MenuLucro { Cadastrar = 1, Listar, Soma, Sair = 0 }
    public class LucroView
    {
        private LucroController lucroController;
        public LucroView()
        {
            lucroController = new LucroController();
            this.Init();
        }
        public void Init()
        {
            bool rodar = true;
            do
            {
                Console.WriteLine("Menu lucro");
                Console.WriteLine("--------------");

                Console.WriteLine("1 - Cadastrar lucro");
                Console.WriteLine("2 - Listar lucros");
                Console.WriteLine("3 - Soma dos lucros");
                Console.WriteLine("0 - Retornar");

                if (int.TryParse(Console.ReadLine(), out int escolha))
                {
                    MenuLucro opcao = (MenuLucro)escolha;
                    
                    switch(opcao)
                    {
                        case MenuLucro.Cadastrar:
                            Console.Clear();
                            CadastrarLucro();
                            Console.Clear();
                            break;

                        case MenuLucro.Listar:
                            if (DataSet.lucros.Count() != 0)
                                ListarLucro();
                            Console.Clear();
                            break;
                        
                        case MenuLucro.Soma:
                            if (DataSet.lucros.Count() != 0)
                                SomarLucro();
                            Console.Clear();
                            break;

                        case MenuLucro.Sair:
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
        private void CadastrarLucro()
        {
            Console.WriteLine("Cadastrar lucro");
            Console.WriteLine("---------------");

            Console.Write("Valor: ");
            float valor = float.Parse(Console.ReadLine());

            Console.Write("Categoria: ");
            string tipo = Console.ReadLine();

            Console.Write("Forma de pagamento: ");
            string formadepagamento = Console.ReadLine();

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Lucro lucro = new Lucro(valor, tipo, formadepagamento, descricao);

            Console.WriteLine("");
            if (lucroController.Insert(lucro))
            {
                Console.WriteLine("Sucesso ao cadastrar lucro");
                ExportarDados exportarDados = new ExportarDados();
                exportarDados.Export();
            }
            else
                Console.WriteLine("Erro ao cadastrar lucro");
            
            Thread.Sleep(1000);
        }
        private void ListarLucro()
        {
            List<Lucro> lucros = lucroController.Get();

            int id = 0;
            Console.WriteLine("----------------------------");
            foreach (Lucro lucro in lucros)
            {
                Console.WriteLine($" Id: {id}");
                Console.WriteLine($" Valor: {lucro.Valor}");
                Console.WriteLine($" Forma de pagamento: {lucro.FormaDePagamento}");
                Console.WriteLine($" Categoria: {lucro.Tipo}");
                Console.WriteLine($" Descrição: {lucro.Descricao}");
                Console.WriteLine($" Data: {lucro.Data}");
                Console.WriteLine("----------------------------");
                id++;
            }
            Console.WriteLine("Aperte ENTER para retornar");
            Console.ReadLine();
        }
        private void SomarLucro()
        {
            List<Lucro> lucros = lucroController.Get();

            float somadoslucros = 0;
            foreach (Lucro lucro in lucros)
            {
                somadoslucros += lucro.Valor;
            }

            Console.WriteLine($"A soma dos seus lucros cadastrados é igual a R${somadoslucros}");

            Console.WriteLine("");
            Console.WriteLine("Pressione ENTER para retornar");
            Console.ReadLine();
        }
        private void ExcluirLucro()
        {

        }
    }
}