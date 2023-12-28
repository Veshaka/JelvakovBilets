namespace Билет_17
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            result1 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            tabPage2 = new TabPage();
            label2 = new Label();
            result2 = new TextBox();
            button2 = new Button();
            textBox4 = new TextBox();
            comboBox2 = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(460, 66);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(result1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(492, 71);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Масса";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 10);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "кг";
            // 
            // result1
            // 
            result1.Location = new Point(217, 6);
            result1.Name = "result1";
            result1.Size = new Size(100, 23);
            result1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(136, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 2;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "фунт", "унция", "грамм" });
            comboBox1.Location = new Point(323, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "фунт";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(result2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(452, 38);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Расстояние";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 10);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 9;
            label2.Text = "м";
            // 
            // result2
            // 
            result2.Location = new Point(217, 6);
            result2.Name = "result2";
            result2.Size = new Size(100, 23);
            result2.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(136, 6);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 7;
            button2.Text = "=";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "дюйм", "сантиметр", "фут", "морская миля" });
            comboBox2.Location = new Point(323, 6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            comboBox2.Text = "дюйм";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 66);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox result1;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox result2;
        private Button button2;
        private TextBox textBox4;
        private ComboBox comboBox2;
    }
}