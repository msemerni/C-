using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_09042017
{
    class Program
    {
        static void Main(string[] args)
        {
            ////string[] strArray = new string[12]
            ////string a = "Январь";

            //List<string> month = new List<string>
            //{   "Январь",
            //    "Февраль",
            //    "Март",
            //    "Апрель",
            //    "Май",
            //    "Июнь",
            //    "Июль",
            //    "Август",
            //    "Сентябрь",
            //    "Октябрь",
            //    "Ноябрь",
            //    "Декабрь"
            //};
            //month.Sort();
            //month.IndexOf("Ноябрь");

            //foreach (string list in month)
            //{
            //    Console.WriteLine(list);
            //}

            //Console.WriteLine (month.IndexOf("Ноябрь"));
            //Console.ReadLine();
            Car[] carArray = new Car[9];

            carArray[0] = new Car("Mercedes", "S600", 10000, "Blue", 1990);
            carArray[1] = new Car("Audi", "A3", 20000, "Red", 1992);
            carArray[2] = new Car("Renault", "Duster", 5000, "Black", 1998);
            carArray[3] = new Car("BMW", "X5", 40000, "Black", 2000);
            carArray[4] = new Car("BMW", "X6", 45000, "Red", 2003);
            carArray[5] = new Car("Audi", "A3", 35000, "Silver", 1998);
            carArray[6] = new Car("BMW", "I3", 33000, "White", 2003);
            carArray[7] = new Car("Mazda", "6", 22000, "White", 2004);
            carArray[8] = new Car("Mazda", "3", 24000, "Blue", 2004);


            Car[] priceOver30K = Array.FindAll(carArray, x => x.cost > 30000);
            foreach (var car in priceOver30K)
            {
                Console.WriteLine(car.ToString());
            }
            Console.WriteLine("-----------------");

            Car[] onlyBMWandMercedes = Array.FindAll(carArray, x => ((x.brand == "BMW") || (x.brand == "Audi")));
            foreach (var car in onlyBMWandMercedes)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine("-----------------");

            Console.ReadKey();
        }
    }
}
