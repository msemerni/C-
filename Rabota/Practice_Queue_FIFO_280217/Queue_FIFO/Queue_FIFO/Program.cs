using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_FIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queueInt = new MyQueue<int>();
            queueInt.Push(1);
            queueInt.Push(2);
            queueInt.Push(3);
            queueInt.Push(4);
            queueInt.Push('a'); // 97 - номер символа в таблице ASCII
            ////цикл for ???
                    ////MyQueue //// private List<T> list = new List<T>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(queueInt.Pop());
            }
            Console.WriteLine(queueInt.Pop());
            Console.WriteLine(queueInt.Pop());
            Console.WriteLine(queueInt.Pop());
            Console.WriteLine(queueInt.Pop());
            Console.WriteLine(queueInt.Pop());
            Console.WriteLine(queueInt.Pop());//тут будет ошибка, так как стэк пустой.
            queueInt.Push(1);
            queueInt.Push(2);
            queueInt.Clear();
            Console.WriteLine(queueInt.Pop());//тут будет ошибка, так как стэк пустой.

            Console.ReadKey();
        }
    }
}
