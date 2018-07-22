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
    public partial class ViewVacanciesForm : Form
    {
        public ViewVacanciesForm()
        {
            InitializeComponent();
            //this.dataSet1.Tables.Add("Vacancies");
            //this.dataView1 = new System.Data.DataView(dataSet.Tables[0]);
            this.dataView1 = new System.Data.DataView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox3.Text == "")
            {
                this.dataView1.RowFilter = "Company LIKE '%" + textBox1.Text + "%' AND " +
                                           "Profession LIKE '%" + textBox2.Text + "%'";
            }
            else
            {
                try
                {
                    this.dataView1.RowFilter = "Company LIKE '%" + textBox1.Text + "%' AND " +
                                               "Profession LIKE '%" + textBox2.Text + "%' AND " +
                                               "Salary >= " + textBox3.Text + " AND Salary <=" + textBox3.Text;
                }
                catch
                {
                    MessageBox.Show("Введені некоректні дані");
                }
            }
        }
    }
}
