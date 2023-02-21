using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostLongSentenceFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 2) Считать текстовый файл.Определить самое длинное предложение в файле и вывести его номер на экран.
            //// Если строк несколько - то вывести номера всех таких строк.
            string readedText = File.ReadAllText(@"D:\Программирование\Rabota\Lection15_Files\Задание и примеры\HT.txt");

            Console.WriteLine(readedText);

            readedText = readedText.Trim();

            ////////нужно как-то удалить последний перевод строки !!!!!!!!!!!!!!!

            readedText = readedText.Replace("\n\r\n", " ").Replace("\n", "").Replace("\r", "").Replace("\v", "").Replace(". ", ".");
            string[] strArr = readedText.Split('.');
            Console.WriteLine("\nПредложения в тексте:\n");

            ///////////// ????????????? Правильно работает только если "strArr.Length-1" (на одно меньше) ///////////////
            for (int i=0; i < strArr.Length-1; i++)
            {
                Console.WriteLine("{0}) {1}", i, strArr[i]);
            }
            ////можно и так:
            //foreach (var s in strArr)
            //{
            //    Console.WriteLine(s);
            //}

            Console.WriteLine("\nКоличество предложений в тексте: {0}", strArr.Length-1);

            ////найти самое длинное и самое короткое предложение:

            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int wordMax = 0;
            int wordMin = 0;
            for (int i = 0; i < strArr.Length-1; i++)
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
            Console.WriteLine("\nСамое длинное предложение с индексом {0}:\n{1}", wordMax, strArr[wordMax]);
            Console.WriteLine("Количество символов в предложении: {0}", max);

            Console.WriteLine("\nСамое короткое предложение с индексом {0}:\n{1}", wordMin, strArr[wordMin]);
            Console.WriteLine("Количество символов в предложении: {0}", min);

            Console.ReadKey();
        }
    }
}
