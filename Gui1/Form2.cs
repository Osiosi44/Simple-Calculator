using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.richTextBox1.KeyDown += new KeyEventHandler(this.Form2_KeyDown);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string zerotonine = ".,0,1,2,3,4,5,6,7,8,9";
            string input = richTextBox1.Text;

            List<char> oper = new List<char>();

            //containing operations
            foreach (char x in input)
            {
                if (!zerotonine.Contains(x))
                {
                    oper.Add(x);
                }
            }
            //containing numbers
            string[] splitedinput = input.Split('+', '-', '*', '÷', '%', '/');
            List<double> nu = new List<double>();

            foreach (string number in splitedinput)
            {
                nu.Add(double.Parse(number));
            }

            double result = nu[0];
            //int size = nu.Count;

            for (int i = 0; i < oper.Count; i++)
            {
                result = go(oper[i], i, result, nu[i + 1]);
            }


            richTextBox1.Text += " = " + result.ToString();
        }

        double go(char x, int i, double y, double z)
        {
            switch (x)
            {
                case '+':
                    try { double res = y + z; }
                    catch(FormatException res)
                    {
                        MessageBox.Show("Enter only numbers!");
                    }
                    return y + z;
                case '-':
                    try { double res = y - z; }
                    catch (FormatException res)
                    {
                        MessageBox.Show("Enter only numbers!");
                    }
                    return y - z;
                case '*':
                case 'x':
                    try { double res = y * z; }
                    catch (FormatException res)
                    {
                        MessageBox.Show("Enter only numbers!");
                    }
                    return y * z;
                case '÷':
                case '/':
                    try { double res = y / z; }
                    catch (FormatException res)
                    {
                        MessageBox.Show("Enter only numbers!");
                    }
                    catch(DivideByZeroException res)
                    {
                        MessageBox.Show("Can't divide by zero!!");
                    }
                    return y / z;
                case '%': //module
                    try { double res = y % z; }
                    catch (FormatException res)
                    {
                        MessageBox.Show("Enter only numbers!");
                    }
                    return y % z;
                default:
                    try { }
                    catch (ArgumentException d)
                    {
                        MessageBox.Show("There is an invalid operator!!");
                    }
                    return 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //string input = richTextBox1.Text;
            richTextBox1.Text += '+';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //string input = richTextBox1.Text;
            richTextBox1.Text += '-';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //string input = richTextBox1.Text;
            richTextBox1.Text += '*';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //string input = richTextBox1.Text;
            richTextBox1.Text += '÷';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '9';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int position = richTextBox1.SelectionStart;

            if (position > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(position - 1, 1);
                richTextBox1.SelectionStart = position - 1;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '.';
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button16_Click(sender, e);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += '%';
        }
    }
}
