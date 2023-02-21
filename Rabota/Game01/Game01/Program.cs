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
            int startPositionX = 5;
            int startPositionY = 5;
            int width = 5;
            int height = 3;
            int nodesCount = 7;

            TitleAndLoader titleAndLoader = new TitleAndLoader();
            GameField gameField = new GameField(height, width, startPositionX + 1, startPositionY + 1);

            //InputHandler ih = new InputHandler();
            //GameLogic logic = new GameLogic(gameField, new Drawer(), nodesCount, ih);

            GameLogic logic = new GameLogic(gameField, new Drawer(), nodesCount);

            //titleAndLoader.DrawTitle();
            //titleAndLoader.DrawLoader();
            logic.StartGame();
        }
    }
}

