using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exibirMenu = true;

            List<Produto> produtos = new List<Produto>
            {
                new Televisor(1, "Televisor OLED de 70 polegadas", 5800),
                new VideoGame(2, "PS5", 3700),
                new Guitarra(3, "Guitarra Fender", 9900),
                new DVD(4, "Aparelho DVD", 400),
                new Notebook(5, "Notebook Positivo", 1780.00)
            };

            CestaDeCompras cesta = new CestaDeCompras();

            while (exibirMenu)
            {
                exibirMenu = Menu(cesta, produtos);
            }

        }
        private static bool Menu(CestaDeCompras cesta, List<Produto> protutos)
        {
            Console.Clear();

            Console.WriteLine("Entre com um valor entre 1 e 5");
            Console.WriteLine("___________________Menu___________________");
            Console.WriteLine("[1] Incluir um dos produtos na cesta");
            Console.WriteLine("[2] Reajustar o preço de todos os produtos");
            Console.WriteLine("[3] Exibir a cesta de produtos");
            Console.WriteLine("[4] Exibir total da compra");
            Console.WriteLine("[5] Sair");
            Console.Write("Sua opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ExibirProdutosDisponiveis(cesta, protutos);
                    return true;
                case "2":
                    foreach(var produto in protutos)
                    {
                        produto.reajustarValor();
                    }
                    Console.WriteLine("Preços reajustados com sucesso");
                    Console.ReadLine();
                    return true;
                case "3":
                    cesta.ExibirCesta();
                    Console.ReadLine();
                    return true;
                case "4":
                    cesta.ExibirTotal();
                    Console.ReadLine();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

        private static void ExibirProdutosDisponiveis(CestaDeCompras cesta, List<Produto> produtos)
        {
            Console.WriteLine("Escolha o produto para adicionar à cesta de compras:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Código: {produto.codigo} - Produto: {produto.descricao} - Valor: R$ {Math.Round(produto.valor, 2)}");
            }
            Console.Write("Digite o código do produto: ");

            if (int.TryParse(Console.ReadLine(), out int codigoProduto))
            {
                Produto produtoSelecionado = produtos.Find(p => p.codigo == codigoProduto);
                if (produtoSelecionado != null)
                {
                    cesta.AdicionarProduto(produtoSelecionado);
                    Console.WriteLine("Produto adicionado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Código inválido.");
            }
            Console.ReadLine();
        }


    }
}

