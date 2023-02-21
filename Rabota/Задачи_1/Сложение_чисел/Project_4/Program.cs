using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c; //можно не указывать чтобы не заполнять память
            Console.Title="Сложение чисел";
            Console.WriteLine("Введите число 1");
            string str22 = Console.ReadLine();
            a = Int32.Parse(str22);
            Console.WriteLine("Введите число 2");
            str22 = Console.ReadLine();
            b = Int32.Parse(str22);

            //c = a + b; "c" можно не указывать чтобы не заполнять память

            Console.WriteLine("Сумма="+(a+b));
            Console.ReadLine();

        }
    }
}
