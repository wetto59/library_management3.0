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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string authorName = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(authorName))
            {
                DisplayBooksByAuthor(authorName);
            }
        }

        private void DisplayBooksByAuthor(string authorName)
        {
            using (var dbContext = new LibraryDbContext())
            {
                var booksByAuthor = dbContext.GetBooksByAuthor(authorName);
                dataGridView1.DataSource = booksByAuthor;
            }
        }
    }
}
