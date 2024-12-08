﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Guitarra : Produto
    {

        public Guitarra(int codigo, string descricao, double valor) : base(codigo, descricao, valor) { }

        public override void exibirProduto()
        {
            base.exibirProduto();
        }

        public override void reajustarValor()
        {
            valor += valor * 0.005;
        }
    }
}