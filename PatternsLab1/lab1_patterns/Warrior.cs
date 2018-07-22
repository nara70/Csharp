using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    class Warrior : Unit
    {
        public Warrior()
        {
            this.health = 100;
            Console.WriteLine("Warrior is created!");
        }
        public override void Attack(Unit unit)
        {
            unit.health -= 10;
        }
        public override void getWood(Territory territory, int amount) { }
        public override void buildBarracks(Nation nation) { }
        public override void buildWorks(Nation nation) { }
        public override void buildPalace(Nation nation) { }
        public override void buyJewelry(Nation nation) { }
    }
}
