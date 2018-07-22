using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTest
{
    /// <summary>
    /// Class of column
    /// </summary>
    class Column
    {
        public System.Windows.Forms.CheckBox checkBox;
        public string type;
        public Column(System.Windows.Forms.CheckBox checkBox, string type)
        {
            this.checkBox = checkBox;
            this.type = type;
        }
    }
}
