using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab2
{
    abstract class Bird : Animal
    {
        public bool FlyingOpportunity { get; set; }
        public float BeakLength { get; set; }
        public Bird (IWayToSurvive way)
            : base(way)
        {
            this.AmountOfLegs = 2;
        }
    }
}
