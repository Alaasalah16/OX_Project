namespace OXproject
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            inputP1 = new TextBox();
            inputP2 = new TextBox();
            groupbox = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            groupbox.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "PlayerOneName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(527, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 1;
            label2.Text = "PlayerTwoName";
            // 
            // inputP1
            // 
            inputP1.Location = new Point(234, 47);
            inputP1.Margin = new Padding(4, 3, 4, 3);
            inputP1.Name = "inputP1";
            inputP1.Size = new Size(170, 28);
            inputP1.TabIndex = 2;
            // 
            // inputP2
            // 
            inputP2.Location = new Point(715, 50);
            inputP2.Margin = new Padding(4, 3, 4, 3);
            inputP2.Name = "inputP2";
            inputP2.Size = new Size(170, 28);
            inputP2.TabIndex = 3;
            // 
            // groupbox
            // 
            groupbox.Controls.Add(radioButton2);
            groupbox.Controls.Add(radioButton1);
            groupbox.Location = new Point(52, 125);
            groupbox.Margin = new Padding(4, 3, 4, 3);
            groupbox.Name = "groupbox";
            groupbox.Padding = new Padding(4, 3, 4, 3);
            groupbox.Size = new Size(441, 87);
            groupbox.TabIndex = 4;
            groupbox.TabStop = false;
            groupbox.Text = "PlayerOne";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(219, 36);
            radioButton2.Margin = new Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(44, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "O";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(22, 36);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(41, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "X";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(515, 125);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(430, 87);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "PlayerTwo";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(8, 50);
            radioButton4.Margin = new Padding(4, 3, 4, 3);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(41, 24);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "X";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(197, 50);
            radioButton3.Margin = new Padding(4, 3, 4, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(44, 24);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "O";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(376, 279);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(265, 53);
            button1.TabIndex = 6;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1100, 450);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupbox);
            Controls.Add(inputP2);
            Controls.Add(inputP1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Lucida Handwriting", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Form2";
            groupbox.ResumeLayout(false);
            groupbox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox inputP1;
        private TextBox inputP2;
        private GroupBox groupbox;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Button button1;
    }
}