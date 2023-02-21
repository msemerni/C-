using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем новую папку:
            string newDir = @"D:\Программирование\Rabota\Lection15_Files\Files_resources\Newfolder1";
            ////можно писать и без собаки, но тогда надо в пути два слеша \\:
            Directory.CreateDirectory(newDir);

            //смотрим содеажимое папки:
            string[] files = Directory.GetFiles(@"D:\Программирование\Rabota\Lection15_Files\Files_resources\Resources", "*.txt", SearchOption.TopDirectoryOnly);

            //проверяем, существует ли папка newDir  
            //потом копируем найденные выше текстовые файлы в указанное место
            //но если файл с таким именем уже существует в папке, то будет ошибка компиляции!!!
            if (Directory.Exists(newDir))
            {
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                    string file2 = file.Replace("Resources", "Newfolder1");
                    File.Copy(file, file2);
                    //////можно не писать Console.WriteLine(file); и string file2 = file.Replace("Resources", "Newfolder1");
                    //////а написать так: 
                    //File.Copy(file, @"D:\Программирование\Rabota\Lection15_Files\Files_resources\Newfolder1\sometextfile.txt");
                }

            }
            //// теперь удаляем папки:
            //bool isDirectoryExist = Directory.Exists(@"D:\Программирование\Rabota\Lection15_Files\Files_resources\Resources");
            //if (isDirectoryExist)
            //{
            //    ////true указываем ниже для того, чтобы папка удалилась вместе с файлами
            //    //если не указать true, то откажется удалять папку если в ней есть какие-то файлы
            //    Directory.Delete(@"D:\Программирование\Rabota\Lection15_Files\Files_resources\Resources", true);
            //}

            ////теперь вставляем такст Вставка в новый скопированный файл:
            string text = "Вставка";
            string[] files2 = Directory.GetFiles(newDir, "*.txt", SearchOption.TopDirectoryOnly);
            foreach (var file in files2)
            {
                File.WriteAllText(file, text);
            }
                
                Console.ReadKey();
        }
    }
}
