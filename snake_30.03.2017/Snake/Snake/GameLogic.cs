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

            rnd = new Random();
            nodes = new List<ConsoleNode>();
            target = GenerateRandomTarget('$', ConsoleColor.DarkGreen);
        }

        public void StartGame()
        {
            TitleAndLoader gameOver = new TitleAndLoader();
            nodes = new List<ConsoleNode>() { new ConsoleNode(0, 0, 'o', ConsoleColor.DarkYellow) };
            //RandomPlacement(nodes);
            CreateInitialSnake(nodes[0]);
            //InitializeSnake();

            //nodes.Add(new ConsoleNode(nodes[0].X, nodes[0].Y + 1, 'o', ConsoleColor.DarkYellow));
            bool gOver = false;

            while (gOver != true)
            {

                for (;;)
                {
                    
                    drawer.DrawGameFieldFrame(gameField, ConsoleColor.DarkBlue, ConsoleColor.Black, '#');
                    drawer.DrawListAndScore(nodes, gameField, 2, winCounts, level, lives);
                    drawer.DrawNodeList(nodes);
                    drawer.DrawGameNode(target);
                    _ih.QueryKB();
                    nodes[0].Move(CheckPosition);
                    MoveTailOfSnake(nodes);

                    if (IsNodeOnTarget(nodes[0]))
                    {
                        winCounts++;
                        nodeCount++;
                        target = GenerateRandomTarget('$', ConsoleColor.DarkGreen);
                        nodes.Add(new ConsoleNode(nodes[nodeCount-1].X, nodes[nodeCount-1].Y, 'o', ConsoleColor.DarkYellow));

                        if (winCounts % 5 == 0)
                        {
                            level ++;
                            speed -= 100;
                        }
                        //break;
                    }

                    if (!gameField.IsOnField(nodes[0].X, nodes[0].Y))
                    {
                        GameOver("Игра закончена :(");
                        gOver = true;
                        break;
                    }

                    if (winCounts == (gameField.Height * gameField.Width) - 3)
                    {
                        GameOver("Вы выиграли !!! :)");
                        gOver = true;
                        break;
                    }

                    Thread.Sleep(speed);
                }

            }
        }

        //private void MovePlayerNode(ConsoleNode node)
        //{
        //    for (;;)
        //    {
        //        _ih.QueryKB();
        //        node.Move(CheckPosition);
        //        drawer.DrawGameNode(node);
        //        //Thread.Sleep(200);
        //    }
        //}

        private void MoveTailOfSnake(List<ConsoleNode> nodes)
        {
            for (int i = nodes.Count-1; i >= 1; i--)
            {
                nodes[i].X = nodes[i - 1].X;
                nodes[i].Y = nodes[i - 1].Y;
            }
        }

        //public void InitializeSnake()
        //{
        //    nodes = new List<ConsoleNode>() 
        //    {
        //    new ConsoleNode(gameField.StartFieldX + 3, gameField.StartFieldY + 5, 'o', ConsoleColor.Red),
        //    new ConsoleNode(gameField.StartFieldX + 3, gameField.StartFieldY + 6, 'o', ConsoleColor.DarkMagenta),
        //    new ConsoleNode(gameField.StartFieldX + 3, gameField.StartFieldY + 7, 'o', ConsoleColor.DarkCyan),
        //    };

        //}


        private void CreateInitialSnake(ConsoleNode node)
        {
            bool check = false;
            while (!check)
            {
                RandomPlacement(nodes);
                if (gameField.IsOnField(nodes[0].X, nodes[0].Y + 1) && gameField.IsOnField(nodes[0].X, nodes[0].Y + 2))
                {
                    nodes.Add(new ConsoleNode(nodes[0].X, nodes[0].Y + 1, 'o', ConsoleColor.DarkYellow));
                    nodes.Add(new ConsoleNode(nodes[0].X, nodes[0].Y + 2, 'o', ConsoleColor.DarkYellow));
                    check = true;
                }
            }
        }


        public void GameOver(string gameOver)
        {
            Console.SetCursorPosition(gameField.StartFieldX, gameField.StartFieldY + gameField.Height + 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(gameOver);
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


        private bool IsNodeOnTarget(ConsoleNode node)
        {
            if (node.X == target.X && node.Y == target.Y)
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
            if (CheckPosition(nodes[0].X - 1, nodes[0].Y) == Position.Free /*&&*/)
                //gameField.IsOnField(nodes[0].X - 1, nodes[0].Y))
                nodes[0].move = Direction.Left;
            //nodes[0].MoveLeft();
        }

        private void MoveNodeRight(object sender, EventArgs e)
        {
            if (CheckPosition(nodes[0].X + 1, nodes[0].Y) == Position.Free /*&&*/)
                //gameField.IsOnField(nodes[0].X + 1, nodes[0].Y))
                nodes[0].move = Direction.Right;
            //nodes[0].MoveRight();
        }

        private void MoveNodeUp(object sender, EventArgs e)
        {
            if (CheckPosition(nodes[0].X, nodes[0].Y - 1) == Position.Free /*&&*/)
                //gameField.IsOnField(nodes[0].X, nodes[0].Y - 1))
                nodes[0].move = Direction.Up;
            //nodes[0].MoveUp();
        }

        private void MoveNodeDown(object sender, EventArgs e)
        {
            if (CheckPosition(nodes[0].X, nodes[0].Y + 1) == Position.Free /*&&*/)
                //gameField.IsOnField(nodes[0].X, nodes[0].Y + 1))
                nodes[0].move = Direction.Down;
            //nodes[0].MoveDown();
        }
    }

    public enum Position
    {
        Node,
        Border,
        Free
    }

}



/////////////////////////////////////////////////////////////
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace Game01
//{
//    class GameLogic
//    {
//        private readonly GameField gameField;
//        private readonly Drawer drawer;
//        private readonly Random rnd;
//        private List<ConsoleNode> nodes;
//        private ConsoleNode target;
//        private int[] winCounts;
//        private int nodeCount;
//        private readonly InputHandler _ih;



//        public GameLogic(GameField gameField, Drawer drawer, int nodeCount, InputHandler ih)
//        {
//            this.gameField = gameField;
//            this.drawer = drawer;
//            this.nodeCount = nodeCount;

//            _ih = ih;
//            _ih.KeyLeft += MoveNodeLeft;
//            _ih.KeyRight += MoveNodeRight;
//            _ih.KeyUp += MoveNodeUp;
//            _ih.KeyDown += MoveNodeDown;


//            rnd = new Random();
//            nodes = new List<ConsoleNode>();
//            target = GenerateRandomTarget('$', ConsoleColor.Green);

//        }


//        public void StartGame()
//        {
//            //bool isGameOver = false;
//            for (int z = 0; z < gameField.Height*gameField.Width; z++)
//            {
//                nodes = new List<ConsoleNode>()
//                {
//                    new ConsoleNode(0,0,(char)1, ConsoleColor.DarkYellow),
//                };

//                if (winCounts == null)
//                    winCounts = new int[nodes.Count];
//                RandomPlacement(nodes);
//                Console.Clear();
//                drawer.DrawListAndScore(nodes, gameField, 2, winCounts);
//                bool isNewRound = false;

//                do
//                {
//                    drawer.DrawGameFieldFrame(gameField, ConsoleColor.DarkBlue, ConsoleColor.Black, '#');
//                    drawer.DrawNodeList(nodes);
//                    drawer.DrawGameNode(target);
//                    //target = GenerateRandomTarget((char)1, ConsoleColor.White);
//                    _ih.QueryKB();
//                    for (int i = 0; i < nodes.Count; i++)
//                    {
//                        if (IsNodeOnTarget(nodes[i]))
//                        {
//                            winCounts[i]++;
//                            isNewRound = true;
//                            target = GenerateRandomTarget('$', ConsoleColor.Green);
//                        }
//                    }
//                    Thread.Sleep(100);
//                }
//                while (!isNewRound);
//            }
//            Console.ReadKey();
//        }


//        private ConsoleNode GenerateRandomNode(int nodeCount)
//        {

//            int randomX = 0;
//            int randomY = 0;
//            do
//            {
//                randomX = rnd.Next(gameField.StartFieldX, gameField.Width + gameField.StartFieldX);
//                randomY = rnd.Next(gameField.StartFieldY, gameField.Height + gameField.StartFieldY);

//            } while (!IsPositionFree(randomX, randomY));

//            return new ConsoleNode(randomX, randomY, (char)(nodeCount + 65),
//                                    (ConsoleColor)rnd.Next(1, 15));
//        }

//        private ConsoleNode GenerateRandomTarget(char symbol, ConsoleColor color)
//        {

//            int randomX = 0;
//            int randomY = 0;
//            do
//            {
//                randomX = rnd.Next(gameField.StartFieldX, gameField.Width + gameField.StartFieldX);
//                randomY = rnd.Next(gameField.StartFieldY, gameField.Height + gameField.StartFieldY);

//            } while (!IsPositionFree(randomX, randomY));

//            return new ConsoleNode(randomX, randomY, symbol, color);
//        }

//        private ConsoleNode GenerateRandomNodes(char symbol, ConsoleColor color)

//        {
//            int randomX = 0;
//            int randomY = 0;
//            for (int i = 0; i < nodeCount; i++)
//            {
//                nodes.Add(GenerateRandomNode(i));
//            }
//            return new ConsoleNode(randomX, randomY, symbol, color);

//        }

//        private bool IsPositionFree(int x, int y)
//        {
//            foreach (var nd in nodes)
//            {
//                if (nd.IsOnPossition(x, y))
//                    return false;
//            }
//            return true;
//        }


//        private bool IsNodeOnTarget(ConsoleNode node)
//        {
//            if (node.X == target.X && node.Y == target.Y)
//                return true;
//            return false;
//        }


//        private void RandomPlacement(List<ConsoleNode> nodes)
//        {
//            int x = 0;
//            int y = 0;

//            foreach (var node in nodes)
//            {
//                do
//                {
//                    x = rnd.Next(gameField.StartFieldX, gameField.Width + gameField.StartFieldX);
//                    y = rnd.Next(gameField.StartFieldY, gameField.Height + gameField.StartFieldY);

//                } while (!IsPositionFree(x,y));
//                node.x = x;
//                node.y = y;

//            }
//        }

//        private void MoveNodeLeft(object sender, EventArgs e)
//        {
//            if (IsPositionFree(nodes[0].X - 1, nodes[0].Y) &&
//                gameField.IsOnField(nodes[0].X - 1, nodes[0].Y))
//                nodes[0].MoveLeft();
//        }

//        private void MoveNodeRight(object sender, EventArgs e)
//        {
//            if (IsPositionFree(nodes[0].X + 1, nodes[0].Y) &&
//                gameField.IsOnField(nodes[0].X + 1, nodes[0].Y))
//                nodes[0].MoveRight();
//        }


//        private void MoveNodeUp(object sender, EventArgs e)
//        {
//            if (IsPositionFree(nodes[0].X, nodes[0].Y - 1) &&
//                gameField.IsOnField(nodes[0].X, nodes[0].Y - 1))
//                nodes[0].MoveUp();
//        }

//        private void MoveNodeDown(object sender, EventArgs e)
//        {
//            if (IsPositionFree(nodes[0].X, nodes[0].Y + 1) &&
//                gameField.IsOnField(nodes[0].X, nodes[0].Y + 1))
//                nodes[0].MoveDown();
//        }
//    }

//    public enum Position
//    {
//        Node,
//        Border,
//        Free
//    }

//}
