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
    public partial class UnemployedRoom : Form
    {
        public UnemployedRoom(DatabaseMaster dataMaster)
        {
            this.databaseMaster = dataMaster;
            this.unemployed = new Unemployed(dataMaster);
            InitializeComponent();
        }

        public UnemployedRoom(DatabaseMaster dataMaster, string login)
        {
            this.databaseMaster = dataMaster;
            InicializeUnemployed(login, dataMaster);
            InitializeComponent();
        }

        public void InicializeUnemployed(string login, DatabaseMaster dataMaster)
        {
            string fName;
            string secName;
            string surName;
            string cmd1Text = "SELECT `FirstName` FROM `Unemployed` WHERE `AcountID` = " + 
                              "(SELECT `ID` FROM `Users` WHERE `Login` = '" + login + "')";
            string cmd2Text = "SELECT `SecondName` FROM `Unemployed` WHERE `AcountID` = " +
                              "(SELECT `ID` FROM `Users` WHERE `Login` = '" + login + "')";
            string cmd3Text = "SELECT `Surname` FROM `Unemployed` WHERE `AcountID` = " +
                              "(SELECT `ID` FROM `Users` WHERE `Login` = '" + login + "')";
            System.Data.OleDb.OleDbCommand cmd1 = new System.Data.OleDb.OleDbCommand();
            System.Data.OleDb.OleDbCommand cmd2 = new System.Data.OleDb.OleDbCommand();
            System.Data.OleDb.OleDbCommand cmd3 = new System.Data.OleDb.OleDbCommand();
            dataMaster.connection.Open();
            cmd1.Connection = dataMaster.connection;
            cmd2.Connection = dataMaster.connection;
            cmd3.Connection = dataMaster.connection;
            cmd1.CommandText = cmd1Text;
            cmd2.CommandText = cmd2Text;
            cmd3.CommandText = cmd3Text;
            try
            {
                fName = (string)cmd1.ExecuteScalar();
                secName = (string)cmd2.ExecuteScalar();
                surName = (string)cmd3.ExecuteScalar();
                this.unemployed = new Unemployed(login, fName, secName, surName, dataMaster);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            dataMaster.connection.Close();
        }
        private void UnemployedRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.viewVacanciesForm = new ViewVacanciesForm();
            this.viewVacanciesForm.TopLevel = false;
            this.viewVacanciesForm.FormBorderStyle = FormBorderStyle.None;
            this.viewVacanciesForm.Dock = DockStyle.Fill;
            this.viewVacanciesForm.Visible = true;
            this.unemployed.ViewVacancies(this.viewVacanciesForm.dataGridView, this.viewVacanciesForm.dataView);
            this.viewVacanciesForm.tableLayoutPanel.Controls.Add(this.viewVacanciesForm.dataGridView, 0, 0);
            this.panel3.Controls.Add(this.viewVacanciesForm);
            this.panel1.Controls.Remove(this.button1);
            this.panel2.Controls.Remove(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.viewVacanciesForm.dataView.RowFilter = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Remove(this.viewVacanciesForm);
            this.panel1.Controls.Remove(this.button3);
            this.panel2.Controls.Remove(this.button4);
            this.panel4.Controls.Remove(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(this.viewVacanciesForm.dataGridView.CurrentCell != null)
            {
                this.vacancyForm = new VacancyForm();
                this.vacancyForm.requirements.Text = Convert.ToString(this.viewVacanciesForm.dataGridView[2, this.viewVacanciesForm.dataGridView.CurrentCell.RowIndex].Value);
                this.vacancyForm.company.Text = Convert.ToString(this.viewVacanciesForm.dataGridView[0, this.viewVacanciesForm.dataGridView.CurrentCell.RowIndex].Value);
                this.vacancyForm.profession.Text = Convert.ToString(this.viewVacanciesForm.dataGridView[1, this.viewVacanciesForm.dataGridView.CurrentCell.RowIndex].Value);
                this.vacancyForm.salary.Text = Convert.ToString(this.viewVacanciesForm.dataGridView[3, this.viewVacanciesForm.dataGridView.CurrentCell.RowIndex].Value);
                this.vacancyForm.Show();
            }
            //MessageBox.Show(Convert.ToString(this.viewVacanciesForm.dataGridView[0, this.viewVacanciesForm.dataGridView.CurrentCell.RowIndex].Value));
        }
    }
}
