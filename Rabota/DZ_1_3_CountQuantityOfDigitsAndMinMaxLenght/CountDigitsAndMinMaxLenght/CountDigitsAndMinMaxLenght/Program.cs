using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDigitsAndMinMaxDigit
{
    class Program
    {
        static void Main(string[] args)
        {


            //   3) Пользователь вводит число.
            //3.1) Определить количество цифр в числе
            //3.2) Найти минимальную и максимальную цифру в числе
            Console.Title = "Определение количества цифр в числе, max и min цифры в числе";
            Console.WriteLine("Определение количества цифр в числе, max и min цифры в числе\n");
            Console.Write("Введите число: ");

            int number = Int32.Parse(Console.ReadLine());
            int count = 1;
            int max = 0;
            int min = 9;
            int mid = 0;
            while (number / 10 > 0)
            {
                mid = number % 10;
                if (max < mid)
                    max = mid;
                if (mid < min)
                    min = mid;
                number /= 10;
                count++;
            }
            if (max < number)
                max = number;
            if (number < min)
                min = number;
            Console.WriteLine("\nКоличество цифр в числе: " +count);
            Console.WriteLine("Максимальная цифра в числе: " +max);
            Console.WriteLine("Минимальная цифра в числе: " +min);

            Console.ReadKey();

        }
    }
}
