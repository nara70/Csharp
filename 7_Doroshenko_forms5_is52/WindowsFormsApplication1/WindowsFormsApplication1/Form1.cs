using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task_1 task1 = new Task_1();
            task1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task_2 task2 = new Task_2();
            task2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task_3 task3 = new Task_3();
            task3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WinDataBinding winDataBinding = new WinDataBinding();
            winDataBinding.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WinDataSourcesWizard winDataSourcesWizard = new WinDataSourcesWizard();
            winDataSourcesWizard.Show();
        }
    }
}
