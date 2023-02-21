using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            //Комментарий 1
            //Комментарий 2

            a = 1;
            b = a+1;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine();

            //b = a++;

            a = 1;
            b = a++;
            //b = a;
            //a=a+1;
            Console.WriteLine("a=" +a);
            Console.WriteLine("b="+b);
            Console.WriteLine();

            //b = ++a;
            a = 1;
            b = ++a;
            //a = a + 1;
            //b = a;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);


            Console.ReadLine();
        }
    }
}
