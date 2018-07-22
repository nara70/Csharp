using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterOfEployment_0._1._0
{
    /// <summary>
    /// Клас роботодавця
    /// </summary>
    public class Employer : User
    {
        /// <summary>
        /// Конструктор ініціалізації
        /// </summary>
        /// <param name="newLogin">Логін</param>
        /// <param name="newPassword">Пароль</param>
        /// <param name="compName">Назва компанії</param>
        /// <param name="addr">Адреса компанії</param>
        /// /// <param name="dataMaster">Мастер управління базою даних</param>
        public Employer(string newLogin, string compName, string addr, DatabaseMaster dataMaster)
        {
            this.login = newLogin;
            this.companyName = compName;
            this.address = addr;
            this.databaseMaster = dataMaster;
        }

        public Employer(DatabaseMaster dataMaster)
        {
            this.databaseMaster = dataMaster;
        }
        /// <summary>
        /// Додавання вакансії
        /// </summary>
        /// <param name="compName">Назва компанії</param>
        /// <param name="profession">Посада</param>
        /// <param name="requirements">Вимоги</param>
        /// <param name="salary">Зарплатня</param>
        public void AddVacancy(string compName, string profession, string requirements, int salary)
        {
            string cmdString = "INSERT INTO `Vacancies` (`Company`, `Profession`, `Requirements`, `Salary`) VALUES ('"
                               + this.companyName + "', '" + profession + "', '" + requirements + "', '" + salary + "')";
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            this.databaseMaster.connection.Open();
            cmd.CommandText = cmdString;
            cmd.Connection = this.databaseMaster.connection;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            this.databaseMaster.connection.Close();
        }
        /// <summary>
        /// Надсилання сповіщення
        /// </summary>
        /// <param name="recipientID">ID отримувача</param>
        /// <param name="message">Текс сповіщення</param>
        public void SendMessage(int recipientID, string message)
        {
            string cmdString2 = "SELECT `ID` FROM `Employer` WHERE `AcountID` = (SELECT `ID` FROM `Users` WHERE `Login` = '" + this.login + "')";
            int senderID = 0;
            System.Data.OleDb.OleDbCommand cmd2 = new System.Data.OleDb.OleDbCommand();
            this.databaseMaster.connection.Open();
            cmd2.CommandText = cmdString2;
            cmd2.Connection = this.databaseMaster.connection;
            try
            {
                senderID = (int)cmd2.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            this.databaseMaster.connection.Close();
            string cmdString1 = "INSERT INTO `Message` (`SenderID`, `RecipientID`, `MessageText`) VALUES ('"
                               + senderID + "', '" + recipientID + "', '" + message + "')";
            System.Data.OleDb.OleDbCommand cmd1 = new System.Data.OleDb.OleDbCommand();       
            this.databaseMaster.connection.Open();
            cmd1.CommandText = cmdString1;
            cmd1.Connection = this.databaseMaster.connection;
            try
            {
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Повідомлення успішно відправлене!");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            this.databaseMaster.connection.Close();
        }
        /// <summary>
        /// Перегляд резюме
        /// </summary>
        /// <param name="dataGridView">Таблиця</param>
        /// <param name="dataView">наповнення</param>
        public void ViewResumes(System.Windows.Forms.DataGridView dataGridView, System.Data.DataView dataView)
        {
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Tables.Add("Resume");
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM `Resume` WHERE `CompanyName` = '" + this.companyName + "'", this.databaseMaster.connection);
            oleDbDataAdapter.Fill(dataSet, "Resume");
            dataView.Table = dataSet.Tables[0];
            // 
            // dataGridView1
            // 
            dataGridView.AutoGenerateColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.Location = new System.Drawing.Point(0, 111);
            dataGridView.Name = "dataGridView1";
            dataGridView.Size = new System.Drawing.Size(353, 150);
            dataGridView.MultiSelect = false;
            //dataGridView.DataSource = dataSet;
            //dataGridView.DataMember = "Vacancies";
            dataGridView.DataSource = dataView;
            dataGridView.TabIndex = 2;
        }

        private string companyName;
        private string address;
        private DatabaseMaster databaseMaster;
        public DatabaseMaster dataMaster
        {
            get { return this.databaseMaster; }
            set { this.databaseMaster = value; }
        }
    }
}
