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

        public class Alunos
        {
            float[] notas = new float[4];
            float[] pesos = new float[4];


            public Alunos(float[] notas, float[] pesos)
            {
                this.notas = notas;
                this.pesos = pesos;
            }

            public void calcularMediaPonderada()
            {
                float somaNotasPesos = 0;
                float somaPesos = 0;

                for (int i = 0; i < notas.Length; i++)
                {
                    Console.Write($"Entre com a {i + 1}ª nota: ");
                    notas[i] = float.Parse(Console.ReadLine());

                    Console.Write($"Entre com o {i + 1}º peso da nota: ");
                    pesos[i] = float.Parse(Console.ReadLine());
                }


                for (int i = 0; i < notas.Length; i++)
                {
                    somaNotasPesos += notas[i] * pesos[i];
                    somaPesos += pesos[i];
                }

                float mediaPonderada = somaPesos > 0 ? somaNotasPesos / somaPesos : 0;

                MessageBox.Show($"A média ponderada é: {mediaPonderada}");
            }
        }




    }
}

