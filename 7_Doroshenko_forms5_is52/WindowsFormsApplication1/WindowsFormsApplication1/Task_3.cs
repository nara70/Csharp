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
    public partial class Task_3 : Form
    {
        public Task_3()
        {
            InitializeComponent();
        }
        DataView CustomersDataView;
        private void button1_Click(object sender, EventArgs e)
        {
            // // Завантаження таблиці даними : 
            customersTableAdapter1.Fill(candy_FactoryDataSet1.Customers);
            // // Налаштування об'єкту DataView
            CustomersDataView = new DataView(candy_FactoryDataSet1.Customers);
            // // Налаштування dataGridView для відображення даних
            dataGridView1.DataSource = CustomersDataView;
            // // Привласнення початкового порядку сортування
            CustomersDataView.Sort = "Surname";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(dataSet11);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomersDataView.Sort = SortTextBox.Text;
            CustomersDataView.RowFilter = FilterTextBox.Text;
        }
    }
}
