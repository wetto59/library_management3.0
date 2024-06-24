namespace Library_manangement.Forms
{
    partial class ReturnBooksF
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
            panel3 = new Panel();
            panel4 = new Panel();
            bookComboBox = new ComboBox();
            clientComboBox = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            panel5 = new Panel();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 503);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(-1, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 526);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(bookComboBox);
            panel4.Controls.Add(clientComboBox);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(-1, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 526);
            panel4.TabIndex = 2;
            // 
            // bookComboBox
            // 
            bookComboBox.FormattingEnabled = true;
            bookComboBox.Location = new Point(99, 219);
            bookComboBox.Name = "bookComboBox";
            bookComboBox.Size = new Size(162, 28);
            bookComboBox.TabIndex = 18;
            // 
            // clientComboBox
            // 
            clientComboBox.FormattingEnabled = true;
            clientComboBox.Location = new Point(99, 170);
            clientComboBox.Name = "clientComboBox";
            clientComboBox.Size = new Size(162, 28);
            clientComboBox.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(14, 128, 87);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 10.2F);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(67, 289);
            button1.Name = "button1";
            button1.Size = new Size(115, 40);
            button1.TabIndex = 15;
            button1.Text = "RETURN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(82, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F);
            label5.Location = new Point(26, 223);
            label5.Name = "label5";
            label5.Size = new Size(77, 18);
            label5.TabIndex = 2;
            label5.Text = "Book Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F);
            label4.Location = new Point(12, 174);
            label4.Name = "label4";
            label4.Size = new Size(91, 18);
            label4.TabIndex = 0;
            label4.Text = "Client Name:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(97, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 24);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 47);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 0;
            label3.Text = "Issue ID:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(97, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 24);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 0;
            label2.Text = "Issue ID:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(324, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 503);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(507, 431);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 0;
            label1.Text = "All Issued Books";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(14, 128, 87);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(862, 34);
            panel5.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(780, 9);
            label7.Name = "label7";
            label7.Size = new Size(40, 24);
            label7.TabIndex = 1;
            label7.Text = "<=";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(831, 9);
            label6.Name = "label6";
            label6.Size = new Size(22, 24);
            label6.TabIndex = 0;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // ReturnBooksF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 556);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReturnBooksF";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button button1;
        private ComboBox bookComboBox;
        private ComboBox clientComboBox;
        private ColorDialog colorDialog1;
        #region Windows Form Designer generated code


        #endregion

        private Panel panel5;
        private Label label6;
        private Label label7;
    }
}