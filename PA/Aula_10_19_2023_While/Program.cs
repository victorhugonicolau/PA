using System;

namespace Aula_10_19_2023_While
{
    class Program
    {
        static void Main(string[] args)
        {
            exemplo_3();
        }

        static void exemplo_1() // número ficho
        {
            int contador = 1;
            while (contador <= 10) // tabuada do 2 até 10 
            {
                Console.WriteLine($"2 x {contador} = {2 * contador}");

                //contador = contador + 1; (jeito antigo)

                contador++; // própria variável + 1 
            }

            Console.WriteLine("*** Fim da tabuada ***");
        } 

        static void exemplo_2() // usuário informa o número que vai ser multiplicado 
        {
            int contador = 1, fator;

            Console.Write("Informe o fator: ");
            fator = int.Parse(Console.ReadLine());

            while (contador <= 10) 
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                //contador = contador + 1; 
                contador++; 
            }

            Console.WriteLine("*** Fim da tabuada ***");
        }

        static void exemplo_3() // usuário informa o nuúmero que vai ser multiplicado e até que número vai a tabuada 
        {
            int contador = 1, fator, multiplicador;

            Console.Write("Informe o fator: ");
            fator = int.Parse(Console.ReadLine());

            Console.Write("Informe o número final: ");
            multiplicador = int.Parse(Console.ReadLine());

            while (contador <= multiplicador)
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                //contador = contador + 1; 
                contador++;
            }

            Console.WriteLine("*** Fim da tabuada ***");
        }
    }
}
