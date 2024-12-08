using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao
{
    class Cliente
    {
        private int id;
        private static int ultimoId = 1;
        private string nome;
        private int idade;
        private string cpf;

        public Cliente(string nome, int idade, string cpf)
        {
            this.id = ultimoId++;
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
        }

        public Cliente() { }

        public int getId()
        {
            return id;
        }

        public string getNome()
        {
            return nome;
        }

        public void getCliente()
        {
            Console.Write($"ID: {id}");
            Console.Write($" | Nome: {nome}");
            Console.Write($" | Idade: {idade}");
            Console.Write($" | CPF: {cpf}\n");
        }

    }
}
