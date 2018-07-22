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

        private void button2_Click(object sender, EventArgs e)
        {
            this.viewResumesForm = new ViewResumesForm();
            this.viewResumesForm.TopLevel = false;
            this.viewResumesForm.FormBorderStyle = FormBorderStyle.None;
            this.viewResumesForm.Dock = DockStyle.Fill;
            this.viewResumesForm.Visible = true;
            this.employer.ViewResumes(this.viewResumesForm.dataGridView, this.viewResumesForm.dataView);
            this.viewResumesForm.tableLayoutPanel.Controls.Add(this.viewResumesForm.dataGridView, 0, 0);
            this.panel3.Controls.Add(this.viewResumesForm);
            this.panel1.Controls.Remove(this.button1);
            this.panel2.Controls.Remove(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button7);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.viewResumesForm.dataView.RowFilter = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.viewResumesForm.dataGridView.CurrentCell != null)
            {
                this.resumeForm = new ResumeForm(this.employer, Convert.ToInt16(this.viewResumesForm.dataGridView[8, this.viewResumesForm.dataGridView.CurrentCell.RowIndex].Value));
                //string firstName;
                //string secondName;
                //string surname;
                string resumeID = Convert.ToString(this.viewResumesForm.dataGridView[0, this.viewResumesForm.dataGridView.CurrentCell.RowIndex].Value);
                string cmd1Text = "SELECT `FirstName` FROM `Unemployed` WHERE `ID` = " +
                              "(SELECT `UnemployedID` FROM `Resume` WHERE `ID` = " + resumeID + ")";
                string cmd2Text = "SELECT `SecondName` FROM `Unemployed` WHERE `ID` = " +
                                  "(SELECT `UnemployedID` FROM `Resume` WHERE `ID` = " + resumeID + ")";
                string cmd3Text = "SELECT `Surname` FROM `Unemployed` WHERE `ID` = " +
                                  "(SELECT `UnemployedID` FROM `Resume` WHERE `ID` = " + resumeID + ")";
                System.Data.OleDb.OleDbCommand cmd1 = new System.Data.OleDb.OleDbCommand();
                System.Data.OleDb.OleDbCommand cmd2 = new System.Data.OleDb.OleDbCommand();
                System.Data.OleDb.OleDbCommand cmd3 = new System.Data.OleDb.OleDbCommand();
                this.employer.dataMaster.connection.Open();
                cmd1.Connection = this.employer.dataMaster.connection;
                cmd2.Connection = this.employer.dataMaster.connection;
                cmd3.Connection = this.employer.dataMaster.connection;
                cmd1.CommandText = cmd1Text;
                cmd2.CommandText = cmd2Text;
                cmd3.CommandText = cmd3Text;
                try
                {
                    //firstName = (string)cmd1.ExecuteScalar();
                    //secondName = (string)cmd2.ExecuteScalar();
                    //surname = (string)cmd3.ExecuteScalar();

                    this.resumeForm.firstName.Text = (string)cmd1.ExecuteScalar();
                    this.resumeForm.secondName.Text = (string)cmd2.ExecuteScalar();
                    this.resumeForm.surname.Text = (string)cmd3.ExecuteScalar();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                this.employer.dataMaster.connection.Close();
                //int id = Convert.ToInt16(this.viewResumesForm.dataGridView[0, this.viewResumesForm.dataGridView.CurrentCell.RowIndex].Value);
                //string name = Convert.ToString(this.viewResumesForm.dataGridView[1, this.viewResumesForm.dataGridView.CurrentCell.RowIndex].Value);
                
                //this.resumeForm = new ResumeForm(this.employer, id, name);
                //this.resumeForm.firstName.Text = firstName;
                //this.resumeForm.secondName.Text = ;
                //this.resumeForm.surname.Text = ;

                this.resumeForm.education.Text = Convert.ToString(this.viewResumesForm.dataGridView[1, this.viewResumesForm.dataGridView.CurrentCell.RowIndex].Value);
                this.resumeForm.lastWork.Text = Convert.ToString(this.viewResumesForm.dataGridView[2, this.viewResumesForm.dataGridView.CurrentCell.RowIndex].Value);
                this.resumeForm.birth.Text = Convert.ToString(this.viewResumesForm.dataGridView[3, this.viewResumesForm.dataGridView.CurrentCell.RowIndex].Value);
                this.resumeForm.address.Text = Convert.ToString(this.viewResumesForm.dataGridView[4, this.viewResumesForm.dataGridView.CurrentCell.RowIndex].Value);
                this.resumeForm.email.Text = Convert.ToString(this.viewResumesForm.dataGridView[5, this.viewResumesForm.dataGridView.CurrentCell.RowIndex].Value);
                this.resumeForm.phoneNumber.Text = Convert.ToString(this.viewResumesForm.dataGridView[6, this.viewResumesForm.dataGridView.CurrentCell.RowIndex].Value);
                this.resumeForm.goal.Text = Convert.ToString(this.viewResumesForm.dataGridView[7, this.viewResumesForm.dataGridView.CurrentCell.RowIndex].Value);
                this.resumeForm.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Remove(this.viewResumesForm);
            this.panel1.Controls.Remove(this.button5);
            this.panel2.Controls.Remove(this.button6);
            this.panel4.Controls.Remove(this.button7);
            this.panel1.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
        }
    }
}
