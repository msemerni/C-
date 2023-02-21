using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInUniver
{
    class Students
    {
        public string firstName;
        public string lastName;
        public DateTime dateOfBirth;
        public int[] marks = new int[5];

        private static int studentsNumber = 0;

        public void inputInfo()

        {
            firstName = "Вася" + studentsNumber;
            lastName = "Пупкин";
            Random rnd = new Random();
            dateOfBirth = new dateOfBirth
    }



        public double AverageMark()
        {
            double sumOfMarks = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sumOfMarks += marks[i];
            }
            return sumOfMarks / 5;
        }

        public void Introduce()
        {
            Console.WriteLine("Студент: {0} {1}, дата рождения {2}, средний балл: {3}", firstName, lastName, dateOfBirth);
        }

    }
}
