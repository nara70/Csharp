using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointer
{
    class A
    {
        public A(C cp)
        {
            this.c = cp;
        }
        public C getC()
        {
            return this.c;
        }
        public void add()
        {
            this.c.num++;
        }
        private C c;
    }
}
