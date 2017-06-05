using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            textBox1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            textBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            textBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            textBox1.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            textBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            textBox1.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            textBox1.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            textBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            textBox1.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            textBox1.Text += input;
        }

        private void Dot_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void add_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
        }
    }
}
