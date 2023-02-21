using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageSnack
{
    class Snack : MenuItem
    {
        private double Price;

        public Snack(double snackPrice, string name) : base(name)
        {
            Price = snackPrice;
        }

        public double snackPrice
        {
            get
            {
                return Price;
            }
            private set
            {
                Price = value;
            }
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("{0} - Price: ${1:0.00}.", Name, snackPrice);
        }

    }
}
