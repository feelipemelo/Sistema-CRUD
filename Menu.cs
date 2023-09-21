using sistemaCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCRUD
{
    public class Menu
    {
        List<Produto> listaProduto = new List<Produto>();

        int proximoId = 1;

        public void exibirMenu() { 
        Console.WriteLine("Bem-vindo ao sistema de Produtos!");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Escolha uma das opções abaixo:");
        Console.WriteLine("1 - Adicionar um item.");
        Console.WriteLine("2 - Remover um item pelo ID.");
        Console.WriteLine("3 - Editar o nome de um item após informar o ID.");
        Console.WriteLine("4 - Visualizar todos os itens cadastrados.");
        Console.WriteLine("5 - Finalizar o sistema.");
        Console.WriteLine("---------------------------------------------");
        }

                

        public void CadastrarProduto()
        {
            Produto produtoNovo = new Produto();

            Console.WriteLine("Digite o nome do produto: ");
            produtoNovo.Nome = Console.ReadLine();
            produtoNovo.Id = proximoId;
            proximoId++;
            listaProduto.Add(produtoNovo);

            Console.WriteLine("Produto cadastrado com sucesso.");



        }

        public void RemoverProduto()
        {
            Console.WriteLine("Digite o ID do produto que deseja remover: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Produto produtoRemover = listaProduto.Find(produtoParaSerRemovido => produtoParaSerRemovido.Id == id);

            if (produtoRemover != null)
            {
                listaProduto.Remove(produtoRemover);
                Console.WriteLine("Produto removido com sucesso.");
            }
        }

        public void EditarProduto()
        {
            Console.WriteLine("Digite o ID do produto que deseja editar: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Produto produtoEditar = listaProduto.Find(produtoParaSerEditado => produtoParaSerEditado.Id == id);

            if (produtoEditar != null)
            {
                Console.WriteLine("Digite o nome do produto: ");
                string produtoParaSerEditado = Console.ReadLine();
                produtoEditar.Nome = produtoParaSerEditado;
                Console.WriteLine("Nome atualizado.");
            }
            else { Console.WriteLine("ID não encontrado!"); }
        }

        public void VisualizarProdutos()
        {
            foreach (Produto item in listaProduto)
            {
                Console.WriteLine($"ID: {item.Id}, nome: {item.Nome}");
            }
        }

    }
}
