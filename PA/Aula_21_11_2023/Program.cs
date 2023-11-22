using System;

namespace Aula_21_11_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            ex_1();
        }

        static void ex_1()

        {
            float alturaGeral;
            float alturaMaior = 0, alturaMenor = 0;

            for (int contador = 1; contador <= 15; contador++)
            {
                Console.Write("Informe a altura: ");
                alturaGeral = float.Parse(Console.ReadLine());

                if (alturaGeral >= alturaMaior)
                {
                    alturaMaior = alturaGeral;
                }

                else if (alturaGeral <= alturaMenor || alturaMenor == 0)
                {
                    alturaMenor = alturaGeral;
                }
            }

            Console.WriteLine($"Maior altura: {alturaMaior}");
            Console.WriteLine($"Menor altura: {alturaMenor}");

        }
    }
}
