namespace Calculator.Models;

public class Subtraction
{
    public static void Execute()
    {
         Console.Clear();

            Console.WriteLine("Você escolheu Subtração.");
            float firstNumber = ReadFloat("Digite o primeiro número: ");
            float secondNumber = ReadFloat("Digite o segundo número: ");

            float result = firstNumber - secondNumber;

            Console.WriteLine($"\nO resultado da subtração é: {result}");
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

