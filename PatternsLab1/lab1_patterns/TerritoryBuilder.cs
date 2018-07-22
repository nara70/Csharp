using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    abstract class TerritoryBuilder
    {
        public Territory territory { get; set; }
        public void createTerritory()
        {
            this.territory = new Territory();
        }
        public abstract void setArea();
        public abstract void setForest();
        public abstract void setField();
        public abstract void setWorks(Nation nation);
        public abstract void setPalaces(Nation nation);
        public abstract void setBarracks(Nation nation);
    }
}
