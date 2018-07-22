﻿using System;
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
    public partial class WinContainer : Form
    {
        public WinContainer()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void but_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) this.but.Text = "First";
            else if (radioButton2.Checked == true) this.but.Text = "Second";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SetFlowBreak(button6, true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SetFlowBreak(button7, true);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button aButton = new Button();
            tableLayoutPanel1.Controls.Add(aButton, 1, 1);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (splitContainer1.FixedPanel == FixedPanel.Panel1) splitContainer1.FixedPanel = FixedPanel.None;
            else
                splitContainer1.FixedPanel = FixedPanel.Panel1;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            splitContainer1.IsSplitterFixed = !(!(splitContainer1.IsSplitterFixed));

        }

        private void button12_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !(!(splitContainer1.Panel1Collapsed));

        }

        private void WinContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
