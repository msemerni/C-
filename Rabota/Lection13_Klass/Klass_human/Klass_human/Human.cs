using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass_human
{
    class Human
    {
        public string firstName;
        public string lastName;
        public string age;

        public void Introduce()
        {
            Console.WriteLine("Привет, меня зовут {0} {1}. Возраст: {2}", firstName, lastName, age);
        }

    }
}
