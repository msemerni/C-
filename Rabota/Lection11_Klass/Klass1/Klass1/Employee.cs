using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass1
{
    class Employee
    {

        public string firstName;
        public string lastName;
        public int salary;

        public void PrintInfo()
        {
            Console.WriteLine("Зарплата {0} {1}: {2}", firstName, lastName, salary);
        }

}
}
