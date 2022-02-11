using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksDll;

namespace Assignment_5._4
{
    public partial class fLibrary : Form
    {
        BookRepository repository;
        Book newbook;

        public fLibrary()
        {
            InitializeComponent();
        }

        private void fLibrary_Load(object sender, EventArgs e)
        {
            repository = new BookRepository();
            dgvBooklist.DataSource = repository.GetBooks().ToList();
            dgvBooklist.BackgroundColor = Color.LightYellow;
            dgvBooklist.Columns[0].Width = 170;
            dgvBooklist.Columns[1].Width = 30;
            dgvBooklist.Columns[1].HeaderText = "#";
            dgvBooklist.Columns[2].Width = 190;
            dgvBooklist.Columns[3].Width = 60;
            dgvBooklist.Columns[3].HeaderText = "Date";
            dgvBooklist.Columns[4].Width = 150;
            dgvBooklist.Columns[5].Width = 125;            
        }

        public void RefreshData()
        {
            txtSeries.Clear();
            txtBookNumber.Clear();
            txtTitle.Clear();
            txtYear.Clear();
            txtAuthor.Clear();
            txtISBN.Clear();
            dgvBooklist.DataSource = null;
            dgvBooklist.DataSource = repository.GetBooks().ToList();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            btnAddBook.Visible = false;
            btnDeleteBook.Visible = false;
            btnConfirm.Visible = false;
            grpBookInfo.Visible = true;          
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {           
            if (txtTitle.Text == String.Empty || txtAuthor.Text == String.Empty)
            {
                MessageBox.Show("Title and Author cannot be blank");
                return;
            }
            else
            {
                newbook = new Book();
                newbook.Series = txtSeries.Text;
                newbook.BookNumber = txtBookNumber.Text;
                newbook.Title = txtTitle.Text;
                newbook.YearPublished = txtYear.Text;
                newbook.Author = txtAuthor.Text;
                newbook.ISBN = txtISBN.Text;
                repository.AddBook(newbook);
            }
            RefreshData();
            grpBookInfo.Visible = false;
            btnConfirm.Visible = false;
            btnAddBook.Visible = true;
            btnDeleteBook.Visible = true;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            btnAddBook.Visible = false;
            btnDeleteBook.Visible = false;
            grpBookInfo.Visible = false;
            MessageBox.Show("Select a book and click Confirm");
            btnConfirm.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            repository.DeleteBook(dgvBooklist.CurrentRow.Index);
            dgvBooklist.DataSource = null;
            dgvBooklist.DataSource = repository.GetBooks().ToList();
            MessageBox.Show("Book deleted");
            btnConfirm.Visible = false;
            btnAddBook.Visible = true;
            btnDeleteBook.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
