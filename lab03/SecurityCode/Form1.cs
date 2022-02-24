using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button0.Select();
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            listAccessBox.Items.Clear(); ;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string date = dt.ToString("dd/MM/yyyy hh:mm:ss");
            switch (textBox1.Text)
            {
                case "1645":
                    listAccessBox.Items.Add(date + "\tTechnicians");
                    break;
                case "1689":
                    listAccessBox.Items.Add(date + "\tTechnicians");
                    break;
                case "8345":
                    listAccessBox.Items.Add(date + "\tCustodians");
                    break;
                case "9998":
                    listAccessBox.Items.Add(date + "\tScientist");
                    break;
                case "1006":
                    listAccessBox.Items.Add(date + "\tScientist");
                    break;
                case "1007":
                    listAccessBox.Items.Add(date + "\tScientist");
                    break;
                case "1008":
                    listAccessBox.Items.Add(date + "\tScientist");
                    break;
                default:
                    listAccessBox.Items.Add(date + "\tRestricted Access");
                    break;
            }
            textBox1.Text = "";
        }
        
        private void button_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = (Button)sender;
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                button1.PerformClick();
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                button2.PerformClick();
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                button3.PerformClick();
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                button4.PerformClick();
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                button5.PerformClick();
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                button6.PerformClick();
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                button7.PerformClick();
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                button8.PerformClick();
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                button9.PerformClick();
            }
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                button0.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(new FileStream("access.txt", FileMode.Append));
            foreach (string item in listAccessBox.Items)
            {
                if (item != "")
                {
                    sw.WriteLine(item);
                    textBox2.Text = "Successfully Saved";
                }
            }
            sw.Close();
        }
    }
}