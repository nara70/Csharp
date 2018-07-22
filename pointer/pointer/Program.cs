using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointer
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            //Console.WriteLine(c.n);
            Console.WriteLine(c.num);
            A a = new A(c);
            B b = new B(c, a);
            c.add();
            //Console.WriteLine(c.n);
            Console.WriteLine(b.a.getC().num);
            b.a.add();
            //Console.WriteLine(c.n);
            Console.WriteLine(c.num);
            Console.ReadKey();
        }
    }
}
