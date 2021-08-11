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
        Double resultValue = 0;
        string operatorClicked = "";
        bool isOperatedClicked = false;
        public Calculator()
        {
            InitializeComponent();
        }
         
        private void click_button(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            if (resultBox.Text == "0" || (isOperatedClicked))
            {
                resultBox.Clear();


            }
            isOperatedClicked = false;
            if (button.Text ==  "Clear")
            {
                resultBox.Clear();
                resultValue = 0;
                resultBox.Text = "0";
            }
            else
            {
                resultBox.Text = resultBox.Text + button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            if (resultValue != 0)
            {
                btnEqual.PerformClick();
                operatorClicked = button.Text;
                isOperatedClicked = true;
            }
            else
            {
                operatorClicked = button.Text;
                resultValue = Double.Parse(resultBox.Text);
                isOperatedClicked = true;
            }
            operatorClicked = button.Text;
            resultValue = Double.Parse(resultBox.Text);
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch (operatorClicked)
            {
                case "+":
                    resultBox.Text = (resultValue + Double.Parse((resultBox.Text))).ToString();
                    break;
                case "-":
                    resultBox.Text = (resultValue - Double.Parse((resultBox.Text))).ToString();
                    break;
                case "×":
                    resultBox.Text = (resultValue * Double.Parse((resultBox.Text))).ToString();
                    break;
                case "÷":
                    resultBox.Text = (resultValue / Double.Parse((resultBox.Text))).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
