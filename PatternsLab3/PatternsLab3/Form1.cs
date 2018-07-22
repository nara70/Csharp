using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.calculator = new Context();
            a = 0;
            b = 0;
        }

        private bool onOperation = false;
        private double a;
        private double b;
        private string operation;

        private Context calculator;

        private void buttonClick(object sender, EventArgs e)
        {
            if(this.onOperation)
            {
                this.textBox1.Text = "";
                this.onOperation = false;
            }
            Button button = (Button)sender;
            this.textBox1.Text = textBox1.Text + button.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            this.onOperation = true;
            Button button = (Button)sender;
            this.label1.Text = textBox1.Text + " " + button.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.onOperation = true;

            this.label1.Text = this.label1.Text + " " + this.textBox1.Text;
            string[] words = this.label1.Text.Split(' ');
            try
            {
                this.a = Double.Parse(words[0]);
                this.operation = words[1];
                this.b = Double.Parse(words[2]);
            }
            catch (Exception exep)
            {

            }

            if(this.operation == "+")
            {
                this.calculator.SetStrategy(new ConcreteStrategyAdd());
            }

            if (this.operation == "-")
            {
                this.calculator.SetStrategy(new ConcreteStrategySubtract());
            }

            if (this.operation == "*")
            {
                this.calculator.SetStrategy(new ConcreteStrategyMultiply());
            }
            if (this.operation == "/")
            {
                this.calculator.SetStrategy(new ConcreteStrategyDivide());
            }

            this.textBox1.Text = this.calculator.ExecuteStrategy(this.a, this.b).ToString();
            this.a = 0;
            this.b = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.label1.Text = "";
        }
    }
}
