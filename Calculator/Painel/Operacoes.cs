using System;
using Calculator.BasicOperations;
using Calculator.Calculate;
using Calculator;

namespace Calculator.Painel
{
    public class Operacoes
    {
        public static void OpcaoOperacoes(float valor1, float valor2)
        {
            Console.WriteLine("\nOperações: \n");
            Console.WriteLine("Digite 1 para Somar");
            Console.WriteLine("Digite 2 para Subtrair");
            Console.WriteLine("Digite 3 para Multiplicar");
            Console.WriteLine("Digite 4 para Dividir\n");

            int opcaoOperacao = int.Parse(Console.ReadLine());

            FazerCalculo calcular = new FazerCalculo();

            switch (opcaoOperacao)
            {
                case 1:
                    Console.WriteLine($"\nResultado da Soma: {calcular.Soma.Calcular(valor1, valor2)}");
                    break;
                case 2:
                    Console.WriteLine($"\nResultado da Subtração: {calcular.Subtracao.Calcular(valor1, valor2)}");
                    break;
                case 3:
                    Console.WriteLine($"\nResultado da Multiplicação: {calcular.Multiplicacao.Calcular(valor1, valor2)}");
                    break;
                case 4:
                    Console.WriteLine($"\nResultado da Divisão: {calcular.Divisao.Calcular(valor1, valor2)}");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente!");
                    OpcaoOperacoes(valor1, valor2);
                    break;
            }
        }

    }
}