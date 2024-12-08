using Avaliacao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                continuar = Menu();
            }

            ClienteRepository clienteRepository = ClienteRepository.getInstance();
            ProdutoRepository produtosRepository = ProdutoRepository.getInstance();
            VendaRepository vendaRepository = VendaRepository.getInstance();
            Cliente cliente = new Cliente();
            Produto produto = new Produto();
            Venda venda = new Venda();

            Cliente cliente1 = new Cliente("Renan", 29, "444.162.388-88");
            Cliente cliente2 = new Cliente("John Doe", 40, "123.162.789-08");
            Produto produto1 = new Produto("Volkswagem", "Nivus", "Carro", 120000);
            Venda venda1 = new Venda(cliente1, new List<Produto> { produto1 });
            Venda venda2 = new Venda(cliente2, new List<Produto> { produto1, produto1 });

            clienteRepository.cadastrarCliente(cliente1);
            //clienteRepository.listarClientes();

            vendaRepository.cadastrarVenda(venda1);
            vendaRepository.cadastrarVenda(venda2);
            vendaRepository.listarVendas();


            // Exibir venda

            //Cliente cliente = new Cliente();
            //Cliente cliente1 = new Cliente("Renan", 29, "444.162.388-88");
            //Cliente cliente2 = new Cliente("Ana", 20, "303.890.377-11");
            //Cliente cliente3 = new Cliente("João", 25, "200.123.456-71");

            //Produto produto = new Produto();
            //Produto produto1 = new Produto("Audi", "A3", "Carro", 200000);
            //Produto produto2 = new Produto("Volkswagem", "Nivus", "Carro", 120000);

            //Venda venda = new Venda();
            //Venda venda1 = new Venda(1, new List<int>(1));

            //cliente.cadastrarCliente(cliente1);
            //Console.WriteLine(cliente1.getNome());

            //cliente.cadastrarCliente(cliente2);
            //cliente.cadastrarCliente(cliente3);

            //produto.cadastrarProduto(produto1);
            //produto.cadastrarProduto(produto2);

            //venda.cadastrarVenda(venda1);
            //venda.listarVendas();


            //Console.WriteLine("Clientes cadastrados: ");
            //cliente.listarClientes();

            //Console.WriteLine("Produtos cadastrados: ");
            //produto.listarProdutos();

            //cliente.deletarCliente(2);
            //cliente.listarClientes();

            //produto.deletarProduto(1);
            //produto.listarProdutos();
        }

        private static bool Menu()
        {
            Console.Clear();

            Console.WriteLine("___________________Menu___________________");
            Console.WriteLine("[1] Cadastro de clientes");
            Console.WriteLine("[2] Cadastro de produtos");
            Console.WriteLine("[3] Cadastro de vendas");
            Console.WriteLine("[0] Sair");
            Console.Write("Sua opção: ");


            switch (Console.ReadLine())
            {
                case "1":
                    MenuCliente();
                    return true;
                //case "2":
                //    foreach (var produto in protutos)
                //    {
                //        produto.reajustarValor();
                //    }
                //    Console.WriteLine("Preços reajustados com sucesso");
                //    Console.ReadLine();
                //    return true;
                //case "3":
                //    cesta.ExibirCesta();
                //    Console.ReadLine();
                //    return true;
                //case "4":
                //    cesta.ExibirTotal();
                //    Console.ReadLine();
                //    return true;
                case "0":
                    Console.WriteLine("Saindo do programa...");
                    return false;
                default:
                    return true;
            }
        }

        private static bool MenuCliente()
        {
            bool continuar = true;
            Cliente cliente = new Cliente();
            ClienteRepository clienteRepository = ClienteRepository.getInstance();
            string nome;
            var entradaIdade = "";
            int idade;
            string cpf;
            Console.Clear();

            Console.WriteLine("___________________Menu___________________");
            Console.WriteLine("[1] Cadastrar novo cliente");
            Console.WriteLine("[2] Buscar cliente por código");
            Console.WriteLine("[3] Listar todos os clientes");
            Console.WriteLine("[4] Deletar cliente");
            Console.WriteLine("[0] Sair");
            Console.Write("Sua opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
                    {
                        Console.WriteLine("Idade inválida. Insira um número inteiro positivo.");
                        Console.Write("Idade: ");
                    }
                    Console.Write("CPF: ");
                    cpf = Console.ReadLine();
                    cliente = new Cliente(nome, idade, cpf);

                    clienteRepository.cadastrarCliente(cliente);
                    return true;
                case "2":
                    Console.Write("Digite o ID do cliente: ");
                    clienteRepository.getClienteById(int.Parse(Console.ReadLine()));
                    return true;
                case "3":
                    clienteRepository.listarClientes();
                    return true;
                //case "4":
                //    cesta.ExibirTotal();
                //    Console.ReadLine();
                //    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }
    }
}
