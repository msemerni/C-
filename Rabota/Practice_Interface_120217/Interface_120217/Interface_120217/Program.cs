using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_120217
{
    class Program
    {
        static void Main(string[] args)
            {
                List<IExecutable> exlist = new List<IExecutable>();
                exlist.Add(new RobotA());
                exlist.Add(new RobotB());
                exlist.Add(new RobotC());
                exlist.Add(new RobotA());

                RobotWorker rw = new RobotWorker(exlist);

                rw.Run();

                Console.ReadKey();
            }

        class RobotWorker
        {
            private List<IExecutable> jobs;

            public RobotWorker(List<IExecutable> actions)
            {
                jobs = actions;
            }

            public void Run()
            {
                foreach (var actionX in jobs)
                {
                    actionX.Execute();
                }
            }
        }

        interface IExecutable
        {
            void Execute();
        }

        class RobotA : IExecutable
        {
            public void Execute()
            {
                Console.WriteLine("Action one");
            }
        }

        class RobotB : IExecutable
        {
            public void Execute()
            {
                Console.WriteLine("Action two");
            }
        }

        class RobotC : IExecutable
        {
            public void Execute()
            {
                Console.WriteLine("Action three");
            }
        }
    }
}
 