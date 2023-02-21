using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_work_2
{
    class Program
    {
        ////Нарисовать рамку в консоли. Высота, Ширина и символ для отображения границ рамки являются 
        ////входящими параметрами в метод
        static void Main(string[] args)
        {

            Console.Write("Введите высоту рамки: ");
            int height = Int32.Parse(Console.ReadLine());
            Console.Write("Введите ширину рамки: ");
            int width = Int32.Parse(Console.ReadLine());
            Console.Write("Введите символ рамки: ");
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine();

            //DrawRamka(height, width, symbol);
            //Console.WriteLine();

            DrawRamka2(height, width, symbol);
            Console.WriteLine();

            ////можно так:
            //DrawRamka2(15, 20, '$');
            Console.ReadKey();
        }
        ////
        public static void DrawRamka(int height, int width, char symbol)
        {
            int positionX = 10;
            int positionY = 10;

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(positionX, positionY++);
                for (int j = 0; j < width; j++)
                {
                   
                    if (i == 0 || i == height - 1) Console.Write(symbol);
                    else if (j == 0 || j == width - 1) Console.Write(symbol);
                    else Console.Write(' ');
                }

                Console.WriteLine();
                
            }
        }

        // Рамка со сдвигом на 1. Для игры.
        public static void DrawRamka2(int height, int width, char symbol)
        {
            int positionX = 20;
            int positionY = 10;
            for (int i = -1; i < height + 1; i++)
            {
                Console.SetCursorPosition(positionX, positionY++);
                for (int j = -1; j < width + 1; j++)
                {
                    if (i == -1 || i == height) Console.Write(symbol);
                    else if (j == -1 || j == width) Console.Write(symbol);
                    else Console.Write(' ');
                }
                Console.WriteLine();
            }
        }


    }
}
