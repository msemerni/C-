using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_list_2var
{
    class Student
    {
        private string dataPath = @"D:\Программирование\Rabota\Lection17_Klass_Svoistva\Student_list_2var\StudentsInfo2.txt";
        private int studentID;
        private string firstName;
        private string lastName;
        private string fullInfoOfStudent;
        private string choise;

        public void addStudent()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Номер студента: ");
                studentID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите фамилию студента");
                lastName = Console.ReadLine();
                Console.WriteLine("Введите имя студента");
                firstName = Console.ReadLine();
                fullInfoOfStudent = studentID + "\t" + lastName + "\t" + firstName + Environment.NewLine;
                File.AppendAllText(dataPath, fullInfoOfStudent);

                /////////// ??????????????????????
                //do
                //{
                    Console.WriteLine("Добавить еще студента? Д/Н");
                    choise = Console.ReadLine().ToUpper();
                //}
                //while (choise != "Д" || choise != "Н");
            }
            while (choise == "Д");
        }
        public void showStudent()
        {
            string ListFromFile = File.ReadAllText(dataPath);
            Console.WriteLine(ListFromFile);
        }
    }
}
