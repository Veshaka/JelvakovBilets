namespace Билет_12
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
            domainUpDown1 = new DomainUpDown();
            factor = new Label();
            fibonachi = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("2");
            domainUpDown1.Items.Add("3");
            domainUpDown1.Items.Add("4");
            domainUpDown1.Items.Add("5");
            domainUpDown1.Items.Add("6");
            domainUpDown1.Items.Add("7");
            domainUpDown1.Items.Add("8");
            domainUpDown1.Items.Add("9");
            domainUpDown1.Items.Add("10");
            domainUpDown1.Items.Add("11");
            domainUpDown1.Items.Add("12");
            domainUpDown1.Items.Add("13");
            domainUpDown1.Items.Add("14");
            domainUpDown1.Items.Add("15");
            domainUpDown1.Location = new Point(12, 12);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.RightToLeft = RightToLeft.No;
            domainUpDown1.Size = new Size(266, 23);
            domainUpDown1.TabIndex = 0;
            domainUpDown1.Text = "2";
            // 
            // factor
            // 
            factor.AutoSize = true;
            factor.Location = new Point(12, 67);
            factor.Name = "factor";
            factor.Size = new Size(38, 15);
            factor.TabIndex = 1;
            factor.Text = "label1";
            // 
            // fibonachi
            // 
            fibonachi.AutoSize = true;
            fibonachi.Location = new Point(12, 94);
            fibonachi.Name = "fibonachi";
            fibonachi.Size = new Size(38, 15);
            fibonachi.TabIndex = 2;
            fibonachi.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(266, 23);
            button1.TabIndex = 3;
            button1.Text = "Решить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 121);
            Controls.Add(button1);
            Controls.Add(fibonachi);
            Controls.Add(factor);
            Controls.Add(domainUpDown1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown domainUpDown1;
        private Label factor;
        private Label fibonachi;
        private Button button1;
    }
}