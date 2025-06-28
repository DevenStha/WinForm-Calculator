using System;
using System.Collections;
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

            // Initalize both arraylists
            //numbersList.Add("0");
            //operatorsList.Add(null);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private ArrayList numbersList = new ArrayList();
        private ArrayList operatorsList = new ArrayList();

        private int numberListIndex = 0;
        private int operatorsIndex = 0;

        private StringBuilder numbers = new StringBuilder();
        private StringBuilder operators = new StringBuilder();

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

            string textBoxArray = textBoxExpression.Text.ToArray;
            try
            {
                foreach(char character in textBoxExpression.Text)
                {
                    // because of course I can't directly parse char as they are basically integers !??!?, I think
                   int tmp = int.Parse(char.ToString(character));
                   numbers.Append(character);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void seperateNumAndOperators(string text)
        {

        }

    }
}
