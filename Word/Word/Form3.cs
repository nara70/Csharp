using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.dataDataSet.User);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10 + Convert.ToInt16(this.userDataGridView[0, 1].Value);
            this.textBox1.Text = a.ToString();
            //this.textBox1.Text = this.userDataGridView[0, 1].Value.ToString();
        }
    }
}
