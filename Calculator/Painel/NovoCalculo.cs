using System;
using Calculator.BasicOperations;
using Calculator;

namespace Calculator.Painel
{
    public class NovoCalculo
    {
        public static void NovaConsulta()
        {
            Console.Clear();

            Console.WriteLine("Gostaria de realizar um novo cálculo?\n");
            Console.WriteLine("Digite 1 para sim");
            Console.WriteLine("Digite 2 para não\n");

            int novaOperacao = int.Parse(Console.ReadLine());

            if (novaOperacao == 1)
            {
                Console.WriteLine("\nReiniciando...");
                Thread.Sleep(1500);
                Program.Main();
            }
            else if (novaOperacao == 2)
            {
                Console.WriteLine("\nPrograma encerrado!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nOpção inválida! Tente novamente.");
                NovaConsulta();
            }
        }

    }
}