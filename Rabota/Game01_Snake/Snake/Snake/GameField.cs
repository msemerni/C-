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
            if ((x >= StartFieldX) && (x < StartFieldX + Width) &&
                (y >= StartFieldY) && (y < StartFieldY + Height))
                return true;
            else
                return false;
        }

        public void GameOver(string gameOver)
        {
            Console.SetCursorPosition(StartFieldX + 1, StartFieldY + 1);
            Console.WriteLine(gameOver);
        }


    }
}
