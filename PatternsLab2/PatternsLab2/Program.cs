using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Card lionCard = new Card(new Lion(new Hunter("Savanna"), 100));
            Console.WriteLine(lionCard.Listen());
            Console.WriteLine(lionCard.ShowInfo());
            Card card2 = new Card(new Elephant(new PlantFeeder("Forest"), 1000));
            Console.WriteLine(card2.Listen());
            Console.WriteLine(card2.ShowInfo());
            Card card1 = new Card(new Eagle(new Hunter("Mountains"), 10));
            Console.WriteLine(card1.Listen());
            Console.WriteLine(card1.ShowInfo());
        }
    }
}
