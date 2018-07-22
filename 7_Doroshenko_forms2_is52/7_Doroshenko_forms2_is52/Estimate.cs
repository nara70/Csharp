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
    public partial class Estimate : Form
    {
        public Estimate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //MessageBox.Show("1");
                if(int.Parse(comboBox1.Text) > 100)
                {
                    double res = (1 - (int.Parse(comboBox1.Text) / 100) * 0.1) * int.Parse(textBox1.Text) * int.Parse(comboBox1.Text);
                    MessageBox.Show(res.ToString());
                }
                else
                {
                    double res = int.Parse(textBox1.Text) * int.Parse(comboBox1.Text);
                    MessageBox.Show(res.ToString());
                }
            }
            else if (radioButton2.Checked == true)
            {
                //MessageBox.Show("2");
                if (int.Parse(comboBox1.Text) > 100)
                {
                    double res = (1 - (int.Parse(comboBox1.Text) / 100) * 0.05) * int.Parse(textBox1.Text) * int.Parse(comboBox1.Text);
                    MessageBox.Show(res.ToString());
                }
                else
                {
                    double res = int.Parse(textBox1.Text) * int.Parse(comboBox1.Text);
                    MessageBox.Show(res.ToString());
                }
            }

        }
    }
}
