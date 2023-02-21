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
        private readonly GameField gameField;
        private readonly Drawer drawer;
        private readonly Random rnd;
        private List<ConsoleNode> nodes;
        private List<ConsoleNode> winnerNodes;
        private ConsoleNode target;
        private int nodeCount;

        public GameLogic(GameField gameField, Drawer drawer, int nodeCount)
        {
            this.gameField = gameField;
            this.drawer = drawer;
            this.nodeCount = nodeCount;

            rnd = new Random();
            nodes = new List<ConsoleNode>();
            winnerNodes = new List<ConsoleNode>();
            //target = GenerateRandomTarget((char)1, ConsoleColor.White);

        }
        public void StartGame()
        {
            GenerateRandomNodes('F', ConsoleColor.Cyan);

            bool isGameOver = false;
            do
            {
                Console.Clear();
                bool isNewRound = false;
                target = GenerateRandomTarget((char)1, ConsoleColor.White);

                do
                {
                    drawer.DrawGameFieldFrame(gameField, ConsoleColor.DarkBlue, ConsoleColor.Black, '#');

                    for (int i = 0; i < nodes.Count; i++)
                    {
                        MoveNodeRandomly(nodes[i]);
                    }
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        if (IsNodeOnTarget(nodes[i]))
                        {
                            winnerNodes.Add(nodes[i]);
                            drawer.DrawListAndMessage(winnerNodes, gameField, 5, "Победители:");
                            nodes.RemoveAt(i);
                            if (nodes.Count == 1)
                            {
                                drawer.DrawListAndMessage(nodes, gameField, 25, "Проигравшие:");
                                isNewRound = true;
                                RandomPlacement(winnerNodes);
                            }
                        }
                    }
                    drawer.DrawNodeList(nodes);
                    drawer.DrawGameNode(target);
                    Thread.Sleep(100);
                }
                while (!isNewRound);

                Console.ReadKey();

                if (winnerNodes.Count == 1)
                {
                    isGameOver = true;
                }
                else
                {
                    nodes = winnerNodes;
                    winnerNodes = new List<ConsoleNode>();
                }

            } while (!isGameOver);
        }


        private ConsoleNode GenerateRandomNode(int nodeCount)
        {

        int randomX = 0;
        int randomY = 0;
        do
        {
            randomX = rnd.Next(gameField.StartFieldX, gameField.Width + gameField.StartFieldX);
            randomY = rnd.Next(gameField.StartFieldY, gameField.Height + gameField.StartFieldY);

        } while (!IsPositionFree(randomX, randomY));

            return new ConsoleNode(randomX, randomY, (char)(nodeCount + 65),
                                    (ConsoleColor)rnd.Next(1, 15));
    }

    private ConsoleNode GenerateRandomTarget(char symbol, ConsoleColor color)
    {

        int randomX = 0;
        int randomY = 0;
        do
        {
            randomX = rnd.Next(gameField.StartFieldX, gameField.Width + gameField.StartFieldX);
            randomY = rnd.Next(gameField.StartFieldY, gameField.Height + gameField.StartFieldY);

        } while (!IsPositionFree(randomX, randomY));

        return new ConsoleNode(randomX, randomY, symbol, color);
    }

    private ConsoleNode GenerateRandomNodes(char symbol, ConsoleColor color)

    {
        int randomX = 0;
        int randomY = 0;
            for (int i = 0; i < nodeCount; i++)
        {
            nodes.Add(GenerateRandomNode(i));
        }
            return new ConsoleNode(randomX, randomY, symbol, color);

        }

        private bool IsPositionFree(int x, int y)
        {
            foreach (var nd in nodes)
            {
                if (nd.IsOnPossition(x, y))
                    return false;
            }
            return true;
        }



        private void MoveNodeRandomly(ConsoleNode node)
        {
            int randomMove = rnd.Next(1, 5);
            switch (randomMove)
            {

                case 1:
                    {
                        if (IsPositionFree(node.X, node.Y - 1) &&
                        gameField.IsOnField(node.X, node.Y - 1))
                            node.MoveUp();
                    }
                    break;

                case 2:
                    {
                        if (IsPositionFree(node.X, node.Y + 1) &&
                        gameField.IsOnField(node.X, node.Y + 1))
                            node.MoveDown();
                    }
                    break;

                case 3:
                    {
                        if (IsPositionFree(node.X - 1, node.Y) &&
                        gameField.IsOnField(node.X - 1, node.Y))
                            node.MoveLeft();
                    }
                    break;

                case 4:
                    {
                        if (IsPositionFree(node.X + 1, node.Y) &&
                        gameField.IsOnField(node.X + 1, node.Y))
                            node.MoveRight();
                    }
                    break;

            }
        }


        private bool IsNodeOnTarget(ConsoleNode node)
        {
            if (node.X == target.X && node.Y == target.Y)
                return true;
            return false;
        }


        private void RandomPlacement(List<ConsoleNode> nodes)
        {
            foreach (var node in nodes)
            {
                do
                {
                    node.X = rnd.Next(gameField.StartFieldX, gameField.Width + gameField.StartFieldX);
                    node.Y = rnd.Next(gameField.StartFieldY, gameField.Height + gameField.StartFieldY);

                } while (!IsPositionFree(node.X, node.Y));
            }
        }
}
}
