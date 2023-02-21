using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_list
{
    class Program
    {
                static void Main(string[] args)
        {
                    string choice = "Н";
                    string finalChoice = "Н";
                    List<Student> students = new List<Student>();
                    string studentsFileInfoPath = @"D:\Программирование\Rabota\Lection17_Klass_Svoistva\Student_list\StudentsInfo.txt";
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1 - Добавить студентов в список");
                        Console.WriteLine("2 - Посмотреть список студентов");
                        Console.Write("Выбор: ");
                        int select = Int32.Parse(Console.ReadLine());
                        switch (select)
                        {
                            case 1:
                                do
                                {
                                    Console.Clear();
                                    Student student = new Student();
                                    student.AddStudentInfo();
                                    students.Add(student);
                                    Console.Write("Будете ещё добавлять? Д/Н: ");
                                    choice = Console.ReadLine().ToUpper();
                                }
                                while (choice == "Д");

                                foreach (var student in students)
                                {
                                    File.AppendAllText(studentsFileInfoPath, student.id + Environment.NewLine);
                                    File.AppendAllText(studentsFileInfoPath, student.firstName + Environment.NewLine);
                                    File.AppendAllText(studentsFileInfoPath, student.lastName + Environment.NewLine);
                                    File.AppendAllText(studentsFileInfoPath, Environment.NewLine);
                                }
                                students.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                string[] studentsFileInfo = File.ReadAllLines(studentsFileInfoPath);
                                for (int i = 0; i < studentsFileInfo.Length; i++)
                                {
                                    students.Add(new Student(studentsFileInfo[i], studentsFileInfo[i + 1], studentsFileInfo[i + 2]));
                                    i = i + 3;
                                }

                                foreach (var student in students)
                                {
                                    Console.WriteLine(student.id);
                                    Console.WriteLine(student.firstName);
                                    Console.WriteLine(student.lastName);
                                }
                                break;
                        }
                        Console.Write("Вернуться в главное меню? Д/Н: ");
                        finalChoice = Console.ReadLine().ToUpper();
                    }
                    while (finalChoice == "Д");
                }
            }

        }
