using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab2
{
    class Eagle : Bird
    {
        public Eagle(IWayToSurvive way, float weight)
            : base(way)
        {
            this.Weight = weight;
            this.FlyingOpportunity = true;
            this.BeakLength = 1;
        }
        public override string Say()
        {
            return "Caaar!";
        }
        public override string Image()
        {
            return "                                                               __..-'\n"+
                   "                                                        _.--''\n"+
                   "                                              _...__..-'\n"+
                   "                                            .'\n"+
                   "                                          .'\n"+
                   "                                        .'\n"+
                   "                                      .'\n"+
                   "           .------._                 ;\n"+
                   "     .-'''`-.<')    `-._           .'\n"+
                   "    (.--. _   `._       `'---.__.-'\n"+
                   "     `   `;'-.-'         '-    ._\n"+
                   "       .--'``  '._      - '   .\n"+
                   "        `'''-.    `---'    ,\n"+
                   "''--..__      ` \n"+
                   "        ``''---'`|      .'\n"+
                   "                  `'. '\n"+
                   "                    `'.\n";
        }
    }
}
