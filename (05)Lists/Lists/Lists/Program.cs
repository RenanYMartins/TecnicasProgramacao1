
internal class Program
{
    private static void Main(string[] args)
    {
        // Exemplo lista de numeros
        // Program.ListaNumeros();

        // Exemplo disciplinas
        // Program.Disciplinas();

        // Exercicio 01 - calculo inteiros
        Program.ListaParesImpares();

        //Exercicio 02 - remover numero
        Program.RemoverLista();

        // Exercicio 03 - maior e menor numero
        Program.MaiorMenorNumero();

        // Exercicio 04 - ordenar nomes
        Program.OrdenarNomes();
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

    private static void RemoverLista()
    {
        int num = 0;
        int numRemovido = 0;
        List<int> intList = new List<int>();

        do
        {
            Console.Write("Informe um número(Pressione 0 para sair): ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 0)
                intList.Add(num);
        } while (num != 0);

        if (intList.Count > 0)
        {
            Console.WriteLine("Digite o número a ser excluído: ");
            num = Convert.ToInt32(Console.ReadLine());

            intList.Remove(num);
        }

        foreach (int x in intList)
            Console.WriteLine(x);

    }

    private static void MaiorMenorNumero()
    {
        int num = 0;
        List<int> intList = new List<int>();

        do
        {
            Console.Write("Informe um número inteiro(Pressione 0 para sair): ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 0)
                intList.Add(num);
        } while (num != 0);

        if (intList.Count > 0)
        {
            intList.Sort();

            Console.WriteLine($"\nMaior número: {intList[0]}");
            Console.WriteLine($"Maior número: {intList[intList.Count - 1]}");
        }
        else{
            Console.Write("\nNão há nenhum número na lista.");
        }
    }

    private static void OrdenarNomes(){
        List<string> nomesList = new List<string>();
        string nome = "";

        do
        {
            Console.Write("Informe um nome(Escreva FIM para sair): ");
            nome = Convert.ToString(Console.ReadLine()).ToUpper();

            if (nome != "FIM" && nome != "")
                nomesList.Add(nome);
        } while (nome != "FIM");

        if (nomesList.Count > 0){
            nomesList.Sort();

            Console.WriteLine("Nomes ordenados:");
            foreach (string x in nomesList)
                Console.WriteLine(x);
        }
        else{
            Console.WriteLine("Não há nenhum nome na lista");
        }
    }

}