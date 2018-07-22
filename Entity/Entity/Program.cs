using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace Entity
{
    class Program
    {
        static void InitData()
        {
            Entities db = new Entities();
            HOUSE house1 = new HOUSE
            {
                ID = 1,
                TYPEOFPROJECT = "type_1",
                AMOUNTOFFLOORS = 5,
                AMOUNTOFENTRANCES = 2,
                DATE_ = "11.12.97"
            };
            HOUSE house2 = new HOUSE
            {
                ID = 2,
                TYPEOFPROJECT = "type_2",
                AMOUNTOFFLOORS = 10,
                AMOUNTOFENTRANCES = 2,
                DATE_ = "7.04.08"
            };
            HOUSE house3 = new HOUSE
            {
                ID = 3,
                TYPEOFPROJECT = "type_3",
                AMOUNTOFFLOORS = 18,
                AMOUNTOFENTRANCES = 1,
                DATE_ = "21.10.15"
            };
            HOUSE house4 = new HOUSE
            {
                ID = 4,
                TYPEOFPROJECT = "type_1",
                AMOUNTOFFLOORS = 5,
                AMOUNTOFENTRANCES = 2,
                DATE_ = "12.03.98"
            };
            CITYREGION region1 = new CITYREGION
            {
                ID = 1,
                NAME_ = "Moldavanka",
                ADDRESS = "add1",
                AMOUNTOFINHABITATS = 1200,
                AREA = 12
            };
            CITYREGION region2 = new CITYREGION
            {
                ID = 2,
                NAME_ = "Peresip",
                ADDRESS = "add2",
                AMOUNTOFINHABITATS = 3200,
                AREA = 13
            };
            CITYREGION region3 = new CITYREGION
            {
                ID = 3,
                NAME_ = "Troeshina",
                ADDRESS = "add3",
                AMOUNTOFINHABITATS = 500,
                AREA = 9
            };

            HOUSEREGIONLINK link1 = new HOUSEREGIONLINK
            {
                ID = 1,
                HOUSE = house2,
                CITYREGION = region1
            };
            HOUSEREGIONLINK link2 = new HOUSEREGIONLINK
            {
                ID = 2,
                HOUSE = house3,
                CITYREGION = region1
            };
            HOUSEREGIONLINK link3 = new HOUSEREGIONLINK
            {
                ID = 3,
                HOUSE = house3,
                CITYREGION = region2
            };
            HOUSEREGIONLINK link4 = new HOUSEREGIONLINK
            {
                ID = 4,
                HOUSE = house4,
                CITYREGION = region2
            };
            HOUSEREGIONLINK link5 = new HOUSEREGIONLINK
            {
                ID = 5,
                HOUSE = house4,
                CITYREGION = region3
            };
            HOUSEREGIONLINK link6 = new HOUSEREGIONLINK
            {
                ID = 6,
                HOUSE = house1,
                CITYREGION = region3
            };
            db.Houses.Add(house1);
            db.Houses.Add(house2);
            db.Houses.Add(house3);
            db.Houses.Add(house4);
            db.CITYREGIONs.Add(region1);
            db.CITYREGIONs.Add(region2);
            db.CITYREGIONs.Add(region3);
            db.HOUSEREGIONLINKs.Add(link1);
            db.HOUSEREGIONLINKs.Add(link2);
            db.HOUSEREGIONLINKs.Add(link3);
            db.HOUSEREGIONLINKs.Add(link4);
            db.HOUSEREGIONLINKs.Add(link5);
            db.HOUSEREGIONLINKs.Add(link6);

            db.SaveChanges();
        }

        static void Queries()
        {
            Entities db = new Entities();

            var q1 = from x in db.Houses
                     select x;
            foreach (var x in q1)
                Console.WriteLine(x);

            var q2 = from x in db.CITYREGIONs
                     select x.NAME_;
            foreach (var x in q2)
                Console.WriteLine(x);

            var q3 = from x in db.Houses
                     where x.AMOUNTOFFLOORS > 5
                     select x.TYPEOFPROJECT;
            foreach (var x in q3)
                Console.WriteLine(x);

            var q4 = from x in db.Houses
                     orderby x.TYPEOFPROJECT
                     select x;
            foreach (var x in q4)
                Console.WriteLine(x);

            var q5 = from x in db.Houses
                     from y in db.HOUSEREGIONLINKs
                     where x.ID == y.HOUSE_ID
                     select new { v1 = x, reg = y.REGION_ID};
            foreach (var x in q5)
                Console.WriteLine(x);

            Console.WriteLine("\nInner Join\n");

            var q6 = from x in db.Houses
                     join y in db.HOUSEREGIONLINKs on x.ID equals y.HOUSE_ID into temp
                     from t1 in temp
                     join z in db.CITYREGIONs on t1.REGION_ID equals z.ID into temp2
                     from t2 in temp2
                     select new { HouseType = x.TYPEOFPROJECT, region = t2.NAME_};
            foreach (var x in q6)
                Console.WriteLine(x);

            var q7 = (from x in db.CITYREGIONs
                      let temp1 = from l in db.HOUSEREGIONLINKs where l.REGION_ID == x.ID select l
                      from t1 in temp1
                      let temp2 = from y in db.Houses
                                  where y.ID == t1.HOUSE_ID
                                  select y
                      where temp2.Count() >= 0
                      select x.NAME_).Distinct();
            foreach (var x in q7)
                Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            InitData();
            Queries();
        }
    }
}
