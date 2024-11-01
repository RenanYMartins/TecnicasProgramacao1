using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public class HelloWorld
    {
        private string nome;

        public HelloWorld()
        {
            nome = "Desconhecido";
        }

        public HelloWorld(string nome)
        {
            this.nome = nome;
        }

        public void sayHello()
        {
            MessageBox.Show($"Olá, {this.nome}");
        }


    }
}
