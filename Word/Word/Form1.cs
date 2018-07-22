using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.connection = new System.Data.OleDb.OleDbConnection();
            InitializeComponent();
        }

        word.Application wapp;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                wapp = new word.Application();
                //word.Document tdoc = wapp.Documents.Add("D:\\CSharp\\Word\\template.docx");
                MessageBox.Show(Environment.CurrentDirectory);
                word.Document tdoc = wapp.Documents.Add(Environment.CurrentDirectory + "\\template.docx");
                tdoc.Bookmarks["Surname"].Range.Text = this.textBox1.Text;
                if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
                {
                    tdoc.SaveAs(saveFileDialog1.FileName);
                }
                tdoc.Close();
                MessageBox.Show("Документ успішно створено!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                wapp.Quit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dataSource = "D:\\CSharp\\Word\\data.mdb";
            openFileDialog1.Filter = "Database files|*.mdb";
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dataSource = openFileDialog1.FileName;
            }
            this.connection.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=\"" + dataSource +"\"";
            System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand();
            command.CommandText = "INSERT INTO `User` (`Surname`, `FirstName`, `SecondName`) VALUES " +
                                  "('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "')";
            command.Connection = this.connection;
            this.connection.Open();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Дані успішно занесені до БД!");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        private void колірToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
