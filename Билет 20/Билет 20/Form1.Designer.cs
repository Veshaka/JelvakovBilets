namespace Билет_20
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
            fam = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            mail = new TextBox();
            addres = new TextBox();
            phone = new MaskedTextBox();
            date = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // fam
            // 
            fam.Location = new Point(108, 6);
            fam.Name = "fam";
            fam.Size = new Size(218, 23);
            fam.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Дата рождения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "Телефон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Адрес";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 5;
            label5.Text = "E-mail";
            // 
            // mail
            // 
            mail.Location = new Point(108, 122);
            mail.Name = "mail";
            mail.Size = new Size(218, 23);
            mail.TabIndex = 6;
            // 
            // addres
            // 
            addres.Location = new Point(108, 93);
            addres.Name = "addres";
            addres.Size = new Size(218, 23);
            addres.TabIndex = 7;
            // 
            // phone
            // 
            phone.Location = new Point(108, 64);
            phone.Mask = "+7(000)000-00-00";
            phone.Name = "phone";
            phone.Size = new Size(218, 23);
            phone.TabIndex = 8;
            // 
            // date
            // 
            date.Location = new Point(108, 35);
            date.Name = "date";
            date.Size = new Size(218, 23);
            date.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(12, 151);
            button2.Name = "button2";
            button2.Size = new Size(314, 23);
            button2.TabIndex = 11;
            button2.Text = "Внести";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 180);
            button1.Name = "button1";
            button1.Size = new Size(314, 23);
            button1.TabIndex = 12;
            button1.Text = "Данные в файле";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 219);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(date);
            Controls.Add(phone);
            Controls.Add(addres);
            Controls.Add(mail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fam);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fam;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox mail;
        private TextBox addres;
        private MaskedTextBox phone;
        private DateTimePicker date;
        private Button button2;
        private Button button1;
    }
}