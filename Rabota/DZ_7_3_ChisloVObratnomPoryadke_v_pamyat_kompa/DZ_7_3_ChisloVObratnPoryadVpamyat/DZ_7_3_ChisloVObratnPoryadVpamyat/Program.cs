using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_7_3_ChisloVObratnPoryadVpamyat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Преобразовать его в другое число, 
            //цифры которого будут следовать в обратном порядке.
            //Вывод числа  в память компа, не только на экран (как было в ChisloVObratnomPoryadke)

            Console.Title = "Преобразование числа в обратном порядке.\n";

                Console.WriteLine("Преобразование числа в обратном порядке.\n");
                Console.Write("Введите целое число:\t");

            int number = Int32.Parse(Console.ReadLine());
            int reversNumber=0;


            do
            {
                reversNumber *= 10;
                reversNumber += (number % 10);

                number /= 10;
            }
            while (number != 0);


            ////или так:
            //while (number != 0)
            //{
            //        reversNumber = reversNumber * 10;
            //        reversNumber = reversNumber + (number % 10);

            //        number = number / 10;
            //}


            ////Как сделать, чтобы выводились ноли до и после в результате?????
            Console.WriteLine("\nРезультат:\t\t{0}", reversNumber);

            
            Console.ReadKey();
        }
    }
}


////////Console.WriteLine("\nРезультат:\t\t{0}", Convert.ToString(reversNumber));
////////Console.WriteLine("\nРезультат:\t\t{0:00000000000000}", reversNumber);
////////Console.WriteLine(string.Format("{0:D200}", 000001));