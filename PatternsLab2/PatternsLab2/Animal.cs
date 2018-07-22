using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab2
{
    abstract class Animal
    {
        public int AmountOfLegs { get; set; }
        public float Weight { get; set; }

        protected IWayToSurvive wayToSurvive;
        public IWayToSurvive WayToSurvive
        {
            set { wayToSurvive = value; }
        }
        public Animal(IWayToSurvive way)
        {
            this.wayToSurvive = way;
        }
        public virtual string GetHabitat()
        {
            return this.wayToSurvive.Dwell();
        }
        public virtual string GetFood()
        {
            return this.wayToSurvive.Eat();
        }
        public abstract string Image();
        public abstract string Say();
    }
}
