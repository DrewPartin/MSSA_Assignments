using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5._1
{
    
    public partial class CalculatorForm : Form
    {
        Calculator Calc = new Calculator();
        Stack<decimal> numbers;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            txtCalcDisplay.Clear(); 
        }

        #region NumPad Code
        private void btn1_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + '9';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + '0';
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + '.';
        } 
        #endregion

        private void btnPlus_Click(object sender, EventArgs e)
        {
            numbers = new Stack<decimal>();
            decimal n1 = decimal.Parse(txtCalcDisplay.Text);
            numbers.Push(n1);
            txtCalcDisplay.Clear();
            btnPlusEquals.Visible = true;
            btnSubtractEquals.Visible = false;
            btnMultiplyEquals.Visible = false;
            btnDivideEquals.Visible = false;
        }

        private void btnPlusEquals_Click(object sender, EventArgs e)
        {
            decimal n2 = decimal.Parse(txtCalcDisplay.Text);
            txtCalcDisplay.Text = Calc.AddNumbers(numbers.Pop(), n2).ToString();
            numbers.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            numbers = new Stack<decimal>();
            decimal n1 = decimal.Parse(txtCalcDisplay.Text);
            numbers.Push(n1);
            txtCalcDisplay.Clear();
            btnPlusEquals.Visible = false;
            btnSubtractEquals.Visible = true;
            btnMultiplyEquals.Visible = false;
            btnDivideEquals.Visible = false;
        }

        private void btnSubtractEquals_Click(object sender, EventArgs e)
        {
            decimal n2 = decimal.Parse(txtCalcDisplay.Text);
            txtCalcDisplay.Text = Calc.SubtractNumbers(numbers.Pop(), n2).ToString();
            numbers.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            numbers = new Stack<decimal>();
            decimal n1 = decimal.Parse(txtCalcDisplay.Text);
            numbers.Push(n1);
            txtCalcDisplay.Clear();
            btnPlusEquals.Visible = false;
            btnSubtractEquals.Visible = false;
            btnMultiplyEquals.Visible = true;
            btnDivideEquals.Visible = false;
        }

        private void btnMultiplyEquals_Click(object sender, EventArgs e)
        {
            decimal n2 = decimal.Parse(txtCalcDisplay.Text);
            txtCalcDisplay.Text = Calc.MultiplyNumbers(numbers.Pop(), n2).ToString();
            numbers.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            numbers = new Stack<decimal>();
            decimal n1 = decimal.Parse(txtCalcDisplay.Text);
            numbers.Push(n1);
            txtCalcDisplay.Clear();
            btnPlusEquals.Visible = false;
            btnSubtractEquals.Visible = false;
            btnMultiplyEquals.Visible = false;
            btnDivideEquals.Visible = true;
        }

        private void btnDivideEquals_Click(object sender, EventArgs e)
        {
            decimal n2 = decimal.Parse(txtCalcDisplay.Text);
            decimal result = Calc.DivideNumbers(numbers.Pop(), n2);
            if(result == 0)
            {
                MessageBox.Show("Cannot divide by zero");
                txtCalcDisplay.Clear();
                numbers.Clear();
            }
            else
            {
                txtCalcDisplay.Text = result.ToString();
                numbers.Clear();
            }          
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Clear();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            txtCalcDisplay.Clear();
            this.Close();
            mainMenu.Visible = true;
        }

        
    }
}
