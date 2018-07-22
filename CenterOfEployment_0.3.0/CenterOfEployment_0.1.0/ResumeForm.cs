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
    public partial class ResumeForm : Form
    {
        public ResumeForm(Employer empl, int id)
        {
            this.employer = empl;
            this.recipientID = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.createMessageForm = new CreateMessageForm(this.employer, this.recipientID);
            this.createMessageForm.ShowDialog();
        }
    }
}
