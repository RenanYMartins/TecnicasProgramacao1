using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Avaliacao
{
    class Produto
    {
        private int id;
        private static int ultimoId = 1;
        private string marca;
        private string modelo;
        private string descricao;
        private float preco;

        public Produto(string marca, string modelo, string descricao, float preco)
        {
            this.id = ultimoId++;
            this.marca = marca;
            this.modelo = modelo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public Produto() { }

        public int getId()
        {
            return id;
        }

        public void getProduto()
        {
            Console.Write($"ID: {id}");
            Console.Write($" | Marca: {marca}");
            Console.Write($" | Modelo: {modelo}");
            Console.Write($" | Descrição: {descricao}");
            Console.Write($" | Preço: {preco}\n");
        }

        public void getProduto(string venda)
        {
            Console.Write($"ID: {id}");
            Console.Write($" | Marca: {marca}");
            Console.Write($" | Modelo: {modelo}");
            Console.Write($" | Descrição: {descricao}");
            Console.Write($" | Preço: {preco}\n");
        }
    }
}
