using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        int num1;
        int num2;
        int answer;
        string equation;

        private void btn1_Click(object sender, EventArgs e)
        {
            tb_sum.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tb_sum.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tb_sum.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tb_sum.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tb_sum.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tb_sum.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tb_sum.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tb_sum.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tb_sum.Text += 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tb_sum.Text += 0;
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(tb_sum.Text);
            tb_sum.Clear();
            equation = "Add";
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(tb_sum.Text);
            tb_sum.Clear();
            equation = "Subtract";
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(tb_sum.Text);
            tb_sum.Clear();
            equation = "Multiply";
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(tb_sum.Text);
            tb_sum.Clear();
            equation = "Divide";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(tb_sum.Text);

            if (equation.Equals("Add"))
            {
                answer = num1 + num2;
                tb_sum.Text = Convert.ToString(answer);
            }
            else if (equation.Equals("Subtract"))
            {
                answer = num1 - num2;
                tb_sum.Text = Convert.ToString(answer);
            }
            else if (equation.Equals("Divide"))
            {
                answer = num1 / num2;
                tb_sum.Text = Convert.ToString(answer);
            }
            else if (equation.Equals("Multiply"))
            {
                answer = num1 * num2;
                tb_sum.Text = Convert.ToString(answer);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_sum.Clear();
        }
    }
}
