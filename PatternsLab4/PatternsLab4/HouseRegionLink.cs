using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab4
{
    class HouseRegionLink
    {
        public int ID;
        public int HouseID;
        public int RegionID;

        public HouseRegionLink(int id, int houseID, int regionID)
        {
            this.ID = id;
            this.HouseID = houseID;
            this.RegionID = regionID;
        }
    }
}
