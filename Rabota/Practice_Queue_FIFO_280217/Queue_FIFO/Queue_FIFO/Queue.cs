using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_FIFO
{
    class MyQueue <T>
    {
        private List<T> list = new List<T>();

        public void Push(T input)
        {
            list.Add(input);
        }

        public object Pop()
        {
            try
            {
                T number = list[0];
                list.RemoveAt(0);
                return number;
            }
            catch (Exception e)
            {
                Console.Write("Ошибка: {0}", e.Message);
                return null;
            }

        }

        public void Clear()
        {
            list.Clear();
        }

    }
}

