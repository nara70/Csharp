using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ViewVacancies(System.Windows.Forms.DataGridView dataGridView, System.Data.DataView dataView)
        {
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Tables.Add("Vacancies");
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT `Company`, `Profession`, `Requirements`, `Salary` FROM Vacancies", this.databaseMaster.connection);
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

        private string firstName;
        private string secondName;
        private string surname;
        private DatabaseMaster databaseMaster;
    }
}
