using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Скопировать файл myfile.jpg из папки temp в папку temp2
            File.Copy(@"c:\temp\myfile.jpg", @"c:\temp2\myfile.jpg");

            //Объявим переменную и сохраним в нее путь для дальнейшего переиспользования
            string path = @"c:\temp\myfile.jpg";

            //Удалим файл
            File.Delete(path);


            string txtPath = @"c:\TempFolder\Test.txt";

            //Проверим, существует ли такой файл
            if (File.Exists(txtPath))
            {
                //Считаем содержимое файла и сохраним в переменную textFromFile
                string textFromFile = File.ReadAllText(txtPath);
                Console.WriteLine(textFromFile);
            }
            else
            {
                Console.WriteLine("Такого файла не существует");
            }

            //Создадим экземпляр FileInfo
            FileInfo fileInfo = new FileInfo(path);

            //Скопируем файл на который указывает fileInfo на диск С: в папку My Files и назовем TestCopy.txt
            //Такой вариант отработает только если в каталоге My Files нет файла TestCopy.txt
            fileInfo.CopyTo(@"c:\My Files\TestCopy.txt");

            //Для того чтоб перезаписывать существующие файлы, необходимо воспользоваться перегрузкой метода
            //и указать параметр overwrite = true
            fileInfo.CopyTo(@"c:\My Files\TestCopy.txt", true);

            //Проверим, существует ли файл
            if (fileInfo.Exists)
            {
                //Удалим файл
                fileInfo.Delete();
            }
            
            //Примеры работы с классом Path
            string filePath = @"c:\My Files\TestCopy.txt";

            Console.WriteLine("Расширение: {0}", Path.GetExtension(filePath));
            Console.WriteLine("Имя файла: {0}", Path.GetFileName(filePath));
            Console.WriteLine("Имя файла без расширения: {0}", Path.GetFileNameWithoutExtension(filePath));
            Console.WriteLine("Путь к каталогу в котором лежит файл: {0}", Path.GetDirectoryName(filePath));
        }
    }
}
