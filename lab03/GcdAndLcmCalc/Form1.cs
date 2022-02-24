using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GcdAndLcmCalc
{
    static class Calculator
    {
        public static int Gcd(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if (a == b)
                return a;
            if (a > b)
                return Gcd(a - b, b);
            return Gcd(a, b - a);
        }

        public static int Lcm(int a, int b)
        {
            return a * b / Gcd(a, b);
        }
    }
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findGCDBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int gcd = Calculator.Gcd(a, b);
                textBox3.Text = gcd.ToString();
            }
            catch (Exception)
            {
                statusBox.Text = "[Error] Please enter valid numbers";
            }
        }

        private void findLCMBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int lcm = Calculator.Lcm(a, b);
                textBox3.Text = lcm.ToString();
            }
            catch (Exception)
            {
                statusBox.Text = "[Error] Please enter valid numbers";
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}