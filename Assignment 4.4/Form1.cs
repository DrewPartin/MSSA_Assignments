using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment_4._4
{
    public partial class Form1 : Form
    {
        List<Coffee> coffeelist;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            coffeelist = new List<Coffee>();
            coffeelist.Add(new Coffee() { OrderID = 1, CustomerName = "Drew", DrinkName = "Americano", size = Beverages.Size.Medium, temp = Beverages.Temp.Hot, Cream = false, Sugar = true, Own_Cup = false, UnitPrice = 1.25M, Tax = 0.10M, Discount = 0.00M, TotalPrice = Math.Round(1.25M + (1.25M * 0.08M), 2) });
            coffeelist.Add(new Coffee() { OrderID = 2, CustomerName = "Jen", DrinkName = "Cafe Latte", size = Beverages.Size.Small, temp = Beverages.Temp.Hot, Cream = false, Sugar = false, Own_Cup = false, UnitPrice = 1.75M, Tax = 0.14M, Discount = 0.00M, TotalPrice = Math.Round(1.75M + (1.75M * 0.08M), 2) }) ;
            coffeelist.Add(new Coffee() { OrderID = 3, CustomerName = "Owen", DrinkName = "Caramel Macchiato", size = Beverages.Size.Small, temp = Beverages.Temp.Cold, Cream = true, Sugar = true, Own_Cup = true, UnitPrice = 2.50M, Tax = 0.20M, Discount = 0.50M, TotalPrice = Math.Round(2.50M + (2.50M * 0.08M) - .50M, 2) });
            coffeeGrid.DataSource = coffeelist.ToList();
            cmbSize.DataSource = Enum.GetValues(typeof(Coffee.Size));
            cmbTemp.DataSource = Enum.GetValues(typeof(Coffee.Temp));
        }

        private void RefreshData()
        {
            txtOrderID.Clear();
            txtCustomerName.Clear();
            txtDrinkName.Clear();
            txtUnitPrice.Clear();
            chboxCream.Checked = false;
            chboxSugar.Checked = false;
            chboxCup.Checked = false;
            coffeeGrid.DataSource = null;
            coffeeGrid.DataSource = coffeelist;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnClear.Visible = false;
            btnComplete.Visible = false;
            btnAdd.Visible = false;
            lblOrderInfo.Visible = true;
            grpOrderInfo.Visible = true;
            btnConfirm.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtOrderID.Text != String.Empty && txtCustomerName.Text != String.Empty && txtDrinkName.Text != String.Empty && txtUnitPrice.Text != String.Empty)
            {
                Coffee newCoffee = new Coffee();
                newCoffee.OrderID = Int32.Parse(txtOrderID.Text);
                newCoffee.CustomerName = txtCustomerName.Text;
                newCoffee.DrinkName = txtDrinkName.Text;
                newCoffee.size = (Coffee.Size)cmbSize.SelectedIndex;
                newCoffee.temp = (Coffee.Temp)cmbTemp.SelectedIndex;
                newCoffee.Cream = (chboxCream.Checked);
                newCoffee.Sugar = (chboxSugar.Checked);
                newCoffee.Own_Cup = (chboxCup.Checked);
                if(chboxCup.Checked == true)
                {
                    newCoffee.Own_Cup = true;
                    newCoffee.Discount = 0.50M;
                }
                else
                {
                    newCoffee.Own_Cup=false;
                    newCoffee.Discount = 0.00M;
                }
                newCoffee.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                newCoffee.Tax = newCoffee.CalculateTax(0.08M);               
                newCoffee.TotalPrice = newCoffee.CalculateCost(0.08M);
                coffeelist.Add(newCoffee);
            }
            RefreshData();
            btnComplete.Visible = true;
            btnAdd.Visible = true;
            btnClear.Visible = false;
            lblOrderInfo.Visible = false;
            grpOrderInfo.Visible = false;
            btnConfirm.Visible = false;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            lblOrderInfo.Visible = false;
            btnConfirm.Visible = false;
            btnComplete.Visible = false;
            btnClear.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.Visible = false;
            btnComplete.Visible = true;
            btnAdd.Visible = true;
            lblOrderInfo.Visible = false;
            grpOrderInfo.Visible = false;
            btnConfirm.Visible = false;
            coffeelist.RemoveAt(coffeeGrid.CurrentRow.Index);
            RefreshData();
        }
    }
}
