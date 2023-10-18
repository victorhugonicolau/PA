using System;

namespace Aula_10_17_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;
            char operacao;

            Console.Write("Digite a equação desejada (+, -, *, /): ");
            operacao = Char.Parse(Console.ReadLine());

            Console.Write("\nDigite um número: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = float.Parse(Console.ReadLine());

            switch (operacao)
            {
                case '+':
                    Console.WriteLine($"\nO resultado é: {numero1 + numero2}");
                    break;

                case '-':
                    Console.WriteLine($"\nO resultado é: {numero1 - numero2}");
                    break;

                case '*':
                    Console.WriteLine($"\nO resultado é: {numero1 * numero2}");
                    break;

                case '/':
                    Console.WriteLine($"\nO resultado é: {numero1 / numero2}");
                    break;

                default:
                    Console.WriteLine("Operador inválido");
                    break;
            }

        }
    
    }
}
