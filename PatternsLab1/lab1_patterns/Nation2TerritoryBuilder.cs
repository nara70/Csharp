using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    class Nation2TerritoryBuilder : TerritoryBuilder
    {
        public override void setArea()
        {
            this.territory.area = 70;
        }

        public override void setField()
        {
            this.territory.field = new Field { area = 30};
        }

        public override void setForest()
        {
            this.territory.forest = new Forest { area = 40};
        }
        public override void setBarracks(Nation Nation)
        {
            //not used
        }
        public override void setPalaces(Nation nation)
        {
            this.territory.palaces = new List<Palace>();
            Palace newPalace = new Palace();
            newPalace.onCreating += nation.addNewInhabitant;
            this.territory.palaces.Add(newPalace);
        }
        public override void setWorks(Nation nation)
        {
            this.territory.works = new List<Works>();
            for (int i = 0; i < 3; i++)
            {
                Works newWorks = new Works();
                newWorks.onCreating += nation.addNewInhabitant;
                this.territory.works.Add(newWorks);
            }
        }
    }
}
