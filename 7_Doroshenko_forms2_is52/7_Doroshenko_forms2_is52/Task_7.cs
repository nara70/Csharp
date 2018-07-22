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
    public partial class WinLinkLabel2 : Form
    {
        public WinLinkLabel2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            Form3 aForm = new Form3();
            aResult = aForm.ShowDialog();
            if (aResult == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Your name is " + aForm.textBox1.Text + "  " + aForm.textBox2.Text);
                MessageBox.Show("Your address is " + aForm.textBox3.Text);
                MessageBox.Show("Your phone number is " + aForm.maskedTextBox1.Text);
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
