using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Doroshenko_forms2_is52
{
    public partial class WinLinkLabel : Form
    {
        public WinLinkLabel()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            Form2 aForm = new Form2();
            aResult = aForm.ShowDialog();
            if (aResult == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Your name is " + aForm.textBox1.Text + "  " + aForm.textBox2.Text);
            }
            linkLabel1.LinkVisited = true;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.kpi.ua");
            linkLabel2.LinkVisited = true;

        }

        private void WinLinkLabel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
