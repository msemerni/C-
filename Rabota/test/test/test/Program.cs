using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            ///////////////////////////////////////////////////////
        //    string message = Hello(); // вызов первого метода

        //    Console.WriteLine(message);
        //    Console.WriteLine(Hello());

        //    Sum(); // вызов второго метода

        //    Console.ReadLine();
        //}
        //static string Hello()
        //{
        //    return "Hello to World!";
        //}
        //static void Sum()
        //{
        //    int x = 2;
        //    int y = 3;
        //    Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        //}


        ////////////////////////////////////////////////////////
        // ввод чисел
        //int[] nums = new int[5];
        //Console.WriteLine("Введите семь чисел");
        //    for (int i = 0; i<nums.Length; i++)
        //    {
        //        Console.Write("{0}-е число: ", i + 1);
        //        nums[i] = Int32.Parse(Console.ReadLine());
        //    }

    // сортировка
    //int temp;
    //        for (int i = 0; i<nums.Length - 1; i++)
    //        {
    //            for (int j = i + 1; j<nums.Length; j++)
    //            {
    //                if (nums[i] > nums[j])
    //                {
    //                    temp = nums[i];
    //                    nums[i] = nums[j];
    //                    nums[j] = temp;
    //                }
    //            }
    //        }

    //        // вывод
    //        Console.WriteLine("Вывод отсортированного массива");
    //        for (int i = 0; i<nums.Length; i++)
    //        {
    //            Console.Write(nums[i]+" ");
    //        }
    //        Console.ReadLine();

            ////////////////////////////////////////////////////////////////

            //int f = 0;
            //for (;;)
            //{
            //    Console.WriteLine("Квадрат числа {0} равен {1}", ++f, f * f);
            //    System.Threading.Thread.Sleep(1000);
            //}

            //int[] array = new int[] { 1, 2, 3, 4, 12, 9 };
            //for (int i = 0; i<array.Length; i++)
            //{
            //    if (array[i] > 10)
            //        break;
            //    Console.WriteLine(array[i]);
            //}

            /////////////////

//            try
//            {
//                int a = 33;
//int b = 600;
//byte c = checked((byte)(a + b));
//Console.WriteLine(c);
//            }
//            catch (OverflowException e)
//            {
//                Console.WriteLine("Что-то пошло не так!");
//                Console.WriteLine(e.Message);
//            }

            /////////////////

//            int[] nums2 = new int[4];
//nums2[0] = 1;
//            nums2[1] = 2;
//            nums2[2] = 3;
//            nums2[3] = 5;
//            Console.WriteLine(nums2[3]);

//            int[] nums1 = new int[] { 8, 1, 5, 3, 4, 2 };
//int length = nums1.Length;
//Console.WriteLine("количество элементов: {0}", length);
//            int rank = nums1.Rank;
//Console.WriteLine("размерность массива: {0}", rank);
//            Array.Reverse(nums1);
//            Console.WriteLine(nums1[1]);
//            Array.Sort(nums1);
//            Console.WriteLine(nums1[4]);
//            Console.WriteLine(nums1);
//            foreach (var s in nums1)
//            {
//                Console.Write("{0}\t", s);
//            }
//            Console.WriteLine();


            //string s1 = "hello";
            //string s2 = null;

            //string s3 = new String('a', 6); // результатом будет строка "aaaaaa"
            //string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);



            //string s1 = "hello";
            //char ch1 = s1[1]; // символ 'e'
            //Console.WriteLine(ch1);
            //Console.WriteLine(s1.Length);


            //string s1 = "hello";
            //string s2 = "world";
            //string s3 = s1 + " " + s2; // результат: строка "hello world"
            //string s4 = String.Concat(s1," ", s2, s3); // результат: строка "hello world!!!"

            //Console.WriteLine(s4);


            //string text = "И поэтому  все так произошло";

            //string[] words = text.Split(new char[] { ' ' });

            //foreach (string s in words)
            //{
            //    Console.WriteLine(s);
            //}


            //string text = "И поэтому  все так произошло";

            ////string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.);
            //string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //foreach (string s in words)
            //{
            //    Console.WriteLine(s);
            //}


            //string s5 = "apple";
            //string s6 = "a day";
            //string s7 = "keeps";
            //string s8 = "a doctor";
            //string s9 = "away";
            //string[] values = new string[] { s5, s6, s7, s8, s9 };

            //String s10 = String.Join(" ", values);

            //Console.WriteLine(s10);

            //string s1 = "world";
            //string s2 = "!!!";

            //int result = String.Compare(s2, s1);

            //Console.WriteLine(result);

            //if (result < 0)
            //{
            //    Console.WriteLine("Строка s1 перед строкой s2");
            //}
            //else if (result > 0)
            //{
            //    Console.WriteLine("Строка s1 стоит после строки s2");
            //}
            //else
            //{
            //    Console.WriteLine("Строки s1 и s2 идентичны");
            //}



            //string text = " hello world ";

            //text = text.Trim(); // результат "hello world"
            //text = text.Trim('l', 'd', 'h'); // результат "ello worl"
            //Console.WriteLine(text);


            //string text = "Хороший день";
            //// обрезаем начиная с третьего символа
            ////text = text.Substring(2);
            ////// результат "роший день"
            ////Console.WriteLine(text);
            //Console.WriteLine(text.Length);

            ////text = text.Substring(1, 5);
            ////Console.WriteLine(text);
            ////// обрезаем сначала до последних двух символов
            ////Console.WriteLine(text.Length);

            //text = text.Substring(0, text.Length - 2);
            //// результат "роший де"
            //Console.WriteLine(text);

            //string s1 = null;
            //Console.WriteLine(s1);
            //string s2 = "";
            //Console.WriteLine(s2);

            //string text = "Хороший день";
            //string subString = "замечательный ";

            //text = text.Insert(8, subString);
            //Console.WriteLine(text);

            //string text = "Хороший день";
            // индекс последнего символа
            // вырезаем последний символ
            //text = text.Remove(2);
            //Console.WriteLine(text);

            // вырезаем первые два символа
            //text = text.Remove(2, 3);
            //Console.WriteLine(text);
            //////////////////////////////////////////////////////////////////////////////
            Book b1 = new Book("Война и мир", "Л. Н. Толстой", 1869);
                b1.GetInformation();

            Book b2 = new Book();
                b2.GetInformation();

            Book b21 = new Book("Война и мир", "Война");
                b21.GetInformation();

            Book b31 = new Book();
                b31.name = "Война";
            b31.GetInformation();

            Book b32 = new Book();
                b32.year = 25;
            b32.GetInformation();

            //Для нашего класса Book мы могли бы установить последовательно значения для всех трех полей класса:
            Book b3 = new Book();
                b3.name = "Война и мир";
                b3.author = "Л. Н. Толстой";
                b3.year = 1875;
                b3.GetInformation();
            //Но можно также использовать инициализатор объектов:
            //С помощью инициализатора объектов можно присваивать значения 
            //всем доступным полям и свойствам объекта в момент создания без явного вызова конструктора.


            ///?????? в чём разница Book b4 = new Book { name = "Отцы и дети", author = "И. С. Тургенев", year = 1862 };
            ///и Book b5 = new Book ("Мир", "Л. Н.", 18269);????????
            ///
            /// это одно и тоже. просто разная реализация.
            /// вызывается конструктор по умолчанию. но так не пишут. больше кода.
            Book b4 = new Book { name = "Отцы и дети", author = "И. С. Тургенев", year = 1862 };
                b4.GetInformation();
            ////пишут так:
            //// здесь сразу присваиваются переменные:
            //// вызывается конструктор другой, а не тот, который по умолчанию.
            Book b5 = new Book ("Мир", "Л. Н.", 18269);
                b5.GetInformation();

                // установка зеленого цвета шрифта
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                try
                {
                    do
                    {
                        Console.WriteLine("Введите первое число");
                        int num1 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Введите второе число");
                        int num2 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Сумма чисел {0} и {1} равна {2}", num1, num2, num1 + num2);

                        Console.WriteLine("Для выхода нажмите Escape; для продолжения - любую другую клавишу");
                    }
                    while (Console.ReadKey().Key != ConsoleKey.Escape);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                Console.WriteLine("Введите число");
                Console.ReadLine();
                }
            Console.ReadKey();

            

        }
    }

}