using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK_Push_Pop_Clear
{
    class MyStack
    {
        //хранилище:
        private ArrayList list = new ArrayList();

        //object - это родитель, куда можно засунуть любые типы данных
        public void Push(object input)
        {
            list.Add(input);
        }

        public object Pop()
        {
            try
            {
                object obj = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return obj;
            }
            // е - принятое название эксепшена
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
