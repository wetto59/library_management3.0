using Library_manangement.Data;
using Library_manangement.Models;
using Library_manangement.Services;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_manangement
{
    public partial class IssuedBooks : UserControl
    {
        public int bookID = 1;

        public IssuedBooks()
        {
            InitializeComponent();

            DataBookTitle();
            displayIssuedBook();

        }

        public void displayIssuedBook()
        {

            List<Issue> issuedBooks = DbConnections.GetIssuedBooks();
            dataGridView1.DataSource = issuedBooks;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBoookIssue_add_Click(object sender, EventArgs e)
        {
            if (txtBookIssue_id.Text == ""
                || txtBookIssue_name.Text == ""
                || txtBookIssue_contact.Text == ""
                || txtBookIssue_email.Text == ""
                || CmbBookIssue_bookTitle.Text == ""
                || CmbBookIssue_author.Text == ""
                || CmbBookIssue_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var issuedBook = new Issue()
                {
                    Issue_ID = txtBookIssue_id.Text,
                    Full_Name = txtBookIssue_name.Text,
                    Contact = txtBookIssue_contact.Text,
                    Email = txtBookIssue_email.Text,
                    Book_Title = CmbBookIssue_bookTitle.Text,
                    Author = CmbBookIssue_author.Text,
                    Status = CmbBookIssue_status.Text,
                    Issue_Date = BookIssue_issueDate.Value,
                    Return_Date = CmbBookIssue_returnDate.Value,
                };

                DbConnections.AddIssuedBookData(issuedBook);

                ClearFields();

                displayIssuedBook();
            }
            catch (Exception ex)
            {
                var detailedMessage = $"An error occurred: {ex.Message}";
                if (ex.InnerException != null)
                {
                    detailedMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(detailedMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DataBookTitle()
        {
            using (var db = new LibraryDbContext())
            {
                var books = db.Books.Where(x => x.Status == "Available").ToList();
                try
                {
                    CmbBookIssue_bookTitle.DataSource = books;
                    CmbBookIssue_bookTitle.DisplayMember = "BookTitle";
                    CmbBookIssue_bookTitle.ValueMember = "ID";

                    CmbBookIssue_author.DataSource = books;
                    CmbBookIssue_author.DisplayMember = "Author";
                    CmbBookIssue_author.ValueMember = "ID";
                }
                catch (Exception ex)
                {
                    var detailedMessage = $"An error occurred: {ex.Message}";
                    if (ex.InnerException != null)
                    {
                        detailedMessage += $"\nInner Exception: {ex.InnerException.Message}";
                    }
                    MessageBox.Show(detailedMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IssuedBooks_Load(object sender, EventArgs e)
        {

        }

        private void CmbBookIssue_bookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBookIssue_bookTitle.SelectedValue != null && CmbBookIssue_bookTitle.SelectedValue is int)
            {
                int selectID = Convert.ToInt32(CmbBookIssue_bookTitle.SelectedValue);

                try
                {
                    using (var db = new LibraryDbContext())
                    {
                        var selectedBook = db.Books.FirstOrDefault(b => b.ID == selectID);

                        if (selectedBook != null)
                        {
                            CmbBookIssue_author.Text = selectedBook.Author;
                        }
                        else
                        {
                            MessageBox.Show("Book not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    var detailedMessage = $"An error occurred: {ex.Message}";
                    if (ex.InnerException != null)
                    {
                        detailedMessage += $"\nInner Exception: {ex.InnerException.Message}";
                    }
                    MessageBox.Show(detailedMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFields()
        {
            txtBookIssue_id.Text = "";
            txtBookIssue_name.Text = "";
            txtBookIssue_contact.Text = "";
            txtBookIssue_email.Text = "";
            CmbBookIssue_bookTitle.SelectedIndex = -1;
            CmbBookIssue_author.SelectedIndex = -1;
            CmbBookIssue_status.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bookID = (int)row.Cells[0].Value;
                txtBookIssue_id.Text = row.Cells[1].Value.ToString();
                txtBookIssue_name.Text = row.Cells[2].Value.ToString();
                txtBookIssue_contact.Text = row.Cells[3].Value.ToString();
                txtBookIssue_email.Text = row.Cells[4].Value.ToString();
                CmbBookIssue_bookTitle.Text = row.Cells[5].Value.ToString();
                CmbBookIssue_author.Text = row.Cells[6].Value.ToString();
                BookIssue_issueDate.Text = row.Cells[8].Value.ToString();
                CmbBookIssue_returnDate.Text = row.Cells[9].Value.ToString();
                CmbBookIssue_status.Text = row.Cells[7].Value.ToString();
            }

        }

        private void BtnBoookIssue_update_Click(object sender, EventArgs e)
        {
            if (txtBookIssue_id.Text == ""
                || txtBookIssue_name.Text == ""
                || txtBookIssue_contact.Text == ""
                || txtBookIssue_email.Text == ""
                || CmbBookIssue_bookTitle.Text == ""
                || CmbBookIssue_author.Text == ""
                || CmbBookIssue_status.Text == "")
            {
                MessageBox.Show("Please select an item first!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bookID == 0)
            {
                MessageBox.Show("Please select a book to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var updatedIssuedBook = new Issue
                {
                    ID = bookID,
                    Issue_ID = txtBookIssue_id.Text,
                    Full_Name = txtBookIssue_name.Text,
                    Contact = txtBookIssue_contact.Text,
                    Email = txtBookIssue_email.Text,
                    Book_Title = CmbBookIssue_bookTitle.Text,
                    Author = CmbBookIssue_author.Text,
                    Status = CmbBookIssue_status.Text,
                    Issue_Date = BookIssue_issueDate.Value,
                    Return_Date = CmbBookIssue_returnDate.Value,
                };

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to UPDATE Book ID: " + bookID + " ?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    DbConnections.UpdateIssuedBookData(updatedIssuedBook);
                    
                    displayIssuedBook(); // Refresh the DataGridView
                    
                    ClearFields(); // Clear the input fields
                    
                    //bookID = 0;
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                var detailedMessage = $"An error occurred: {ex.Message}";
                if (ex.InnerException != null)
                {
                    detailedMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(detailedMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
