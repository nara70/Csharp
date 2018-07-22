using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Task_1 : Form
    {
        public Task_1()
        {
            InitializeComponent();
        }
        DataView CustomersDataView;
        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbDataReader myReader;
            string CustomerString;
            oleDbConnection1.Open();
            myReader = oleDbCommand1.ExecuteReader();
            while (myReader.Read())
            {
                // // Витягнути список імен і прізвищ з таблиці 
                // // Замовники і виконати їх контактенацию.
                CustomerString = myReader[1].ToString() + " " + myReader[2].ToString();
                // // Додати результат в список ListBox
                listBox1.Items.Add(CustomerString);
            }
            myReader.Close(); oleDbConnection1.Close();

            //// // Завантаження таблиці даними : заказчикиTableAdapter1.Fill(цукеркова_фабрикаDataSet1.Замовники);
            //// // Налаштування об'єкту DataView
            //CustomersDataView = new DataView(candy_FactoryDataSet1.Customers);
            //// // Налаштування dataGridView для відображення даних
            //dataGridView1.DataSource = CustomersDataView;
            //// // Привласнення початкового порядку сортування
            //CustomersDataView.Sort = "Surname";


        }
    }
}
