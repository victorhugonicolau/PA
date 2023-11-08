using System;

namespace Aula_07_11_2023_For
{
    class Program
    {
        static void Main(string[] args)
        {
            exemplo2();
        }

        static void exemplo1()
        {
            for (int contador = 1; contador <= 10; contador++) // já vem pré feito os atributos para o laço de repetição 
            {
                Console.WriteLine($"2 x {contador} = {2 * contador}");
            }

            Console.WriteLine("fim da tabuada");
        } // for exemplo com tabuada do 2

        static void exemplo2()

        {
            int fator;

            Console.Write("Digite o fator: ");
            fator = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++) 
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
            }
        }
    }
}
