using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageSnack
{
    abstract class MenuItem
    {
        private string name;

        public MenuItem(string name)
        {
            Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        public abstract void PrintToConsole();

    }
}
