using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    class Worker : Unit
    {
        public Worker()
        {
            this.health = 90;
            Console.WriteLine("Worker is created!");
        }
        
        public override void getWood(Territory territory, int amount)
        {
            territory.forest.area -= amount;
        }
        public override void buildBarracks(Nation nation)
        {
            this.getWood(nation.territory, 15);
            Barracks newBarracks = new Barracks();
            newBarracks.onCreating += nation.addNewInhabitant;
            nation.territory.barracks.Add(newBarracks);
        }
        public override void buildWorks(Nation nation)
        {
            this.getWood(nation.territory, 10);
            Works newWorks = new Works();
            newWorks.onCreating += nation.addNewInhabitant;
            nation.territory.works.Add(newWorks);
        }
        public override void buildPalace(Nation nation)
        {
            this.getWood(nation.territory, 20);
            Palace newPalace = new Palace();
            newPalace.onCreating += nation.addNewInhabitant;
            nation.territory.palaces.Add(newPalace);
        }
        public override void buyJewelry(Nation nation) { }
        public override void Attack(Unit unit) { }
    }
}
