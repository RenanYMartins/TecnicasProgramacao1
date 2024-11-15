using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Produto
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double valor { get; set; }

        public Produto(int codigo, string descricao, double valor)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.valor = valor;
        }

        public virtual void exibirProduto()
        {
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Produto: " + descricao);
            Console.WriteLine("Valor: R$" + Math.Round(valor, 2));
        }

        public virtual void reajustarValor()
        {
        }
    }
}
