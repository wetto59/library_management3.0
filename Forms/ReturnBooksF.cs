using Library_manangement.Data;
using Library_manangement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_manangement.Forms
{
    public partial class ReturnBooksF : Form
    {
        
        public ReturnBooksF()
        {
            InitializeComponent();
            clientComboBox.SelectedIndexChanged += ClientComboBox_SelectedIndexChanged;
            PopulateComboBoxes();
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (clientComboBox.SelectedValue == null || bookComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select both a client and a book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int clientId = (int)clientComboBox.SelectedValue;
            int bookId = (int)bookComboBox.SelectedValue;

            ReturnBookCopy(clientId, bookId);

        }

        private void PopulateComboBoxes()
        {
            using (var dbContext = new LibraryDbContext())
            {
                var clients = dbContext.Clients.Select(c => new { c.ID, c.FullName }).ToList();
                var books = dbContext.Books.Select(b => new { b.ID, b.BookTitle }).ToList();

                clientComboBox.DisplayMember = "FullName";
                clientComboBox.ValueMember = "ID";
                clientComboBox.DataSource = clients;

                clientComboBox.SelectedIndexChanged += ClientComboBox_SelectedIndexChanged;

                
            }
        }

        private void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientComboBox.SelectedValue is int clientId)
            {
                PopulateBooksComboBox(clientId);
            }
        }

        private void PopulateBooksComboBox(int clientId)
        {
            using (var dbContext = new LibraryDbContext())
            {
                var borrowedBooks = from br in dbContext.BooksRegistrations
                                    join b in dbContext.Books on br.BookID equals b.ID
                                    where br.ClientID == clientId
                                    select new { b.ID, b.BookTitle };

                bookComboBox.DataSource = borrowedBooks.ToList();
                bookComboBox.DisplayMember = "BookTitle";
                bookComboBox.ValueMember = "ID";

                
            }
        }



        private static void ReturnBookCopy(int clientId, int bookId)
        {
            using (var dbContext = new LibraryDbContext())
            {
                var bookRegistration = dbContext.BooksRegistrations
                    .FirstOrDefault(br => br.ClientID == clientId && br.BookID == bookId);

                if (bookRegistration == null)
                {
                    MessageBox.Show("No borrowed record found for this client and book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bookRegistration.ReturnDate = DateTime.Now;

                var book = dbContext.Books.FirstOrDefault(b => b.ID == bookId);
                if (book != null)
                {
                    book.TotalCopies += 1;
                }
                else
                {
                    MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    dbContext.SaveChanges();
                    MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private static List<Book> GetBorrowedBooksByClient(int clientId)
        //{
        //    using (var dbContext = new LibraryDbContext())
        //    {
        //        var borrowedBooks = from br in dbContext.BooksRegistrations
        //                            join b in dbContext.Books on br.BookID equals b.ID
        //                            where br.ClientID == clientId
        //                            select b;

        //        return borrowedBooks.ToList();
        //    }
        //}
    }   
}
