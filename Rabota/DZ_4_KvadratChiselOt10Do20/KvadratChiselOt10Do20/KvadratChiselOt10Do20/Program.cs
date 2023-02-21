using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratChiselOt10Do20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Составьте программу, выводящую на экран квадраты чисел от 10 до 20 включительно.
            //Console.Title = "Квадраты чисел от 10 до 20 включительно";
            //Console.WriteLine("Квадраты чисел от 10 до 20 включительно:\n");

            ////Первый вариант:
            for (int i = 10; i <= 20; i++)
                Console.WriteLine("Квадрат числа {0} равен {1} ", i, i * i);

                Console.ReadKey();

            //Второй вариант:
            //int i = 10;
            //do
            //{
            //    int j = i * i;
            //    Console.WriteLine("Квадрат числа {0} равен {1}", i, j);
            //    i++;
            //}
            //while (i <= 20);
            //Console.ReadKey();

            ////Третий вариант:
            //int j;
            //for (int i = 10; i <= 20; i++)
            //{
            //    j = i * i;
            //    Console.WriteLine("Квадрат числа {0} равен {1} ", i, j);
            //}
            //Console.ReadKey();

        }
    }
}
