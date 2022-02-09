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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEmpSys_Click(object sender, EventArgs e)
        {
            EmployeeSystem EmpSys = new EmployeeSystem();
            this.Visible = false;
            EmpSys.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            CalculatorForm Calc = new CalculatorForm();
            this.Visible = false;
            Calc.Show();
        }
    }
}
