using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        B b = new B();
    //        Console.WriteLine(b.Get1());
    //        Console.WriteLine(b.Get2());
    //        Console.ReadKey();
    //    }
    //}
    //class A
    //{
    //    public int Get1()
    //    {
    //        return 1;
    //    }
    //    public virtual int Get2()
    //    {
    //        return 2;
    //    }
    //}
    //class B : A
    //{
    //    public /*override*/ int Get1()
    //    {
    //        return 11;
    //    }

    //    public override int Get2()
    //    {
    //        return 21;
    //    }
    //}
    //////////////////////////////////////////////////////////

    //abstract class A
    //{
    //    public abstract int GetInt();
    //}

    //class B : A
    //{
    //    public override int GetInt()
    //    {
    //        return 1;
    //    }
    //}

    //class C : A
    //{
    //    public override int GetInt()
    //    {
    //        return 2;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        B b = new B();
    //        C c = new C();


    //        Write(b);
    //        Write(c);
    //        Console.ReadKey();
    //    }

    //    static void Write(A a)
    //    {
    //        Console.WriteLine("{0} GetInt = {1}", a.ToString(), a.GetInt().ToString());
    //    }

    //}
    ///////////////////////////////////////////////
    internal class A
    {
        public virtual void Do()
        {
            Console.WriteLine("A");
        }
    }

    internal class B : A
    {
        public new void Do()
        {
            Console.WriteLine("B");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = b;
            a.Do();
            Console.ReadLine();
        }
    }
}
