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
    public partial class EmployerRoom : Form
    {
        public EmployerRoom(DatabaseMaster dataMaster)
        {
            this.employer = new Employer(dataMaster);
            InitializeComponent();
        }

        private void EmployerRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.addVacancyForm = new AddVacancyForm();
            this.addVacancyForm.TopLevel = false;
            this.addVacancyForm.FormBorderStyle = FormBorderStyle.None;
            this.addVacancyForm.Dock = DockStyle.Fill;
            this.addVacancyForm.Visible = true;
            this.panel3.Controls.Add(this.addVacancyForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sal;
            int.TryParse(this.addVacancyForm.salary.Text, out sal);
            this.employer.AddVacancy("", this.addVacancyForm.profession.Text, this.addVacancyForm.requirements.Text, sal);
        }
    }
}
