namespace Билет_15
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
            richTextBox1 = new RichTextBox();
            fam = new TextBox();
            label1 = new Label();
            label2 = new Label();
            work = new TextBox();
            zapr = new TextBox();
            label3 = new Label();
            year = new TextBox();
            label4 = new Label();
            sex = new TextBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(864, 364);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // fam
            // 
            fam.Location = new Point(12, 397);
            fam.Name = "fam";
            fam.Size = new Size(131, 23);
            fam.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 379);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 379);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Должность";
            // 
            // work
            // 
            work.Location = new Point(149, 397);
            work.Name = "work";
            work.Size = new Size(131, 23);
            work.TabIndex = 5;
            // 
            // zapr
            // 
            zapr.Location = new Point(286, 397);
            zapr.Name = "zapr";
            zapr.Size = new Size(131, 23);
            zapr.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 379);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Зарплата";
            // 
            // year
            // 
            year.Location = new Point(423, 397);
            year.Name = "year";
            year.Size = new Size(131, 23);
            year.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 379);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 8;
            label4.Text = "Год рождения";
            // 
            // sex
            // 
            sex.Location = new Point(560, 397);
            sex.Name = "sex";
            sex.Size = new Size(131, 23);
            sex.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(560, 379);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 10;
            label5.Text = "Пол";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(756, 397);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 426);
            button1.Name = "button1";
            button1.Size = new Size(679, 23);
            button1.TabIndex = 13;
            button1.Text = "Загрузить файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 461);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(sex);
            Controls.Add(label5);
            Controls.Add(year);
            Controls.Add(label4);
            Controls.Add(zapr);
            Controls.Add(label3);
            Controls.Add(work);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fam);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox fam;
        private Label label1;
        private Label label2;
        private TextBox work;
        private TextBox zapr;
        private Label label3;
        private TextBox year;
        private Label label4;
        private TextBox sex;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Button button1;
    }
}