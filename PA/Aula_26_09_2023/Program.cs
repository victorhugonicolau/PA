using System;

namespace Aula_26_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media, percFrequencia;

            Console.Write("Digite a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            n4 = float.Parse(Console.ReadLine());

            Console.Write("\nInforme o percentual de frequência: ");
            percFrequencia = float.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            if (media < 5 && percFrequencia <= 40 ) 
            {
                Console.WriteLine("Aluno Reprovadon");
            }

            else if (media < 7 && percFrequencia <= 60)
            {
                Console.WriteLine("Aluno em recuperação");
            }

            else if (media <= 10 && percFrequencia > 60)
            {
                Console.WriteLine("Aluno Aprovado");
            }

            else
            {
                Console.WriteLine("Será analisado pela secretaria acadêmica");
            }
        }
    }
}
