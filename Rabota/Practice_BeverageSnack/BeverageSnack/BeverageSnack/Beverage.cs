using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageSnack
{
    class Beverage : MenuItem
    {
        private double small;
        private double medium;
        private double large;

        public Beverage(double small, double medium, double large, string name) : base(name)
        {
            smallBeveragePrice = small;
            mediumBeveragePrice = medium;
            largeBeveragePrice = large;
        }

        public double smallBeveragePrice
        {
            get
            {
                return small;
            }
            private set
            {
                small = value;
            }
        }

        public double mediumBeveragePrice
        {
            get
            {
                return medium;
            }
            private set
            {
                medium = value;
            }
        }
        
        public double largeBeveragePrice
        {
            get
            {
                return large;
            }
            private set
            {
                large = value;
            }
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("{0} - Small: ${1:0.00}; Medium: ${2:0.00}; Large - ${3:0.00}.", Name, small, medium, large);
        }

    }
}
