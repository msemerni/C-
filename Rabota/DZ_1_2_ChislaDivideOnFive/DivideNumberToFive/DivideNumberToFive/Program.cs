using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideNumberToFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывести все двухзначные числа от 0 до 100 кратные 5
            Console.Title = "Вывод всех чисел от 1 до 100, кратных заданному числу";
            Console.WriteLine("Вывод всех чисел от 1 до 100, кратных заданному числу\n");
            Console.Write("Введите делитель: ");

            int delitel = Convert.ToInt32(Console.ReadLine());
            int i;

            Console.WriteLine("Числа от 1 до 100, кратные {0}: ", delitel);
            for (i = 1; i <= 100; i++)
            {
                if (i % delitel == 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
