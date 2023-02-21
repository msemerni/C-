using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        public string shortName;
        public string group;
        public int[] marks = new int[5];

        public void AddUserInfo()
        {
            Console.WriteLine("Введите фамилию и инициалы студента: ");
            shortName = Console.ReadLine();

            Console.WriteLine("Введите группу студента: ");
            group = Console.ReadLine();

            Console.WriteLine("Введите 5 оценок студента: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("{0} оценка: ", i);
                marks[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public double AverageMark()
        {
            int sumOfMarks = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                    sumOfMarks += marks[i];
            }
            return (double) sumOfMarks / 5;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Студент {0}, группа {1}, средний балл: {2}", shortName, group, AverageMark());
        }

    }
}