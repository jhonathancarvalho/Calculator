namespace Calculator.Models;

public class Division
{
     public static void Execute()
    {
         Console.Clear();

            Console.WriteLine("Você escolheu Divisão.");
            float firstNumber = ReadFloat("Digite o primeiro número: ");
            float secondNumber = ReadFloat("Digite o segundo número: ");

            if (secondNumber == 0)
            {
                Console.WriteLine("\nErro: Divisão por zero não é permitida.");
            }
            else
            {
                float result = firstNumber / secondNumber;
                Console.WriteLine($"\nO resultado da divisão é: {result}");
            }
            Console.ReadKey();

            Program.Menu();
        }

        private static float ReadFloat(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (float.TryParse(input, out float number))
                {
                    return number;
                }

                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            }
        }
    }
