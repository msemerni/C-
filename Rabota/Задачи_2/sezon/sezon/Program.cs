using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            int monthNumber = Int32.Parse(Console.ReadLine());
            //while (monthNumber >=1 && monthNumber <= 12)
            //if (monthNumber>=1 && monthNumber <= 12)
                switch (monthNumber)
                {
                    case 1:
                        Console.WriteLine("Winter");
                        break;
                    case 2:
                        Console.WriteLine("Winter");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Spring");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Summer");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Autumn");
                        break;
                    case 12:
                        Console.WriteLine("Winter");
                        break;
                    default:
                    Console.WriteLine("Введите номер месяца от 1 до 12");
                        break;
                }
            Console.ReadKey();

        }
    }
}




