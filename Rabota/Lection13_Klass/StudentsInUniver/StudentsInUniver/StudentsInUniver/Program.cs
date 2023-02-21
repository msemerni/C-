using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInUniver
{
    class Program
    {
        static void Main(string[] args)
        {
            Students firstPerson = new Students();
            firstPerson.firstName = "Саша";
            firstPerson.lastName = "Иванов";
            //firstPerson.dateOfBirth = new DateTime(1982, 12, 2);
            firstPerson.marks[0] = 85;
            firstPerson.marks[1] = 95;
            firstPerson.marks[2] = 95;
            firstPerson.marks[3] = 95;
            firstPerson.marks[4] = 95;

            int[] marks = new int[5] { 85, 95, 78, 96, 25 };

            //firstPerson.marks = { 85, 95, 78, 96, 25 };

            firstPerson.Introduce();

            Students[] personArray = new Students[3];
            personArray[0] = firstPerson;
            //personArray[1] = secondPerson;
            //personArray[2] = thirdPerson;


            Console.ReadKey();

        }
    }
}
