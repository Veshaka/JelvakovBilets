﻿namespace Билет_14
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
            menuStrip1 = new MenuStrip();
            прямоугольникToolStripMenuItem = new ToolStripMenuItem();
            элипсToolStripMenuItem = new ToolStripMenuItem();
            рядОкружностейToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { прямоугольникToolStripMenuItem, элипсToolStripMenuItem, рядОкружностейToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // прямоугольникToolStripMenuItem
            // 
            прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            прямоугольникToolStripMenuItem.Size = new Size(108, 20);
            прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            прямоугольникToolStripMenuItem.Click += прямоугольникToolStripMenuItem_Click;
            // 
            // элипсToolStripMenuItem
            // 
            элипсToolStripMenuItem.Name = "элипсToolStripMenuItem";
            элипсToolStripMenuItem.Size = new Size(53, 20);
            элипсToolStripMenuItem.Text = "Элипс";
            элипсToolStripMenuItem.Click += элипсToolStripMenuItem_Click;
            // 
            // рядОкружностейToolStripMenuItem
            // 
            рядОкружностейToolStripMenuItem.Name = "рядОкружностейToolStripMenuItem";
            рядОкружностейToolStripMenuItem.Size = new Size(114, 20);
            рядОкружностейToolStripMenuItem.Text = "Ряд окружностей";
            рядОкружностейToolStripMenuItem.Click += рядОкружностейToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 426);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem прямоугольникToolStripMenuItem;
        private ToolStripMenuItem элипсToolStripMenuItem;
        private ToolStripMenuItem рядОкружностейToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}