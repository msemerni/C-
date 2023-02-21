using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Game01
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPositionX = 10;
            int startPositionY = 5;
            int width = 10;
            int height = 10;
            int nodeCount = 1;
            int lives = 3;
            int level = 1;
            int speed = 1000;

            TitleAndLoader titleAndLoader = new TitleAndLoader();
            GameField gameField = new GameField(height, width, startPositionX + 1, startPositionY + 1);

            InputHandler ih = new InputHandler();
            GameLogic logic = new GameLogic(gameField, new Drawer(), nodeCount, ih, lives, level, speed);

            //titleAndLoader.DrawTitle();
            //titleAndLoader.DrawLoader();
            logic.StartGame();
            Console.ReadKey();
        }
    }
}

