using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK_Push_Pop_Clear
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            /////можно засунуть любой тип данных: например stack.Push("abc") и другое;
            stack.Push("abc");
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            //////или так:
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(stack.Pop());

            //}
            Console.WriteLine(stack.Pop()); //5
            Console.WriteLine(stack.Pop()); //4
            Console.WriteLine(stack.Pop()); //3
            Console.WriteLine(stack.Pop()); //2
            Console.WriteLine(stack.Pop()); //abc
            Console.WriteLine(stack.Pop()); //тут будет ошибка, так как стэк пустой.
            stack.Push(1);
            stack.Push(2);
            stack.Clear();
            Console.WriteLine(stack.Pop()); //тут будет ошибка, так как стэк пустой.

            Console.ReadKey();
            ////?????
            //Console.WriteLine("Исходный стек: ");
            //foreach (char s in list)
            //    Console.Write(s);
        }
    }
}
