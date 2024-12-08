using Avaliacao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao
{
    class Venda
    {
        public int id;
        private static int ultimoId = 1;
        private Cliente cliente;
        private List<Produto> produtos = new List<Produto>();

        //public static List<Venda> databaseVendas = new List<Venda>();

        public Venda(Cliente cliente, List<Produto> produtos)
        {
            this.id = ultimoId++;
            this.cliente = cliente;
            this.produtos = produtos;
        }

        public Venda() { }

        public int getId()
        {
            return id;
        }

        public void getVenda()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Cliente {cliente.getNome()}");
            foreach(Produto produto in produtos)
            {
                produto.getProduto();
            }

        }



    }
}
