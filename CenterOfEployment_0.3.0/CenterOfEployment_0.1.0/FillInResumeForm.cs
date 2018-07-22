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
    public partial class FillInResumeForm : Form
    {
        public FillInResumeForm()
        {
            InitializeComponent();
        }

        public FillInResumeForm(Unemployed unempl, int id, string name)
        {
            this.unemployed = unempl;
            this.vacancyID = id;
            this.companyName = name;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.unemployed.FillInResume(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text,
                                         this.textBox4.Text, this.textBox5.Text, this.maskedTextBox1.Text,
                                         this.richTextBox1.Text, this.vacancyID, this.companyName);
        }
    }
}
