using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game01
{
    class GameField
    {
        public int StartFieldX { get; private set; }
        public int StartFieldY { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        public GameField(int height, int width, int startFieldX, int startFieldY)
        {
            Height = height;
            Width = width;
            StartFieldX = startFieldX;
            StartFieldY = startFieldY;
        }

        public bool IsOnField(int x, int y)
        {
            if ((x >= StartFieldX) && (x < Width + StartFieldX) &&
                (y >= StartFieldY) && (y < Height + StartFieldY))
                return true;
            else
                return false;
        }

    }
}
