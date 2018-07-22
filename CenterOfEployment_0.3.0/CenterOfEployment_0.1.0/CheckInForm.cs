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
    public partial class CheckInForm : Form
    {
        public CheckInForm(DatabaseMaster dataMaster)
        {
            InitializeComponent();
            this.databaseMaster = dataMaster;
            this.checkInFormUser = new CheckInFormUser(databaseMaster);
            checkInFormUser.TopLevel = false;
            checkInFormUser.FormBorderStyle = FormBorderStyle.None;
            checkInFormUser.Dock = DockStyle.Fill;
            checkInFormUser.Visible = true;
            this.panel1.Controls.Add(checkInFormUser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = this.databaseMaster.RegisterNewUser(this.checkInFormUser.text1.Text, this.checkInFormUser.text2.Text, this.checkInFormUser.comboBox.Text);
            if (flag == 0)
            {
                System.Data.OleDb.OleDbCommand oleDbCommand = new System.Data.OleDb.OleDbCommand();
                this.databaseMaster.connection.Open();
                oleDbCommand.CommandText = "SELECT `ID` FROM `Users` WHERE `Login` = '" + this.checkInFormUser.text1.Text + "'";
                oleDbCommand.Connection = this.databaseMaster.connection;
                try
                {
                    this.id = (int)oleDbCommand.ExecuteScalar();
                }
                catch
                {
                    MessageBox.Show("ID wasn`t saved!");
                }
                this.databaseMaster.connection.Close();
                this.panel1.Controls.Remove(this.checkInFormUser);
                this.tableLayoutPanel1.Controls.Remove(this.button1);
                if (this.checkInFormUser.comboBox.Text == "Знайти роботу")
                {
                    this.checkInFormUnemployed = new CheckInFormUnemployed();
                    this.checkInFormUnemployed.TopLevel = false;
                    this.checkInFormUnemployed.FormBorderStyle = FormBorderStyle.None;
                    this.checkInFormUnemployed.Dock = DockStyle.Fill;
                    this.checkInFormUnemployed.Visible = true;
                    this.panel1.Controls.Add(this.checkInFormUnemployed);
                    this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
                }
                else if (this.checkInFormUser.comboBox.Text == "Знайти співробітника")
                {
                    this.checkInFormEmployer = new CheckInFormEmployer();
                    this.checkInFormEmployer.TopLevel = false;
                    this.checkInFormEmployer.FormBorderStyle = FormBorderStyle.None;
                    this.checkInFormEmployer.Dock = DockStyle.Fill;
                    this.checkInFormEmployer.Visible = true;
                    this.panel1.Controls.Add(this.checkInFormEmployer);
                    this.tableLayoutPanel1.Controls.Add(this.button3, 1, 0);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int flag = this.databaseMaster.RegisterNewUnemployed(this.checkInFormUnemployed.firstName.Text, this.checkInFormUnemployed.secondName.Text, this.checkInFormUnemployed.surname.Text, this.id);
            if (flag == 0)
            {
                this.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int flag = this.databaseMaster.RegisterNewEmployer(this.checkInFormEmployer.companyName.Text, this.checkInFormEmployer.address.Text, this.id);
            if (flag == 0)
            {
                this.Close();
            }
        }
    }
}
