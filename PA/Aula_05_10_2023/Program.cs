using System;

namespace Aula_05_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string programa;

            Console.Write("Digite o programa desejado: ");
            programa = Console.ReadLine();

            if (programa == "ex_1")
            {
                ex_1();
            }

            else if (programa == "ex_2")
            {
                ex_2();
            }

            else if (programa == "ex_3")
            {
                ex_3();
            }

            else
            {
                Console.Write("Digitou algo errado.");
            }

        }

        static void ex_1() // calculadora
        {
            float numero1, numero2;
            char operacao;

            Console.Write("Digite a equação desejada (+, -, *, /): ");
            operacao = Char.Parse(Console.ReadLine());

            Console.Write("\nDigite um número: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = float.Parse(Console.ReadLine());

            if (operacao == '+')
            {
                Console.WriteLine($"\nO resultado é: {numero1 + numero2}");
            }

            else if (operacao == '-')
            {
                Console.WriteLine($"\nO resultado é: {numero1 - numero2}");
            }

            else if (operacao == '*')
            {
                Console.WriteLine($"\nO resultado é: {numero1 * numero2}");
            }

            else if (operacao == '/')
            {
                Console.WriteLine($"\nO resultado é: {numero1 / numero2}");
            }

            else
            {
                Console.WriteLine("\nErro de digitação.");
            }
        }

        static void ex_2()
        {
            {
                float numero;

                Console.Write("\nDigite um número: ");
                numero = float.Parse(Console.ReadLine());

                if (numero < 10)
                {
                    Console.WriteLine("Seu número é menor que 10.");
                }

                else
                {
                    Console.WriteLine("Seu número é maior que 10.");
                }
            }

        } // maior que 10

        static void ex_3()
        {
            float salario;

            Console.Write("\nDigite seu salário: ");
            salario = float.Parse(Console.ReadLine());

            if (salario > 0 && salario <= 3000)
            {
                Console.WriteLine($"Seu salário com reajuste é {(salario * 0.5) + salario} reais.");
            }

            else if (salario > 3000 && salario <=7000)
            {
                Console.WriteLine($"Seu salário com reajuste é {(salario * 0.2) + salario} reais.");
            }

            else if (salario > 7000 && salario <= 10000)
            {
                Console.WriteLine($"Seu salário com reajuste é {(salario * 0.15) + salario} reais.");
            }

            else
            {
                Console.WriteLine($"Seu salário com reajuste é {(salario * 0.1) + salario} reais.");
            }
          
        } // porcentagem salário


    }
}

