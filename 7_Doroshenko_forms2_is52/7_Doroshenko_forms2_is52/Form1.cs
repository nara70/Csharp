using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Doroshenko_forms2_is52
{
    /// <summary>
    /// Головне вікно застосування
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Відкриття першої вправи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            WinQuestion task_1 = new WinQuestion();
            task_1.Show();
        }
        /// <summary>
        /// Відкриття другої вправи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            TestList task_2 = new TestList();
            task_2.Show();
        }
        /// <summary>
        /// Відкриття третьої вправи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Task_3 task_3 = new Task_3();
            task_3.Show();
        }
        /// <summary>
        /// Відкриття індивідуального завдання
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Individual individual = new Individual();
            individual.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task_4 task_4 = new Task_4();
            task_4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WinContainer task_5 = new WinContainer();
            task_5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WinLinkLabel task_6 = new WinLinkLabel();
            task_6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WinLinkLabel2 task_7 = new WinLinkLabel2();
            task_7.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegistrationForm task_8 = new RegistrationForm();
            task_8.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Task_9 task_9 = new Task_9();
            task_9.Show();
        }
    }
}
