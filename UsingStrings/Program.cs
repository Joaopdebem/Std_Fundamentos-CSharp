using System.Text;
using System.Net.Mime;
namespace UsingStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*  Guid(Hash)
            var id = Guid.NewGuid();
            id.ToString();
            System.Console.WriteLine(id);
            */

            /* Interpolação Strings
            var price = 10.2;
            var texto = string.Format("O preço do produto é R${0} apenas na promoção.", price);
            var texto2 = $"O preço do produto é R${price} reais. \nApenas na promoção.";
            System.Console.WriteLine(texto);
            System.Console.WriteLine(texto2);
            */

            /* Comparação Strings
            var texto = "Testando";
            var texto2 = " Este texto é um teste ";

            texto2 = texto2.Trim();

            System.Console.WriteLine(texto.CompareTo("Testando"));
            System.Console.WriteLine(texto.CompareTo("testando"));

            System.Console.WriteLine(texto2.Contains("teste"));
            System.Console.WriteLine(texto2.Contains("Teste", StringComparison.OrdinalIgnoreCase));

            System.Console.WriteLine(texto2.StartsWith("Este"));
            System.Console.WriteLine(texto2.StartsWith("este"));
            System.Console.WriteLine(texto2.EndsWith("Teste"));
            System.Console.WriteLine(texto2.EndsWith("teste"));

            System.Console.WriteLine(texto2.Equals("Este texto é um teste"));
            System.Console.WriteLine(texto.Equals("este texto é um teste"));

            System.Console.WriteLine(texto2.IndexOf("é"));
            System.Console.WriteLine(texto2.LastIndexOf("s"));

            System.Console.WriteLine(texto2.ToUpper());
            System.Console.WriteLine(texto2.ToLower());

            System.Console.WriteLine(texto2.Insert(5, "aqui "));
            System.Console.WriteLine(texto2.Remove(4, 6));

            System.Console.WriteLine(texto.Length);
            System.Console.WriteLine(texto2.Replace("Este", "Isto"));

            var divisao = texto2.Split(" ");

            System.Console.WriteLine(divisao[0]);
            System.Console.WriteLine(divisao[1]);
            System.Console.WriteLine(divisao[2]);
            System.Console.WriteLine(divisao[3]);

            var resultado = texto2.Substring(5, 5);

            System.Console.WriteLine(resultado);
            */

            var texto = new StringBuilder();

            texto.Append("Este texto é um teste");
            texto.Append("é um teste");
            texto.Append("Este texto");
            texto.Append("Este um teste");

            texto.ToString();
            System.Console.WriteLine(texto);


        }
    }
}