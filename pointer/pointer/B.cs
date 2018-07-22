using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointer
{
    class B
    {
        public B(C cp, A ac)
        {
            this.c = cp;
            this.a = ac;
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
        public A a;
    }
}
