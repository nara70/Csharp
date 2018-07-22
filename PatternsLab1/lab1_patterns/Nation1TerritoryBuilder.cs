using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    class Nation1TerritoryBuilder : TerritoryBuilder
    {
        public override void setArea()
        {
            this.territory.area = 100;
        }

        public override void setField()
        {
            this.territory.field = new Field { area = 100 };
        }

        public override void setForest()
        {
            //not used
        }
        public override void setBarracks(Nation nation)
        {
            this.territory.barracks = new List<Barracks>();
            for (int i = 0; i < 2; i++)
            {
                Barracks newBarracks = new Barracks();
                newBarracks.onCreating += nation.addNewInhabitant;
                this.territory.barracks.Add(newBarracks);
            }
        }
        public override void setPalaces(Nation nation)
        {
            //not used
        }
        public override void setWorks(Nation nation)
        {
            this.territory.works = new List<Works>();
            Works newWorks = new Works();
            newWorks.onCreating += nation.addNewInhabitant;
            this.territory.works.Add(newWorks);
        }
    }
}
