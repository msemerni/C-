using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosNegZeroNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //С клавиатуры вводятся n чисел.Составьте программу, которая определяет кол-во 
            //отрицательных, кол - во положительных и кол - во нулей
            Console.Title = "Определение количества положительных чисел, количества отрицательных чисел и нулей";
            Console.WriteLine("Определение количества положительных чисел, количества отрицательных чисел и нулей");

            int countPos = 0;
            int countNeg = 0;
            int countZero = 0;

            Console.Write("Введите количество чисел: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите числа:");
            for (int i=0; i < n; i++)
            {
                int chislo = Int32.Parse(Console.ReadLine());

                if (chislo > 0)
                    countPos = countPos + 1;
                else if (chislo < 0)
                    countNeg = countNeg + 1;
                else
                    countZero = countZero + 1;
            }
            Console.WriteLine("\nВсего чисел: {0}", n);
            Console.WriteLine("\nПоложительных чисел: {0}, отрицательных: {1}, нулей: {2}", countPos, countNeg, countZero);

            Console.ReadKey();

            //Можно так:
            //int countPositive = 0;
            //int countNegative = 0;
            //int countZero = 0;
            //Console.WriteLine("Введите количество чисел");
            //int numberOfDigites = Int32.Parse(Console.ReadLine());
            //int number;
            //Console.WriteLine("Введите числа");
            //for (; numberOfDigites > 0; numberOfDigites--)
            //{
            //    number = Int32.Parse(Console.ReadLine());
            //    if (number > 0)
            //    {
            //        countPositive++;
            //    }
            //    else if (number < 0)
            //    {
            //        countNegative++;
            //    }
            //    else
            //    {
            //        countZero++;
            //    }

            }
        }
    }
