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

    public partial class EmployeeSystem : Form
    {
        List<Employee> employeelist;

        public EmployeeSystem()
        {
            InitializeComponent();
        }

        private void EmployeeSystem_Load(object sender, EventArgs e)
        {
            employeelist = new List<Employee>();
            employeelist.Add(new Employee() { ID = 1, FName = "Drew", LName = "Partin", DOB = new DateTime(1984, 04, 12), Age = 37 });
            employeelist.Add(new Employee() { ID = 2, FName = "Jen", LName = "Partin", DOB = new DateTime(1984, 08, 25), Age = 37 });
            employeelist.Add(new Employee() { ID = 3, FName = "Matthew", LName = "McConaughey", DOB = new DateTime(1969, 11, 04), Age = 52 });
            employeelist.Add(new Employee() { ID = 4, FName = "Eva", LName = "Mendez", DOB = new DateTime(1974, 03, 05), Age = 47 });
            employeelist.Add(new Employee() { ID = 5, FName = "Elon", LName = "Musk", DOB = new DateTime(1971, 06, 28), Age = 50 });
            employeelist.Add(new Employee() { ID = 6, FName = "Mark", LName = "Wahlberg", DOB = new DateTime(1971, 06, 05), Age = 50 });
            empGrid.DataSource = employeelist;
            empGrid.Columns["DOB"].Visible = false;
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {            
            foreach (Employee em in employeelist)
            {               
                if (em.ID == Int32.Parse(txtID.Text))
                {
                    MessageBox.Show("This ID is already assigned to another employee");
                    e.Cancel = true;
                }
                else
                {
                    continue;
                }
            }            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value.AddYears(18) > DateTime.Now.Date)
            {
                MessageBox.Show("Employees must be at least 18 years old");
            }
            else if(dateTimePicker1.Value.AddYears(80) < DateTime.Now.Date)
            {
                MessageBox.Show("You need to retire...");
            }
            else
            {
                txtAge.Text = (((DateTime.Now.Date - dateTimePicker1.Value).Days) / 365).ToString();
                txtAge.ReadOnly = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtID.Text != String.Empty && txtFName.Text != String.Empty && txtLName.Text != String.Empty)
            {
                Employee emp = new Employee();
                emp.ID = Int32.Parse(txtID.Text);
                emp.FName = txtFName.Text;
                emp.LName = txtLName.Text;
                emp.DOB = dateTimePicker1.Value.Date;
                emp.Age = Int32.Parse(txtAge.Text);
                employeelist.Add(emp);
                MessageBox.Show($"{emp.FName} {emp.LName} has been added to the roster");
            }
            RefreshData();
            grpEmpData.Visible = false;
            empGrid.Size = new Size(446, 398);
            btnSubmit.Visible = false;
            btnAdd.Visible = true;
            btnRemove.Visible = true;
            btnBack1.Visible = true;
            btnBack2.Visible = false;
        }

        private void RefreshData()
        {
            txtID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtAge.Clear();
            empGrid.DataSource = null;
            empGrid.DataSource = employeelist;
            empGrid.Columns["DOB"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            empGrid.Size = new Size(446, 150);
            btnBack1.Visible = false;
            btnBack2.Visible = true;
            grpEmpData.Visible = true;
            btnAdd.Visible = false;
            btnRemove.Visible = false;
            btnSubmit.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnBack1.Visible = false;
            btnBack2.Visible = true;
            btnAdd.Visible = false;
            btnDelete.Visible = true;
            btnRemove.Visible = false;
            btnSubmit.Visible=false;
            MessageBox.Show("To confirm, select an employee from the list and click \"Delete\"");
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            employeelist.RemoveAt(empGrid.CurrentRow.Index);
            RefreshData();
            MessageBox.Show("Employee has been deleted");
            btnDelete.Visible = false;
            btnAdd.Visible = true;
            btnRemove.Visible = true;
            btnBack1.Visible = true;
            btnBack2.Visible = false;
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            empGrid.Visible = true;
            empGrid.Size = new Size(446, 398);
            grpEmpData.Visible = false;
            btnSubmit.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = true;
            btnRemove.Visible = true;
            btnBack2.Visible = false;
            btnBack1.Visible = true;
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            this.Close();
            mainMenu.Visible = true;
        }
    }
}
