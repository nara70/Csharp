﻿using System;
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
            Task_1 task_1 = new Task_1();
            task_1.Show();
        }
        /// <summary>
        /// Відкриття другої вправи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Task_2 task_2 = new Task_2();
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
    }
}
