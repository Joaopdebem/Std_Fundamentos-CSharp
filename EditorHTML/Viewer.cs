using System;
using System.Text.RegularExpressions;
using System.IO;

namespace EditorHTML
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Console.WriteLine(" Modo de Visualização");
            System.Console.WriteLine("-------------------------------------------------------------------");
            Replace(text);
            System.Console.WriteLine("\n-------------------------------------------------------------------");
            System.Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();
        }
        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }

        }

    }
}