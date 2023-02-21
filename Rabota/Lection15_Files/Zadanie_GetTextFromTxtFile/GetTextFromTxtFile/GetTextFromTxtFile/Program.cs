using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTextFromTxtFile
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Считать текст из файла HT.txt.
            ////1) Определить количество слов в файле(вывести на консоль)
            ////2) Определить самое длинное слово (вывести на консоль)

            string readedText = File.ReadAllText(@"D:\Программирование\Rabota\Lection15_Files\Задание и примеры\HT.txt");

            Console.WriteLine(readedText);

            readedText = readedText.Trim();
            /////ПУСТАЯ СИМВОЛЬНАЯ КОНСТАНТА - .Replace('\n', ' ') ???
            readedText = readedText.Replace("\n\r\n", " ").Replace(".", "").Replace(",", "").Replace("(", "").Replace(")", "");

            ////Как это всё работает:?
            //StringBuilder builder = new StringBuilder();
            //builder.Clear();
            //readedText = readedText.Remove('.').Remove(',').Remove('(').Remove(')');

            ////Определить количество слов:
            int count = 0;

            ////удаляет несколько пробелов подряд:
            //string[] strArr = readedText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] strArr = readedText.Split(' ');

            Console.WriteLine("\nСлова в тексте:\n");
            foreach (var s in strArr)
            {
                Console.WriteLine(s);
                count++;
            }
            Console.WriteLine("\nКоличество слов: {0}", count);
            ////или можно короче:
            Console.WriteLine("\nКоличество слов: {0}", strArr.Length);

            ////найти самое длинное и самое короткое слово:
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int wordMax = 0;
            int wordMin = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Length > max)
                {
                    max = strArr[i].Length;
                    wordMax = i;
                }
                if (strArr[i].Length < min)
                {
                    min = strArr[i].Length;
                    wordMin = i;
                }
            }
            Console.WriteLine("\nСамое длинное слово в тексте: {0}", strArr[wordMax]);
            Console.WriteLine("Количество символов в слове: {0}", max);

            Console.WriteLine("\nСамое короткое слово в тексте: {0}", strArr[wordMin]);
            Console.WriteLine("Количество символов в слове: {0}", min);

            Console.ReadKey();
        }
    }
}
