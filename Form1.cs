using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADODotNetAppn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //=================================================
        String Operator = "";
        int num1=0,num2=0,number=0;
        //=================================================
        private void Btn1_Click(object sender, EventArgs e)
        {
            DisplayResult.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            DisplayResult.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            DisplayResult.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            DisplayResult.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            DisplayResult.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            DisplayResult.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            DisplayResult.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            DisplayResult.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            DisplayResult.Text += "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            DisplayResult.Text += "0";
        }

        //======================================================
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Operator = "+";
            num1 = Convert.ToInt32(DisplayResult.Text);
            DisplayResult.Clear();
        }
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            Operator = "-";
            num1 = Convert.ToInt32(DisplayResult.Text);
            DisplayResult.Clear();
        }
        private void BtnX_Click(object sender, EventArgs e)
        {
            Operator = "x";
            num1 = Convert.ToInt32(DisplayResult.Text);
            DisplayResult.Clear();
        }
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            Operator = "/";
            num1 = Convert.ToInt32(DisplayResult.Text);
            DisplayResult.Clear();
        }


        //======================================================
        private void BtnCLR_Click(object sender, EventArgs e)
        {
            DisplayResult.Clear();
        }


        //======================================================
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(DisplayResult.Text);
            if (Operator == "+")
            {
                number = (num1 + num2);
            }
            if (Operator == "-")
            {
                number = (num1 - num2);
            }
            if (Operator == "x")
            {
                number = (num1 * num2);
            }
            if (Operator == "/")
            {
                number = (num1 / num2);
            }
            DisplayResult.Text=Convert.ToString(number);
        }
    }
}
