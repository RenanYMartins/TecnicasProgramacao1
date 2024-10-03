using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Program.Fibonacci();

        // Exercicio 01 - impressao numeros
        Program.ImprimirNumeros();

        // Exercicio 02
        Program.NumerosPrimos();

        //Exercicio 03
        Program.FibonacciPares();

        // Exercicio 04
        Program.Intervalo();

        //Exercicio 05
        Program.Fatorial();
    }

    public static void Fibonacci()
    {
        int soma = 0;
        int atual = 0;
        int anterior = 1;

        for (int i = 0; i < 31; i++)
        {
            Console.Write(" " + soma);

            soma = anterior + atual;
            atual = anterior;
            anterior = soma;

        }
    }

    public static void ImprimirNumeros()
    {
        for (int i = 0; i <= 50; i++)
        {
            if (i % 2 == 1 || i % 3 == 0)
                continue;

            Console.Write(" " + i);
        }
    }

    public static void NumerosPrimos()
    {
        int multiplos = 0;

        for (int i = 2; i <= 2000; i++)
        {
            multiplos = 0;
            for (int j = i; j >= 1; j--)
            {
                if (i % j == 0)
                {
                    multiplos += 1;
                }
            }

            if (multiplos == 2)
            {
                Console.Write($" " + i);   
            }
        }
    }

    public static void FibonacciPares()
    {
        int soma = 0;
        int atual = 0;
        int anterior = 1;
        int contador = 0;

        for (int i = 0; i < 1000; i++)
        {
            if (soma % 2 == 0)
            {
                Console.Write(" " + soma);
                contador++;
            }

            if(contador == 20)
            {
                break;
            }

            soma = anterior + atual;
            atual = anterior;
            anterior = soma;

        }
    }

    public static void Intervalo()
    {
        int contador = 0;
        int numero = 0;

        for(int i = 1; i <= 15; i++)
        {
            Console.Write("Entre com um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 10 && numero <= 150)
                contador++;
        }

        Console.Write($"Foram digitados {contador} números entre 10 e 150");
    }

    public static void Fatorial()
    {
        int numero = 0;
        int fatorial;

        Console.Write("Entre com um número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        fatorial = numero;

        for(int i = numero-1; i >= 1; i--)
        {
            fatorial = fatorial * i;
        }

        Console.Write($"Soma: {fatorial}");
    }
}
