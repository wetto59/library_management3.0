namespace Library_manangement.Forms
{
    partial class BookRegistration
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
            buttonRegister = new Button();
            comboBoxClients = new ComboBox();
            comboBoxBooks = new ComboBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(14, 128, 87);
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegister.ForeColor = Color.WhiteSmoke;
            buttonRegister.Location = new Point(433, 99);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(140, 39);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += button1_Click;
            // 
            // comboBoxClients
            // 
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(157, 69);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(151, 28);
            comboBoxClients.TabIndex = 1;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(193, 110);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(151, 28);
            comboBoxBooks.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(649, 266);
            dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 47);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(195, 22);
            label8.TabIndex = 4;
            label8.Text = "Book Registration Form";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(577, 9);
            label7.Name = "label7";
            label7.Size = new Size(36, 22);
            label7.TabIndex = 3;
            label7.Text = "<=";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(641, 9);
            label6.Name = "label6";
            label6.Size = new Size(20, 22);
            label6.TabIndex = 2;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.8F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(752, 9);
            label2.Name = "label2";
            label2.Size = new Size(28, 22);
            label2.TabIndex = 1;
            label2.Text = "<=";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.8F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(813, 9);
            label1.Name = "label1";
            label1.Size = new Size(19, 22);
            label1.TabIndex = 0;
            label1.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 72);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 5;
            label3.Text = "Clients:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 113);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 6;
            label4.Text = "Books:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 160);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 7;
            label5.Text = "Return Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(243, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // BookRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(678, 482);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxBooks);
            Controls.Add(comboBoxClients);
            Controls.Add(buttonRegister);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookRegistration";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegister;
        private ComboBox comboBoxClients;
        private ComboBox comboBoxBooks;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}