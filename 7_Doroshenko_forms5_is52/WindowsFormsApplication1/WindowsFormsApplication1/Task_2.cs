using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Task_2 : WindowsFormsApplication1.Task_1
    {
        public Task_2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Exercise2 = new Form2();
            Exercise2.Show();
        }
    }
}
