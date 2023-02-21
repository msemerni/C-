using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_120217
{
    abstract class Employee
    {
        private string name;

        public Employee(string name)
        {
            Name = name;
        }

        //public string Name { get; private set; }

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                name = value;
            }
        }

        public abstract void CalculateSalary();
    }
}
