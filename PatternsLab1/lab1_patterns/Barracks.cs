using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    class Barracks : Factory
    {
        public delegate void Method(Unit unit);
        public event Method onCreating;
        public override Unit create()
        {
            Unit newWarrior = new Warrior();
            onCreating(newWarrior);
            return newWarrior;
        }
    }
}
