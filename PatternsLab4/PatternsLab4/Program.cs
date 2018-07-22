using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab4
{
    class Program
    {
        static List<House> Houses = new List<House>()
        {
            new House(1, "type_1", 5, 2, "11.12.97"),
            new House(2, "type_2", 10, 2, "7.4.08"),
            new House(3, "type_3", 18, 1, "21.10.15"),
            new House(4, "type_1", 5, 2, "12.3.98")
        };

        static List<CityRegion> Regions = new List<CityRegion>()
        {
            new CityRegion(1, "Moldavanka", "add1", 1200, 12),
            new CityRegion(2, "Peresip", "add2", 3200, 13),
            new CityRegion(3, "Troeshina", "add3", 500, 9)
        };

        static List<HouseRegionLink> Links = new List<HouseRegionLink>()
        {
            new HouseRegionLink(1, 2, 1),
            new HouseRegionLink(2, 3, 1),
            new HouseRegionLink(3, 3, 2),
            new HouseRegionLink(4, 4, 2),
            new HouseRegionLink(5, 4, 3),
            new HouseRegionLink(6, 1, 3)
        };

        static List<int> A = new List<int>()
        {
            -3, -2, -4, 31, -4, 32, 31
        };

        static void Query(List<int> a, int D)
        {
            try
            {
                var q = (from x in a
                         where x > 0 && (x % 10) == D
                         select x).First();
                Console.WriteLine(q);
            }
            catch
            { Console.WriteLine(0); }
        }

        static void Main(string[] args)
        {
            var q1 = from x in Houses
                     select x;
            foreach(var x in q1)
                Console.WriteLine(x);

            var q2 = from x in Regions
                     select x.Name;
            foreach (var x in q2)
                Console.WriteLine(x);

            var q3 = from x in Houses
                     where x.AmountOfFloors > 5
                     select x.TypeOfProject;
            foreach(var x in q3)
                Console.WriteLine(x);

            var q4 = from x in Houses
                     orderby x.TypeOfProject
                     select x;
            foreach (var x in q4)
                Console.WriteLine(x);

            var q5 = from x in Houses
                     from y in Links
                     where x.ID == y.HouseID
                     select new { v1 = x, reg = y.RegionID};
            foreach (var x in q5)
                Console.WriteLine(x);

            Console.WriteLine("\nInner Join\n");

            var q6 = from x in Houses
                     join y in Links on  x.ID equals y.HouseID into temp
                     from t1 in temp
                     join z in Regions on t1.RegionID equals z.ID into temp2
                     from t2 in temp2
                     select new { HouseType = x.TypeOfProject, region = t2.Name};
            foreach (var x in q6)
                Console.WriteLine(x);

            var q7 = (from x in Regions
                     let temp1 = from l in Links where l.RegionID == x.ID select l
                     from t1 in temp1
                     let temp2 = from y in Houses
                                 where y.ID == t1.HouseID
                                 select y where temp2.Count() >= 0
                     select x.Name).Distinct();
            foreach(var x in q7)
                Console.WriteLine(x);
            Console.WriteLine();
            Query(A, 1);

        }
    }
}
