using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class CestaDeCompras
    {
        List<Produto> listaCompras = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            listaCompras.Add(produto);
            Console.WriteLine(produto.descricao + " adicionado à cesta.");
        }

        public void ExibirCesta()
        {
            Console.WriteLine("Itens na cesta:");
            foreach (var produto in listaCompras)
            {
                produto.exibirProduto();
                Console.WriteLine();
            }
        }

        public void ReajustarPrecos()
        {
            foreach (var produto in listaCompras)
            {
                produto.reajustarValor();
            }
        }

        public void ExibirTotal()
        {
            double total = 0;

            foreach (var produto in listaCompras)
            {
                total += produto.valor;
            }
            Console.WriteLine("Total da compra: R$" + Math.Round(total, 2));
        }
    }
}
