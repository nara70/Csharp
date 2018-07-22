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
    public partial class Task_9 : Form
    {
        public Task_9()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(17, 96);
                lbl.Size = new System.Drawing.Size(50, 23);
                lbl.Name = "label";
                lbl.TabIndex = 2;
                lbl.Text = "PIN 2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(96, 96);
                txt.Size = new System.Drawing.Size(184, 20);
                txt.Name = "textboxx"; txt.TabIndex = 1;
                txt.Text = "";
                txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле Name не може містити цифри");
            }
            errorProvider1.SetError(textBox1, "Must be letter");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле Name не може містити цифри");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBox2.Text); e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не може мати букви");
                }
            }
        }

        private void task9_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
