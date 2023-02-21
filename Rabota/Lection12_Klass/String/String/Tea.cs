using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Tea
    {
        public string teaName;
        public string teaCountryName;
        public double teaPrice;

        public void AddTeaInfo()
        {
            Console.WriteLine("Введитете название чая: ");
            teaName = Console.ReadLine();
            Console.WriteLine("Введите страну производства: ");
            teaCountryName = Console.ReadLine();
            Console.WriteLine("Введите цену за 100 гр.: ");
            teaPrice = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintInfo()
        {
            Console.WriteLine("Чай {0}, страна производитель {1}, цена за 100 гр.: {2:#.00} грн.", teaName, teaCountryName, teaPrice);
        }

    }
}
