using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media;

            Console.Write("Digite a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            n4 = float.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 0 && media < 5)
            {
                Console.WriteLine($"\n Sua média é {media}, reprovado");
            }

            else if (media >= 5.01 && media < 7)
            {
                Console.WriteLine($"\n Sua média é {media}, recuperação");
            }

            else if (media >= 7 && media <= 10)
            {
                Console.WriteLine($"\n Sua média é {media}, aprovado");
            }

            else
            {
                Console.WriteLine($"\nSua média é {media}" +
                    $"\nA media deve estar entre 0 e 10");
            }

        }
    }
}
