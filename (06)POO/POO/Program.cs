using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HelloWorld hello = new HelloWorld("John Doe");
            //hello.sayHello();

            //Classes.Car newCar = new Classes.Car("Peugout", "207", 4);
            //newCar.showCar();

            //Classes.Book book = new Classes.Book("close");
            //book.openClose();

            float[] notas = new float[4];
            float[] pesos = new float[4];
            Classes.Alunos notasAlunos = new Classes.Alunos(notas, pesos);
            notasAlunos.calcularMediaPonderada();

        }
    }
}
