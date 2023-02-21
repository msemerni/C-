using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Расчёт факториала";

            int result=1;
            Console.Write("Введите число: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number < 0)
                Console.Write("Введите положительное число!");
            else
            {
                int number1 = number;
                for (; number > 0; number--)
                {
                    result = number * result;
                }
                Console.WriteLine("Факториал числа {0} равен: {1}", number1, result);
            }
            Console.ReadLine();
        }




        //{
        //    int j = 0;
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 3 == 0)
        //            j++;
        //    }
        //    Console.WriteLine(j);
        //    Console.ReadLine();
        //}



        
    }
}
