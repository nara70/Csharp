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
    public class DatabaseLoader
    {
        public DatabaseLoader()
        {
            this.connection = new System.Data.OleDb.OleDbConnection();
            this.dataSet = new System.Data.DataSet();
            this.dataSet1 = new System.Data.DataSet();
            this.oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter();
            
        }

        private void InitializeDataAdapter()
        {
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1.CommandText = "SELECT * FROM FullName";
            this.oleDbSelectCommand1.Connection = this.connection;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `FullName` (`FirstName`, `SecondName`, `Surname`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.connection;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("SecondName", System.Data.OleDb.OleDbType.VarWChar, 0, "SecondName"),
            new System.Data.OleDb.OleDbParameter("Surname", System.Data.OleDb.OleDbType.VarWChar, 0, "Surname")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1.CommandText = "UPDATE `FullName` SET `FirstName` = @FirstName, `SecondName` = @SecondName, `Surname` = @Surname " +
                                                    "WHERE `ID` = @oldID";
            this.oleDbUpdateCommand1.Connection = this.connection;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("SecondName", System.Data.OleDb.OleDbType.VarWChar, 0, "SecondName"),
            new System.Data.OleDb.OleDbParameter("Surname", System.Data.OleDb.OleDbType.VarWChar, 0, "Surname"),
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_SecondName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SecondName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_SecondName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SecondName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Surname", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Surname", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Surname", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Surname", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `FullName` WHERE `ID` = @ID";
            this.oleDbDeleteCommand1.Connection = this.connection;
            this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "FullName", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("SecondName", "SecondName"),
                        new System.Data.Common.DataColumnMapping("Surname", "Surname")})});

            this.oleDbDataAdapter.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter.UpdateCommand = this.oleDbUpdateCommand1;
        }
        public void AddConection(string dataSourse)
        {
            this.connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + dataSourse + "\"";
        }
        public void CreateDataGrid(System.Windows.Forms.DataGridView dataGridView)
        {
            this.dataSet.Tables.Add("FullName");
            this.oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM FullName", this.connection);
            this.oleDbDataAdapter.Fill(dataSet, "FullName");
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
            this.InitializeDataAdapter();
        }
        public void CreateDataGrid1(System.Windows.Forms.DataGridView dataGridView)
        {
            this.dataSet.Tables.Add("Unemployed");
            this.oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Unemployed", this.connection);
            this.oleDbDataAdapter.Fill(dataSet, "Unemployed");
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
            dataGridView.DataMember = "Unemployed";
            dataGridView.TabIndex = 2;
            this.InitializeDataAdapter();
        }

        public void UpdateDataBase()
        {
            try
            {
                this.oleDbDataAdapter.Update(dataSet, "FullName");
                MessageBox.Show("Update");
            }
            catch
            {
                MessageBox.Show("Couldn`t update");
            }
        }

        private System.Data.OleDb.OleDbConnection connection;
        private System.Data.DataSet dataSet;
        private System.Data.DataSet dataSet1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
    }
}
