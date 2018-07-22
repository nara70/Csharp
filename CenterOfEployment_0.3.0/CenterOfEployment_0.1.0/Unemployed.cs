using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterOfEployment_0._1._0
{
    /// <summary>
    /// Клас безробітного
    /// </summary>
    public class Unemployed : User
    {
        /// <summary>
        /// Конструктор ініціалізації
        /// </summary>
        /// <param name="newLogin">Логін</param>
        /// <param name="newPassword">Пароль</param>
        /// <param name="fName">Ім'я</param>
        /// <param name="secName">По батькові</param>
        /// <param name="surName">Прізвище</param>
        /// <param name="dataMaster">Мастер управління базою даних</param>
        public Unemployed(string newLogin, string fName, string secName, string surName, DatabaseMaster dataMaster)
        {
            this.login = newLogin;
            this.firstName = fName;
            this.secondName = secName;
            this.surname = surName;
            this.databaseMaster = dataMaster;
        }

        public Unemployed(DatabaseMaster dataMaster)
        {
            this.databaseMaster = dataMaster;
        }
        /// <summary>
        /// Перегляд вакансій
        /// </summary>
        /// <param name="dataGridView">Таблиця</param>
        /// <param name="dataView">Наповнення</param>
        public void ViewVacancies(System.Windows.Forms.DataGridView dataGridView, System.Data.DataView dataView)
        {
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Tables.Add("Vacancies");
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT `ID`, `Company`, `Profession`, `Requirements`, `Salary` FROM Vacancies", this.databaseMaster.connection);
            oleDbDataAdapter.Fill(dataSet, "Vacancies");
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
        /// <summary>
        /// Перегляд сповіщень
        /// </summary>
        /// <param name="dataGridView">таблиця</param>
        /// <param name="dataView">наповнення</param>
        public void ViewMessages(System.Windows.Forms.DataGridView dataGridView, System.Data.DataView dataView)
        {
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Tables.Add("Message");
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Message", this.databaseMaster.connection);
            oleDbDataAdapter.Fill(dataSet, "Message");
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
        /// <summary>
        /// Заповнення резюме
        /// </summary>
        /// <param name="education">Освіта</param>
        /// <param name="lastWork">Останнє місце роботи</param>
        /// <param name="birth">Дата народження</param>
        /// <param name="address">адреса</param>
        /// <param name="email">улектронна адреса</param>
        /// <param name="phoneNumber">номер телефону</param>
        /// <param name="goal">Ціль</param>
        /// <param name="vacancyID">Вакансія</param>
        /// <param name="companyName">назва компанії</param>
        public void FillInResume(string education, string lastWork, string birth, string address, 
                                 string email, string phoneNumber, string goal, int vacancyID, string companyName)
        {
            string commandText = "INSERT INTO `Resume` (`Education`, `LastWork`, `Birth`, `Address`, "+
                                 "`Email`, `PhoneNumber`, `Goal`, `VacancyID`, `CompanyName`, `UnemployedID`) " +
                                 "SELECT '" + education + "', '" + lastWork + "', '" + birth + "', '" +
                                 address + "', '" + email + "', '" + phoneNumber + "', '" + goal + "', " +
                                 vacancyID + ", '" + companyName + "', `ID` FROM `Unemployed` WHERE `AcountID` = " +
                                 "(SELECT `ID` FROM `Users` WHERE `Login` = '" + this.login + "')";

            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(); this.databaseMaster.connection.Open();
            cmd.CommandText = commandText;
            cmd.Connection = this.databaseMaster.connection;
            //cmd.ExecuteNonQuery();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Резюме відправлено!");
            }
            catch
            {
                MessageBox.Show("Не всі поля заповнені!");
            }
            this.databaseMaster.connection.Close();
        }

        private string firstName;
        private string secondName;
        private string surname;
        private DatabaseMaster databaseMaster;
    }
}
