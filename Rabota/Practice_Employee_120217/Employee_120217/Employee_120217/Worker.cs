using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_120217
{
    class Worker : Employee
    {
        private double yearSalary;

        public Worker(string name, double yearSalary) : base (name)
        {
            YearSalary = yearSalary;
        }
        
        //public double YearSalary { get; private set; }

        public double YearSalary
        {
            get
            {
                return yearSalary;
            }

            private set
            {
                yearSalary = value;
            }
        }

        public override void CalculateSalary()
        {
            Console.WriteLine("{0} - зарплата: {1:0.00} грн./мес", Name, yearSalary / 12);
        }

    }
}
