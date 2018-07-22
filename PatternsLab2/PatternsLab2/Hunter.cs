using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab2
{
    class Hunter : IWayToSurvive
    {
        public Hunter(string habitat)
        {
            this.Habitat = habitat;
        }
        private string Habitat;
        public string Eat()
        {
            return "Eat another animals.\n" + Hunting();
        }
        public string Dwell()
        {
            return this.Habitat;
        }
        private string Hunting()
        {
            return "The hunter before eating must to hunt another animal";
        }
    }
}
