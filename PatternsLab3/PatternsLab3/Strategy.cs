using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab3
{
    interface IStrategy
    {
        double Execute(double a, double b);
    }
}
