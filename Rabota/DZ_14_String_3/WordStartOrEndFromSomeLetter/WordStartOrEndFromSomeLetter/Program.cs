using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordStartOrEndFromSomeLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            ////3) Считать текстовый файл. Пользователь вводит букву, 
            ////необходимо вывести все слова в файле которые начинаются или заканчиваются на эту букву

            string readedText = File.ReadAllText(@"D:\Программирование\Rabota\Lection15_Files\Задание и примеры\HT.txt");

            Console.WriteLine(readedText);

            readedText = readedText.Trim().ToUpper();
            readedText = readedText.Replace("\n\r\n", " ").Replace(".", "").Replace(",", "").Replace("(", "").Replace(")", "");

            ////удаляет несколько пробелов подряд:
            string[] strArr = readedText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nСлова и символы в тексте:\n");
            foreach (var s in strArr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\nКоличество слов и символов : {0}", strArr.Length);

            Console.WriteLine("\nВведите первые или последние любые буквы или символы в слове:");

            string letterFromUser = (Console.ReadLine().ToUpper());

            Console.WriteLine("\nВсе слова/символы в тексте, которые начинаются или заканчиваются на {0}:", letterFromUser);

            int count = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                if ((strArr[i].StartsWith(letterFromUser) == true) || (strArr[i].EndsWith(letterFromUser) == true))
                {
                    Console.WriteLine(strArr[i]);
                    count++;
                }
            }
            if (count++ <= 0)
            {
                Console.WriteLine("\nСлов/символов, начинающихся или заканчивающихся на {0} в тексте нет!", letterFromUser);
            }

            Console.ReadKey();
        }
    }
}
