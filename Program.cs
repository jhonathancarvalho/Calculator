using Calculator.Models;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Bem-vindo à Calculadora!");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("----------");
        Console.Write("Digite a opção desejada: ");

            string? input = Console.ReadLine();

        if (!short.TryParse(input, out short option))
    {
        Console.WriteLine("Entrada inválida. Por favor, insira um número.");
        Console.ReadKey();
        Menu();
        return;
    }

    switch (option)
    {
        case 1:
            Addition.Execute();
            break;
        case 2:
            Subtraction.Execute();
            break;
        case 3:
            Division.Execute();
            break;
        case 4:
            Multiplication.Execute();
            break;
        case 5:
            Console.WriteLine("Encerrando o programa. Até mais!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ReadKey();
            Menu();
            break;
        }
    }
}
