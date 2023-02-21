using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Строка написана с пробелами до и после:
            string str = " Мама мыла раму ";
            Console.WriteLine(str);

            ////Trim - убирате пробелы до и после:
            str = str.Trim();
            Console.WriteLine(str);

            //Далее работаем уже с обрезанной строкой
            //"Мама мыла раму"

            int indexOfa = str.IndexOf("ам");
            int lastIndexOfa = str.LastIndexOf("ам");

            Console.WriteLine("indexOfa: {0}", indexOfa);
            Console.WriteLine("lastIndexOfa: {0}", lastIndexOfa);

            string str1 = str.Substring(10);
            string str2 = str.Substring(0, 4);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine("=================");
            string[] strArr = str.Split(' ');

            foreach (var s in strArr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("=================");
            string strReplace = str.Replace('а', '!');
            Console.WriteLine(strReplace);

            string strReplace2 = str.Replace("Мама", "Папа");
            Console.WriteLine(strReplace2);
            Console.WriteLine("=================");

            string strTest = " ";

            if (!String.IsNullOrWhiteSpace(strTest))
            {
                Console.WriteLine("Не налл и не пустая");
            }
            else
            {
                Console.WriteLine("Пустая или налл");
            }

            Console.ReadKey();
        }
    }
}
