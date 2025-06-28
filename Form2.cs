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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += 10;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += '.';
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = "";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += '*';
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += '/';
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += '-';
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += '+';
        }

        private void buttonEqualTo_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "WIP";
        }

    }
}
