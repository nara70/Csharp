using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    class Works : Factory
    {
        public delegate void Method(Unit unit);
        public event Method onCreating;
        public override Unit create()
        {
            Unit newWorker = new Worker();
            onCreating(newWorker);
            return newWorker;
        }
    }
}
