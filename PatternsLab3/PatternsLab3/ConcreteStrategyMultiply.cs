using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab3
{
    class ConcreteStrategyMultiply : IStrategy
    {
        public double Execute(double a, double b)
        {
            return a * b;
        }
    }
}
