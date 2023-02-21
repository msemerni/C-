using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game01
{
    class GameLogic
    {
        public void StartGame()
        {
            Drawer dr = new Drawer((char)01, '#');
            GameField field = new GameField(6, 8, 5, 5);
            Random rnd = new Random();
            bool isNodeExist = false;

            List<GameNode> nodeList = new List<GameNode>(4);
            for (int i = 0; i < 4; i++)
            {
                GameNode node = new GameNode(rnd.Next(field.StartFieldX, field.StartFieldX + field.Width), rnd.Next(field.StartFieldY, field.StartFieldY + field.Height));
                nodeList.Add(node);
                ////// или так:
                ////nodeList.Add(new GameNode(rnd.Next(field.StartX, field.StartX + field.Width), rnd.Next(field.StartY, field.StartY + field.Height)));
            }

            dr.DrawGameFieldFrame(field, ConsoleColor.DarkBlue, ConsoleColor.DarkGray, '#');



            do
            {
                for (int j = 0; j < nodeList.Count; j++)
                {
                    switch (rnd.Next(1, 5))
                    {
                        case 1:
                            {
                                foreach (var node in nodeList)
                                {
                                    if (node.X == nodeList[j].X && node.Y == nodeList[j].Y - 1)
                                    {
                                        isNodeExist = true;
                                    }
                                }

                                if (nodeList[j].Y > field.StartFieldY && !isNodeExist)
                                {
                                    nodeList[j].MoveUp();
                                }
                                isNodeExist = false;
                                break;
                            }
                        case 2:
                            {
                                foreach (var node in nodeList)
                                {
                                    if (node.X == nodeList[j].X && node.Y == nodeList[j].Y + 1)
                                    {
                                        isNodeExist = true;
                                    }
                                }

                                if (nodeList[j].Y < field.StartFieldY + (field.Height - 1) && !isNodeExist)
                                {
                                    nodeList[j].MoveDown();
                                }
                                isNodeExist = false;
                                break;
                            }
                        case 3:
                            {
                                foreach (var node in nodeList)
                                {
                                    if (node.X == nodeList[j].X - 1 && node.Y == nodeList[j].Y)
                                    {
                                        isNodeExist = true;
                                    }
                                }

                                if (nodeList[j].X > field.StartFieldX && !isNodeExist)
                                {
                                    nodeList[j].MoveLeft();
                                }
                                isNodeExist = false;
                                break;
                            }
                        case 4:
                            {
                                foreach (var node in nodeList)
                                {
                                    if (node.X == nodeList[j].X + 1 && node.Y == nodeList[j].Y)
                                    {
                                        isNodeExist = true;
                                    }
                                }

                                if (nodeList[j].X < field.StartFieldX + (field.Width - 1) && !isNodeExist)
                                {
                                    nodeList[j].MoveRight();
                                }
                                isNodeExist = false;
                                break;
                            }
                    }

                    if (j == 0) { dr.DrawGameNode(nodeList[j], (char)01, ConsoleColor.Red); }
                    if (j == 1) { dr.DrawGameNode(nodeList[j], (char)15, ConsoleColor.Green); }
                    if (j == 2) { dr.DrawGameNode(nodeList[j], (char)03, ConsoleColor.Yellow); }
                    if (j == 3) { dr.DrawGameNode(nodeList[j], (char)04, ConsoleColor.Cyan); }
                    if (j == 4) { dr.DrawGameNode(nodeList[j], (char)12, ConsoleColor.DarkBlue); }
                    if (j == 5) { dr.DrawGameNode(nodeList[j], (char)13, ConsoleColor.DarkCyan); }
                    if (j == 6) { dr.DrawGameNode(nodeList[j], (char)14, ConsoleColor.DarkGray); }
                    if (j == 7) { dr.DrawGameNode(nodeList[j], (char)15, ConsoleColor.DarkGreen); }
                    if (j == 8) { dr.DrawGameNode(nodeList[j], (char)16, ConsoleColor.DarkMagenta); }
                    if (j == 9) { dr.DrawGameNode(nodeList[j], (char)17, ConsoleColor.DarkRed); }
                    if (j == 10) { dr.DrawGameNode(nodeList[j], (char)18, ConsoleColor.DarkYellow); }
                    if (j == 11) { dr.DrawGameNode(nodeList[j], (char)19, ConsoleColor.Gray); }
                    if (j == 12) { dr.DrawGameNode(nodeList[j], (char)20, ConsoleColor.Green); }
                    if (j == 13) { dr.DrawGameNode(nodeList[j], (char)21, ConsoleColor.Magenta); }
                    if (j == 14) { dr.DrawGameNode(nodeList[j], (char)22, ConsoleColor.Red); }
                    if (j == 15) { dr.DrawGameNode(nodeList[j], (char)23, ConsoleColor.White); }
                    if (j == 16) { dr.DrawGameNode(nodeList[j], (char)24, ConsoleColor.Yellow); }
                    if (j == 17) { dr.DrawGameNode(nodeList[j], (char)25, ConsoleColor.Blue); }
                    if (j == 18) { dr.DrawGameNode(nodeList[j], (char)26, ConsoleColor.Cyan); }
                    if (j == 19) { dr.DrawGameNode(nodeList[j], (char)27, ConsoleColor.DarkBlue); }
                    if (j == 20) { dr.DrawGameNode(nodeList[j], (char)28, ConsoleColor.DarkGreen); }

                }

                Thread.Sleep(500);
                foreach (var nod in nodeList)
                {
                    dr.ClearGameNode(nod);
                }
            }
            while (true);
        }
    }
}
