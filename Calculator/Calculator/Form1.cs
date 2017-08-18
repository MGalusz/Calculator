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

        Double resultValue = 0;
        string operatonClick = "";
        bool isOperatotClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {

            if (resaultBox.Text == "0" || (isOperatotClicked))
                 resaultBox.Clear();

            isOperatotClicked = false;
             Button button = (Button)sender;
             if (button.Text == ".")
             {
                 if (!resaultBox.Text.Contains("."))
                     resaultBox.Text = resaultBox.Text + button.Text;
             }
             else
                resaultBox.Text = resaultBox.Text + button.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue !=0)
            {

                btnEaqul.PerformClick();
                operatonClick = button.Text;
                isOperatotClicked = true;
            }else
            {
                operatonClick = button.Text;
                resultValue = Double.Parse(resaultBox.Text);
                isOperatotClicked = true;
            }
            operatonClick = button.Text;
            resultValue = Double.Parse(resaultBox.Text);

        }

        private void clearBtnClick(object sender, EventArgs e)
        {
            resaultBox.Text = "0";
            resultValue = 0;
        }

        private void equalBtnClick(object sender, EventArgs e)
        {
            switch(operatonClick)
            {
                case "+":
                    resaultBox.Text = (resultValue + Double.Parse(resaultBox.Text)).ToString();
                    break;
                case "-":
                    resaultBox.Text = (resultValue - Double.Parse(resaultBox.Text)).ToString();
                    break;
                case "x":
                    resaultBox.Text = (resultValue * Double.Parse(resaultBox.Text)).ToString();
                    break;
                case "÷":
                    resaultBox.Text = (resultValue / Double.Parse(resaultBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
