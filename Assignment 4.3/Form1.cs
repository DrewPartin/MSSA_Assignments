using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment_4._3
{
    public partial class Form1 : Form
    {
        ArrayList studlist;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studlist = new ArrayList();
            studlist.Add(new Student() { StudID = 1, FirstName = "Harry", LastName = "Potter", Address = "4 Privet Drive, Surrey", Grade = Grade.A, MonthOfAdmission = MonthOfAdmission.Dec, House = House.Gryffindor });
            studlist.Add(new Student() { StudID = 2, FirstName = "Ron", LastName = "Weasley", Address = "Ottery Street, Catchpole", Grade = Grade.C, MonthOfAdmission = MonthOfAdmission.Dec, House = House.Gryffindor });
            studlist.Add(new Student() { StudID = 3, FirstName = "Hermione", LastName = "Granger", Address = "Hampstead Garden, Northwest London", Grade = Grade.A, MonthOfAdmission = MonthOfAdmission.Dec, House = House.Gryffindor });
            studlist.Add(new Student() { StudID = 4, FirstName = "Draco", LastName = "Malfoy", Address = "Malfoy Manor", Grade = Grade.B, MonthOfAdmission = MonthOfAdmission.Dec, House = House.Slytherin });
            studGrid.DataSource = studlist;
            comboAdmMon.DataSource = Enum.GetValues(typeof(MonthOfAdmission));
            comboGrade.DataSource = Enum.GetValues(typeof(Grade));
            comboHouse.DataSource = Enum.GetValues(typeof(House));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            grpStudInfo.Visible = true;
            btnSubmit.Visible = true;            
        }

        private void RefreshData()
        {
            txtStudID.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtAddress.Clear();
            studGrid.DataSource = null;
            studGrid.DataSource = studlist;
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtStudID.Text != String.Empty && txtFname.Text != String.Empty && txtLname.Text != String.Empty && txtAddress.Text != String.Empty)
            {
                Student newStud = new Student();
                newStud.StudID = Int32.Parse(txtStudID.Text);
                newStud.FirstName = txtFname.Text;
                newStud.LastName = txtLname.Text;
                newStud.Address = txtAddress.Text;
                newStud.MonthOfAdmission = (MonthOfAdmission)comboAdmMon.SelectedIndex;
                newStud.Grade = (Grade)comboGrade.SelectedIndex;
                newStud.House = (House)comboHouse.SelectedIndex;
                studlist.Add(newStud);
            }
            RefreshData();
            grpStudInfo.Visible = false;
            btnSubmit.Visible = false;
            btnAdd.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnConfirm.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = false;
            btnDelete.Visible = true;
            studlist.RemoveAt(studGrid.CurrentRow.Index);
            RefreshData();
        }
    }
}
