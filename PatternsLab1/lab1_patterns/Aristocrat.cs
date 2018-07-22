using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    class Aristocrat : Unit
    {
        public Aristocrat()
        {
            this.health = 80;
            Console.WriteLine("Aristocrat is created!");
        }
        public override void buyJewelry(Nation nation)
        {
            nation.gold -= 85;
        }
        public override void Attack(Unit unit) { }
        public override void getWood(Territory territory, int amount) { }
        public override void buildBarracks(Nation nation) { }
        public override void buildWorks(Nation nation) { }
        public override void buildPalace(Nation nation) { }
    }
}
