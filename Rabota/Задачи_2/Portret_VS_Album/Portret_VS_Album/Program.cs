using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portret_VS_Album
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину фотографии");
            double shir = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту фотографии");
            double vis = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (shir > vis)
                Console.WriteLine("Album");
            else if (shir < vis)
                Console.WriteLine("Portrait");
            else
                Console.WriteLine("Kvadrat");

            Console.ReadLine();

        }
    }
}
