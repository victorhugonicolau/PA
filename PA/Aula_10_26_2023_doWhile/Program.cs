using System;

namespace Aula_10_26_2023_doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;

            do // while faz o teste no inicio / do while faz o texte no final 
            {
                Console.WriteLine($"2 x {contador} = {2 * contador}");
                contador++;
            } while (contador <= 10);

            Console.WriteLine("Fim da tabuada");
        }
    }
}
