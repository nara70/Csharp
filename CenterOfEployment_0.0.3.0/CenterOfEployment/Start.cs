using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterOfEployment
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dataLoader.AddConection(this.oleDbConnection1, openFileDialog1.FileName);
                MessageBox.Show(openFileDialog1.FileName);
                dataLoader.CreateDataGrid(this.oleDbConnection1, this.dataGridView1, this.dataSet1, this.oleDbDataAdapter1);
                this.InitializeDataAdapter();
                this.Controls.Add(this.dataGridView1);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                this.oleDbDataAdapter1.Update(dataSet1, "FullName");
                MessageBox.Show("Update");
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            this.cmd.CommandText = "UPDATE FullName SET FirstName = " + this.textBox1.Text + " WHERE Surname = '" + this.textBox2.Text + "'";
            this.cmd.Connection = this.oleDbConnection1;
            //this.oleDbDataAdapter1.UpdateCommand = this.cmd;
            //this.oleDbDataAdapter1.Update(dataSet1, "FullName");
            try
            {
                this.cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            this.Controls.Remove(this.dataGridView1);
            dataLoader.CreateDataGrid(this.oleDbConnection1, this.dataGridView1, this.dataSet1, this.oleDbDataAdapter1);
            oleDbDataAdapter1.Fill(dataSet1, "FullName");
            this.Controls.Add(this.dataGridView1);
            oleDbConnection1.Close();
        }
    }
}
