using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_MaxNumberFromFive
{
    class Program
    {
        static void Main(string[] args)
        {

            //Пользователь вводит 5 чисел.Найти max из введенных чисел

            Console.Title = "Нахождение максимального числа из 5-ти введённых";
            Console.WriteLine("Нахождение максимального числа из 5-ти введённых.\n");
            Console.WriteLine("Введите 5 целых чисел:");

            int max = Int32.MinValue;
            int number;

            //Первый вариант:
            for (int i = 0; i < 5; i++)
            {
                number = Int32.Parse(Console.ReadLine());
                if (max < number)
                    max = number;
            }
            Console.WriteLine("\nМаксимальное число: " + max);
            Console.ReadKey();


            ////Второй вариант:// Что-то не так
            //number = Int32.Parse(Console.ReadLine());
            //if (max == number)
            //{
            //    max = number;
            //}
            //else if (max < number)
            //{
            //    max = number;
            //}
            //else
            //{
            //    continue;
            //}
            //Console.WriteLine("\nМаксимальное число: " + max);
            //Console.ReadKey();


            //// Макса вариант:
            //bool isFirstIteration = true;

            //for (int i = 0; i < 5; i++)
            //{
            //    number = Int32.Parse(Console.ReadLine());
            //    if (isFirstIteration == true)
            //    {
            //        max = number;
            //        isFirstIteration = false;
            //    }
            //    else if (number > max)
            //    {
            //        max = number;
            //    }
            //}
            //Console.WriteLine("\nМаксимальное число: " + max);
            //Console.ReadKey();




        }
    }
}

