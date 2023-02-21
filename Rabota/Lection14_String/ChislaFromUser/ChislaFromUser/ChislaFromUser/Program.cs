using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChislaFromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит числа одной строкой с разделителем "-"
            // Пример 1-3-4-6
            //Определить количество введенных чисел 
            //Определить есть ли повторяющиеся элементы
            //Для каждого элемента массива вывести сколько раз этот элемент повторяется
            Console.WriteLine("Введите числа через тире (X-X-X-...):");
            string str = Console.ReadLine();

            //int count = 0;
            string[] strArr = str.Split('-');

            Console.WriteLine("Вы ввели следующие цифры: ");
            foreach (var s in strArr)
            {
                Console.WriteLine(s);
                //count++;
            }
            ////можно так:
            //Console.WriteLine("\nКоличество введенных цифр: {0}", count);
            ////можно еще так:
            Console.WriteLine("\nКоличество введенных цифр: {0}\n", strArr.Length);

            /////////////////////////////

            for (int i = 0; i < strArr.Length; i++)
            {
                int count2 = 0;
                for (int j = 0; j < strArr.Length; j++)
                {
                    if (i != j && strArr[i] == strArr[j])
                    {
                        count2++;
                    }
                }
                //string unicNumber = strArr[i];
                //////if (count2 == 0)
                //if (unicNumber != strArr[i])
                    Console.WriteLine("Цифра {0}: количество повторений: {1}", strArr[i], count2);
            }
            
            Console.ReadKey();
        }
    }
}
