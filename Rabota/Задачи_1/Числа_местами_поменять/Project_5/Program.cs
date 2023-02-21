using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Числа местами";
            string str1, str2, str3;

            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            str3 = str1;
            str1 = str2;
            str2 = str3;
            //так
            Console.WriteLine("{0} and {1}", str1, str2);
            //или так:
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.ReadKey();
                   

        }
    }
}
