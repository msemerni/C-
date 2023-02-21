using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Book
    {
        public string name;
        public string author;
        public int year;

        public Book()
        {
            name = "неизвестно";
            author = "неизвестно";
            year = 1;
        }

        public Book(string name, string author, int year)
        {
            this.name = name;
            this.author = author;
            this.year = year;
        }

        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
        public void GetInformation()
        {
            Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году", name, author, year);
        }
    }
}
