using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointer
{
    class C
    {
        public C()
        {
            n = 0;
        }
        public void add()
        {
            this.n++;
        }
        public int num
        {
            get { return n; }
            set { n = value; }
        }
        private int n;
        //public int n { get; set; }
    }
}
