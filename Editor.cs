using System;
using System.Text;

namespace chtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Welcome to the HTML Editor!");
            Console.WriteLine("---------------------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();
            ConsoleKeyInfo key;

            do
            {
                string line = ReadLineWithEscape(out key);
                if (key.Key != ConsoleKey.Escape)
                {
                    file.AppendLine(line);
                }
            } while (key.Key != ConsoleKey.Escape);

            Console.WriteLine("--------------");
            Console.WriteLine("Want to save your file?");
            Viewer.Show(file.ToString());
        }

        private static string ReadLineWithEscape(out ConsoleKeyInfo escapeKey)
        {
            var input = new StringBuilder();
            escapeKey = new ConsoleKeyInfo();

            while (true)
            {
                var key = Console.ReadKey(intercept: false);
                
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return input.ToString();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    escapeKey = key;
                    return input.ToString();
                }
                else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    input.Append(key.KeyChar);
                }
            }
        }
    }
}