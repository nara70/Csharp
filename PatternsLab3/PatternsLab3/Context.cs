using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab3
{
    class Context
    {
        private IStrategy Strategy;

        public Context()
        {
            this.Strategy = new ConcreteStrategyAdd();
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public double ExecuteStrategy(double a, double b)
        {
            return this.Strategy.Execute(a, b);
        }
    }
}
