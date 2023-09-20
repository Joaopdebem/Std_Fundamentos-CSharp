using System.Globalization;
using System;

namespace Money
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;

            Console.WriteLine(
                valor.ToString(
                    "C",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );

            Console.WriteLine($"Só arredonda para o mais próximo - {Math.Round(valor)}");
            Console.WriteLine($"Arredonda para cima  - {Math.Ceiling(valor)}");
            Console.WriteLine($"Arredonda para baixo - {Math.Floor(valor)}");

        }
    }
}