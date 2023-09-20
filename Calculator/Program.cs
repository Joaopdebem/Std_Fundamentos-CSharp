using System;
using Calculator.BasicOperations;
using Calculator.Calculate;
using Calculator.Painel;
using Calculator;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            NovoCalculo novoCalculo = new NovoCalculo();
            Operacoes operacoes = new Operacoes();

            Console.WriteLine("\n#################### Calculadora básica ####################\n");
            Console.WriteLine("Insira seus dois valores e em seguida escolha sua operação.\n");

            Console.WriteLine("Primeiro valor: ");
            float primeiroValor = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float segundoValor = int.Parse(Console.ReadLine());

            Operacoes.OpcaoOperacoes(primeiroValor, segundoValor);
            Console.WriteLine("\n\nPressione Enter para continuar...");
            Console.ReadKey();
            NovoCalculo.NovaConsulta();

            Console.ReadLine();

        }

    }
}
