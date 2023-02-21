using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Введите число. Результат будет на 5 больше");
            string str = Console.ReadLine();
            //int number = Int32.Parse(str); 
            //или можно так:
            int number = Convert.ToInt32(str);
            number += 5;
            Console.WriteLine("Результат = " + number);
            Console.WriteLine("Спасибо :)");

            Console.WriteLine("Error!");
            Console.ReadLine();
        }
     
    }
}
