using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageSnack
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem[] menu = new MenuItem[7];
            menu[0] = new Beverage(2.00, 3.00, 4.00, "Espresso");
            menu[1] = new Beverage(2.99, 3.99, 4.99, "Capuccino");
            menu[2] = new Beverage(1.25, 2.25, 3.25, "House coffe");
            menu[3] = new Beverage(2.00, 3.00, 4.00, "Iced coffe");
            menu[4] = new Snack(1.50, "Muffin");
            menu[5] = new Snack(1.95, "Bagel");
            menu[6] = new Snack(2.95, "Croissant");

            foreach (var eda in menu)
            {
                eda.PrintToConsole();
            }

            Console.WriteLine();

            //////// или так:
            List<MenuItem> menues = new List<MenuItem>();
            menues.Add(new Beverage(2.00, 3.00, 4.00, "Espresso"));
            menues.Add(new Beverage(2.99, 3.99, 4.99, "Capuccino"));
            menues.Add(new Beverage(1.25, 2.25, 3.25, "House coffe"));
            menues.Add(new Beverage(2.00, 3.00, 4.00, "Iced coffe"));
            menues.Add(new Snack(1.50, "Muffin"));
            menues.Add(new Snack(1.95, "Bagel"));
            menues.Add(new Snack(2.95, "Croissant"));

            foreach (var eda in menues)
            {
                eda.PrintToConsole();
            }

            Console.ReadKey();
        }
    }
}
