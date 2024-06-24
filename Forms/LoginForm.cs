
using System.Data;
using Library_manangement.Data;

namespace Library_manangement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm rForm = new RegisterForm();
            rForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (txtLogUsername.Text == "" || txtLogPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //else
            var existingUser = CashedData.usersInfo.Where(u => u.UserName == txtLogUsername.Text).FirstOrDefault();

            if (existingUser == null)
            {
                MessageBox.Show("The username doesn't exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //има такъв 
            //провери паролата
            if (existingUser.Password != txtLogPassword.Text)
            {
                MessageBox.Show("The password is incorrect", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Succes Login
            CashedData.CurrentUser = existingUser;

            MessageBox.Show("Login Successfully!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainForm mForm = new MainForm();
            mForm.Show();
            this.Hide();

        }

        private void login_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            txtLogPassword.PasswordChar = login_checkBox.Checked ? '\0' : '*';
        }
    }
}
