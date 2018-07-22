using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    class Nation
    {
        public Nation()
        {
            this.inhabitants = new List<Unit>();
        }
        public Nation(Territory territory, int gold)
        {
            this.territory = territory;
            this.gold = gold;
            this.inhabitants = new List<Unit>();
        }
        public void addNewInhabitant(Unit unit)
        {
            this.inhabitants.Add(unit);
        }

        public Territory territory{ get; set; }
        public List<Unit> inhabitants { get; set; }
        public int gold { get; set; }
    }
}
