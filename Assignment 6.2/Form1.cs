using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6._2
{
    public partial class Form1 : Form
    {
        CarRepository repository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repository = new CarRepository();
            carGrid.DataSource = repository.GetCars();
            txtVIN.Enabled = false;
            txtMake.Enabled = false;
            txtModel.Enabled = false;
            txtYear.Enabled = false;
            txtPrice.Enabled = false;
            SetGridHeight(carGrid, carGrid.Height);
        }

        public void SetGridHeight(DataGridView grd, int maxHeight)
        {
            var height = 26;
            maxHeight = 180;
            foreach (DataGridViewRow row in grd.Rows)
            {
                if (row.Visible)
                    height += row.Height;
            }

            if (height > maxHeight)
                height = maxHeight;

            grd.Height = height;
        }

            private void Clear()
        {
            txtVIN.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Clear();
            btnSubmit.Enabled = true;
            btnSubmit.Visible = true;
            btnAddCar.Enabled = false;
            btnAddCar.Visible = false;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
            txtVIN.Enabled = true;
            txtMake.Enabled = true;
            txtModel.Enabled = true;
            txtYear.Enabled = true;
            txtPrice.Enabled = true;
            txtVIN.ReadOnly = false;
            txtMake.ReadOnly = false;
            txtModel.ReadOnly = false;
            txtYear.ReadOnly = false;
            txtPrice.ReadOnly = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtVIN.Text != String.Empty && txtMake.Text != String.Empty && txtYear.Text != String.Empty)
            {
                var newcar = new Car();
                newcar.VIN = txtVIN.Text;
                newcar.Make = txtMake.Text;
                newcar.Model = txtModel.Text;
                newcar.Year = Convert.ToInt32(txtYear.Text);
                newcar.Price = txtPrice.Text;
                repository.AddCar(newcar);
                carGrid.DataSource = null;
                carGrid.DataSource = repository.GetCars();
                SetGridHeight(carGrid, carGrid.Height);
                Clear();
                btnSubmit.Enabled = false;
                btnSubmit.Visible = false;
                btnAddCar.Enabled = true;
                btnAddCar.Visible = true;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                btnDelete.Enabled = false;
                btnDelete.Visible = false;
                txtVIN.Enabled = false;
                txtMake.Enabled = false;
                txtModel.Enabled = false;
                txtYear.Enabled = false;
                txtPrice.Enabled = false;
            }
            else
            {
                MessageBox.Show("VIN, Make, and Model must be filled out");
                return;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var vin = carGrid.CurrentRow.Cells[0].Value;
            var cartoupdate = repository.FindCar((string)vin);
            txtVIN.Text = cartoupdate.VIN;
            txtMake.Text = cartoupdate.Make;
            txtModel.Text = cartoupdate.Model;
            txtYear.Text = cartoupdate.Year.ToString();
            txtPrice.Text = cartoupdate.Price;
            btnAddCar.Enabled = true;
            btnAddCar.Visible = true;
            btnUpdate.Enabled = true;
            btnUpdate.Visible = true;
            btnDelete.Enabled = true;
            btnDelete.Visible = true;
            btnSubmit.Enabled = false;
            btnSubmit.Visible = false;
            txtVIN.Enabled = true;
            txtMake.Enabled = true;
            txtModel.Enabled = true;
            txtYear.Enabled = true;
            txtPrice.Enabled = true;
            txtVIN.ReadOnly = true;
            txtMake.ReadOnly = true;
            txtModel.ReadOnly = true;
            txtYear.ReadOnly = true;
            txtPrice.ReadOnly = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var vin = txtVIN.Text;
            var cartoupdate = repository.FindCar(vin);
            cartoupdate.Make = txtMake.Text;
            cartoupdate.Model = txtModel.Text;
            cartoupdate.Year = Convert.ToInt32(txtYear.Text);
            cartoupdate.Price = txtPrice.Text;
            repository.UpdateCar(vin, cartoupdate);
            carGrid.DataSource = null;
            carGrid.DataSource = repository.GetCars();
            Clear();
            SetGridHeight(carGrid, carGrid.Height);
            btnAddCar.Enabled = true;
            btnAddCar.Visible = true;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
            btnSubmit.Enabled = false;
            btnSubmit.Visible = false;
            txtVIN.Enabled = false;
            txtMake.Enabled = false;
            txtModel.Enabled = false;
            txtYear.Enabled = false;
            txtPrice.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var vin = carGrid.CurrentRow.Cells[0].Value;
            var cartodel = repository.FindCar((string)vin);
            repository.DeleteCar(cartodel);
            MessageBox.Show("Car deleted");
            carGrid.DataSource = null;
            carGrid.DataSource = repository.GetCars();
            Clear();
            SetGridHeight(carGrid, carGrid.Height);
            btnAddCar.Enabled = true;
            btnAddCar.Visible = true;
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
            btnSubmit.Enabled = false;
            btnSubmit.Visible = false;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            txtVIN.Enabled = false;
            txtMake.Enabled = false;
            txtModel.Enabled = false;
            txtYear.Enabled = false;
            txtPrice.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            txtVIN.Enabled = false;
            txtMake.Enabled = false;
            txtModel.Enabled = false;
            txtYear.Enabled = false;
            txtPrice.Enabled = false;
            btnAddCar.Enabled = true;
            btnAddCar.Visible = true;
            btnSubmit.Enabled = false;
            btnSubmit.Visible = false;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
            Form1_Load(sender, e);
            SetGridHeight(carGrid, carGrid.Height);
        }
    }
}
