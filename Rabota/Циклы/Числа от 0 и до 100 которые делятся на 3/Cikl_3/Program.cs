using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl_3
{
    class Program
    {
        static void Main(string[] args)
        {
        int j=0;
            for (int i=1; i<=100; i++)
            {
                if (j % 3 == 0)
                Console.WriteLine(j);
                j++;
            }
    Console.ReadLine();
        }
        
    }
}
