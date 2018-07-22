using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab2
{
    class PlantFeeder : IWayToSurvive
    {
        private string Habitat;
        public PlantFeeder(string habitat)
        {
            this.Habitat = habitat;
        }
        public string Eat()
        {
            return "Eat plants.";
        }
        public string Dwell()
        {
            return this.Habitat;
        }
    }
}
