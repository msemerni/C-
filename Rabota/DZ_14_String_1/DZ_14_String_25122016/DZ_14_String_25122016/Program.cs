using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14_String_25122016
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1) Пользователь вводит строку.Необходимо удалить из нее все пробелы, 
            //// после этого определить является ли она палиндромом (одинаково пишется как с начала так и с конца)

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////Первый вариант - не работает///////////////////////////////////////////////////////////////

            Console.WriteLine("Введите предложение:");

            string userSentence = Console.ReadLine();

            userSentence = userSentence.Replace(" ", "");
            //Console.WriteLine(userSentence);

            string userSentenceReverse = userSentence;

            Console.WriteLine("\nВсе элементы массива:");
            char[] userSentenceInChar = userSentence.ToCharArray();
            /////или так:
            //char[] userSentenceInChar = userSentence.ToArray<char>();
            foreach (var s in userSentenceInChar)
            {
                Console.Write(s);
            }

            Console.WriteLine("\nРеверс всех элементов массива:");

            char[] userSentenceInCharReverse = userSentenceReverse.ToCharArray();

            Array.Reverse(userSentenceInCharReverse);
            foreach (var s in userSentenceInCharReverse)
            {
                Console.Write(s);
            }

            Console.WriteLine();

            ////string userSentenceInCharReverseString = userSentenceInCharReverse.ToString();
            ////string userSentenceInCharString = userSentenceInChar.ToString();
            ////if (userSentenceInCharReverseString == userSentenceInCharString)
            if (userSentenceInChar == userSentenceInCharReverse)
            {
                Console.WriteLine("\nВведенная строка является палиндромом");
            }
            else
            {
                Console.WriteLine("\nВведенная строка не является палиндромом");
            }
            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////Вторая попытка/////////////////////////////////////////////////////////////////////////////

            //Console.WriteLine("Введите предложение:");

            //string userSentence = Console.ReadLine();

            //userSentence = userSentence.ToUpper().Replace(" ", "");

            //string userSentenceReverse = userSentence;

            //Console.WriteLine("\nВсе элементы массива:");
            //char[] userSentenceInChar = userSentence.ToCharArray();
            //foreach (var s in userSentenceInChar)
            //{
            //    Console.Write(s);
            //}


            //Console.WriteLine("\nРеверс всех элементов массива:");

            //char[] userSentenceInCharReverse = userSentenceReverse.ToCharArray();

            //Array.Reverse(userSentenceInCharReverse);
            //foreach (var s in userSentenceInCharReverse)
            //{
            //    Console.Write(s);
            //}

            //Console.WriteLine();

            //int count = 0;

            //for (int i = 0; i < userSentence.Length; i++)
            //if (userSentenceInChar[i] == userSentenceInCharReverse[i])
            //{
            //   count++;
            //}
            //else
            //{
            //    Console.WriteLine("\nВведенная строка не является палиндромом");
            //    break;
            //}

            //if (count++ == userSentence.Length)
            //{
            //    Console.WriteLine("\nВведенная строка является палиндромом");
            //}
            //Console.ReadKey();
        }
    }
}
