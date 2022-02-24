using System;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            listBox1.Items.Add("SEMESTER 5");
            listBox1.Items.Add("- PRN211");
            listBox1.Items.Add("- SWP311");
            listBox1.Items.Add("- SWR201");
            listBox1.Items.Add("- SWT301");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}