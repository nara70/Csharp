using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    class TerritoryDirector
    {
        public TerritoryBuilder builder { set; get; }
        public TerritoryDirector(TerritoryBuilder builder)
        {
            this.builder = builder;
        }

        public Nation Construct(int gold)
        {
            Nation nation = new Nation();
            nation.gold = gold;
            builder.createTerritory();
            builder.setArea();
            builder.setField();
            builder.setForest();
            builder.setBarracks(nation);
            builder.setPalaces(nation);
            builder.setWorks(nation);
            nation.territory = builder.territory;
            return nation;
        }
    }
}
