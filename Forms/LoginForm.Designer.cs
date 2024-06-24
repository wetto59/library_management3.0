namespace Library_manangement
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtLogUsername = new TextBox();
            txtLogPassword = new TextBox();
            label4 = new Label();
            loginBtn = new Button();
            label5 = new Label();
            signupBtn = new Button();
            login_checkBox = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 35);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(19, 22);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(69, 155);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 2;
            label2.Text = "Welcome, User!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 221);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // txtLogUsername
            // 
            txtLogUsername.Font = new Font("Tahoma", 10.2F);
            txtLogUsername.Location = new Point(23, 246);
            txtLogUsername.Multiline = true;
            txtLogUsername.Name = "txtLogUsername";
            txtLogUsername.Size = new Size(270, 30);
            txtLogUsername.TabIndex = 4;
            // 
            // txtLogPassword
            // 
            txtLogPassword.Font = new Font("Tahoma", 10.2F);
            txtLogPassword.Location = new Point(23, 313);
            txtLogPassword.Multiline = true;
            txtLogPassword.Name = "txtLogPassword";
            txtLogPassword.PasswordChar = '*';
            txtLogPassword.Size = new Size(270, 30);
            txtLogPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 288);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(14, 128, 87);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            loginBtn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.WhiteSmoke;
            loginBtn.Location = new Point(23, 386);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(278, 40);
            loginBtn.TabIndex = 7;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(110, 440);
            label5.Name = "label5";
            label5.Size = new Size(137, 25);
            label5.TabIndex = 8;
            label5.Text = "Register Account";
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.FromArgb(14, 128, 87);
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.FlatAppearance.BorderSize = 0;
            signupBtn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            signupBtn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            signupBtn.FlatStyle = FlatStyle.Flat;
            signupBtn.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupBtn.ForeColor = Color.WhiteSmoke;
            signupBtn.Location = new Point(23, 477);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(278, 30);
            signupBtn.TabIndex = 9;
            signupBtn.Text = "SIGN UP";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += signupBtn_Click;
            // 
            // login_checkBox
            // 
            login_checkBox.AutoSize = true;
            login_checkBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_checkBox.Location = new Point(145, 349);
            login_checkBox.Name = "login_checkBox";
            login_checkBox.Size = new Size(148, 25);
            login_checkBox.TabIndex = 10;
            login_checkBox.Text = "Show Password";
            login_checkBox.UseVisualStyleBackColor = true;
            login_checkBox.CheckedChanged += login_checkBox_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(320, 525);
            Controls.Add(login_checkBox);
            Controls.Add(signupBtn);
            Controls.Add(label5);
            Controls.Add(loginBtn);
            Controls.Add(txtLogPassword);
            Controls.Add(label4);
            Controls.Add(txtLogUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtLogUsername;
        private TextBox txtLogPassword;
        private Label label4;
        private Button loginBtn;
        private Label label5;
        private Button signupBtn;
        private CheckBox login_checkBox;
    }
}