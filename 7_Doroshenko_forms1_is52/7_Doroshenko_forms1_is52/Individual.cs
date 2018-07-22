using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Doroshenko_forms1_is52
{
    /// <summary>
    /// Вікно індивідуального завдання
    /// </summary>
    public partial class Individual : Form
    {
        public Individual()
        {
            InitializeComponent();
        }

        private void Individual_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Закриття вікна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Зміна кольору фону
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumSpringGreen;
        }
        /// <summary>
        /// При закритті виводить повідомлення
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Individual_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Author: Anton Doroshenko");
        }
    }
}
