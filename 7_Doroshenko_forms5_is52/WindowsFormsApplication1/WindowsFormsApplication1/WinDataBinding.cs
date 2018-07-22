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
    public partial class WinDataBinding : Form
    {
        public WinDataBinding()
        {
            InitializeComponent();
        }
        private BindingSource sotrBindingSourse;
        private void WinDataBinding_Load(object sender, EventArgs e)
        {
            // // Завантаження таблиці даними : 
            coWorkersTableAdapter1.Fill(candy_FactoryDataSet11.CoWorkers);
            // // Створення BindingSource для таблиці Співробітники: 
            sotrBindingSourse = new BindingSource(candy_FactoryDataSet11, "CoWorkers");
            // // Налаштування зв'язування для елементів TextBox :
            FamtextBox.DataBindings.Add("Text", sotrBindingSourse, "Surname");
            NametextBox.DataBindings.Add("Text", sotrBindingSourse, "Name");
            SectiontextBox.DataBindings.Add("Text", sotrBindingSourse, "City");

        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MovePrevious();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MoveNext();
        }
    }
}
