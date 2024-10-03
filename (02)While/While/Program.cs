internal class Program
{
    private static void Main(string[] args)
    {
        //Program.DecimalParaBinario();

        Program.Menu();

        // Exercicio 01
        //Program.Senha();

        // Exercicio 02
        //Program.NumerosInteiros();

        // Exercicio 03
        //Program.VendaCarros();
    }

    public static void DecimalParaBinario()
    {
        int numero;
        int resto;
        string binario = string.Empty;

        Console.Write("Digite um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 0)
        {
            while (numero > 0)
            {
                resto = numero % 2;
                numero /= 2;
                binario = resto.ToString() + binario;
            }

            Console.WriteLine($"\nBinário: {binario}");
        }
        else
        {
            Console.WriteLine("Erro! Entre com um número maior que 0");
        }
    }

    public static void Menu()
    {
        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("\n_____Menu_____");
            Console.WriteLine("[01] Somar dois números");
            Console.WriteLine("[02] Subtrair dois números");
            Console.WriteLine("[03 Multiplicar dois números");
            Console.WriteLine("[04] Dividir dois números");
            Console.WriteLine("[05] Sair");
            Console.Write("Opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            Calcular(opcao);
        }

        Console.WriteLine("\nSaindo...");
    }

    public static void Calcular(int opcao)
    {
        int[] numeros = new int[2];

        if (opcao != 5)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Entre com o {i + 1}º número");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        switch (opcao)
        {
            case 1:
                Console.Write($"{numeros[0]} + {numeros[1]} = {numeros[0] + numeros[1]}");
                break;
            case 2:
                Console.Write($"{numeros[0]} - {numeros[1]} = {numeros[0] - numeros[1]}");
                break;
            case 3:
                Console.Write($"{numeros[0]} * {numeros[1]} = {numeros[0] * numeros[1]}");
                break;
            case 4:
                Console.Write($"{numeros[0]} / {numeros[1]} = {numeros[0] / numeros[1]}");
                break;
            case 5:
                break;
            default:
                Console.Write("Opção inválida");
                break;
        }
    }

    public static void Senha()
    {
        String senha = "0";

        while (senha != "12345")
        {
            Console.Write("Entre com a senha: ");
            senha = Convert.ToString(Console.ReadLine());
        }

        Console.WriteLine("Senha correta!");
    }

    public static void NumerosInteiros()
    {
        int numero = 1;
        int somaPares = 0;
        int somaImpares = 0;
        int contadorImpares = 0;
        double mediaImpares = 0;

        while (numero != 0)
        {
            Console.Write("Entre com o número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                somaPares += numero;
            }
            else
            {
                somaImpares += numero;
                contadorImpares += 1;
            }
        }

        if (contadorImpares != 0)
        {
            mediaImpares = somaImpares / contadorImpares;
        }

        Console.WriteLine($"Soma dos números pares digitados: {somaPares}");
        Console.WriteLine($"Média dos números ímpares digitados: {Math.Round(mediaImpares, 2)}");
    }

    static void VendaCarros()
    {
        int anoCarro;
        double percentualDesconto;
        int valorCarro;
        double valorVenda;
        double somaVendas = 0;
        int quantidadeCarrosAntigos = 0;
        String opcao = "S";

        while (opcao != "N")
        {
            Console.Write("Ano do carro: ");
            anoCarro = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor do carro: ");
            valorCarro = Convert.ToInt32(Console.ReadLine());

            if (anoCarro <= 2000)
            {
                valorVenda = valorCarro * 0.88;
                somaVendas += valorVenda;
                quantidadeCarrosAntigos += 1;
            }
            else
            {
                valorVenda = valorCarro * 0.93;
                somaVendas += valorVenda;
            }

            Console.Write("Deseja cadastrar nova venda? (S/N) ");
            opcao = Convert.ToString(Console.ReadLine()).ToUpper();
        }

        Console.WriteLine($"Total de carros vendidos com ano até 2000: {quantidadeCarrosAntigos}");
        Console.WriteLine($"Total de vendas: {Math.Round(somaVendas, 2)}");


    }

}