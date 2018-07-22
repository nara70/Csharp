using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab2
{
    class Card
    {
        public Card(Animal animal)
        {
            this.Animal = animal;
        }
        public Animal Animal { set; get; }
        public string Listen()
        {
            return "Say: " + this.Animal.Say();
        }
        public string ShowInfo()
        {
            string info = "";
            info = info + "Weight: " + Animal.Weight.ToString() + " kg\n";
            info = info + "Amount of legs: " + Animal.AmountOfLegs.ToString() + "\n";
            info = info + "Habitat: " + Animal.GetHabitat() + "\n";
            info = info + "Nutrition: " + Animal.GetFood();
            info = info + "\n\n======Image======\n\n" + Animal.Image() + "\n=================\n";
            return info;
        }
    }
}
