namespace Library_manangement
{
    partial class AddBooks
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel4 = new Panel();
            addBooks_ImportBtn = new Button();
            addBooks_clearBtn = new Button();
            addBooks_delBtn = new Button();
            addBooks_status = new ComboBox();
            label2 = new Label();
            addBooks_published = new DateTimePicker();
            addBooks_updateBtn = new Button();
            addBooks_addBtn = new Button();
            label8 = new Label();
            addBooks_author = new TextBox();
            label9 = new Label();
            addBooks_bookTitle = new TextBox();
            label10 = new Label();
            addBooks_picture = new PictureBox();
            label3 = new Label();
            addBooks_copies = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addBooks_picture).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(320, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 526);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(14, 128, 87);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(15, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(507, 431);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(addBooks_copies);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(addBooks_ImportBtn);
            panel4.Controls.Add(addBooks_clearBtn);
            panel4.Controls.Add(addBooks_delBtn);
            panel4.Controls.Add(addBooks_status);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(addBooks_published);
            panel4.Controls.Add(addBooks_updateBtn);
            panel4.Controls.Add(addBooks_addBtn);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(addBooks_author);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(addBooks_bookTitle);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(addBooks_picture);
            panel4.Location = new Point(9, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 526);
            panel4.TabIndex = 4;
            // 
            // addBooks_ImportBtn
            // 
            addBooks_ImportBtn.BackColor = Color.FromArgb(14, 128, 87);
            addBooks_ImportBtn.FlatAppearance.BorderSize = 0;
            addBooks_ImportBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addBooks_ImportBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            addBooks_ImportBtn.FlatStyle = FlatStyle.Flat;
            addBooks_ImportBtn.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBooks_ImportBtn.ForeColor = Color.WhiteSmoke;
            addBooks_ImportBtn.Location = new Point(82, 112);
            addBooks_ImportBtn.Name = "addBooks_ImportBtn";
            addBooks_ImportBtn.Size = new Size(100, 31);
            addBooks_ImportBtn.TabIndex = 22;
            addBooks_ImportBtn.Text = "Import";
            addBooks_ImportBtn.UseVisualStyleBackColor = false;
            addBooks_ImportBtn.Click += button1_Click;
            // 
            // addBooks_clearBtn
            // 
            addBooks_clearBtn.BackColor = Color.FromArgb(14, 128, 87);
            addBooks_clearBtn.FlatAppearance.BorderSize = 0;
            addBooks_clearBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addBooks_clearBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            addBooks_clearBtn.FlatStyle = FlatStyle.Flat;
            addBooks_clearBtn.Font = new Font("Arial Narrow", 10.2F);
            addBooks_clearBtn.ForeColor = Color.WhiteSmoke;
            addBooks_clearBtn.Location = new Point(144, 421);
            addBooks_clearBtn.Name = "addBooks_clearBtn";
            addBooks_clearBtn.Size = new Size(115, 40);
            addBooks_clearBtn.TabIndex = 21;
            addBooks_clearBtn.Text = "CLEAR";
            addBooks_clearBtn.UseVisualStyleBackColor = false;
            addBooks_clearBtn.Click += addBooks_clearBtn_Click;
            // 
            // addBooks_delBtn
            // 
            addBooks_delBtn.BackColor = Color.FromArgb(14, 128, 87);
            addBooks_delBtn.FlatAppearance.BorderSize = 0;
            addBooks_delBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addBooks_delBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            addBooks_delBtn.FlatStyle = FlatStyle.Flat;
            addBooks_delBtn.Font = new Font("Arial Narrow", 10.2F);
            addBooks_delBtn.ForeColor = Color.WhiteSmoke;
            addBooks_delBtn.Location = new Point(14, 421);
            addBooks_delBtn.Name = "addBooks_delBtn";
            addBooks_delBtn.Size = new Size(115, 40);
            addBooks_delBtn.TabIndex = 20;
            addBooks_delBtn.Text = "DELETE";
            addBooks_delBtn.UseVisualStyleBackColor = false;
            addBooks_delBtn.Click += addBooks_delBtn_Click;
            // 
            // addBooks_status
            // 
            addBooks_status.FormattingEnabled = true;
            addBooks_status.Items.AddRange(new object[] { "Available", "Not Available" });
            addBooks_status.Location = new Point(97, 323);
            addBooks_status.Name = "addBooks_status";
            addBooks_status.Size = new Size(162, 28);
            addBooks_status.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(37, 327);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 18;
            label2.Text = "Status:";
            // 
            // addBooks_published
            // 
            addBooks_published.Location = new Point(97, 279);
            addBooks_published.Name = "addBooks_published";
            addBooks_published.Size = new Size(162, 27);
            addBooks_published.TabIndex = 17;
            // 
            // addBooks_updateBtn
            // 
            addBooks_updateBtn.BackColor = Color.FromArgb(14, 128, 87);
            addBooks_updateBtn.FlatAppearance.BorderSize = 0;
            addBooks_updateBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addBooks_updateBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            addBooks_updateBtn.FlatStyle = FlatStyle.Flat;
            addBooks_updateBtn.Font = new Font("Arial Narrow", 10.2F);
            addBooks_updateBtn.ForeColor = Color.WhiteSmoke;
            addBooks_updateBtn.Location = new Point(146, 357);
            addBooks_updateBtn.Name = "addBooks_updateBtn";
            addBooks_updateBtn.Size = new Size(115, 40);
            addBooks_updateBtn.TabIndex = 16;
            addBooks_updateBtn.Text = "UPDATE";
            addBooks_updateBtn.UseVisualStyleBackColor = false;
            addBooks_updateBtn.Click += addBooks_updateBtn_Click;
            // 
            // addBooks_addBtn
            // 
            addBooks_addBtn.BackColor = Color.FromArgb(14, 128, 87);
            addBooks_addBtn.FlatAppearance.BorderSize = 0;
            addBooks_addBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addBooks_addBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            addBooks_addBtn.FlatStyle = FlatStyle.Flat;
            addBooks_addBtn.Font = new Font("Arial Narrow", 10.2F);
            addBooks_addBtn.ForeColor = Color.WhiteSmoke;
            addBooks_addBtn.Location = new Point(16, 357);
            addBooks_addBtn.Name = "addBooks_addBtn";
            addBooks_addBtn.Size = new Size(115, 40);
            addBooks_addBtn.TabIndex = 15;
            addBooks_addBtn.Text = "ADD";
            addBooks_addBtn.UseVisualStyleBackColor = false;
            addBooks_addBtn.Click += addBooks_addBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F);
            label8.Location = new Point(21, 285);
            label8.Name = "label8";
            label8.Size = new Size(72, 18);
            label8.TabIndex = 13;
            label8.Text = "Published:";
            // 
            // addBooks_author
            // 
            addBooks_author.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBooks_author.Location = new Point(97, 200);
            addBooks_author.Name = "addBooks_author";
            addBooks_author.Size = new Size(164, 24);
            addBooks_author.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9F);
            label9.Location = new Point(37, 203);
            label9.Name = "label9";
            label9.Size = new Size(56, 18);
            label9.TabIndex = 11;
            label9.Text = "Author:";
            // 
            // addBooks_bookTitle
            // 
            addBooks_bookTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBooks_bookTitle.Location = new Point(97, 158);
            addBooks_bookTitle.Name = "addBooks_bookTitle";
            addBooks_bookTitle.Size = new Size(164, 24);
            addBooks_bookTitle.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9F);
            label10.Location = new Point(16, 164);
            label10.Name = "label10";
            label10.Size = new Size(77, 18);
            label10.TabIndex = 9;
            label10.Text = "Book Title:";
            // 
            // addBooks_picture
            // 
            addBooks_picture.BackColor = SystemColors.ControlDark;
            addBooks_picture.Location = new Point(82, 15);
            addBooks_picture.Name = "addBooks_picture";
            addBooks_picture.Size = new Size(100, 100);
            addBooks_picture.TabIndex = 8;
            addBooks_picture.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.Location = new Point(1, 246);
            label3.Name = "label3";
            label3.Size = new Size(93, 18);
            label3.TabIndex = 23;
            label3.Text = "Total Copies:";
            // 
            // addBooks_copies
            // 
            addBooks_copies.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBooks_copies.Location = new Point(95, 240);
            addBooks_copies.Name = "addBooks_copies";
            addBooks_copies.Size = new Size(164, 24);
            addBooks_copies.TabIndex = 24;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "AddBooks";
            Size = new Size(880, 576);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addBooks_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel4;
        private ComboBox addBooks_status;
        private Label label2;
        private DateTimePicker addBooks_published;
        private Button addBooks_updateBtn;
        private Button addBooks_addBtn;
        private Label label8;
        private TextBox addBooks_author;
        private Label label9;
        private TextBox addBooks_bookTitle;
        private Label label10;
        private PictureBox addBooks_picture;
        private Button addBooks_clearBtn;
        private Button addBooks_delBtn;
        private Button addBooks_ImportBtn;
        private TextBox addBooks_copies;
        private Label label3;
    }
}
