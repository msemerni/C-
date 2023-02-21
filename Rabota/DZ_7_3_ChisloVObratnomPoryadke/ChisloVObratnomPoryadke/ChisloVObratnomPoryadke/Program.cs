using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChisloVObratnomPoryadke
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вводится число. Преобразовать его в другое число, 
            //цифры которого будут следовать в обратном порядке.

            // !!!!! Вывод числа на экран, но не в память компа.!!!!!!!
            // В память компа - см. DZ_7_3_ChisloVObratnomPoryadke_v_pamyat_kompa

            Console.Title = "Преобразование числа в обратном порядке.\n";
            string ch = "n";
            ////или так можно ??//string ch = "";  или так можно ??//string ch;
            do
            {
                Console.Clear();
                Console.WriteLine("Преобразование числа в обратном порядке.\n");
                Console.Write("Введите целое число:\t");

                int number = Int32.Parse(Console.ReadLine());

                Console.Write("\nРезультат:\t\t");

                //Лучше делать это через do/while. Но я не делал...
                Console.Write(number % 10);

                while ((number /= 10) != 0)
                //while ((number /= 10) > 0)
                    
                    //Console.Write(number % 10);
                Console.Write(number % 10);

                ////Так не работает:
                //Console.Write(number % 10);
                //while (number > 0)
                //    number = number / 10;

                //Console.Write(number % 10);

                Console.WriteLine();

                Console.Write("\nХотите продолжить? y/n ");
                ch = Console.ReadLine();


                ////выходит если нажата любая клавиша кроме y:
                //// Для этого надо написать еще один цикл внутри, пока не нажмут y или n


                //while (true)
                //{
                //    Console.Write("\nХотите продолжить? y/n ");

                //    if (ch != "y" || ch != "n")
                //        break;

                //    else
                //    {
                //        Console.Write("Ок, продолжим");
                //    }

                //}
                //Console.ReadKey();



                //// не работает:
                //while (ch != "y" || ch != "n")
                //{
                //    Console.Write("\nХотите продолжить? y/n ");
                //    ch = Console.ReadLine();
                //}

                //// не работает:
                //do
                //{
                //    Console.Write("\nХотите продолжить? y/n ");
                //    ch = Console.ReadLine();

                //}
                //while (ch != "y" || ch != "n");


                //// не работает:
                //if (ch == "y" || ch == "n")
                //{

                //}
                //else
                //{
                //    Console.Write("\nХотите продолжить? y/n ");
                //    ch = Console.ReadLine();
                //}

                //// не работает:
                //if (ch != "y" || ch != "n")
                //{
                //    Console.Write("\nХотите продолжить? y/n ");
                //    ch = Console.ReadLine();
                //}
                //else
                //{
                //    ch = Console.ReadLine();
                //}


            }
            while (ch == "y");

            Console.Write("\nДо свидания !!!");

            Console.ReadKey();
        }
    }
}

