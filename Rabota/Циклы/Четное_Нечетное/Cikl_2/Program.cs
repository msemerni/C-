using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Почему нельзя    char ch = 'N'; ????????????????????
            // Потому что не получается. но как-то можно. в общем пользоваться String надо всегда
            string ch = "N";
            do
            {
                Console.Clear();
                Console.WriteLine("Введите число:");
                int number = Int32.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Четное число");
                }
                else
                {
                    Console.WriteLine("Нечетное");
                }
                Console.WriteLine("Желаете продолжить? Y/N");
                ch = Console.ReadLine();

            }
            while (ch == "Y");
            Console.WriteLine("Спасибо за работу!");


        }
    }
}
