using Library_manangement.Data;
using Library_manangement.Models;
using Library_manangement.Services;


namespace Library_manangement
{
    public partial class RegisterForm : Form
    {
        LibraryDbContext db = new LibraryDbContext();
        
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtRegPassword.PasswordChar = register_showPassword.Checked ? '\0' : '*';
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            LoginForm lForm = new LoginForm();
            lForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (txtRegEmail.Text == "" || txtRegUsername.Text == "" || txtRegPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var existingUser = CashedData.usersInfo.FirstOrDefault(u => u.UserName == txtRegUsername.Text);
                //context.Users.FirstOrDefault(u => u.UserName == txtRegUsername.Text);
                if (existingUser != null)
                {
                    MessageBox.Show("Username already exists. Please choose a different one.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var newUser = new User 
                    { 
                        UserName = txtRegUsername.Text, 
                        Password = txtRegPassword.Text,
                        Email = txtRegEmail.Text,
                        DateRegister = DateTime.Now
                    };
                    DbConnections.AddUserInDB(newUser);


                    LoginForm lForm = new LoginForm();
                    lForm.Show();
                    this.Hide();
                }

            }
        }

        
    }
}
