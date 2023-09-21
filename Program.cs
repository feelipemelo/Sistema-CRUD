using CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCRUD
{
    internal class Program
    {   
        
        static void Main(string[] args)
        {
            
            Menu menu = new Menu();

            bool start = true;

            while (start)
            {
                menu.exibirMenu();
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        menu.CadastrarProduto();
                        break;

                    case 2:
                        menu.RemoverProduto();
                        break;

                    case 3:
                        menu.EditarProduto();
                        break;

                    case 4:
                        menu.VisualizarProdutos();
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Digito incorreto.");
                        break;
                }

                if (opcao == 5)
                {
                    Console.WriteLine("Encerrando..");
                    start = false;
                }
                 


                Console.ReadKey();
            }

            


            
        }
    }
}
