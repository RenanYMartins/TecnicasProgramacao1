using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        // Exercicio 01
        Program.MediaVetor();

        // Exercicio 02
        Program.PrimosVetor();

        // Exercicio 03
        Program.CalculoMatriz();

        // Exercicio 04
        Program.MatrizIdentidade();

        // Exercicio 05
        Program.TransposicaoMatriz();
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

    private static void CalculoMatriz()
    {
        int[,] matriz = new int[5, 5];
        int contador = 1;
        int somaLinha = 0;
        int somaColuna = 0;
        double mediaLinha = 0;
        double mediaColuna = 0;
        int somaMatriz = 0;
        double mediaMatriz = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Entre com o {contador}° valor inteiro: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                contador++;
            }
        }

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                somaMatriz += matriz[i, j];
            }
        }

        mediaMatriz = somaMatriz / (double)(matriz.GetLength(0) * matriz.GetLength(1));

        Console.WriteLine($"Soma da matriz: {somaMatriz}");
        Console.WriteLine($"Média da matriz: {Math.Round(mediaMatriz, 2)}");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            somaLinha = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                somaLinha += matriz[i, j];
            }
            mediaLinha = somaLinha / (double)matriz.GetLength(1);
            Console.WriteLine($"Soma da {i + 1}ª linha: {somaLinha}");
            Console.WriteLine($"Média da {i + 1}ª linha: {Math.Round(mediaLinha, 2)}");
        }

        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            somaColuna = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                somaColuna += matriz[i, j];
            }
            mediaColuna = somaColuna / (double)matriz.GetLength(0);
            Console.WriteLine($"Soma da {j + 1}ª coluna: {somaColuna}");
            Console.WriteLine($"Média da {j + 1}ª coluna: {Math.Round(mediaColuna, 2)}");
        }
    }

    private static void MatrizIdentidade()
    {
        int[,] matriz = new int[5, 5];
        bool verificacaoMatriz = true;
        int contador = 1;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Entre com o {contador}° valor inteiro: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                contador++;
            }
        }

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == j && matriz[i, j] != 1)
                {
                    verificacaoMatriz = false;
                    break;
                }
                else if (i != j && matriz[i, j] != 0)
                {
                    verificacaoMatriz = false;
                    break;
                }
            }
        }

        if (verificacaoMatriz)
        {
            Console.WriteLine("É uma matriz identidade.");
        }
        else
        {
            Console.WriteLine("NÃO é uma matriz identidade.");
        }
    }

    private static void TransposicaoMatriz(){
        int linha = 0, coluna = 0, contador = 1;
        
        Console.Write("Digite o número de linhas da matriz: ");
        linha = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o número de colunas da matriz: ");
        coluna = Convert.ToInt32(Console.ReadLine());

        int[,] matriz = new int[linha, coluna];
        int[,] matrizTransposta = new int[coluna, linha];

        for(int i = 0; i < matriz.GetLength(0); i++){
            for(int j = 0; j < matriz.GetLength(1); j++){
                 Console.Write($"Entre com o {contador}° valor inteiro: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                contador++;
            }
        }

        for(int i = 0; i < matriz.GetLength(0); i++){
            for(int j = 0; j < matriz.GetLength(1); j++){
                matrizTransposta[j, i] = matriz[i, j];
            }
        }

        Console.WriteLine("\nMatriz original:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nMatriz transposta:");
        for (int i = 0; i < matrizTransposta.GetLength(0); i++)
        {
            for (int j = 0; j < matrizTransposta.GetLength(1); j++)
            {
                Console.Write(matrizTransposta[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}