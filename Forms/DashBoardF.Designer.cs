namespace Library_manangement
{
    partial class DashBoardF
    {
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
            panel4 = new Panel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 195);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(14, 128, 87);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(583, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(235, 144);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(160, 103);
            label5.Name = "label5";
            label5.Size = new Size(75, 41);
            label5.TabIndex = 2;
            label5.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(17, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(83, 18);
            label6.Name = "label6";
            label6.Size = new Size(150, 24);
            label6.TabIndex = 0;
            label6.Text = "Returned Books";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(14, 128, 87);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(311, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 144);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(160, 103);
            label3.Name = "label3";
            label3.Size = new Size(75, 41);
            label3.TabIndex = 2;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(27, 18);
            label4.Name = "label4";
            label4.Size = new Size(171, 24);
            label4.TabIndex = 0;
            label4.Text = "Registered Clients";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 128, 87);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(37, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 144);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(140, 103);
            label2.Name = "label2";
            label2.Size = new Size(95, 41);
            label2.TabIndex = 2;
            label2.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(83, 18);
            label1.Name = "label1";
            label1.Size = new Size(149, 24);
            label1.TabIndex = 0;
            label1.Text = "Available books";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(199, 329);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(408, 216);
            dataGridView1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 231);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 4;
            label7.Text = "By Author:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(133, 293);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 5;
            label8.Text = "By Book Title:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 290);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // DashBoardF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 561);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoardF";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
    }
    

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    //private void InitializeComponent()
    //    {
    //        this.components = new System.ComponentModel.Container();
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.ClientSize = new System.Drawing.Size(800, 450);
    //        this.Text = "DashBoardF";
    //    }

    //    #endregion
    //}
}
