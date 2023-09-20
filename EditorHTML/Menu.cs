using System;
using System.IO;
namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen(98, 15);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOptions(option);
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=================================================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }
        public static void DrawScreen(int widthScreen, int heightScreen)
        {
            DrawMainRow(widthScreen);
            DrawEmptyColumns(widthScreen, heightScreen);
            DrawMainRow(widthScreen);
        }
        public static void DrawMainRow(int widthScreen)
        {
            Console.Write("+");
            for (int width = 0; width <= widthScreen; width++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawEmptyColumns(int widthScreen, int heightScreen)
        {
            for (int lines = 0; lines <= heightScreen; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= widthScreen; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
        }
        public static void HandleMenuOptions(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(""); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }

    }
}