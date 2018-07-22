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
    public partial class EmployerRoom : Form
    {
        public EmployerRoom(DatabaseMaster dataMaster)
        {
            this.employer = new Employer(dataMaster);
            InitializeComponent();
        }

        public EmployerRoom(DatabaseMaster dataMaster, string login)
        {
            InicializeEmployer(dataMaster, login);
            InitializeComponent();
        }

        public void InicializeEmployer(DatabaseMaster dataMaster, string login)
        {
            string compName;
            string addr;
            string cmd1Text = "SELECT `CompanyName` FROM `Employer` WHERE `AcountID` = " +
                              "(SELECT `ID` FROM `Users` WHERE `Login` = '" + login + "')";
            string cmd2Text = "SELECT `Address` FROM `Employer` WHERE `AcountID` = " +
                              "(SELECT `ID` FROM `Users` WHERE `Login` = '" + login + "')";
            System.Data.OleDb.OleDbCommand cmd1 = new System.Data.OleDb.OleDbCommand();
            System.Data.OleDb.OleDbCommand cmd2 = new System.Data.OleDb.OleDbCommand();
            dataMaster.connection.Open();
            cmd1.Connection = dataMaster.connection;
            cmd2.Connection = dataMaster.connection;
            cmd1.CommandText = cmd1Text;
            cmd2.CommandText = cmd2Text;
            try
            {
                compName = (string)cmd1.ExecuteScalar();
                addr = (string)cmd2.ExecuteScalar();
                this.employer = new Employer(login, compName, addr, dataMaster);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            dataMaster.connection.Close();
        }
        private void EmployerRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.addVacancyForm = new AddVacancyForm();
            this.addVacancyForm.TopLevel = false;
            this.addVacancyForm.FormBorderStyle = FormBorderStyle.None;
            this.addVacancyForm.Dock = DockStyle.Fill;
            this.addVacancyForm.Visible = true;
            this.panel3.Controls.Add(this.addVacancyForm);
            this.panel1.Controls.Remove(this.button1);
            this.panel2.Controls.Remove(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sal;
            int.TryParse(this.addVacancyForm.salary.Text, out sal);
            this.employer.AddVacancy("", this.addVacancyForm.profession.Text, this.addVacancyForm.requirements.Text, sal);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Remove(this.button3);
            this.panel2.Controls.Remove(this.button4);
            this.panel3.Controls.Remove(this.addVacancyForm);
            this.panel1.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
        }
    }
}
