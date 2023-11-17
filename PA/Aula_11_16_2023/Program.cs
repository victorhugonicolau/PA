using System;

namespace Aula_11_16_2023
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void ex_1()
        {

            Console.WriteLine("Números ímpares:");


            for (int contador = 1; contador <= 20; contador++)
            {

                if (contador % 2 != 0)
                {
                    Console.WriteLine(contador);
                }
            }

        }

        static void ex_2()
        {
            int subtracao1, subtracao2;

            for (int contador = 1; contador <= 3; contador++)
            {
                Console.Write("Iforme o primeiro número: ");
                subtracao1 = int.Parse(Console.ReadLine());

                Console.Write("Iforme o segundo número: ");
                subtracao2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"O Resultado: {subtracao1 - subtracao2}\n");
            }
        }
    }
}
