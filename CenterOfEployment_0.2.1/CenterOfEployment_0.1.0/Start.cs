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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        public Start(DatabaseMaster dataMaster)
        {
            this.databaseMaster = dataMaster;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                databaseMaster.SetConnection(openFileDialog1.FileName);
                MessageBox.Show(openFileDialog1.FileName);
            }
            Authorization login = new Authorization(this.databaseMaster);
            this.Visible = false;
            login.Show();
        }
    }
}
