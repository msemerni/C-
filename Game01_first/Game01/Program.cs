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
            Console.CursorVisible = false;

            TitleAndLoader titleAndLoader = new TitleAndLoader();
            GameLogic gameLogic = new GameLogic();

            titleAndLoader.DrawTitle();

            titleAndLoader.DrawLoader();


            gameLogic.StartGame();

        }
    }
}

