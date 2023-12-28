namespace Билет_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            a = new TextBox();
            b = new TextBox();
            c = new TextBox();
            label1 = new Label();
            label2 = new Label();
            index1 = new Label();
            index2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            resultX1 = new Label();
            resultX2 = new Label();
            resultX4 = new Label();
            resultX3 = new Label();
            SuspendLayout();
            // 
            // a
            // 
            a.Location = new Point(12, 12);
            a.Name = "a";
            a.Size = new Size(100, 23);
            a.TabIndex = 0;
            // 
            // b
            // 
            b.Location = new Point(145, 12);
            b.Name = "b";
            b.Size = new Size(100, 23);
            b.TabIndex = 1;
            // 
            // c
            // 
            c.Location = new Point(278, 12);
            c.Name = "c";
            c.Size = new Size(100, 23);
            c.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 12);
            label1.Name = "label1";
            label1.Size = new Size(21, 25);
            label1.TabIndex = 3;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(251, 12);
            label2.Name = "label2";
            label2.Size = new Size(21, 25);
            label2.TabIndex = 4;
            label2.Text = "x";
            // 
            // index1
            // 
            index1.AutoSize = true;
            index1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            index1.Location = new Point(131, 9);
            index1.Name = "index1";
            index1.Size = new Size(13, 13);
            index1.TabIndex = 5;
            index1.Text = "2";
            // 
            // index2
            // 
            index2.AutoSize = true;
            index2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            index2.Location = new Point(263, 9);
            index2.Name = "index2";
            index2.Size = new Size(0, 13);
            index2.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(400, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Кубическое";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(400, 37);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(101, 19);
            radioButton2.TabIndex = 8;
            radioButton2.Text = "Биквадратное";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(366, 23);
            button1.TabIndex = 9;
            button1.Text = "Решить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultX1
            // 
            resultX1.AutoSize = true;
            resultX1.Location = new Point(12, 67);
            resultX1.Name = "resultX1";
            resultX1.Size = new Size(0, 15);
            resultX1.TabIndex = 10;
            // 
            // resultX2
            // 
            resultX2.AutoSize = true;
            resultX2.Location = new Point(12, 82);
            resultX2.Name = "resultX2";
            resultX2.Size = new Size(0, 15);
            resultX2.TabIndex = 11;
            // 
            // resultX4
            // 
            resultX4.AutoSize = true;
            resultX4.Location = new Point(224, 82);
            resultX4.Name = "resultX4";
            resultX4.Size = new Size(0, 15);
            resultX4.TabIndex = 12;
            // 
            // resultX3
            // 
            resultX3.AutoSize = true;
            resultX3.Location = new Point(224, 67);
            resultX3.Name = "resultX3";
            resultX3.Size = new Size(0, 15);
            resultX3.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 116);
            Controls.Add(resultX3);
            Controls.Add(resultX4);
            Controls.Add(resultX2);
            Controls.Add(resultX1);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(index2);
            Controls.Add(index1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(c);
            Controls.Add(b);
            Controls.Add(a);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox a;
        private TextBox b;
        private TextBox c;
        private Label label1;
        private Label label2;
        private Label index1;
        private Label index2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Label resultX1;
        private Label resultX2;
        private Label resultX4;
        private Label resultX3;
    }
}