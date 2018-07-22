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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataSource = "D:\\CSharp\\Word\\data.mdb";

            this.dataGridView.AutoGenerateColumns = true;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + dataSource + "\"";

            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM `User`", conn);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Tables.Add("User");
            adapter.Fill(dataSet, "User");
            //this.dataGridView.DataSource = dataSet;
            //this.dataGridView.DataMember = "User";
            System.Data.DataView dataView = new DataView();
            dataView.Table = dataSet.Tables[0];
            this.dataGridView.DataSource = dataView;
            this.Controls.Add(this.dataGridView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
