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
    public partial class BookRegistration : Form
    {
        public BookRegistration()
        {
            InitializeComponent();
            LoadClients();
            LoadBooks();
            DisplayBorrowedBooks();
        }

        private void LoadClients()
        {
            using (var dbContext = new LibraryDbContext())
            {
                var clients = dbContext.Clients.ToList();
                comboBoxClients.DataSource = clients;
                comboBoxClients.DisplayMember = "FullName";
                comboBoxClients.ValueMember = "ID";
            }
        }

        private void LoadBooks()
        {
            using (var dbContext = new LibraryDbContext())
            {
                var books = dbContext.Books.ToList();
                comboBoxBooks.DataSource = books;
                comboBoxBooks.DisplayMember = "BookTitle";
                comboBoxBooks.ValueMember = "ID";
            }
        }

        private void DisplayBorrowedBooks()
        {
            using (var dbContext = new LibraryDbContext())
            {
                var borrowedBooks = from br in dbContext.BooksRegistrations
                                    join b in dbContext.Books on br.BookID equals b.ID
                                    join c in dbContext.Clients on br.ClientID equals c.ID
                                    select new BorrowedBookViewModel
                                    {
                                        ID = br.ID,
                                        ClientName = c.FullName,
                                        BookTitle = b.BookTitle,
                                        RegistrationDate = br.RegistrationDate,
                                        ReturnDate = br.ReturnDate,
                                    };

                dataGridView1.DataSource = borrowedBooks.ToList();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int clientId = (int)comboBoxClients.SelectedValue;
            int bookId = (int)comboBoxBooks.SelectedValue;

            RegisterBook(clientId, bookId);
        }

        private void RegisterBook(int cid, int bid)
        {
            using (var dbContext = new LibraryDbContext())
            {
                var book = dbContext.Books.FirstOrDefault(b => b.ID == bid);

                if (book == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

                if (book.TotalCopies < 1)
                {
                    MessageBox.Show("No copies available.");
                    return;
                }

                var client = dbContext.Clients.FirstOrDefault(c => c.ID == cid);
                if (client == null)
                {
                    MessageBox.Show("Client not found.");
                    return;
                }

                var registration = new BooksRegistration
                {
                    BookID = bid,
                    ClientID = cid,
                    RegistrationDate = DateTime.Now,
                    ReturnDate = dateTimePicker1.Value,
                };

                dbContext.BooksRegistrations.Add(registration);
                book.TotalCopies -= 1;

                if (book.TotalCopies < 1)
                {
                    book.Status = "Not Available";
                }

                try
                {
                    dbContext.SaveChanges();
                    MessageBox.Show("Book registered successfully.");
                    DisplayBorrowedBooks();
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

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
