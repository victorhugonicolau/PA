using System;

namespace Aula_14_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string programa;

            Console.Write("Digite o programa desejado: ");
            programa = Console.ReadLine();

            if (programa == "ex_1")
            {
                ex_1();
            }

            else if (programa == "ex_2")
            {
                ex_2();
            }

            else
            {
                Console.Write("Digitou algo errado");
            }
        }

        static void ex_1() // soma de dois números (14_09_2023) 
        {
            int numero1, numero2;

            Console.Write("\nDigite o número para soma: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número para soma: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("O resultado é: {0} ", numero1 + numero2);
        }  

        static void ex_2() // a média de quatro números (14_09_2023)
        {
            decimal n1, n2, n3, n4;

            Console.Write("\nEscreva a primeira nota: ");
            n1 = decimal.Parse(Console.ReadLine());

            Console.Write("Escreva a segunda nota: ");
            n2 = decimal.Parse(Console.ReadLine());

            Console.Write("Escreva a terceira nota: ");
            n3 = decimal.Parse(Console.ReadLine());

            Console.Write("Escreva a quarta nota: ");
            n4 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nSua média é: {0}", (n1 + n2 + n3 + n4) / 4);
            Console.WriteLine($"\nSua média é: {(n1 + n2 + n3 + n4) / 4}"); // outra maneira de dar a resposta 
        }

    }
}
