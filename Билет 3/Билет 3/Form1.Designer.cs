namespace Билет_3
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
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            result = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 12);
            numericUpDown1.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 1;
            button1.Text = "Решить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(12, 67);
            result.Name = "result";
            result.Size = new Size(0, 15);
            result.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(151, 98);
            Controls.Add(result);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label result;
    }
}