internal class Program
{
    private static void Main(string[] args)
    {
        // Exercicio 01
        //Program.MediaVetor();

        // Exercicio 02
        //Program.PrimosVetor();

        // Exercico 03
    }

    private static void MediaVetor()
    {
        int[] vetor = new int[10];
        double soma = 0;
        double media = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Entre com o {i + 1} valor: ");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
            soma += vetor[i];
        }

        media = soma / vetor.Length;

        Console.WriteLine($"Média dos valores: {Math.Round(media, 2)}");
    }

    private static void PrimosVetor()
    {
        int[] vetor = new int[5];
        int primo = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Entre com o {i + 1} valor: ");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 1; i <= vetor.Length; i++)
        {
            for (int j = i; j > 0; j--)
            {
                if (i % j == 0)
                {
                    primo++;
                }
            }

            if (primo == 2)
            {
                Console.WriteLine(i);
            }

            primo = 0;
        }
    }
}