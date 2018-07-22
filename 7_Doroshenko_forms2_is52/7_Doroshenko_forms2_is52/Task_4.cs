using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _7_Doroshenko_forms2_is52
{
    public partial class Task_4 : _7_Doroshenko_forms2_is52.WinQuestion
    {
        public Task_4()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }
        int openDocuments = 0;
        private void toolStrip1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Task_3 newChild = new Task_3(); /*newChild.MdiParent = this;*/ newChild.Show();
            newChild.Text = newChild.Text + " " + ++openDocuments;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            spWin.Text = "Windows is cascade";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            spWin.Text = "Windows is horizontal";
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }


    }
}
