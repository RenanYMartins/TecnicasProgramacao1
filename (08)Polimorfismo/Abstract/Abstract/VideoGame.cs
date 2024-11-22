using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class VideoGame : Produto
    {

        public VideoGame(int codigo, string descricao, double valor) : base(codigo, descricao, valor) { }

        public override void exibirProduto()
        {
            base.exibirProduto();
        }

        public override void reajustarValor()
        {
            valor += valor * 0.015;
        }
    }
}
