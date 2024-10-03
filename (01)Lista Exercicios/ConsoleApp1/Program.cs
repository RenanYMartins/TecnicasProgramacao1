using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        // Exercicio 01 - media notas
        Program.Notas();

        // Exercicio 02 - ordenacao inteiros
        Program.OrdenaInteiros();

        // Exercicio 03 - classificacao produtos
        Program.ClasseProduto();

        // Exercicio 04 - par ou impar
        Program.ParOuImpar();

        // Exercicio 05 - aposentadoria
        Program.Aposentadoria(); 

        // Exercicio 06 - doacao de sangue
        Program.DoacaoDeSangue();

        // Exercicio 07 - peso ideal
        Program.PesoIdeal();

        // Exercicio 08 - emprestimo
        Program.Emprestimo();

        // Exercicio 09 - abastecimento
        Program.AbastecerCarro();
    }

    private static void Notas()
    {
        double[] notas = new double[2];
        double media = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Entre com a {i + 1}ª nota(Entre 1 e 10): ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
        }

        media = (notas[0] + notas[1]) / notas.Length;

        if (media >= 6)
            Console.WriteLine($"Nota: {media} | Status: APROVADO");
        else if (media >= 4 && media < 6)
            Console.WriteLine($"Nota: {media} | Status: RECUPERAÇÃO");
        else
            Console.WriteLine($"Nota: {media} | Status: REPROVADO");
    }

    private static void OrdenaInteiros()
    {
        int[] inteiros = new int[3];
        int aux;

        for (int i = 0; i < inteiros.Length; i++)
        {
            Console.Write($"Entre com o {i + 1}° inteiro: ");
            inteiros[i] = Convert.ToInt32(Console.ReadLine());
        }

        if (inteiros[0] > inteiros[1])
        {
            aux = inteiros[0];
            inteiros[0] = inteiros[1];
            inteiros[1] = aux;
        }

        if (inteiros[1] > inteiros[2])
        {
            aux = inteiros[1];
            inteiros[1] = inteiros[2];
            inteiros[2] = aux;
        }

        if (inteiros[0] > inteiros[1])
        {
            aux = inteiros[0];
            inteiros[0] = inteiros[1];
            inteiros[1] = aux;
        }

        for (int i = 0; i < inteiros.Length; i++)
        {
            Console.WriteLine(inteiros[i]);
        }
    }

    public static void ClasseProduto()
    {
        int codigo = 1;

        while (codigo > 0 && codigo < 16)
        {
            Console.Write("Entre com o código do produto: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.Write("Alimento não-perecível.\n");
                    break;
                case int n when (n >= 2 && n <= 4):
                    Console.Write("Alimento perecível.\n");
                    break;
                case int n when (n >= 5 && n <= 6):
                    Console.Write("Vestuário.\n");
                    break;
                case 7:
                    Console.Write("Higiene pessoal.\n");
                    break;
                case int n when (n >= 8 && n <= 15):
                    Console.Write("Limpeza.\n");
                    break;
                default:
                    Console.Write("Inválido!\n");
                    break;
            }
        }
    }

    public static void ParOuImpar()
    {
        int numero;

        Console.Write("Entre com o número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
            Console.Write($"{numero} é um número par");
        else
            Console.Write($"{numero} é um número ímpar");
    }

    public static void Aposentadoria()
    {
        int idade;

        Console.Write("Entre com a idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 65)
            Console.Write("Você já pode se aposentar!");
        else
            Console.Write($"Faltam {65 - idade} anos para você se aposentar.");
    }

    public static void DoacaoDeSangue()
    {
        string[] nome = new string[2];
        string nomeDoador;
        string sangueDoador;
        string nomeReceptor;
        string sangueReceptor;

        Console.Write($"\nEntre com o nome da pessoa que receberá doação: ");
        nomeDoador = Convert.ToString(Console.ReadLine()).ToUpper();

        Console.Write($"\nEntre com o tipo sanguíneo: ");
        sangueDoador = Convert.ToString(Console.ReadLine()).ToUpper();

        Console.Write($"\nEntre com o nome da pessoa que doará sangue: ");
        nomeReceptor = Convert.ToString(Console.ReadLine()).ToUpper();

        Console.Write($"\nEntre com o tipo sanguíneo: ");
        sangueReceptor = Convert.ToString(Console.ReadLine()).ToUpper();

        if (sangueDoador == "O-")
        {
            Console.WriteLine($"\n{nomeReceptor} pode receber o sangue de {nomeDoador}");
        }
        else if (sangueDoador == "O+" && (sangueReceptor == "O+" || sangueReceptor == "A+" || sangueReceptor == "B+" || sangueReceptor == "AB+"))
        {
            Console.WriteLine($"\n{nomeReceptor} pode receber o sangue de {nomeDoador}");
        }
        else if (sangueDoador == "A-" && (sangueReceptor == "A-" || sangueReceptor == "A+" || sangueReceptor == "AB-" || sangueReceptor == "AB+"))
        {
            Console.WriteLine($"\n{nomeReceptor} pode receber o sangue de {nomeDoador}");
        }
        else if (sangueDoador == "A+" && (sangueReceptor == "A+" || sangueReceptor == "AB+"))
        {
            Console.WriteLine($"\n{nomeReceptor} pode receber o sangue de {nomeDoador}");
        }
        else if (sangueDoador == "B-" && (sangueReceptor == "B-" || sangueReceptor == "B+" || sangueReceptor == "AB-" || sangueReceptor == "AB+"))
        {
            Console.WriteLine($"\n{nomeReceptor} pode receber o sangue de {nomeDoador}");
        }
        else if (sangueDoador == "B+" && (sangueReceptor == "B+" || sangueReceptor == "AB+"))
        {
            Console.WriteLine($"\n{nomeReceptor} pode receber o sangue de {nomeDoador}");
        }
        else if (sangueDoador == "AB-" && (sangueReceptor == "AB-" || sangueReceptor == "AB+"))
        {
            Console.WriteLine($"\n{nomeReceptor} pode receber o sangue de {nomeDoador}");
        }
        else if (sangueDoador == "AB+" && sangueReceptor == "AB+")
        {
            Console.WriteLine($"\n{nomeReceptor} pode receber o sangue de {nomeDoador}");
        }
        else
        {
            Console.WriteLine($"\n{nomeReceptor} NÃO pode receber o sangue de {nomeDoador}.");
        }
    }

    public static void PesoIdeal()
    {
        double altura;
        string sexo;
        double pesoIdeal;

        Console.Write("Entre com a altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entre com o sexo da pessoa(M ou F):  ");
        sexo = Convert.ToString(Console.ReadLine());

        if (sexo == "M")
        {
            Math.Round(pesoIdeal = 72.7 * altura - 58, 2);
            Console.Write($"O peso ideal para o sexo masculino com altura de {altura} é de {pesoIdeal} kg.");
        }
        else
        {
            Math.Round(pesoIdeal = 62.1 * altura - 44.1, 2);
            Console.Write($"O peso ideal para o sexo feminino com altura de {altura} é de {pesoIdeal} kg.");
        }

    }

    public static void Emprestimo()
    {
        double valorEmprestimo;
        int parcelas;
        double valorParcela;
        double salarioBruto;
        double valorMinimoParcela;

        Console.Write("Entre com o valor do empréstimo: ");
        valorEmprestimo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entre com a quantidade de parcelas: ");
        parcelas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Entre com o salário bruto: ");
        salarioBruto = Convert.ToDouble(Console.ReadLine());

        Math.Round(valorParcela = valorEmprestimo / parcelas, 2);

        Console.WriteLine($"\nValor por parcela: {valorParcela}");

        if (salarioBruto * 0.25 > valorParcela)
        {
            Console.WriteLine("\nEmpréstimo aprovado!");
        }
        else
        {
            valorMinimoParcela = (salarioBruto / valorParcela - 1) * 100;
            Console.WriteLine($"\nEmpréstimo reprovado! O salário bruto representa {Math.Round(valorMinimoParcela, 2)} do valor por parcela");
        }
    }

    public static void AbastecerCarro()
    {
        string combustivel;
        double capacidadeTanque;
        double litrosNoTranque;
        double valorParaEncherTanque;
        double quantidadeParaEncherTanque;
        double valorCombustivel;

        Console.Write("Qual combustível será usado no abastecimento(A-Álcool/ G-Gasolina)? ");
        combustivel = Convert.ToString(Console.ReadLine()).ToUpper();
        Console.Write("\nCapacidade do tanque(em litros): ");
        capacidadeTanque = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nLitros no tanque no momento: ");
        litrosNoTranque = Convert.ToDouble(Console.ReadLine());

        quantidadeParaEncherTanque = capacidadeTanque - litrosNoTranque;

        if (combustivel == "A")
        {
            valorCombustivel = 3.14;
            combustivel = "álcool";
        }
        else
        {
            valorCombustivel = 4.84;
            combustivel = "gasolina";
        }

        valorParaEncherTanque = quantidadeParaEncherTanque * valorCombustivel;

        Console.Write($"\nQuantidade de {combustivel} para completar o tanque: {Math.Round(quantidadeParaEncherTanque, 2)}");
        Console.Write($"\nValor para encher o tanque: R$ {Math.Round(valorParaEncherTanque, 2)}");
    }
}