using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skolsky_pomocnik
{
    public partial class CalculatorControl : UserControl
    {

        private double currentValue = 0;
        private string currentOperator = "";
        private bool operatorPressed = false;
        private bool resultDisplayed = false;

        public CalculatorControl()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (textBox_Output.Text == "0" || operatorPressed || resultDisplayed)
            {
                textBox_Output.Text = btn.Text;
                operatorPressed = false;
                resultDisplayed = false;
            }
            else
            {
                textBox_Output.Text += btn.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            currentValue = double.Parse(textBox_Output.Text);
            currentOperator = btn.Text;
            operatorPressed = true;
            resultDisplayed = false;
        }

        private void button_Calculator_Equals_Click(object sender, EventArgs e)
        {
            double secondValue = double.Parse(textBox_Output.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+": result = currentValue + secondValue; break;
                case "-": result = currentValue - secondValue; break;
                case "*": result = currentValue * secondValue; break;
                case "/":
                    if (secondValue != 0)
                        result = currentValue / secondValue;
                    else
                    {
                        MessageBox.Show("Delenie nulou nie je povolené");
                        return;
                    }
                    break;
                default:
                    return; // žiadna operácia
            }

            textBox_Output.Text = result.ToString();
            currentValue = result;
            currentOperator = "";
            resultDisplayed = true;
        }

        private void button_Calculator_Clear_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = "0";
            currentValue = 0;
            currentOperator = "";
            operatorPressed = false;
            resultDisplayed = false;
        }

        private void button_Calculator_BCKSPC_Click(object sender, EventArgs e)
        {
            if (textBox_Output.Text.Length > 1)
                textBox_Output.Text = textBox_Output.Text.Substring(0, textBox_Output.Text.Length - 1);
            else
                textBox_Output.Text = "0";
        }

        private void button_Calculator_Switch_Click(object sender, EventArgs e)
        {
            if (textBox_Output.Text != "0")
            {
                if (textBox_Output.Text.StartsWith("-"))
                    textBox_Output.Text = textBox_Output.Text.Substring(1);
                else
                    textBox_Output.Text = "-" + textBox_Output.Text;
            }
        }

        private void button_Calculator_Decimal_Click(object sender, EventArgs e)
        {
            if (operatorPressed || resultDisplayed)
            {
                textBox_Output.Text = "0.";
                operatorPressed = false;
                resultDisplayed = false;
            }
            else if (!textBox_Output.Text.Contains("."))
            {
                textBox_Output.Text += ".";
            }
        }
    }
}
