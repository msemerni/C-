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
        private ConsoleColor ColorFG = ConsoleColor.Red; /*{ get; private set; }*/
        private ConsoleColor ColorBG = ConsoleColor.DarkBlue; /*{ get; private set; }*/
        private ConsoleColor Color2FG = ConsoleColor.White; /*{ get; private set; }*/
        private ConsoleColor Color2BG = ConsoleColor.Black; /*{ get; private set; }*/
        private ConsoleColor Color3FG = ConsoleColor.Blue; /*{ get; private set; }*/
        private ConsoleColor Color3BG = ConsoleColor.Gray; /*{ get; private set; }*/
        private char LoaderChar = (char)016; /*{ get; private set; }*/

    //public TitleAndLoader(char loaderChar, ConsoleColor colorFG, ConsoleColor colorBG,
    //                        ConsoleColor color2FG, ConsoleColor color2BG, ConsoleColor color3FG, ConsoleColor color3BG)
    //{
    //    ColorFG = colorFG;
    //    ColorBG = colorBG;
    //    Color2FG = color2FG;
    //    Color2BG = color2BG;
    //    Color3FG = color3FG;
    //    Color3BG = color3BG;
    //    LoaderChar = loaderChar;
    //}

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
