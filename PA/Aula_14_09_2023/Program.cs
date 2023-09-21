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

        static void ex_3() // coletar os 4 numeros fazer a média e se for <7 reprovou e >7 passou (19_09_2023)
        {
            float n1, n2, n3, n4, media;

            Console.Write("Digite a primeira nota: ");
            n1 = byte.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            n4 = float.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 7 && media <= 10)
            {
                Console.WriteLine($"\n Sua média é {media} passou de ano!");
            }

            else if (media < 7 && media >= 0)
            {
                Console.WriteLine($"\n Sua média é {media} reprovou de ano!");
            }

            else
            {
                Console.WriteLine("\nSua media deve estar entre 0 e 10");
            }
        }

    }
}
