using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstPerson = new Employee();
            firstPerson.firstName = "Maksim";
            firstPerson.lastName = "Evsukov";
            firstPerson.salary = 200;

            Employee secondPerson = new Employee();
            secondPerson.firstName = "Вася";
            secondPerson.lastName = "Пупкин";
            secondPerson.salary = 300;

            Employee thirdPerson = new Employee();
            thirdPerson.firstName = "Аня";
            thirdPerson.lastName = "Пупкина";
            thirdPerson.salary = 250;

            Employee fourthPerson = new Employee();
            fourthPerson.firstName = "Ира";
            fourthPerson.lastName = "Иванова";
            fourthPerson.salary = 350;

            Employee fifthPerson = new Employee();
            fifthPerson.firstName = "Саша";
            fifthPerson.lastName = "Петров";
            fifthPerson.salary = 400;


            Employee[] personArray = new Employee[5];
            personArray[0] = firstPerson;
            personArray[1] = secondPerson;
            personArray[2] = thirdPerson;
            personArray[3] = fourthPerson;
            personArray[4] = fifthPerson;

            //или так:

            //Employee first = new Employee()
            //{
            //    firstName = "Вася",
            //    lastName = "Первый"
            //};

            //personArray.Add(firstPerson);
            //personArray.Add(secondPerson);
            //personArray.Add(thirdPerson);
            //personArray.Add(fourthPerson);
            //personArray.Add(fifthPerson);

            int sumOfSellary = 0;
            foreach (var employee in personArray)
            {
                employee.PrintInfo();
                sumOfSellary += employee.salary;
            }

            Console.WriteLine("Общая зарплата: {0}", sumOfSellary);

            Console.ReadKey();
        }
    }
}
