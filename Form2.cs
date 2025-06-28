using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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

        private bool endOfExpression = false;

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
            seperateNumAndOperators(textBoxExpression.Text);
            calculateExpression(numbersList, operatorsList);
        }

        private void seperateNumAndOperators(string text)
        {
            int index = 0;
            while (endOfExpression == false)
            {
                try
                {
                    for (int i = index; i < text.Length; i++)
                    {
                        // testing if the data is an valid int
                        int tmp = int.Parse(char.ToString(text[i]));
                        numbers.Append(text[i]);
                        index++;
                    }
                }
                catch (FormatException e)
                {
                    if (index < text.Length)
                    {
                        index++;

                        // Add operators to the operators list
                        switch (text[index - 1])
                        {
                            case '+':
                                operatorsList.Add(Operators.Add);
                                break;
                            case '-':
                                operatorsList.Add(Operators.Subtract);
                                break;
                            case '*':
                                operatorsList.Add(Operators.Multiply);
                                break;
                            case '/':
                                operatorsList.Add(Operators.Divide);
                                break;
                            default:
                                textBoxResult.Text = "Error! Invalid Expression!";
                                index = 0;
                                numbers.Clear();
                                numbersList.Clear();
                                operatorsList.Clear();
                                endOfExpression = true;
                                break;
                        }
                    }

                    // Add the number to the number lists
                    numbersList.Add(Convert.ToInt32(numbers.ToString()));
                    textBoxResult.Text = numbers.ToString();
                    numbers.Clear();

                }
                finally
                {
                    if (index >= text.Length)
                    {
                        endOfExpression = true;
                        index = 0;
                    }
                }
            }

        }

        private void calculateExpression(ArrayList numbers, ArrayList operators)
        {
            // very hacky, I think
            // here I am putting the operators index which has highest priorities as firstIndexes and lower priorities as last indexes
            // so I will compute from the index starting from the first and eventually reaching the final index

            ArrayList operatorIndexByHierarchy = new ArrayList();
            operatorIndexByHierarchy.Add(null);
            for (int index = 0; index < operatorsList.Count; index++)
            {
                if (operatorsList[index].Equals(Operators.Multiply) || operatorsList[index].Equals(Operators.Divide))
                {
                    operatorIndexByHierarchy.Insert(0, index);
                }
                else
                {
                    operatorIndexByHierarchy.Add(index);
                }
            }

            while (true)
            {

            }
        }
        private void EraseButton_Click(object sender, EventArgs e)
        {

            // So ^1 doesn't work here
            try
            {
                textBoxExpression.Text = textBoxExpression.Text.Remove(textBoxExpression.Text.Length - 1);
            }
            catch(ArgumentOutOfRangeException)
            {
            }
        }
    }
    public enum Operators { Add = 1, Subtract, Multiply, Divide }
}
