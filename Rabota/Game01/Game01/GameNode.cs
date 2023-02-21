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

        public GameNode(int X, int Y)
        {
            x = X;
            y = Y;
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

    }

    class ConsoleNode : GameNode
    {
        public char NodeSymbol { get; private set; }
        public ConsoleColor NodeColor { get; private set; }

        public ConsoleNode(int X, int Y, char nodeSymbol, ConsoleColor nodeColor) : base(X, Y)
        {
            NodeSymbol = nodeSymbol;
            NodeColor = nodeColor;
        }
    }

}