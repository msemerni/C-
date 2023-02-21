using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game01
{
    class Drawer
    {
        private readonly char gameNodeSymbol;
        private readonly char frameChar;

        public Drawer(char gameNodeChar, char FrameChar)
        {
            Console.CursorVisible = false;
            gameNodeSymbol = gameNodeChar;
            frameChar = FrameChar;
        }


        public void DrawGameNode(GameNode node, char NodeSymbol, ConsoleColor NodeColor)
        {
            Console.ForegroundColor = NodeColor;
            Console.SetCursorPosition(node.x, node.y);
            Console.WriteLine(NodeSymbol);
            ////Thread.Sleep(300);
            ////Console.Beep();
        }

        public void ClearGameNode(GameNode node)
        {
            Console.SetCursorPosition(node.X, node.Y);
            Console.WriteLine(' ');
        }

        public void DrawGameFieldFrame(GameField field, ConsoleColor color, ConsoleColor color2, char frameChar)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = color2;
            int yPosition = field.StartFieldY - 1;
            int xPosition = field.StartFieldX - 1;

            for (int i = 0; i < field.Height + 2; i++)
            {
                Console.SetCursorPosition(xPosition, yPosition);
                for (int j = 0; j < field.Width + 2; j++)
                {
                    if (i == 0 || i == field.Height + 1)
                    {
                        Console.Write(frameChar);
                    }
                    else if (j == 0 || j == field.Width + 1)
                    {
                        Console.Write(frameChar);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
                Console.SetCursorPosition(field.StartFieldX, ++yPosition);
            }
        }


    }
}