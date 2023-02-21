using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="My application";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Пожалуйста введите своё имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, {0}", name);
            Console.ReadLine();
                }
    }
}
