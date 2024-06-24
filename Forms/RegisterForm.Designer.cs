namespace Library_manangement
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            register_showPassword = new CheckBox();
            signin_btn = new Button();
            label5 = new Label();
            register_btn = new Button();
            txtRegPassword = new TextBox();
            label4 = new Label();
            txtRegUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            txtRegEmail = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // register_showPassword
            // 
            register_showPassword.AutoSize = true;
            register_showPassword.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showPassword.Location = new Point(145, 384);
            register_showPassword.Name = "register_showPassword";
            register_showPassword.Size = new Size(148, 25);
            register_showPassword.TabIndex = 21;
            register_showPassword.Text = "Show Password";
            register_showPassword.UseVisualStyleBackColor = true;
            register_showPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // signin_btn
            // 
            signin_btn.BackColor = Color.FromArgb(14, 128, 87);
            signin_btn.Cursor = Cursors.Hand;
            signin_btn.FlatAppearance.BorderSize = 0;
            signin_btn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            signin_btn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            signin_btn.FlatStyle = FlatStyle.Flat;
            signin_btn.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signin_btn.ForeColor = Color.WhiteSmoke;
            signin_btn.Location = new Point(23, 486);
            signin_btn.Name = "signin_btn";
            signin_btn.Size = new Size(278, 30);
            signin_btn.TabIndex = 20;
            signin_btn.Text = "SIGN IN";
            signin_btn.UseVisualStyleBackColor = false;
            signin_btn.Click += signin_btn_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(100, 469);
            label5.Name = "label5";
            label5.Size = new Size(137, 25);
            label5.TabIndex = 19;
            label5.Text = "Register Account";
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(14, 128, 87);
            register_btn.Cursor = Cursors.Hand;
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            register_btn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.WhiteSmoke;
            register_btn.Location = new Point(23, 415);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(278, 40);
            register_btn.TabIndex = 18;
            register_btn.Text = "REGISTER";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Font = new Font("Tahoma", 10.2F);
            txtRegPassword.Location = new Point(23, 349);
            txtRegPassword.Multiline = true;
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.PasswordChar = '*';
            txtRegPassword.Size = new Size(270, 30);
            txtRegPassword.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 324);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 16;
            label4.Text = "Password:";
            // 
            // txtRegUsername
            // 
            txtRegUsername.Font = new Font("Tahoma", 10.2F);
            txtRegUsername.Location = new Point(23, 282);
            txtRegUsername.Multiline = true;
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(270, 30);
            txtRegUsername.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 257);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 14;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(76, 153);
            label2.Name = "label2";
            label2.Size = new Size(161, 32);
            label2.TabIndex = 13;
            label2.Text = "Register Form";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 35);
            panel1.TabIndex = 11;
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
            // txtRegEmail
            // 
            txtRegEmail.Font = new Font("Tahoma", 10.2F);
            txtRegEmail.Location = new Point(23, 215);
            txtRegEmail.Multiline = true;
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(270, 30);
            txtRegEmail.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 190);
            label6.Name = "label6";
            label6.Size = new Size(126, 22);
            label6.TabIndex = 22;
            label6.Text = "Email Address:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(320, 525);
            Controls.Add(txtRegEmail);
            Controls.Add(label6);
            Controls.Add(register_showPassword);
            Controls.Add(signin_btn);
            Controls.Add(label5);
            Controls.Add(register_btn);
            Controls.Add(txtRegPassword);
            Controls.Add(label4);
            Controls.Add(txtRegUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox register_showPassword;
        private Button signin_btn;
        private Label label5;
        private Button register_btn;
        private TextBox txtRegPassword;
        private Label label4;
        private TextBox txtRegUsername;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox txtRegEmail;
        private Label label6;
    }
}