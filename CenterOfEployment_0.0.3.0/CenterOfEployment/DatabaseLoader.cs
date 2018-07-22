using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterOfEployment
{
    class DatabaseLoader
    {
        public DatabaseLoader()
        {
            //this.selfForm = form;
        }
        //private Start selfForm;
        public void AddConection(System.Data.OleDb.OleDbConnection oleDbConnection1, string dataSourse)
        {
            oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + dataSourse + "\"";
        }
        public void CreateDataGrid(System.Data.OleDb.OleDbConnection oleDbConnection1, System.Windows.Forms.DataGridView dataGridView, System.Data.DataSet dataSet, System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter)
        {
            dataSet.Tables.Add("FullName");
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM FullName", oleDbConnection1);
            oleDbDataAdapter.Fill(dataSet, "FullName");
            // 
            // dataGridView1
            // 
            dataGridView.AutoGenerateColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView.Location = new System.Drawing.Point(0, 111);
            dataGridView.Name = "dataGridView1";
            dataGridView.Size = new System.Drawing.Size(353, 150);
            dataGridView.DataSource = dataSet;
            dataGridView.DataMember = "FullName";
            dataGridView.TabIndex = 2;
        }
    }
}
