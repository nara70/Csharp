using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TerritoryBuilder builder = new Nation2TerritoryBuilder();
            TerritoryDirector director = new TerritoryDirector(builder);
            Nation settlers = director.Construct(1000);
            Console.WriteLine(settlers.inhabitants.Count);
            settlers.territory.works[0].create();
            Console.WriteLine(settlers.inhabitants.Count);

            builder = new Nation1TerritoryBuilder();
            director.builder = builder;
            Nation barbarians = director.Construct(500);
            Console.WriteLine(barbarians.inhabitants.Count);
            barbarians.territory.works[0].create();
            barbarians.territory.barracks[0].create();
            barbarians.inhabitants[1].Attack(settlers.inhabitants[0]);
            Console.WriteLine(barbarians.inhabitants.Count);
        }
    }
}
