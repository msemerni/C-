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


    }


    ////можно так записать короче:

    ////public int x { get; private set; }
    ////public int y { get; private set; }
    ////public GameNode(int X, int Y)
    ////{
    ////    x = X;
    ////    y = Y;
    ////}

    ////public void MoveUp()
    ////{
    ////    Y--;
    ////}
    ////.......
    ///////////////////////////////////////
}