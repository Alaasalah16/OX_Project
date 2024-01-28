namespace OXproject
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Xwin = new NumericUpDown();
            Owin = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Xwin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Owin).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(799, 321);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            label1.Location = new Point(62, 23);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 1;
            label1.Text = "PlayerOneName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            label2.Location = new Point(62, 77);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 2;
            label2.Text = "PlayerTwoName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            label3.Location = new Point(422, 23);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 3;
            label3.Text = "Xwin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            label4.Location = new Point(422, 77);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 4;
            label4.Text = "Owin";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            textBox1.Location = new Point(218, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 32);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            textBox2.Location = new Point(218, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 32);
            textBox2.TabIndex = 6;
            // 
            // Xwin
            // 
            Xwin.Location = new Point(493, 25);
            Xwin.Name = "Xwin";
            Xwin.Size = new Size(150, 27);
            Xwin.TabIndex = 7;
            // 
            // Owin
            // 
            Owin.Location = new Point(493, 75);
            Owin.Name = "Owin";
            Owin.Size = new Size(150, 27);
            Owin.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(683, 27);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(683, 75);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Owin);
            Controls.Add(Xwin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Xwin).EndInit();
            ((System.ComponentModel.ISupportInitialize)Owin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown Xwin;
        private NumericUpDown Owin;
        private Button button1;
        private Button button2;
    }
}