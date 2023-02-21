using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Oboi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Расчет обоев";
            Console.WriteLine("Введите ширину комнаты");
            double rw = Double.Parse(Console.ReadLine());

            //int b;
            //str22 = Console.ReadLine();
            //b = Int32.Parse(str22);

            Console.WriteLine("Введите длину комнаты");
            double rl = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту комнаты");
            double rh = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину рулона");
            double ol = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину рулона");
            double ow = Double.Parse(Console.ReadLine());

            //Расчёт обоев с остатками

            int kolpol = (int)(ol / rh);

            double rulw = kolpol * ow;

            double perim = 2 * (rl + rw);

            //Расчёт обоев без остатков

            Console.WriteLine();
            Console.WriteLine("Количество рулонов (с остатками):" + Math.Ceiling(perim / rulw));

            Console.WriteLine();
            Console.WriteLine("Количество рулонов (без остатков):" + Math.Ceiling((perim * rh) / (ol * ow)));

            Console.ReadLine();
        }
    }
}
