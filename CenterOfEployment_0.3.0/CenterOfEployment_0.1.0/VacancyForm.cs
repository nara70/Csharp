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
    public partial class VacancyForm : Form
    {
        public VacancyForm()
        {
            InitializeComponent();
        }

        public VacancyForm(Unemployed unempl, int id, string name)
        {
            this.unemployed = unempl;
            this.vacancyID = id;
            this.companyName = name;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillInResumeForm fillInResumeForm = new FillInResumeForm(this.unemployed, this.vacancyID, this.companyName);
            fillInResumeForm.Show();
        }
    }
}
