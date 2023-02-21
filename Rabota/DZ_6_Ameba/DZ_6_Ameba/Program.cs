using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_Ameba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 6.
            //Одноклеточная амеба каждые 3 часа делится на 2 клетки. 
            //Определить, сколько амеб будет через 3, 6, 9, 12,..., 24 часа.
            {
                Console.WriteLine("\nРасчёт количества амёб:\n");
                int ameba = 1;
                //int - считает до 90 часов
                //ulong - считает до 189 часов
                for (int hour = 3; hour <= 24; hour += 3)
                {
                    ameba *= 2;
                    Console.WriteLine("Через\t {0} ч.\t амёб будет\t {1}\n", hour, ameba);
                }
                Console.ReadKey();
            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            //Console.WriteLine("\nРасчёт количества амёб:\n");
            //int ameba = 1;
            //int hour = 0;
            //while (hour <= 24)
            //{
            //    Console.WriteLine("Через {0} ч. амёб будет {1}", hour, ameba);
            //    hour += 3;
            //    ameba *= 2;
            //}
            //Console.ReadKey();


            //////////////////////////////////////////////////////////////////////////////////////////////

            //Console.WriteLine("\nРасчёт количества амёб:\n");
            //Console.WriteLine();
            //int ameba = 1;
            //int hour = 0;

            //do
            //{
            //    hour += 3;
            //    ameba *= 2;
            //    Console.WriteLine("Через {0} ч. амёб будет {1}", hour, ameba);
            //}
            //while (hour <= 24);

            //Console.ReadKey();


            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Console.WriteLine("Введите количество часов:");
            //int hour = Int32.Parse(Console.ReadLine());
            //int ameba = 1;
            //int h = 0;

            //for (h = 0; h <= 24; h++)
            //{
            //    ameba = ameba * 2;
            //    h = h + 3;
            //    Console.WriteLine("Через {0} часов будет {1} амёб", h, ameba);
            //}

            //Console.ReadKey();





        }
    }
}
