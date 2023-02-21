using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezon2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            int monthNumber = Int32.Parse(Console.ReadLine());

            if (monthNumber >= 3 && monthNumber <= 5)
                Console.WriteLine("Весна");
            else if (monthNumber >= 6 && monthNumber <= 8)
                Console.WriteLine("Лето");
            else if (monthNumber >= 9 && monthNumber <= 11)
                Console.WriteLine("Осень");
            else if (monthNumber == 12 || monthNumber == 1 || monthNumber == 2)
            //можно так ?
            //else if (monthNumber == 12 || monthNumber >= 1 && monthNumber <= 2)
                Console.WriteLine("Зима");
            Console.ReadLine();
        }
    }
}
