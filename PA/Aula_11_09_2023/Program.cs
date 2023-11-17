using System;

namespace Aula_11_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "S";

            while (resposta.ToUpper() == "S") // toUpper lê a resposta em maúsculo 
            {
                Console.Clear(); // apaga

                calcularTabuada();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Deseja continuar? ");
                resposta = Console.ReadLine();
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*** FIM ***");

        }

        static void calcularTabuada()
        {
            float fator;

            Console.Write("Digite o fator desejado: ");
            fator = float.Parse(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                if (contador % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; // Console.ForegroundColor = muda a cor do fundo / ConsoleColor.(cor escolhida para o fundo) 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
            }
        }
    }
}
