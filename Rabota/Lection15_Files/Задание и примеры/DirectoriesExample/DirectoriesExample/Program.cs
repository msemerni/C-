using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoriesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать папку TempFolder на диске С
            Directory.CreateDirectory(@"c:\TempFolder");

            //Получить список файлов из папки My Files на диске С:
            Directory.GetFiles(@"C:\My Files");

            //Получить список файлов с расширением txt которые находятся в папке My Files
            Directory.GetFiles(@"C:\My Files", "*.jpg", SearchOption.TopDirectoryOnly);

            //Получить список файлов с расширением txt которые находятся в папке My Files
            //и во всех вложенных в нее папках (SearchOption.AllDirectories)
            string[] files = Directory.GetFiles(@"C:\My Files", "*.txt", SearchOption.AllDirectories);

            //Вывести на консоль пути к найденным файлам
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            //Получить список папок в папке My Files на диске С:
            string[] directories = Directory.GetDirectories(@"C:\My Files", "*.*", SearchOption.TopDirectoryOnly);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            //Проверить, существует ли каталог My Files на диске С:
            bool isDirectoryExist = Directory.Exists(@"C:\My Files");

            if (isDirectoryExist)
            {
                Console.WriteLine("Такой каталог существует");
            }
            else
            {
                Console.WriteLine("Такого каталога нет");
            }
        }
    }
}
