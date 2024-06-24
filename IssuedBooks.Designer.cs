namespace Library_manangement
{
    partial class IssuedBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            CmbBookIssue_status = new ComboBox();
            label10 = new Label();
            BtnBoookIssue_clear = new Button();
            BtnBoookIssue_delete = new Button();
            BtnBoookIssue_update = new Button();
            BtnBoookIssue_add = new Button();
            CmbBookIssue_returnDate = new DateTimePicker();
            BookIssue_issueDate = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            CmbBookIssue_author = new ComboBox();
            CmbBookIssue_bookTitle = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtBookIssue_email = new TextBox();
            label5 = new Label();
            txtBookIssue_contact = new TextBox();
            label3 = new Label();
            txtBookIssue_name = new TextBox();
            label2 = new Label();
            txtBookIssue_id = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(CmbBookIssue_status);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(BtnBoookIssue_clear);
            panel1.Controls.Add(BtnBoookIssue_delete);
            panel1.Controls.Add(BtnBoookIssue_update);
            panel1.Controls.Add(BtnBoookIssue_add);
            panel1.Controls.Add(CmbBookIssue_returnDate);
            panel1.Controls.Add(BookIssue_issueDate);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(CmbBookIssue_author);
            panel1.Controls.Add(CmbBookIssue_bookTitle);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtBookIssue_email);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBookIssue_contact);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBookIssue_name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBookIssue_id);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(17, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 230);
            panel1.TabIndex = 0;
            // 
            // CmbBookIssue_status
            // 
            CmbBookIssue_status.FormattingEnabled = true;
            CmbBookIssue_status.Items.AddRange(new object[] { "Return", "Not Return" });
            CmbBookIssue_status.Location = new Point(583, 12);
            CmbBookIssue_status.Name = "CmbBookIssue_status";
            CmbBookIssue_status.Size = new Size(151, 28);
            CmbBookIssue_status.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(533, 15);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 23;
            label10.Text = "Status:";
            // 
            // BtnBoookIssue_clear
            // 
            BtnBoookIssue_clear.BackColor = Color.FromArgb(14, 128, 87);
            BtnBoookIssue_clear.FlatAppearance.BorderSize = 0;
            BtnBoookIssue_clear.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            BtnBoookIssue_clear.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            BtnBoookIssue_clear.FlatStyle = FlatStyle.Flat;
            BtnBoookIssue_clear.Font = new Font("Arial Narrow", 10.2F);
            BtnBoookIssue_clear.ForeColor = Color.WhiteSmoke;
            BtnBoookIssue_clear.Location = new Point(613, 173);
            BtnBoookIssue_clear.Name = "BtnBoookIssue_clear";
            BtnBoookIssue_clear.Size = new Size(115, 35);
            BtnBoookIssue_clear.TabIndex = 22;
            BtnBoookIssue_clear.Text = "CLEAR";
            BtnBoookIssue_clear.UseVisualStyleBackColor = false;
            // 
            // BtnBoookIssue_delete
            // 
            BtnBoookIssue_delete.BackColor = Color.FromArgb(14, 128, 87);
            BtnBoookIssue_delete.FlatAppearance.BorderSize = 0;
            BtnBoookIssue_delete.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            BtnBoookIssue_delete.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            BtnBoookIssue_delete.FlatStyle = FlatStyle.Flat;
            BtnBoookIssue_delete.Font = new Font("Arial Narrow", 10.2F);
            BtnBoookIssue_delete.ForeColor = Color.WhiteSmoke;
            BtnBoookIssue_delete.Location = new Point(476, 173);
            BtnBoookIssue_delete.Name = "BtnBoookIssue_delete";
            BtnBoookIssue_delete.Size = new Size(115, 35);
            BtnBoookIssue_delete.TabIndex = 21;
            BtnBoookIssue_delete.Text = "REMOVE";
            BtnBoookIssue_delete.UseVisualStyleBackColor = false;
            // 
            // BtnBoookIssue_update
            // 
            BtnBoookIssue_update.BackColor = Color.FromArgb(14, 128, 87);
            BtnBoookIssue_update.FlatAppearance.BorderSize = 0;
            BtnBoookIssue_update.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            BtnBoookIssue_update.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            BtnBoookIssue_update.FlatStyle = FlatStyle.Flat;
            BtnBoookIssue_update.Font = new Font("Arial Narrow", 10.2F);
            BtnBoookIssue_update.ForeColor = Color.WhiteSmoke;
            BtnBoookIssue_update.Location = new Point(331, 173);
            BtnBoookIssue_update.Name = "BtnBoookIssue_update";
            BtnBoookIssue_update.Size = new Size(115, 35);
            BtnBoookIssue_update.TabIndex = 20;
            BtnBoookIssue_update.Text = "UPDATE";
            BtnBoookIssue_update.UseVisualStyleBackColor = false;
            BtnBoookIssue_update.Click += BtnBoookIssue_update_Click;
            // 
            // BtnBoookIssue_add
            // 
            BtnBoookIssue_add.BackColor = Color.FromArgb(14, 128, 87);
            BtnBoookIssue_add.FlatAppearance.BorderSize = 0;
            BtnBoookIssue_add.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            BtnBoookIssue_add.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            BtnBoookIssue_add.FlatStyle = FlatStyle.Flat;
            BtnBoookIssue_add.Font = new Font("Arial Narrow", 10.2F);
            BtnBoookIssue_add.ForeColor = Color.WhiteSmoke;
            BtnBoookIssue_add.Location = new Point(182, 173);
            BtnBoookIssue_add.Name = "BtnBoookIssue_add";
            BtnBoookIssue_add.Size = new Size(115, 35);
            BtnBoookIssue_add.TabIndex = 19;
            BtnBoookIssue_add.Text = "ADD";
            BtnBoookIssue_add.UseVisualStyleBackColor = false;
            BtnBoookIssue_add.Click += BtnBoookIssue_add_Click;
            // 
            // CmbBookIssue_returnDate
            // 
            CmbBookIssue_returnDate.Location = new Point(376, 120);
            CmbBookIssue_returnDate.Name = "CmbBookIssue_returnDate";
            CmbBookIssue_returnDate.Size = new Size(242, 27);
            CmbBookIssue_returnDate.TabIndex = 18;
            // 
            // BookIssue_issueDate
            // 
            BookIssue_issueDate.Location = new Point(376, 81);
            BookIssue_issueDate.Name = "BookIssue_issueDate";
            BookIssue_issueDate.Size = new Size(242, 27);
            BookIssue_issueDate.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9F);
            label9.Location = new Point(314, 123);
            label9.Name = "label9";
            label9.Size = new Size(56, 18);
            label9.TabIndex = 16;
            label9.Text = "Return:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F);
            label8.Location = new Point(314, 84);
            label8.Name = "label8";
            label8.Size = new Size(49, 18);
            label8.TabIndex = 15;
            label8.Text = "Issue:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(740, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CmbBookIssue_author
            // 
            CmbBookIssue_author.FormattingEnabled = true;
            CmbBookIssue_author.Location = new Point(376, 46);
            CmbBookIssue_author.Name = "CmbBookIssue_author";
            CmbBookIssue_author.Size = new Size(151, 28);
            CmbBookIssue_author.TabIndex = 13;
            // 
            // CmbBookIssue_bookTitle
            // 
            CmbBookIssue_bookTitle.FormattingEnabled = true;
            CmbBookIssue_bookTitle.Location = new Point(376, 12);
            CmbBookIssue_bookTitle.Name = "CmbBookIssue_bookTitle";
            CmbBookIssue_bookTitle.Size = new Size(151, 28);
            CmbBookIssue_bookTitle.TabIndex = 12;
            CmbBookIssue_bookTitle.SelectedIndexChanged += CmbBookIssue_bookTitle_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F);
            label7.Location = new Point(314, 50);
            label7.Name = "label7";
            label7.Size = new Size(56, 18);
            label7.TabIndex = 11;
            label7.Text = "Author:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F);
            label6.Location = new Point(293, 16);
            label6.Name = "label6";
            label6.Size = new Size(77, 18);
            label6.TabIndex = 10;
            label6.Text = "Book Title:";
            // 
            // txtBookIssue_email
            // 
            txtBookIssue_email.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookIssue_email.Location = new Point(106, 120);
            txtBookIssue_email.Name = "txtBookIssue_email";
            txtBookIssue_email.Size = new Size(164, 24);
            txtBookIssue_email.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F);
            label5.Location = new Point(54, 123);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 8;
            label5.Text = "Email:";
            // 
            // txtBookIssue_contact
            // 
            txtBookIssue_contact.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookIssue_contact.Location = new Point(106, 81);
            txtBookIssue_contact.Name = "txtBookIssue_contact";
            txtBookIssue_contact.Size = new Size(164, 24);
            txtBookIssue_contact.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.Location = new Point(21, 84);
            label3.Name = "label3";
            label3.Size = new Size(79, 18);
            label3.TabIndex = 6;
            label3.Text = "Contact #:";
            // 
            // txtBookIssue_name
            // 
            txtBookIssue_name.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookIssue_name.Location = new Point(106, 47);
            txtBookIssue_name.Name = "txtBookIssue_name";
            txtBookIssue_name.Size = new Size(164, 24);
            txtBookIssue_name.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(48, 50);
            label2.Name = "label2";
            label2.Size = new Size(52, 18);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // txtBookIssue_id
            // 
            txtBookIssue_id.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookIssue_id.Location = new Point(106, 13);
            txtBookIssue_id.Name = "txtBookIssue_id";
            txtBookIssue_id.Size = new Size(164, 24);
            txtBookIssue_id.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F);
            label4.Location = new Point(30, 16);
            label4.Name = "label4";
            label4.Size = new Size(70, 18);
            label4.TabIndex = 2;
            label4.Text = "Issue ID:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(17, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 300);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 222);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(155, 24);
            label1.TabIndex = 0;
            label1.Text = "All Issued Books";
            // 
            // IssuedBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssuedBooks";
            Size = new Size(880, 576);
            Load += IssuedBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox CmbBookIssue_author;
        private ComboBox CmbBookIssue_bookTitle;
        private Label label7;
        private Label label6;
        private TextBox txtBookIssue_email;
        private Label label5;
        private TextBox txtBookIssue_contact;
        private Label label3;
        private TextBox txtBookIssue_name;
        private Label label2;
        private TextBox txtBookIssue_id;
        private Label label4;
        private DateTimePicker CmbBookIssue_returnDate;
        private DateTimePicker BookIssue_issueDate;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
        private Button BtnBoookIssue_clear;
        private Button BtnBoookIssue_delete;
        private Button BtnBoookIssue_update;
        private Button BtnBoookIssue_add;
        private ComboBox CmbBookIssue_status;
        private Label label10;
    }
}
