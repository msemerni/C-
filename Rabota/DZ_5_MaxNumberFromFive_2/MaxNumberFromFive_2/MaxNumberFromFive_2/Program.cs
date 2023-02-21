using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberFromFive_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 5 чисел.Найти max из введенных чисел

            Console.Title = "Нахождение максимального числа из 5-ти введённых";
            Console.WriteLine("Нахождение максимального числа из 5-ти введённых.\n");
            Console.WriteLine("Введите 5 целых чисел:");


            //Первый вариант:
            //int number = Int32.Parse(Console.ReadLine());
            //int max = number;
            //for (int i = 0; i < 4; i++)
            //{
            //    number = Int32.Parse(Console.ReadLine());
            //    if (max < number)
            //        max = number;
            //}

            //Второй вариант:
            //int max = Int32.MinValue;
            //int number;
            //for (int i = 0; i < 5; i++)
            //{
            //    number = Int32.Parse(Console.ReadLine());
            //    if (max < number)
            //        max = number;
            //}

            //Третий вариант:
            int max = Int32.MinValue; ;
            for (int i = 0; i < 5; i++)
            {
                int number = Int32.Parse(Console.ReadLine());
                if (max < number)
                    max = number;
            }

            Console.WriteLine("\nМаксимальное число: " + max);
            Console.ReadKey();

        }
    }
}

   