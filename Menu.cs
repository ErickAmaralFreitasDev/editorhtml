using System;

namespace chtml
{
    public static class Menu
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();
            Console.ResetColor();

            var option = short.Parse(Console.ReadLine());
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(10, 1);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(5, 2);
            Console.Write("=======================");
            Console.SetCursorPosition(10, 3);
            Console.Write("1. New File");
            Console.SetCursorPosition(10, 4);
            Console.Write("2. Open File");
            Console.SetCursorPosition(10, 5);
            Console.Write("3. Exit");
            Console.SetCursorPosition(9, 7);
            Console.Write("Select an option: ");
            // Console.SetCursorPosition(1, 13);

        }

    }
}