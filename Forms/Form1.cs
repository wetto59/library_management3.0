using Library_manangement.Data;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;


namespace Library_manangement
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            using(var db = new LibraryDbContext())
            {
                CashedData.usersInfo = db.Users.ToList();
                CashedData.bookInfo = db.Books.ToList();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;
            if (panel2.Width >= 575) 
            {
                timer1.Stop();

                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();

            }
        }
    }
}
