using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_list
{
        class Student
        {
            public string id;
            public string firstName;
            public string lastName;

            public Student()
            {

            }

            public Student(string id, string firstName, string lastName)
            {
                this.id = id;
                this.firstName = firstName;
                this.lastName = lastName;
            }

            public void AddStudentInfo()
            {
                Console.Write("Номер студента: ");
                id = Console.ReadLine();
                Console.Write("Имя студента: ");
                firstName = Console.ReadLine();
                Console.Write("Фамилия студента: ");
                lastName = Console.ReadLine();
            }
        }
}
