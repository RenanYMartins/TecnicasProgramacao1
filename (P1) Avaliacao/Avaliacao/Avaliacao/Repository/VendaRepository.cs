using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.Repository
{
    class VendaRepository
    {
        private static VendaRepository _vendaRepository = new VendaRepository();
        private List<Venda> vendas = new List<Venda>();

        private VendaRepository() { }

        public static VendaRepository getInstance()
        {
            return _vendaRepository;
        }

        public void cadastrarVenda(Venda venda)
        {
            vendas.Add(venda);
        }

        public void listarVendas()
        {
            for (int i = 0; i < vendas.Count; i++)
            {
                vendas[i].getVenda();
            }
        }
    }
}
