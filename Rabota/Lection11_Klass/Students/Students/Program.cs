using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();
            string choise = "N";
            do
            {
                Console.Clear();
                Console.WriteLine("Введитете данные о студенте: ");

                Student student = new Student();
                student.AddUserInfo();
                allStudents.Add(student);
                Console.WriteLine("Будете еще добавлять? (Y/N)");
                choise = Console.ReadLine().ToUpper();
            }
            while (choise == "Y");

            Console.WriteLine("\nСписок студентов, чей средний балл > 67: ");

            foreach (var student in allStudents)
            {
                if (student.AverageMark() >= 67)
                    student.PrintInfo();
            }
            Console.ReadKey();
         }
    }
}

