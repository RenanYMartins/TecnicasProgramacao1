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

            Produto tvPlasma = new Televisor(1, "Televisor de Plasma de 40 polegadas", 1500.00);
            Produto tvOled = new Televisor(2, "Televisor OLED de 70 polegadas", 5800);

            CestaDeCompras cesta = new CestaDeCompras();

            tvPlasma.reajustarValor();

            cesta.AdicionarProduto(tvPlasma);
            cesta.AdicionarProduto(tvOled);

            while (exibirMenu)
            {
                exibirMenu = Menu(cesta);
            }

            //cesta.ExibirCesta();

            //Console.ReadLine();
        }
        private static bool Menu(CestaDeCompras cesta)
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
                    Console.WriteLine("Opção 1 selecionada");
                    return true;
                case "2":
                    Console.WriteLine("Opção 2 selecioanada");
                    return true;
                case "3":
                    cesta.ExibirCesta();
                    return true;
                case "4":
                    Console.WriteLine("Opção 4 selecionada");
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }


    }
}

