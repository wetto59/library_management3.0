using Library_manangement.Data;
using Library_manangement.Models;
using Library_manangement.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_manangement
{
    public partial class AddBooks : UserControl
    {
        private Book selectedBook;
        private int bookID = 0;
      

        public AddBooks()
        {
            InitializeComponent();
            DisplayBooks();

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string imagePath = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addBooks_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void addBooks_addBtn_Click(object sender, EventArgs e)
        {
            if (addBooks_picture.Image == null
                || addBooks_bookTitle.Text == ""
                || addBooks_copies.Text == ""
                || addBooks_author.Text == ""
                || addBooks_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(addBooks_copies.Text, out int totalCopies))
            {
                MessageBox.Show("Please enter a valid number for copies", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newBook = new Book
            {
                BookTitle = addBooks_bookTitle.Text,
                Author = addBooks_author.Text,
                TotalCopies = totalCopies,
                Published = addBooks_published.Value,
                Status = addBooks_status.Text,
                DataInsert = DateTime.Now,
                ID = bookID
            };

            DbConnections.AddBookData(newBook);

            CashedData.CurrentBook = newBook;

            ClearFields();

            DisplayBooks();
        }

        public void ClearFields()
        {
            addBooks_bookTitle.Text = "";
            addBooks_author.Text = "";
            addBooks_status.SelectedIndex = -1;
        }

        public void DisplayBooks()
        {
            List<Book> books = DbConnections.GetBooks();
            dataGridView1.DataSource = books;
        }

        private void addBooks_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void addBooks_updateBtn_Click(object sender, EventArgs e)
        {
            if (addBooks_bookTitle.Text == ""
                || addBooks_author.Text == ""
                || addBooks_status.Text == "")
            {
                MessageBox.Show("Please select an item first!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bookID == 0)
            {
                MessageBox.Show("Please select a book to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(addBooks_copies.Text, out int totalCopies))
            {
                MessageBox.Show("Please enter a valid number for copies", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var updatedBook = new Book
            {
                ID = bookID,
                BookTitle = addBooks_bookTitle.Text,
                Author = addBooks_author.Text,
                Published = addBooks_published.Value,
                Status = addBooks_status.Text,
                DateUpdate = DateTime.Now,
                TotalCopies = totalCopies
            };

            CashedData.CurrentBook = updatedBook;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to UPDATE Book ID: " + bookID + " ?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DbConnections.UpdateBookData(updatedBook);
                DisplayBooks(); // Refresh the DataGridView
                ClearFields(); // Clear the input fields
                bookID = 0;
            }
            else
            {
                MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bookID = (int)row.Cells[0].Value;
                addBooks_bookTitle.Text = row.Cells[1].Value.ToString();
                addBooks_author.Text = row.Cells[2].Value.ToString();
                addBooks_copies.Text = row.Cells[3].Value.ToString();
                addBooks_published.Text = row.Cells[4].Value.ToString();
                addBooks_status.Text = row.Cells[5].Value.ToString();
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                if (selectedRowIndex >= 0)
                {
                    selectedBook = dataGridView1.SelectedRows[0].DataBoundItem as Book;

                    if (selectedBook != null)
                    {
                        addBooks_bookTitle.Text = selectedBook.BookTitle;
                        addBooks_author.Text = selectedBook.Author;
                        addBooks_copies.Text = selectedBook.TotalCopies.ToString();
                        addBooks_published.Value = selectedBook.Published;
                        addBooks_status.Text = selectedBook.Status;
                    }
                }
            }
        }

        private void addBooks_delBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            bookID = (int)selectedRow.Cells["ID"].Value;

            var deletedBook = new Book
            {
                ID = bookID
            };


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE Book ID: " + bookID + " ?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DbConnections.DeleteBookData(deletedBook);
                DisplayBooks(); // Refresh the DataGridView
                ClearFields(); // Clear the input fields
                bookID = 0;
            }
            else
            {
                MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
    }
}
