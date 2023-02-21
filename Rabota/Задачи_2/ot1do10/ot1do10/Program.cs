using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ot1do10
{
    class Program
    {
        static void Main(string[] args)
        {

            int chislo;
            Console.WriteLine("Введите число от 1 до 10");

            do
            {
                //while (true);

                chislo = Int32.Parse(Console.ReadLine());

                if (chislo >= 1 && chislo <= 10)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("От 1 до 10 !!!");
            }
            while (true);

        }
    }
}
