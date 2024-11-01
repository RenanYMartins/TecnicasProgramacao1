using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    internal class Classes
    {
        public class Car
        {
            public string marca;
            public string modelo;
            public int qtdPortas;

            public Car(string marca, string modelo, int qtdPortas)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.qtdPortas = qtdPortas;
            }

            public void showCar()
            {
                MessageBox.Show($"Marca: {marca}\nModelo: {modelo}\nQuantidade de Portas: {qtdPortas}");
                //Console.WriteLine($"Marca: ${marca}");
                //Console.WriteLine($"Modelo: ${modelo}");
                //Console.WriteLine($"Quantidade de Portas: ${qtdPortas}");
            }
        }

        public class Book
        {
            string act;

            public Book(string act)
            {
                this.act = act;
            }

            public void openClose()
            {
                if (act.Contains("open"))
                {
                    MessageBox.Show("Livro aberto");
                }
                else if (act.Contains("close"))
                {
                    MessageBox.Show("Livro fechado");
                }
                else
                {
                    MessageBox.Show("Opção inválida");
                }
            }
        }
    }
}
