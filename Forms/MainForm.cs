using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
using Library_manangement.Forms;

namespace Library_manangement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DashBoardF dashBoardF = new DashBoardF();
            dashBoardF.TopLevel = false;
            this.panel3.Controls.Add(dashBoardF);
            dashBoardF.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();
            }
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            AddBooksF addBooks = new AddBooksF();


            this.panel3.Controls.Clear();

            addBooks.TopLevel = false;

            addBooks.FormBorderStyle = FormBorderStyle.None;

            addBooks.Dock = DockStyle.Fill;

            this.panel3.Controls.Add(addBooks);

            addBooks.Show();
        }

        private void btnAddClients_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
           
            this.panel3.Controls.Clear();

            addClient.TopLevel = false;

            addClient.FormBorderStyle = FormBorderStyle.None;

            addClient.Dock = DockStyle.Fill;

            this.panel3.Controls.Add(addClient);

            addClient.Show();
        }

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            BookRegistration booksRegistration = new BookRegistration();


            this.panel3.Controls.Clear();

            booksRegistration.TopLevel = false;

            booksRegistration.FormBorderStyle = FormBorderStyle.None;

            booksRegistration.Dock = DockStyle.Fill;

            this.panel3.Controls.Add(booksRegistration);

            booksRegistration.Show();
        }

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            ReturnBooksF returnBook = new ReturnBooksF();


            this.panel3.Controls.Clear();

            returnBook.TopLevel = false;

            returnBook.FormBorderStyle = FormBorderStyle.None;

            returnBook.Dock = DockStyle.Fill;

            this.panel3.Controls.Add(returnBook);

            returnBook.Show();
        }
    }
}
