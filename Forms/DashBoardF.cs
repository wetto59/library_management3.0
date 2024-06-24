using Library_manangement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_manangement
{
    public partial class DashBoardF : Form
    {
        public DashBoardF()
        {
            InitializeComponent();
            DisplayDashboardCounts();
        }

        private void DisplayDashboardCounts()
        {
            using (var dbContext = new LibraryDbContext())
            {
                // Update labels with counts
                label2.Text = dbContext.GetAvailableBooksCount().ToString();
                label3.Text = dbContext.GetRegisteredClientsCount().ToString();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //string authorName = textBox1.Text.Trim();
            //if (!string.IsNullOrEmpty(authorName))
            //{
            //    DisplayBooksByAuthor(authorName);
            //}
        }
        private void DisplayBooksByAuthor(string authorName)
        {
            using (var dbContext = new LibraryDbContext())
            {
                var booksByAuthor = dbContext.GetBooksByAuthor(authorName);
                dataGridView1.DataSource = booksByAuthor;
            }
        }

        private void DisplayBooksByTitleKeyword(string keyword)
        {
            using (var dbContext = new LibraryDbContext())
            {
                var booksByTitle = dbContext.GetBooksByTitleKeyword(keyword);
                dataGridView1.DataSource = booksByTitle;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = textBox2.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                DisplayBooksByTitleKeyword(keyword);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string authorName = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(authorName))
            {
                DisplayBooksByAuthor(authorName);
            }
        }
    }
}
