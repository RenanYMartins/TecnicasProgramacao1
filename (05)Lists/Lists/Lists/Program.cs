using System.ComponentModel;
using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        // Exemplo lista de numeros
        //Program.ListaNumeros();

        // Exemplo disciplinas
        //Program.Disciplinas();

        // Exercicio 01 - calculo inteiros
        Program.ListaParesImpares();
    }

    private static void ListaNumeros()
    {
        int num = 0;
        int soma = 0;
        List<int> intList = new List<int>();

        do
        {
            Console.Write("Informe um número inteiro positivo: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                intList.Add(num);
        } while (num > 0);

        foreach (int x in intList)
            soma += x;

        Console.WriteLine($"Quandidade de valores informados: {intList.Count}");

        if (intList.Count > 0)
            Console.WriteLine($"Média dos valores informados: {Convert.ToDouble(soma) / intList.Count}");
    }

    private static void Disciplinas()
    {
        List<string> disciplinas = new List<string>();
        List<string> discProg = new List<string>();

        string disc = String.Empty;

        do
        {
            Console.WriteLine("Informe um nome da disciplina: ");
            disc = Console.ReadLine();

            if (disc.ToUpper() != "FIM")
                disciplinas.Add(disc);
        } while (disc.ToUpper() != "FIM");

        discProg = disciplinas.FindAll(d => d.ToUpper().Contains("PROG"));

        Console.WriteLine("Disciplinas de Programação: ");

        foreach (string d in discProg)
            Console.WriteLine(d);
    }

    private static void ListaParesImpares()
    {
        int num = 0;
        int somaPares = 0;
        int qtdPares = 0;
        int somaImpares = 0;
        int qtdImpares = 0;

        List<int> intList = new List<int>();

        do
        {
            Console.Write("Informe um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 0)
                intList.Add(num);
        } while (num != 0);

        foreach (int x in intList)
        {
            if (x % 2 == 0)
            {
                somaPares += x;
                qtdPares++;
            }
            else
            {
                somaImpares += x;
                qtdImpares++;
            }

        }

        Console.WriteLine($"Quantidade de Pares: {qtdPares} | Quantidade de Ímpares: {qtdImpares}");

        if (intList.Count > 0)
            Console.WriteLine($"Soma dos Pares: {somaPares} | Soma de Ímpares: {somaImpares}");   
    }
}