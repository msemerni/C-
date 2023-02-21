using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Расчёт недель из дней";
            Console.WriteLine("Введите количество дней");
            int number = Int32.Parse(Console.ReadLine());
            int nedeli = number / 7;
            int dni = number % 7;
            Console.WriteLine("Получается {0} недель и {1} дней", nedeli, dni);
            //Console.WriteLine("Получается " + nedeli +" недель и " + dni +" дней");

            //или так:
            //Console.WriteLine("Введите количество дней");
            ////В чём разница Parse and Convert ???
            //int а = Int32.Parse(Console.ReadLine());
            ////int a = Convert.ToInt32(Console.ReadLine());
            //int b;
            //a = a / 7;
            //b = a % 7;
            //Console.WriteLine("Получается {0} недель и {1} дней", a, b);
            //
            Console.ReadKey();

        }
    }
}
