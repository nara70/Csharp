using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterOfEployment_0._1._0
{
    public partial class CheckInFormUser : Form
    {
        public CheckInFormUser()
        {
            InitializeComponent();
        }
        public CheckInFormUser(DatabaseMaster dataMaster)
        {
            this.databaseMaster = dataMaster;
            InitializeComponent();
        }
    }
}
