namespace Library_manangement
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            panel1 = new Panel();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            Btn_AddClientClear = new Button();
            Btn_AddClientDelete = new Button();
            Btn_AddClientUpdate = new Button();
            Btn_AddClientAdd = new Button();
            Txt_AddClientContact = new TextBox();
            Txt_AddClientEmail = new TextBox();
            Txt_AddClientFullName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 34);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(796, 6);
            label7.Name = "label7";
            label7.Size = new Size(33, 25);
            label7.TabIndex = 2;
            label7.Text = "<-";
            label7.Click += label7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(145, 22);
            label2.TabIndex = 1;
            label2.Text = "Add Clients Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(835, 6);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(Btn_AddClientClear);
            panel2.Controls.Add(Btn_AddClientDelete);
            panel2.Controls.Add(Btn_AddClientUpdate);
            panel2.Controls.Add(Btn_AddClientAdd);
            panel2.Controls.Add(Txt_AddClientContact);
            panel2.Controls.Add(Txt_AddClientEmail);
            panel2.Controls.Add(Txt_AddClientFullName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 472);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Btn_AddClientClear
            // 
            Btn_AddClientClear.BackColor = Color.FromArgb(14, 128, 87);
            Btn_AddClientClear.FlatStyle = FlatStyle.Flat;
            Btn_AddClientClear.Font = new Font("Arial Narrow", 10.2F);
            Btn_AddClientClear.ForeColor = Color.WhiteSmoke;
            Btn_AddClientClear.Location = new Point(128, 418);
            Btn_AddClientClear.Name = "Btn_AddClientClear";
            Btn_AddClientClear.Size = new Size(110, 40);
            Btn_AddClientClear.TabIndex = 11;
            Btn_AddClientClear.Text = "CLEAR";
            Btn_AddClientClear.UseVisualStyleBackColor = false;
            Btn_AddClientClear.Click += Btn_AddClientClear_Click;
            // 
            // Btn_AddClientDelete
            // 
            Btn_AddClientDelete.BackColor = Color.FromArgb(14, 128, 87);
            Btn_AddClientDelete.FlatStyle = FlatStyle.Flat;
            Btn_AddClientDelete.Font = new Font("Arial Narrow", 10.2F);
            Btn_AddClientDelete.ForeColor = Color.WhiteSmoke;
            Btn_AddClientDelete.Location = new Point(7, 418);
            Btn_AddClientDelete.Name = "Btn_AddClientDelete";
            Btn_AddClientDelete.Size = new Size(99, 40);
            Btn_AddClientDelete.TabIndex = 10;
            Btn_AddClientDelete.Text = "DELETE";
            Btn_AddClientDelete.UseVisualStyleBackColor = false;
            Btn_AddClientDelete.Click += Btn_AddClientDelete_Click;
            // 
            // Btn_AddClientUpdate
            // 
            Btn_AddClientUpdate.BackColor = Color.FromArgb(14, 128, 87);
            Btn_AddClientUpdate.FlatStyle = FlatStyle.Flat;
            Btn_AddClientUpdate.Font = new Font("Arial Narrow", 10.2F);
            Btn_AddClientUpdate.ForeColor = Color.WhiteSmoke;
            Btn_AddClientUpdate.Location = new Point(128, 357);
            Btn_AddClientUpdate.Name = "Btn_AddClientUpdate";
            Btn_AddClientUpdate.Size = new Size(110, 40);
            Btn_AddClientUpdate.TabIndex = 9;
            Btn_AddClientUpdate.Text = "UPDATE";
            Btn_AddClientUpdate.UseVisualStyleBackColor = false;
            Btn_AddClientUpdate.Click += Btn_AddClientUpdate_Click;
            // 
            // Btn_AddClientAdd
            // 
            Btn_AddClientAdd.BackColor = Color.FromArgb(14, 128, 87);
            Btn_AddClientAdd.FlatStyle = FlatStyle.Flat;
            Btn_AddClientAdd.Font = new Font("Arial Narrow", 10.2F);
            Btn_AddClientAdd.ForeColor = Color.WhiteSmoke;
            Btn_AddClientAdd.Location = new Point(7, 357);
            Btn_AddClientAdd.Name = "Btn_AddClientAdd";
            Btn_AddClientAdd.Size = new Size(99, 40);
            Btn_AddClientAdd.TabIndex = 8;
            Btn_AddClientAdd.Text = "ADD";
            Btn_AddClientAdd.UseVisualStyleBackColor = false;
            Btn_AddClientAdd.Click += Btn_AddClientAdd_Click;
            // 
            // Txt_AddClientContact
            // 
            Txt_AddClientContact.Location = new Point(83, 311);
            Txt_AddClientContact.Name = "Txt_AddClientContact";
            Txt_AddClientContact.Size = new Size(155, 27);
            Txt_AddClientContact.TabIndex = 6;
            // 
            // Txt_AddClientEmail
            // 
            Txt_AddClientEmail.Location = new Point(83, 267);
            Txt_AddClientEmail.Name = "Txt_AddClientEmail";
            Txt_AddClientEmail.Size = new Size(155, 27);
            Txt_AddClientEmail.TabIndex = 5;
            // 
            // Txt_AddClientFullName
            // 
            Txt_AddClientFullName.Location = new Point(83, 216);
            Txt_AddClientFullName.Name = "Txt_AddClientFullName";
            Txt_AddClientFullName.Size = new Size(155, 27);
            Txt_AddClientFullName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 318);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 2;
            label5.Text = "Contact:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 270);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 1;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 219);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "Full Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(275, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 472);
            panel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(18, 11);
            label6.Name = "label6";
            label6.Size = new Size(62, 22);
            label6.TabIndex = 1;
            label6.Text = "Clients";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(561, 416);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 128, 87);
            ClientSize = new Size(862, 529);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddClient";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button Btn_AddClientClear;
        private Button Btn_AddClientDelete;
        private Button Btn_AddClientUpdate;
        private Button Btn_AddClientAdd;
        private TextBox Txt_AddClientContact;
        private TextBox Txt_AddClientEmail;
        private TextBox Txt_AddClientFullName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label7;
        private PictureBox pictureBox1;
    }
}