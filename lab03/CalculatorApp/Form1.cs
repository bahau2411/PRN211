using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void sumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double sum = a + b;
                textBox3.Text = sum.ToString();
            }
            catch (Exception exception)
            {
                textBox4.Text = "[ERROR]: " + exception.Message;
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double sub = a - b;
                textBox3.Text = sub.ToString();
            }
            catch (Exception exception)
            {
                textBox4.Text = "[ERROR]: " + exception.Message;
            }
        }

        private void multipleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double multiple = a * b;
                textBox3.Text = multiple.ToString();
            }
            catch (Exception exception)
            {
                textBox4.Text = "[ERROR]: " + exception.Message;
            }
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double divide = a / b;
                textBox3.Text = divide.ToString();
            }
            catch (Exception exception)
            {
                textBox4.Text = "[ERROR]: " + exception.Message;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; 
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}