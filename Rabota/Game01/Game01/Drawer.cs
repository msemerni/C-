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


        public void DrawNodeList(IEnumerable <ConsoleNode> nodes)
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
        }

        //????????????????????
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

        //public void DrawWinner(int shiftX, int shiftY, int width)
        //{
        //    Console.SetCursorPosition(shiftX + width + 3, shiftY);
        //    //Console.Write("Победители:");
        //}

        //public void DrawLooser(int currentX, int currentY, ConsoleColor currentColor, char currentSymbol,
        //    int shiftX, int shiftY, int width)
        //{
        //    Console.ForegroundColor = currentColor;
        //    Console.SetCursorPosition(currentX, currentY);
        //    Console.Write(currentSymbol);
        //    Console.SetCursorPosition(shiftX + width + 13, shiftY);
        //    //Console.Write("Проигравшие:");
        //    Console.SetCursorPosition(shiftX + width + 13, shiftY + 1);
        //    Console.Write(currentSymbol);
        //    Console.ReadKey();
        //}

        public void DrawListAndMessage(List <ConsoleNode> nodes, GameField field, int shift, string message)
        {
            Console.SetCursorPosition(field.StartFieldX + field.Width + 1 + shift, field.StartFieldY - 1);
            Console.Write(message);

            for (int nodeCounter = 0; nodeCounter < nodes.Count; nodeCounter++)
            {
                Console.ForegroundColor = nodes[nodeCounter].NodeColor;
                Console.SetCursorPosition(field.StartFieldX + field.Width + 1 + shift, field.StartFieldY + nodeCounter);
                Console.Write(nodes[nodeCounter].NodeSymbol);
                Console.ForegroundColor = ConsoleColor.DarkBlue;

            }
        }


    }
}