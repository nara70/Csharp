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
    class Employer : User
    {
        /// <summary>
        /// Конструктор ініціалізації
        /// </summary>
        /// <param name="newLogin">Логін</param>
        /// <param name="newPassword">Пароль</param>
        /// <param name="compName">Назва компанії</param>
        /// <param name="addr">Адреса компанії</param>
        /// /// <param name="dataMaster">Мастер управління базою даних</param>
        public Employer(string newLogin, string newPassword, string compName, string addr, DatabaseMaster dataMaster)
        {
            this.login = newLogin;
            this.password = newPassword;
            this.companyName = compName;
            this.address = addr;
            this.databaseMaster = dataMaster;
        }

        public Employer(DatabaseMaster dataMaster)
        {
            this.databaseMaster = dataMaster;
        }

        public void AddVacancy(string compName, string profession, string requirements, int salary)
        {
            string cmdString = "INSERT INTO `Vacancies` (`Company`, `Profession`, `Requirements`, `Salary`) VALUES ('"
                               + compName + "', '" + profession + "', '" + requirements + "', '" + salary + "')";
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

        private string companyName;
        private string address;
        private DatabaseMaster databaseMaster;
    }
}
