using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CsTest
{
    /// <summary>
    /// Class works with data
    /// </summary>
    class DataMaster
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DataMaster()
        {
            this.dataSet = new DataSet();
            SetConnectionString();
            try
            {
                this.connection = new SqlConnection(this.connectionString);
            }
            catch(ArgumentException exception) // if connection string is invalid then catch exception
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
            SetTableName();
            this.commandString = "SELECT * FROM " + this.tableName + ";";
            this.dataAdapter = new SqlDataAdapter(this.commandString, this.connection);
        }

        private string connectionString;
        private string commandString;

        private DataSet dataSet;
        private SqlDataAdapter dataAdapter;
        private SqlConnection connection;

        private string tableName;
        /// <summary>
        /// Method get connection string from configuration file
        /// </summary>
        public void SetConnectionString()
        {
            try
            {
                this.connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            }
            catch(NullReferenceException exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
        }
        /// <summary>
        /// Method get name of the table
        /// </summary>
        public void SetTableName()
        {
            try
            {
                this.connection.Open();
                this.tableName = (string)connection.GetSchema("Tables").Rows[0][0];
            }
            catch(SqlException exception)//if can`t connect to server
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
            catch (InvalidOperationException exception)//if connectionString property has not been initialized
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
            catch (NullReferenceException exception)//if Sqlconection object has not been initialized
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
        /// <summary>
        ///Method fills list of colums with values
        /// </summary>
        /// <param name="columns">list that must be filled</param>
        public void SetColumns(List<Column> columns)
        {
            try
            {
                this.connection.Open();
                int i = 0;//position
                foreach (DataRow row in connection.GetSchema("Columns").Rows)//for each column in table
                {
                    columns.Add(
                        new Column(new System.Windows.Forms.CheckBox(), (string)row[7]/*type of column*/)
                        );
                    columns.Last().checkBox.Text = (string)row[3];//add name of column
                    columns.Last().checkBox.AutoSize = true;
                    columns.Last().checkBox.Location = new System.Drawing.Point(i, 38);
                    columns.Last().checkBox.UseVisualStyleBackColor = true;
                    i += 110;
                }
            }
            catch (SqlException exception)//if can`t connect to server
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
            catch (InvalidOperationException exception)//if connectionString property has not been initialized
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
            catch (NullReferenceException exception)//if Sqlconection object has not been initialized
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
        /// <summary>
        /// Method creates sql command
        /// </summary>
        /// <param name="columns">list of columns</param>
        public void SetCommandString(List<Column> columns)
        {
            List<string> numericalTypes = new List<string>{
                "bigint", "numeric", "bit", "smallint", "decimal",
                "smallmoney", "int", "tinyint", "money", "float", "real"};

            string selectPart = "SELECT";
            string groupbyPart = " GROUP BY";

            var q1 = from x in columns
                     where !numericalTypes.Contains(x.type) && x.checkBox.Checked
                     select x;         //select all columns which type is not numerical and which were chosen
            var q2 = from x in columns
                     where numericalTypes.Contains(x.type)
                     select x;         //select all columns with numerical types
            var q3 = from x in columns
                     where !numericalTypes.Contains(x.type) && !x.checkBox.Checked
                     select x;         //select all columns which type is not numerical and which were not chosen

            if (q1.Count() != 0 && q3.Count() != 0)
            {//if not all columns was chosen and at list one was chosen
                foreach (var x in q1)
                {//for each chosen column
                    if (selectPart != "SELECT") { selectPart += ","; groupbyPart += ","; }//if there was not columns like this one before
                    selectPart += " " + x.checkBox.Text;//add to select part
                    groupbyPart += " " + x.checkBox.Text;//add to group by part
                }
                foreach (var x in q2)
                {//for each numerical column
                    selectPart += ", SUM(" + x.checkBox.Text + ") AS " + x.checkBox.Text;//sum
                }

                this.commandString = selectPart + " FROM " + this.tableName + groupbyPart + ";";
            }
            else
            {//if any column was not chosen or all columns were chosen
                this.commandString = "SELECT * FROM " + this.tableName + ";";
            }
        }
        /// <summary>
        /// Method fills dataGriedView
        /// </summary>
        /// <param name="gridView">DataGridView that must be filled</param>
        /// <param name="columns">list of columns</param>
        public void FillGridView(System.Windows.Forms.DataGridView gridView, List<Column> columns)
        {
            this.dataSet = new DataSet();
            SetCommandString(columns);
            this.dataAdapter = new SqlDataAdapter(this.commandString, this.connection);
            try
            {
                this.connection.Open();
                this.dataSet.Tables.Add(this.tableName);
                this.dataAdapter.Fill(this.dataSet, this.tableName);
                gridView.DataSource = this.dataSet;
                gridView.DataMember = this.tableName;
            }
            catch (SqlException exception)//if can`t connect to server
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
            catch (InvalidOperationException exception)//if connectionString property has not been initialized
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
            catch (NullReferenceException exception)//if Sqlconection object has not been initialized
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
