using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            Console.WriteLine(a.i);
            B b = new B();
            b.i();
            Console.ReadLine();
        }
    }
   public class A
    {
        public string i = "a";

    }
    public class B:A
    {
        public new void i() { Console.WriteLine("b"); }
    }
}
