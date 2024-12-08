using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.Repository
{
    internal class ProdutoRepository
    {
        private static ProdutoRepository _produtoRepository = new ProdutoRepository();
        private List<Produto> produtos = new List<Produto>();

        private ProdutoRepository() { }

        public static ProdutoRepository getInstance()
        {
            return _produtoRepository;
        }

        public void cadastrarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void listarProdutos()
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                produtos[i].getProduto();
            }
        }

        //public bool deletarProduto(int id)
        //{
        //    for (int i = 0; i < databaseProdutos.Count; i++)
        //    {
        //        if (databaseProdutos[i].id == id)
        //        {
        //            databaseProdutos.Remove(databaseProdutos[i]);
        //            Console.WriteLine("Produto deletado com sucesso.");
        //            return true;
        //        }
        //    }
        //    Console.WriteLine("Nenhum produto com o ID informado foi encontrado");
        //    return false;
        //}
    }
}
