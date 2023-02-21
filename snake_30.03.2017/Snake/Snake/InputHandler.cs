using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game01
{
    class InputHandler
    {
        public event EventHandler KeyLeft;
        public event EventHandler KeyRight;
        public event EventHandler KeyUp;
        public event EventHandler KeyDown;

        protected virtual void OnKeyLeft()
        {
            if (KeyLeft != null)
                KeyLeft(this, EventArgs.Empty);
        }

        protected virtual void OnKeyRight()
        {
            if (KeyRight != null)
                KeyRight(this, EventArgs.Empty);
        }

        protected virtual void OnKeyUp()
        {
            if (KeyUp != null)
                KeyUp(this, EventArgs.Empty);
        }

        protected virtual void OnKeyDown()
        {
            if (KeyDown != null)
                KeyDown(this, EventArgs.Empty);
        }

        public void QueryKB()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            OnKeyLeft();
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            OnKeyRight();
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            OnKeyUp();
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            OnKeyDown();
                            break;
                        }
                }
            }

        }
    }
}
