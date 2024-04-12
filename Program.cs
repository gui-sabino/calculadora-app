using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mensagem de entrada
            Console.WriteLine("Calculadora no Console!");

            // inicializa as 2 variáveis para o cálculo
            double num1 = 0;
            double num2 = 0;

            // Entra em Loop até o usuário dar Exit
            while (true)
            {
                // Menu
                Console.WriteLine("-===================-");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha sua operação: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                // Operações
                switch (choice)
                {
                    case 1: // Adição
                        Console.Write("Insira o primeiro número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Insira o segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case 2: // Subtração
                        Console.Write("Insira o primeiro número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Insira o segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case 3: // Multiplicação
                        Console.Write("Insira o primeiro número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Insira o segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                    case 4: // Divisão
                        Console.Write("Insira o primeiro número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Insira o segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if (num2 == 0)
                        {
                            Console.WriteLine("Erro: não é possível realizar divisões com 0.");
                        }
                        else
                        {
                            Console.WriteLine($"{num1} / {num2} = " + Math.Round(num1 / num2, 2));
                        }
                        break;
                    case 5: // Sai do Loop
                        return;
                    default: // Mensagem de erro
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}