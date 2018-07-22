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

        private void InitializeDataBase()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1.CommandText = "SELECT * FROM FullName";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `FullName` (`FirstName`, `SecondName`, `Surname`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("SecondName", System.Data.OleDb.OleDbType.VarWChar, 0, "SecondName"),
            new System.Data.OleDb.OleDbParameter("Surname", System.Data.OleDb.OleDbType.VarWChar, 0, "Surname")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            //this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.CommandText = "UPDATE `FullName` SET `FirstName` = @FirstName, `SecondName` = @SecondName, `Surname` = @Surname " + 
                                                    "WHERE `ID` = @oldID";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
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
            //this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `FullName` WHERE `ID` = @ID";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_SecondName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SecondName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_SecondName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SecondName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Surname", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Surname", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Surname", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Surname", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "FullName", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("SecondName", "SecondName"),
                        new System.Data.Common.DataColumnMapping("Surname", "Surname")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Database files|*.mdb";
            openFileDialog1.Title = "Open database";
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
                this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
                this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + openFileDialog1.FileName + "\"";
                this.oleDbCommand1.CommandText = "SELECT * FROM FullName";
                this.oleDbCommand1.Connection = this.oleDbConnection1;
                MessageBox.Show(openFileDialog1.FileName);

                this.dataSet1.Tables.Add("FullName");
                this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM FullName", this.oleDbConnection1);
                this.oleDbDataAdapter1.Fill(dataSet1, "FullName");
                this.InitializeDataBase();

                this.dataGridView1 = new System.Windows.Forms.DataGridView();
                // 
                // dataGridView1
                // 
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.dataGridView1.Location = new System.Drawing.Point(0, 111);
                this.dataGridView1.Name = "dataGridView1";
                this.dataGridView1.Size = new System.Drawing.Size(353, 150);
                this.dataGridView1.DataSource = this.dataSet1;
                this.dataGridView1.DataMember = "FullName";
                this.dataGridView1.TabIndex = 2;
                {
                    //this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    //this.iDDataGridViewTextBoxColumn,
                    //this.firstNameDataGridViewTextBoxColumn,
                    //this.secondNameDataGridViewTextBoxColumn,
                    //this.surnameDataGridViewTextBoxColumn});
                }
                this.Controls.Add(this.dataGridView1);
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
                {
                    //// 
                    //// iDDataGridViewTextBoxColumn
                    //// 
                    //this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
                    //this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
                    //this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
                    //// 
                    //// nameDataGridViewTextBoxColumn
                    //// 
                    //this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
                    //this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
                    //this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
                    //// 
                    //// sectionDataGridViewTextBoxColumn
                    //// 
                    //this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
                    //this.secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
                    //this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
                    //// 
                    //// surnameDataGridViewTextBoxColumn
                    //// 
                    //this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
                    //this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
                    //this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
                }
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
    }
}
