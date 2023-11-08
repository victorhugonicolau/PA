using System;

namespace Aula_11_07_2023_Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.Write("Digite o número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2== 0)
            {
                Console.Write("O número é par");
            }

            else
            {
                Console.WriteLine("O número é impar");
            }
        }
    }
}
