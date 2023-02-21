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

        public Drawer()
        {
            Console.CursorVisible = false;
        }

        public void DrawInitialNode
        (int initialNodeX, int initialNodeY, ConsoleColor initialNodeColor, char initialNodeSymbol)
        {
            Console.ForegroundColor = initialNodeColor;
            Console.SetCursorPosition(initialNodeX, initialNodeY);
            Console.Write(initialNodeSymbol);
        }

        public void DrawNodeList(IEnumerable<ConsoleNode> nodes)
        {
            foreach (var consoleNode in nodes)
            {
                DrawGameNode(consoleNode);
            }
        }
        
        public void DrawGameNode(ConsoleNode node)
        {
            Console.ForegroundColor = node.NodeColor;
            Console.SetCursorPosition(node.x, node.y);
            Console.WriteLine(node.NodeSymbol);
            //Thread.Sleep(100);

        }

        //????????????????????
        //public void ClearGameNode(GameNode node)
        //{
        //    Console.SetCursorPosition(node.X, node.Y);
        //    Console.WriteLine(' ');
        //}

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

        public void DrawListAndScore(List<ConsoleNode> nodes, GameField field, int shift, int winCount, int level, int lives)
        {
            Console.SetCursorPosition(field.StartFieldX + field.Width + 1 + shift, field.StartFieldY - 1);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Очки: ");
            Console.ForegroundColor = nodes[0].NodeColor;
            Console.SetCursorPosition(field.StartFieldX + field.Width + 1 + shift, field.StartFieldY);
            Console.WriteLine("{0}", winCount);

            Console.SetCursorPosition(field.StartFieldX + field.Width + 1 + shift, field.StartFieldY + 2);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Уровень: ");
            Console.ForegroundColor = nodes[0].NodeColor;
            Console.SetCursorPosition(field.StartFieldX + field.Width + 1 + shift, field.StartFieldY + 3);
            Console.WriteLine("{0}", level);

            Console.SetCursorPosition(field.StartFieldX + field.Width + 1 + shift, field.StartFieldY + 5);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Жизни: ");
            Console.ForegroundColor = nodes[0].NodeColor;
            Console.SetCursorPosition(field.StartFieldX + field.Width + 1 + shift, field.StartFieldY + 6);
            Console.WriteLine("{0}", lives);




        }

    }
}