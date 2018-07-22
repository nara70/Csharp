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
    /// Трикутне вікно
    /// </summary>
    public partial class Task_2 : Form
    {
        public Task_2()
        {
            InitializeComponent();
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
        /// Задання трикутного відображення
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Task_2_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, 0), new Point(0, this.Height), new Point(this.Width, 0) });
            Region myRegion = new Region(myPath); this.Region = myRegion;

        }
    }
}