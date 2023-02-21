using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game01
{
    class TitleAndLoader
    {
        private ConsoleColor ColorFG = ConsoleColor.Red;
        private ConsoleColor ColorBG = ConsoleColor.DarkBlue;
        private ConsoleColor Color2FG = ConsoleColor.White;
        private ConsoleColor Color2BG = ConsoleColor.Black;
        private ConsoleColor Color3FG = ConsoleColor.Blue;
        private ConsoleColor Color3BG = ConsoleColor.Gray;
        private char LoaderChar = (char)016;

    public void DrawTitle()
        {
            do
            {
                Console.Title = "Crazy Nodes";
                Console.SetCursorPosition(25, 10);
                Console.ForegroundColor = ColorFG;
                Console.BackgroundColor = ColorBG;
                Console.WriteLine("++++++++ Crazy Nodes ++++++++");
                Console.ForegroundColor = Color2FG;
                Console.BackgroundColor = Color2BG;
                Console.SetCursorPosition(28, 12);
                Console.WriteLine(@"Для старта нажмите ENTER");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            while (Console.ReadKey().Key != ConsoleKey.Enter);
                Console.Clear();
        }

        public void DrawLoader()
        {
            Console.ForegroundColor = Color3FG;
            Console.SetCursorPosition(28, 10);
            Console.WriteLine("Подождите, идёт загрузка");

            Console.SetCursorPosition(28, 12);
            Console.BackgroundColor = Color3BG;
            string loader = new String(' ', 24);
            Console.Write(loader);

            Console.SetCursorPosition(28, 12);
            for (int i = 0; i < 24; i++)
            {
                Console.Write(LoaderChar);
                Thread.Sleep(100);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }

    }
}
