﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private List<double> numbersList = new List<double>();
        private List<Operators> operatorsList = new List<Operators>();

        private StringBuilder numbers = new StringBuilder();

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
            textBoxExpression.Text += 0;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += '.';
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = "";
            textBoxResult.Text = "";
            numbers.Clear();
            numbersList.Clear();
            operatorsList.Clear();
            endOfExpression = false;
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
            endOfExpression = false;

            // clearing because of weird issue happening when clicking equal multiple times
            numbers.Clear();
            numbersList.Clear();
            operatorsList.Clear();
            if (textBoxExpression.Text.Length > 0)
            {
                seperateNumAndOperators(textBoxExpression.Text);
                try
                {
                    numbersList.Add(Convert.ToDouble(numbers.ToString()));
                }
                catch (Exception)
                {
                    textBoxResult.Text = "Invalid Expression.";
                    HandleError();
                }
                calculateExpression(numbersList, operatorsList);
            }
            else
            {
                textBoxResult.Text = "Empty input";
            }

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
                        // Add operators to the operators list
                        switch (text[index])
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
                            case '.':
                                numbers.Append(text[index]);
                                break;
                            default:
                                index = 0;
                                HandleError();
                                break;
                        }
                    }

                    if (text[index] != '.')
                    {
                        try
                        {
                            // Add the number to the number lists
                            numbersList.Add(Convert.ToDouble(numbers.ToString()));
                            //textBoxResult.Text = numbers.ToString();
                            numbers.Clear();
                        }
                        catch (Exception)
                        {
                            textBoxResult.Text = "Invalid Expression.";
                            HandleError();
                        }
                    }
                    index++;

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

        private void calculateExpression(List<double> numbers, List<Operators> operators)
        {
            // very hacky, I think
            // here I am putting the operators index which has highest priorities as firstIndexes and lower priorities as last indexes
            // so I will compute from the index starting from the first and eventually reaching the final index
            // definitely very unoptimized, please suggest a better way to compute following the hierarchy


            ArrayList operatorIndexByHierarchy = new ArrayList();
            for (int index = 0; index < operatorsList.Count; index++)
            {

                // divide first priority, multiply second highest priority
                if (operatorsList[index].Equals(Operators.Divide))
                {
                    if (operatorIndexByHierarchy.Count > 0)
                    {
                        operatorIndexByHierarchy.Insert(0, index);
                    }
                    else
                    {
                        operatorIndexByHierarchy.Add(index);
                    }
                }
                else if (operatorsList[index].Equals(Operators.Multiply))
                {
                    operatorIndexByHierarchy.Add(index);
                }
            }

            // another loop for adding add and subtract!!!
            for (int index = 0; index < operatorsList.Count; index++)
            {
                if (operatorsList[index].Equals(Operators.Add) || operatorsList[index].Equals(Operators.Subtract))
                {
                    operatorIndexByHierarchy.Add(index);
                }
            }

            for(int i = 0; i < operatorIndexByHierarchy.Count; i++)
            {
                Console.WriteLine(operatorIndexByHierarchy[i]);
            }

            while (numbersList.Count > 1 && !operatorIndexByHierarchy.Count.Equals(0))
            {
                int index = Convert.ToInt32(operatorIndexByHierarchy[0]);
                int test = 0;
                for(int i = 0; i < operatorIndexByHierarchy.Count; i++)
                {
                    test = Convert.ToInt32(operatorIndexByHierarchy[i]);
                }
                double var1 = Convert.ToDouble(numbersList[index]);
                double var2 = Convert.ToDouble(numbersList[index + 1]);
                switch (operatorsList[index])
                {
                    case Operators.Divide:
                        numbersList.ReplaceAt(index, var1 / var2);
                        break;
                    case Operators.Multiply:
                        numbersList.ReplaceAt(index, var1 * var2); 
                        break;
                    case Operators.Subtract:
                        numbersList.ReplaceAt(index, var1 - var2);
                        break;
                    case Operators.Add:
                        numbersList.ReplaceAt(index, var1 + var2);
                        break;
                    default:
                        break;

                }
                numbersList.RemoveAt(index + 1);
                operatorsList.RemoveAt(index);
                for (int i = 0; i < operatorIndexByHierarchy.Count; i++)
                {
                    if (Convert.ToInt32(operatorIndexByHierarchy[i]) > index)
                    {
                        operatorIndexByHierarchy[i] = Convert.ToInt32(operatorIndexByHierarchy[i]) - 1;
                    }
                }
                operatorIndexByHierarchy.RemoveAt(0);
            }
            try
            {
                textBoxResult.Text = numbersList[0].ToString();
            }
            catch (Exception)
            {
                textBoxResult.Text = "Invalid Expression.";
                HandleError();
            }
        }
        private void EraseButton_Click(object sender, EventArgs e)
        {

            // So ^1 doesn't work here
            try
            {
                textBoxExpression.Text = textBoxExpression.Text.Remove(textBoxExpression.Text.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private void HandleError()
        {
            numbers.Clear();
            numbersList.Clear();
            operatorsList.Clear();
            endOfExpression = true;
        }
    }

    public static class ListExtensions
    {
        public static void ReplaceAt(this List<double> array, int index, double value)
        {
            array[index] = value;
        }
    }
    public enum Operators { Add = 1, Subtract, Multiply, Divide }
}
