using System;

namespace Aula_21_11_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            ex_2();
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

        } // altura pedida no exercício

        static void ex_2()
        {

            string resposta = "S";

            while (resposta.ToUpper() == "S")
            {
                Console.Clear();
                ex_2_comple();
                Console.Write("\nDeseja continuar? ");
                resposta = Console.ReadLine();
            }

        } // complemento urna eletrônica
        static void ex_2_comple()
        {
            int Voto = -1;
            int candidato1 = 0, candidato2 = 0, candidato3 = 0, candidato4 = 0, nulo = 0, votoBranco = 0, totalVotos;

            Console.Write("*** Eleição presidencial ***\n");

            while (Voto != 0)
            {
                Console.Clear();
                Console.WriteLine("********** VOTAÇÃO **********");
                Console.WriteLine("\n--------------------------------");
                Console.Write("Os códiogos dos candidatos são: \n " +
                    "\n1 - Candidato1\n" +
                    "2 - Candidato2\n" +
                    "3 - Candidato3\n" +
                    "4 - Caditado4\n" +
                    "5 - Voto nulo\n" +
                    "6 - Voto em branco\n" +
                    "0 - Finaliza o programa\n");
                Console.WriteLine("--------------------------------");

                Console.Write("\nDigite a opção escolhida: ");
                Voto = int.Parse(Console.ReadLine());

                switch (Voto)
                {
                    case 1:
                        candidato1 += 1;
                        break;
                    case 2:
                        candidato2 += 1;
                        break;
                    case 3:
                        candidato3 += 1;
                        break;
                    case 4:
                        candidato4 += 1;
                        break;
                    case 5:
                        nulo += 1;
                        break;
                    case 6:
                        votoBranco += 1;
                        break;
                    default:
                        Console.WriteLine("Voto não computado.");
                        break;
                }
            }
            Console.Clear();

            totalVotos = candidato1 + candidato2 + candidato3 + candidato4 + nulo + votoBranco;

            Console.WriteLine("****** Apuração ******");
            Console.WriteLine("----------------------");
            Console.WriteLine($"\ncadidato1 = {candidato1}");
            Console.WriteLine($"cadidato2 = {candidato2}");
            Console.WriteLine($"cadidato3 = {candidato3}");
            Console.WriteLine($"cadidato4 = {candidato4}");
            Console.WriteLine($"Votos em nulo = {nulo}");
            Console.WriteLine($"Votos em Branco = {votoBranco}");
            //Console.WriteLine($"% de Votos nulos {totalVotos / 100}%");
            //Console.WriteLine($"% de Votos brancos {votoBranco * totalVotos / 100}%");
            Console.WriteLine("----------------------");
        } // urna eletrônica
    }
}

