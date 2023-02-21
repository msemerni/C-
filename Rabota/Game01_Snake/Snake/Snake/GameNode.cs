using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game01
{
    class GameNode
    {
        public int x;
        public int y;
        private Random rnd;


        public GameNode(int X, int Y)
        {
            x = X;
            y = Y;
            rnd = new Random();

        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public void MoveUp()
        {
            Y--;
        }

        public void MoveDown()
        {
            Y++;
        }

        public void MoveLeft()
        {
            X--;
        }

        public void MoveRight()
        {
            X++;
        }

        public bool IsOnPossition(int positionX, int positionY)
        {
            if (x == positionX && y == positionY)
                return true;
            else
                return false;
        }

        //public virtual void Move(Func<int, int, Position> positionStatus)
        //{
        //    int randomMove = rnd.Next(1, 5);
        //    switch (randomMove)
        //    {
        //        case 1:
        //            {
        //                if (positionStatus(x, y - 1) == Position.Free)
        //                    MoveUp();
        //            }
        //            break;

        //        case 2:
        //            {
        //                if (positionStatus(x, y + 1) == Position.Free)
        //                    MoveDown();
        //            }
        //            break;

        //        case 3:
        //            {
        //                if (positionStatus(x - 1, y) == Position.Free)
        //                    MoveLeft();
        //            }
        //            break;

        //        case 4:
        //            {
        //                if (positionStatus(x + 1, y) == Position.Free)
        //                    MoveRight();
        //            }
        //            break;
        //    }
        //}
    }


    class ConsoleNode : GameNode
    {
        public char NodeSymbol { get; private set; }
        public ConsoleColor NodeColor { get; private set; }
        public Direction move = Direction.MoveStart;


        public ConsoleNode(int X, int Y, char nodeSymbol, ConsoleColor nodeColor) : base(X, Y)
        {
            NodeSymbol = nodeSymbol;
            NodeColor = nodeColor;
        }

        public void Move(Func<int, int, Position> position)
        {
            if (move == Direction.Left)
            {
                MoveLeft();
            }
            if (move == Direction.Right)
            {
                MoveRight();
            }
            if (move == Direction.Up)
            {
                MoveUp();
            }
            if (move == Direction.Down)
            {
                MoveDown();
            }
        }


    }

    enum Direction
    {
        MoveStart,
        Up,
        Down,
        Left,
        Right
    }

}