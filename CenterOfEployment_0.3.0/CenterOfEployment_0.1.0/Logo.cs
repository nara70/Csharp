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
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програма для взаємодії безробітного та роботодавця. Якщо увійти в систему як безробітний то можна буде переглядати вакансії відправляти резюме. Якщо увійти як роботодавець то можна створювати опис вакансій, переглядати резюме претендентів та сповіщати їх про результати перегляду резюме. Детальніше про користування програмою можна дізнатися переглянувши документ ПЗ.docx а точніше керівництво користувача");
        }
    }
}
