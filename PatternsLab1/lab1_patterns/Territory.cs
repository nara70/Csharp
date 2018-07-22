using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_patterns
{
    class Territory
    {
        public int area { get; set; }
        public Forest forest { get; set; }
        public Field field { get; set; }
        public List<Works> works { get; set; }
        public List<Barracks> barracks { get; set; }
        public List<Palace> palaces { get; set; }
    }
}
