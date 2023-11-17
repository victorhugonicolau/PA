using System;

namespace Aula_11_16_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            desafio();
        }

        static void ex_2()
        {

            string resposta = "S";

            while (resposta.ToUpper() == "S")
            {
                Console.Clear();
                ex_2complemento();
                Console.Write("Deseja continuar? ");
                resposta = Console.ReadLine();
            }
        }

        static void ex_2complemento()
        {
            float numeroN;

            Console.WriteLine("Programa para mostrar os números ímpares");

            Console.Write("Iforme o número: ");
            numeroN = float.Parse(Console.ReadLine());


            for (int contador = 1; contador <= numeroN; contador++)
            {

                if (contador % 2 != 0)
                {
                    Console.WriteLine(contador);
                }
            }
        }


        static void ex_1()
        {
            string resposta = "S";

            while (resposta.ToUpper() == "S")
            {
                Console.Clear();
                ex_1complemento();
                Console.Write("Deseja continuar? ");
                resposta = Console.ReadLine();
            }
        }

        static void ex_1complemento()
        {

            int subtracao1, subtracao2;

            Console.WriteLine("Programa com 3 contas de subtração");

            for (int contador = 1; contador <= 3; contador++)
            {
                Console.Write("Iforme o primeiro número: ");
                subtracao1 = int.Parse(Console.ReadLine());

                Console.Write("Iforme o segundo número: ");
                subtracao2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"O Resultado: {subtracao1 - subtracao2}\n");
            }
        }

        static void desafio()
        {
           
        }
    }
}
