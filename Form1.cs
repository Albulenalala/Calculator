using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace) and digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Only allow one negative sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace) and digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Only allow one negative sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        double firstNumber = 0, secondNumber = 0;
        bool control = false;

        void set1Parameter(string text)
        {
            if (text.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
            }
            else
            {
                control = false;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            control = false;
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
            firstNumber = 0;
            secondNumber = 0;
        }

        string message = "Please fill the necessary area!!";

        private void btnMin_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtResult.Text = System.Math.Min(firstNumber, secondNumber).ToString();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtResult.Text = System.Math.Max(firstNumber, secondNumber).ToString();
            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtResult.Text = System.Math.Abs(firstNumber).ToString();
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtResult.Text = System.Math.Sign(firstNumber).ToString();
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = (firstNumber * (System.Math.PI)) / 180;
                txtResult.Text = System.Math.Sin(temp).ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = (firstNumber * (System.Math.PI)) / 180;
                txtResult.Text = System.Math.Cos(temp).ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = (firstNumber * (System.Math.PI)) / 180;
                txtResult.Text = System.Math.Tan(temp).ToString();
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtResult.Text = System.Math.Pow(firstNumber, secondNumber).ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if(!control)
                MessageBox.Show(message);
            else
                txtResult.Text = System.Math.Sqrt(firstNumber).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
                MessageBox.Show(message);
            else
                txtResult.Text = System.Math.Log(secondNumber, firstNumber).ToString();

        }

        private void btnLog1_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
                MessageBox.Show(message);
            else 
                txtResult.Text = System.Math.Log10(firstNumber).ToString();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
                MessageBox.Show(message);
            else
                txtResult.Text = System.Math.Exp(firstNumber).ToString();
        }

        private void btnCopyFirstNumber_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Trim() != "")
            {
                txtFirstNumber.Text = txtResult.Text;
                txtResult.Clear();
                txtSecondNumber.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void set2Parameter(string text1, string text2)
        {
            if (text1.Trim() != "" && text2.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text1);
                secondNumber = Convert.ToDouble(text2);
            }
            else
            {
                control = false;
            }
        }
    }
}