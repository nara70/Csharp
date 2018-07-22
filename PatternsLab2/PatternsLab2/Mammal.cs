using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab2
{
    enum Color { white, black, red, blackAndWhite, grey, brown };
    abstract class Mammal : Animal
    {
        public Mammal(IWayToSurvive way)
            : base(way)
        {
            this.AmountOfLegs = 4;
        }
        public Color HairColor { get; set; }
        public float HairLength { get; set; }
    }
}
