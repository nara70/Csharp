using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CsTest
{
    public partial class Form1 : Form
    {
        private List<Column> columns;//list of columns of table
        private DataMaster dataMaster;

        public Form1()
        {
            InitializeComponent();

            this.dataMaster = new DataMaster();
            this.columns = new List<Column>();
            this.dataMaster.SetColumns(columns);
            foreach(Column column in this.columns)
            {
                this.groupBox1.Controls.Add(column.checkBox);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataMaster.FillGridView(this.dataGridView1, this.columns);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.dataMaster.FillGridView(this.dataGridView1, this.columns);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Column column in this.columns)
            {
                column.checkBox.Checked = false;
            }
            this.dataMaster.FillGridView(this.dataGridView1, this.columns);
        }
    }
}
