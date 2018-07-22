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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(16, 96);
                lbl.Size = new System.Drawing.Size(52, 23);
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PIN 2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(96, 96);
                txt.Size = new System.Drawing.Size(184, 20);
                txt.Name = "textboxx"; txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
            }
            else
            {
                int count;
                count = groupBox1.Controls.Count;// визначається кількість 
                while (count > 0)
                {
                    groupBox1.Controls.RemoveAt(count - 1);
                    count -= 1;
                }

            }

        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
