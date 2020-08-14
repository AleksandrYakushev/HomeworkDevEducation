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
    public partial class Form1 : Form
    {
        private const string _readyToStartMessage = "Готов к вычислениям!";
        private bool waitingForOperation = false;
        public Form1()
        {
            InitializeComponent();
            resultBox.Text = "0";
            currentOperationBox.Text = _readyToStartMessage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentOperationBox.Text == _readyToStartMessage)
                currentOperationBox.Text = "";
            DoDigitButtonClick("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentOperationBox.Text == _readyToStartMessage)
                currentOperationBox.Text = "";
            DoDigitButtonClick("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentOperationBox.Text == _readyToStartMessage)
                currentOperationBox.Text = "";
            DoDigitButtonClick("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentOperationBox.Text == _readyToStartMessage)
                currentOperationBox.Text = "";
            DoDigitButtonClick("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentOperationBox.Text == _readyToStartMessage)
                currentOperationBox.Text = "";
            DoDigitButtonClick("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentOperationBox.Text == _readyToStartMessage)
                currentOperationBox.Text = "";
            DoDigitButtonClick("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentOperationBox.Text == _readyToStartMessage)
                currentOperationBox.Text = "";
            DoDigitButtonClick("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (currentOperationBox.Text == _readyToStartMessage)
                currentOperationBox.Text = "";
            DoDigitButtonClick("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (currentOperationBox.Text == _readyToStartMessage)
                currentOperationBox.Text = "";
            DoDigitButtonClick("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (currentOperationBox.Text == _readyToStartMessage)
                currentOperationBox.Text = "";
            DoDigitButtonClick("0");
        }

        private void DoDigitButtonClick(string digit)
        {
            if (waitingForOperation)
                return;

            if (currentOperationBox.Text == _readyToStartMessage)
            {
                currentOperationBox.Text = "";
            }

            currentOperationBox.Text += digit;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            DoOperationButtonClick("+");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            DoOperationButtonClick("-");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            DoOperationButtonClick("*");
        }

        private void div_Click(object sender, EventArgs e)
        {
            DoOperationButtonClick("/");
        }

        private void DoOperationButtonClick(string action)
        {
            if (resultBox.Text == _readyToStartMessage ||
                currentOperationBox.Text.Contains(" "))
                return;

            currentOperationBox.Text += $" {action} ";
            waitingForOperation = false;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (currentOperationBox.Text == _readyToStartMessage)
                return;

            string[] parts = currentOperationBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 3)
                return;
            int number1 = Convert.ToInt32(parts[0]);
            int number2 = Convert.ToInt32(parts[2]);
            string operation = parts[1];

            if (operation == "/" && number2 == 0)
                return;

            int result = GetResult(number1, number2, operation);

            resultBox.Text = result.ToString();
            currentOperationBox.Text = result.ToString();
            waitingForOperation = true;
        }

        private int GetResult(int number1, int number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;

                default:
                    return 0;
            }
        }
    }
}

