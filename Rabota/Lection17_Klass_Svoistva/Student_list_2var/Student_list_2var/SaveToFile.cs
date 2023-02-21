using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_list_2var
{
    class SaveToFile
    {
        static void Main(string[] args)
        {
            string choice = "Н";
            string finalChoice = "Н";
            Student NewStudent = new Student();
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Добавить студентов в список");
                Console.WriteLine("2 - Посмотреть список студентов");
                Console.WriteLine("3 - Выход");
                Console.Write("Выбор: ");
                int select = Int32.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        do
                        {
                            NewStudent.addStudent();
                        }
                        while (choice == "Д");
                        Console.Write("Вернуться в главное меню? Д/Н: ");
                        finalChoice = Console.ReadLine().ToUpper();
                        break;

                    case 2:
                        NewStudent.showStudent();
                        Console.Write("Вернуться в главное меню? Д/Н: ");
                        finalChoice = Console.ReadLine().ToUpper();
                        break;
                    case 3:
                        finalChoice = "Н";
                        break;
                }
                //Console.Write("Вернуться в главное меню? Д/Н: ");
                //finalChoice = Console.ReadLine().ToUpper();
            }
            while (finalChoice == "Д");
        }
    }
}
