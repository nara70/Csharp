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
    /// Вікно першої вправи
    /// </summary>
    public partial class Task_1 : Form
    {
        public Task_1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Зміна виду і поведінки межі і рядка заголовка форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
        /// <summary>
        /// Зміна розміру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }
        /// <summary>
        /// Зміна прозорості
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}