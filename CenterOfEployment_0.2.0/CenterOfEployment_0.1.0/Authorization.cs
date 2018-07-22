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
    public partial class Authorization : Form
    {
        public Authorization(DatabaseMaster dataMaster)
        {
            InitializeComponent();
            this.databaseMaster = dataMaster;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckInForm checkIn = new CheckInForm(this.databaseMaster);
            checkIn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string commandText = "SELECT `Rights` FROM `Users` WHERE `Login` = '" + this.textBox1.Text + 
                                 "' AND `Password` = '" + this.textBox2.Text + "'";
            string rights = "None";
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            this.databaseMaster.connection.Open();
            cmd.Connection = this.databaseMaster.connection;
            cmd.CommandText = commandText;
            try
            {
                rights = (string)cmd.ExecuteScalar();
                //MessageBox.Show("Ви успішно авторизувалися!");
                //MessageBox.Show(rights);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            if(rights == "Знайти роботу")
            {
                UnemployedRoom unemployedRoom = new UnemployedRoom(this.databaseMaster);
                unemployedRoom.Show();
                this.Visible = false;
            }
            else if(rights == "Знайти співробітника")
            {
                EmployerRoom employerRoom = new EmployerRoom(this.databaseMaster);
                employerRoom.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Ви ввели не коректні дані. Спробуйте ще раз");
            }
            this.databaseMaster.connection.Close();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
