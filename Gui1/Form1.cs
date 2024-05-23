using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int result = x + y;
                textBox3.Text = result.ToString();
            }
            catch (FormatException result)
            {
                MessageBox.Show("Please enter only numbers!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int result = x - y;
                textBox3.Text = result.ToString();
            }
            catch (FormatException result)
            {
                MessageBox.Show("Please enter only numbers!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int result = x * y;
                textBox3.Text = result.ToString();
            }
            catch (FormatException result)
            {
                MessageBox.Show("Please enter only numbers!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int result = x / y;
                textBox3.Text = result.ToString();
            }
            catch (DivideByZeroException y)
            {
                //Console.WriteLine("can't divide by zero!");
                MessageBox.Show("Can't divide by zero!");
            }
            catch (FormatException result)
            {
                MessageBox.Show("Please enter only numbers!");
            }
            catch (Exception result)
            {
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}
