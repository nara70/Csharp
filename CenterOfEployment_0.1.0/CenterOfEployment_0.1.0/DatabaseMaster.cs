using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterOfEployment_0._1._0
{
    /// <summary>
    /// Клас управління базою даних
    /// </summary>
    public class DatabaseMaster
    {
        /// <summary>
        /// Конструктор за замвчуванням
        /// </summary>
        public DatabaseMaster()
        {
            oleDbConnection = new System.Data.OleDb.OleDbConnection();
            oleDbCommand = new System.Data.OleDb.OleDbCommand();
        }
        /// <summary>
        /// Створення з'єднання з базою даних
        /// </summary>
        /// <param name="dataSource">шлях до бази даних</param>
        public void SetConnection(string dataSource)
        {
            this.connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + dataSource + "\"";
        }
        /// <summary>
        /// Реєстрація нового користувача
        /// </summary>
        /// <param name="login">логін</param>
        /// <param name="password">пароль</param>
        /// <param name="rights">Права доступу</param>
        public int RegisterNewUser(string login, string password, string rights)
        {
            int flag;
            this.oleDbConnection.Open();
            this.oleDbCommand.CommandText = "INSERT INTO `Users` (`Login`, `Password`, `Rights`) VALUES ('"
                                            + login + "', '" + password + "', '" + rights + "')";
            this.oleDbCommand.Connection = this.oleDbConnection;
            try
            {
                this.oleDbCommand.ExecuteNonQuery();
                //MessageBox.Show("Ви успішно зареєстровані!");
                flag = 0;
            }
            catch
            {
                MessageBox.Show("Error");
                flag = 1;
            }
            this.oleDbConnection.Close();
            return flag;
        }
        /// <summary>
        /// Реєстрація нового безробітнього
        /// </summary>
        /// <param name="firstName">Ім'я</param>
        /// <param name="secondName">По батькові</param>
        /// <param name="surname">Прізвище</param>
        /// <param name="acountID">ID акаунта</param>
        public int RegisterNewUnemployed(string firstName, string secondName, string surname, int acountID)
        {
            int flag;
            string commandText = "INSERT INTO `Unemployed` (`FirstName`, `SecondName`, `Surname`, `AcountID`) VALUES ('"
                                            + firstName + "', '" + secondName + "', '" + surname + "', '" + acountID + "')";
            this.oleDbConnection.Open();
            this.oleDbCommand.CommandText = commandText;
            this.oleDbCommand.Connection = this.oleDbConnection;
            try
            {
                this.oleDbCommand.ExecuteNonQuery();
                MessageBox.Show("Ви успішно зареєстровані!");
                flag = 0;
            }
            catch
            {
                MessageBox.Show("Error");
                flag = 1;
            }
            this.oleDbConnection.Close();
            return flag;
        }
        /// <summary>
        /// Реєстрація нового роботодавця
        /// </summary>
        /// <param name="companyName">Назва компанії</param>
        /// <param name="address">Адреса</param>
        /// <param name="acountID">ID акаунта</param>
        public int RegisterNewEmployer(string companyName, string address, int acountID)
        {
            int flag;
            string commandText = "INSERT INTO `Employer` (`CompanyName`, `Address`, `AcountID`) VALUES ('"
                                            + companyName + "', '" + address + "', '" + acountID + "')";
            this.oleDbConnection.Open();
            this.oleDbCommand.CommandText = commandText;
            this.oleDbCommand.Connection = this.oleDbConnection;
            try
            {
                this.oleDbCommand.ExecuteNonQuery();
                MessageBox.Show("Ви успішно зареєстровані!");
                flag = 0;
            }
            catch
            {
                MessageBox.Show("Error");
                flag = 1;
            }
            this.oleDbConnection.Close();
            return flag;
        }
        /// <summary>
        /// Властивість з'єднання з базою даних 
        /// </summary>
        public System.Data.OleDb.OleDbConnection connection
        {
            get { return this.oleDbConnection; }
            set { this.oleDbConnection = value; }
        }
        private System.Data.OleDb.OleDbConnection oleDbConnection;
        private System.Data.OleDb.OleDbCommand oleDbCommand;
    }
}
