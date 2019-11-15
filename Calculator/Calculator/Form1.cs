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
    /// <summary>
    /// Followed the steps of youtube tutorial. https://www.youtube.com/watch?v=iJqB6UsM-hs
    /// Author username: ProgammingKnowledge
    ///
    /// STUDENT: Brandon Crandall
    /// SYSNOPIS: I followed his steps to learn how to make a simple calculator. Learned how to create buttons, how to 
    /// manipulate properties and how to set up click events.
    ///
    /// </summary>


    public partial class Form1 : Form
    {
        //Creating variables for calculating the result and performing operations
        Double resultValue = 0;
        String operationPerformed = "";

        //Variable to help store the value
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Creating an event for when a user clicks on the number buttons or "." to display the text of the button
        private void Button_Click(object sender, EventArgs e)
        {
            //This statement allows us to remove the default "0" that is displayed when the calculator starts
            if ((textBox_result.Text == "0") || (isOperationPerformed))
            {
                textBox_result.Clear();
            }

            isOperationPerformed = false;

            //We are creating a variable button to be able to give it the value of the buttons text
            //in order to allow this event to be used for multiple buttons
            Button button = (Button)sender;

            //limiting the number periods allowed
            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                {
                    textBox_result.Text = textBox_result.Text + button.Text;
                }
            }
            else
            {
                textBox_result.Text = textBox_result.Text + button.Text;
            }
            isOperationPerformed = false;
        }

        //Creating a click event for the operator buttons and displaying the result as a double
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            //having the calculator show the value as the user inputs operations
            if (resultValue != 0)
            {
                button16.PerformClick();

                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        //Event for clicking the clear entry (CE) button
        private void Button5_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        //Event for clicking the clear (C) button
        private void Button6_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultValue = 0;
        }

        //Creating event for clicking on the equals button
        private void Button16_Click(object sender, EventArgs e)
        {
            //Performing the mathematical operations
            switch (operationPerformed)
            {
                case "+":
                    textBox_result.Text = (resultValue + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultValue - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultValue * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultValue / Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            //Adding better text to label
            resultValue = Double.Parse(textBox_result.Text);
            labelCurrentOperation.Text = "";
        }
    }

    //MODIFICATIONS: Minimal

    //ANALYSIS: Utilizes click events to allow user to click on buttons on the interface to computer calculations.

    //Output:
    //Presents a basic calculator
    //As seen on the Form1.cs[Design] 
}
