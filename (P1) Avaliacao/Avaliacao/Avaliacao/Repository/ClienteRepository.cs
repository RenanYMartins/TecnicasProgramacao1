using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Avaliacao.Repository
{
    class ClienteRepository
    {
        private static ClienteRepository _clienteRepository = new ClienteRepository();
        private List<Cliente> clientes = new List<Cliente>();

        private ClienteRepository() { }

        public static ClienteRepository getInstance() { 
            return _clienteRepository; 
        }

        public void cadastrarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void listarClientes()
        {
            for(int i = 0; i < clientes.Count; i++)
            {
                clientes[i].getCliente();
            }
        }

        public void getClienteById(int id)
        {
            foreach (Cliente cliente in clientes)
            {
                if(cliente.getId() == id)
                {
                    cliente.getCliente();
                }
            }
            
        }

        //public bool deletarCliente(int id)
        //{
        //    for (int i = 0; i < databaseClientes.Count; i++)
        //    {
        //        if (databaseClientes[i].id == id)
        //        {
        //            databaseClientes.Remove(databaseClientes[i]);
        //            Console.WriteLine("Cliente deletado com sucesso.");
        //            return true;
        //        }
        //    }
        //    Console.WriteLine("Nenhum cliente com o ID informado foi encontrado");
        //    return false;
        //}
    }
}
