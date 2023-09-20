using System;

namespace Aula_19_09_2023
{
    class Program
    {
        static void Main(string[] args)
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

            if (media > 7)
            {
                Console.Write($"/n Sua média é {media} passou de ano!");
            }

            else
            {
                Console.Write($"/n Sua média é { media} reprovou de ano!!");
            }
        }
    }
}
