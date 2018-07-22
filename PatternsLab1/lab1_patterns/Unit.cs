using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    abstract class Unit
    {
        public int health { set; get; }
        abstract public void Attack(Unit unit);
        abstract public void getWood(Territory territory, int amount);
        abstract public void buildBarracks(Nation nation);
        abstract public void buildWorks(Nation nation);
        abstract public void buildPalace(Nation nation);
        abstract public void buyJewelry(Nation nation);
    }
}
