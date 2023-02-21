using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_120217
{
    class HourlyWorker : Employee
    {
        private double rate;
        private double hours;

        public HourlyWorker(string name, double rate, double hours) : base (name)
        {
            Rate = rate;
            Hours = hours;
        }

        //public double Rate { get; private set; }
        //public double Hours { get; private set; }

        public double Rate
        {
            get
            {
                return rate;
            }

            private set
            {
                rate = value;
            }
        }

        public double Hours
        {
            get
            {
                return hours;
            }

            private set
            {
                hours = value;
            }
        }

        public override void CalculateSalary()
        {
            Console.WriteLine("{0} - сумма выплаты: {1:0.00} грн.", Name, rate * hours);
        }
    }
}
