using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab2
{
    class Lion : Mammal
    {
        public Lion(IWayToSurvive way, float weight)
            : base(way)
        {
            this.Weight = weight;
            this.HairColor = Color.brown;
            this.HairLength = 1;
        }
        public override string Say()
        {
            return "AAAAAHHHRRRR!!!";
        }
        public override string Image()
        {
            return "           ,aodObo,\n" +
                   "        ,AMMMMP~~~~\n"+
                   "     ,MMMMMMMMA.\n"+
                   "   ,M;'     `YV'\n"+
                   "  AM' ,OMA,\n"+
                   " AM|   `~VMM,.      .,ama,____,amma,..\n"+
                   " MML      )MMMD   .AMMMMMMMMMMMMMMMMMMD.\n"+
                   " VMMM    .AMMY'  ,AMMMMMMMMMMMMMMMMMMMMD\n"+
                   " `VMM, AMMMV'  ,AMMMMMMMMMMMMMMMMMMMMMMM,                ,\n"+
                   "  VMMMmMMV'  ,AMY~~''  'MMMMMMMMMMMM' '~~             ,aMM\n"+
                   "  `YMMMM'   AMM'        `VMMMMMMMMP'_              A,aMMMM\n"+
                   "   AMMM'    VMMA. YVmmmMMMMMMMMMMML MmmmY          MMMMMMM\n"+
                   "  ,AMMA   _,HMMMMmdMMMMMMMMMMMMMMMML`VMV'         ,MMMMMMM\n"+
                   "  AMMMA _'MMMMMMMMMMMMMMMMMMMMMMMMMMA `'          MMMMMMMM\n"+
                   " ,AMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMa      ,,,   `MMMMMMM\n"+
                   " AMMMMMMMMM'~`YMMMMMMMMMMMMMMMMMMMMMMA    ,AMMV    MMMMMMM\n"+
                   " VMV MMMMMV   `YMMMMMMMMMMMMMMMMMMMMMY   `VMMY'  adMMMMMMM\n"+
                   " `V  MMMM'      `YMMMMMMMV.~~~~~~~~~,aado,`V''   MMMMMMMMM\n"+
                   "    aMMMMmv       `YMMMMMMMm,    ,/AMMMMMA,      YMMMMMMMM\n"+
                   "    VMMMMM,,v       YMMMMMMMMMo oMMMMMMMMM'    a, YMMMMMMM\n"+
                   "    `YMMMMMY'       `YMMMMMMMY' `YMMMMMMMY     MMmMMMMMMMM\n"+
                   "     AMMMMM  ,        ~~~~~,aooooa,~~~~~~      MMMMMMMMMMM\n"+
                   "       YMMMb,d'         dMMMMMMMMMMMMMD,   a,, AMMMMMMMMMM\n"+
                   "        YMMMMM, A       YMMMMMMMMMMMMMY   ,MMMMMMMMMMMMMMM\n"+
                   "       AMMMMMMMMM        `~~~~'  `~~~~'   AMMMMMMMMMMMMMMM\n"+
                   "       `VMMMMMM'  ,A,                  ,,AMMMMMMMMMMMMMMMM\n"+
                   "     ,AMMMMMMMMMMMMMMA,       ,aAMMMMMMMMMMMMMMMMMMMMMMMMM\n"+
                   "   ,AMMMMMMMMMMMMMMMMMMA,    AMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n"+
                   " ,AMMMMMMMMMMMMMMMMMMMMMA   AMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n"+
                   "AMMMMMMMMMMMMMMMMMMMMMMMMAaAMMMMMMMMM KING OF BEASTS GGN94";
        }
    }
}
