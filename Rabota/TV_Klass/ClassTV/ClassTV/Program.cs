using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTV
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise;
            TV tv = new TV();
            do
            {
                Console.WriteLine("N-next, P-previous, S-show");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "n":
                        tv.SwitchChannelUp();
                        break;
                    case "p":
                        tv.SwitchChannelDown();
                        break;
                    case "s":
                        tv.ShowCurrentChannel();
                        break;
                    default:
                        Console.WriteLine("Invalid enter");
                        break;
                }
            }
            while (choise == "n" || choise == "p" || choise == "s");

        }
    }
}
