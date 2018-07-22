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
    public partial class UnemployedRoom : Form
    {
        public UnemployedRoom(DatabaseMaster dataMaster)
        {
            this.databaseMaster = dataMaster;
            this.unemployed = new Unemployed(dataMaster);
            InitializeComponent();
        }

        private void UnemployedRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.unemployed.ViewVacancies(this.dataGridView);
            this.panel3.Controls.Add(this.dataGridView);
        }
    }
}
