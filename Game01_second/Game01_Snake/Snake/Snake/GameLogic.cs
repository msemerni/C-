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
        private ConsoleNode target;
        private int winCounts;
        private int nodeCount;
        private readonly InputHandler _ih;
        private int level;
        private int lives;
        private int speed;

        public GameLogic(GameField gameField, Drawer drawer, int nodeCount, InputHandler ih, int lives, int level, int speed)
        {
            this.gameField = gameField;
            this.drawer = drawer;
            this.nodeCount = nodeCount;
            this.level = level;
            this.lives = lives;
            this.speed = speed;

            _ih = ih;
            _ih.KeyLeft += MoveNodeLeft;
            _ih.KeyRight += MoveNodeRight;
            _ih.KeyUp += MoveNodeUp;
            _ih.KeyDown += MoveNodeDown;
            _ih.KeyPause += Pause;


            rnd = new Random();
            nodes = new List<ConsoleNode>();
            target = GenerateRandomTarget('$', ConsoleColor.DarkGreen);
        }

        public void StartGame()
        {
            bool gOver = false;

            do
            {
                Console.Clear();
                nodes = new List<ConsoleNode>() { new ConsoleNode(0, 0, (char)01, ConsoleColor.DarkYellow) };
                CreateInitialSnake(nodes[0]);
                target = GenerateRandomTarget('$', ConsoleColor.DarkGreen);
                GameTextInfo("Клавиши: " + (char)027 + (char)024 + (char)026 + (char)025 + " - движение / Spacebar - пауза");

                for (;;)
                {
                    _ih.QueryKB();
                    drawer.DrawGameFieldFrame(gameField, ConsoleColor.DarkBlue, ConsoleColor.Black, '#');
                    drawer.DrawGameNode(target);

                    if (nodes[0].move != Direction.MoveStart)
                    {
                        MoveTailOfSnake(nodes);
                        GameTextInfo("                                           ");
                    }
                    nodes[0].Move(CheckPosition);
                    drawer.DrawNodeList(nodes);

                    if (IsHeadOnTarget(nodes[0]))
                    {
                        winCounts++;
                        nodeCount++;
                        Console.Beep(300, 100);

                        if (winCounts % 5 == 0)
                        {
                            level++;
                            speed -= 100;
                        }

                        target = GenerateRandomTarget('$', ConsoleColor.DarkGreen);
                        nodes.Add(new ConsoleNode(nodes[nodeCount - 1].X, nodes[nodeCount - 1].Y, '0', ConsoleColor.DarkYellow));
                    }

                    if (!gameField.IsOnField(nodes[0].X, nodes[0].Y) || IsHeadOnTail())
                    {
                        lives--;
                        GameTextInfo("Игра закончена :(");
                        Console.Beep(2000, 700);
                        gOver = true;
                        break;
                    }

                    if (winCounts == (gameField.Height * gameField.Width) - 3)
                    {
                        GameTextInfo("Вы выиграли !!! :)");
                        gOver = true;
                        break;
                    }

                    //if (lives == 0)
                    //{
                    //  GameTextInfo("Игра закончена :(");
                    //  gOver = true;
                    //  Console.ReadKey();

                    //}
                    drawer.DrawGameNode(target);
                    drawer.DrawListAndScore(nodes, gameField, 2, winCounts, level, lives);
                    Thread.Sleep(speed);
                }
            }
            while (gOver != true);
            Console.ReadKey();
        }

        private void MoveTailOfSnake(List<ConsoleNode> nodes)
        {
            for (int i = nodes.Count-1; i >= 1; i--)
            {
                nodes[i].X = nodes[i - 1].X;
                nodes[i].Y = nodes[i - 1].Y;
            }
        }

        private void CreateInitialSnake(ConsoleNode node)
        {
            bool check = false;
            while (!check)
            {
                RandomPlacement(nodes);
                if (gameField.IsOnField(nodes[0].X, nodes[0].Y + 1) && gameField.IsOnField(nodes[0].X, nodes[0].Y + 2))
                {
                    nodes.Add(new ConsoleNode(nodes[0].X, nodes[0].Y + 1, '0', ConsoleColor.DarkYellow));
                    nodes.Add(new ConsoleNode(nodes[0].X, nodes[0].Y + 2, '0', ConsoleColor.DarkYellow));
                    check = true;
                }
            }
        }
        
        public void GameTextInfo(string textInfo)
        {
            Console.SetCursorPosition(gameField.StartFieldX - 1, gameField.StartFieldY + gameField.Height + 3);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(textInfo);
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

            return new ConsoleNode(randomX, randomY, (char)01,
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


        private bool IsHeadOnTarget(ConsoleNode node)
        {
            if (node.X == target.X && node.Y == target.Y)
                return true;
            return false;
        }

        private bool IsHeadOnTail()
        {
            for (int i=1; i < nodes.Count; i++)
            if (nodes[0].X == nodes[i].X && nodes[0].Y == nodes[i].Y)
                return true;
            return false;
        }


        private void RandomPlacement(List<ConsoleNode> nodes)
        {
            int x = 0;
            int y = 0;

            foreach (var node in nodes)
            {
                do
                {
                    x = rnd.Next(gameField.StartFieldX, gameField.Width + gameField.StartFieldX);
                    y = rnd.Next(gameField.StartFieldY, gameField.Height + gameField.StartFieldY);

                } while (!IsPositionFree(x, y));
                node.x = x;
                node.y = y;

            }
        }

        private Position CheckPosition(int x, int y)
        {
            if (!IsPositionFree(x, y))
                return Position.Node;
            if (!gameField.IsOnField(x, y))
                return Position.Border;
            return Position.Free;
        }


        private void MoveNodeLeft(object sender, EventArgs e)
        {
            if (nodes[0].move != Direction.Right)
            nodes[0].move = Direction.Left;
        }

        private void MoveNodeRight(object sender, EventArgs e)
        {
            if (nodes[0].move != Direction.Left)
                nodes[0].move = Direction.Right;
        }

        private void MoveNodeUp(object sender, EventArgs e)
        {
            if (nodes[0].move != Direction.Down)
                nodes[0].move = Direction.Up;
        }

        private void MoveNodeDown(object sender, EventArgs e)
        {
            if (nodes[0].move != Direction.Up)
                nodes[0].move = Direction.Down;
        }

        public void Pause(object sender, EventArgs e)
        {
            drawer.DrawNodeList(nodes);
            drawer.DrawGameNode(target);
            GameTextInfo("Пауза");
            ConsoleKeyInfo pauseKey;
            do
            {
                pauseKey = Console.ReadKey(true);
            }
            while (pauseKey.Key != ConsoleKey.Spacebar);
            GameTextInfo("     ");
        }
    }

    public enum Position
    {
        Node,
        Border,
        Free
    }
}