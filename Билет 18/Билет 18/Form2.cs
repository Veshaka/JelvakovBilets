using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Билет_18.Form1;

namespace Билет_18
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Initial();
        }

        public int min = 0;
        public int sec = 0;
        public int sc = 0;


        private void Initial()
        {
            min = Settings.min;
            sec = Settings.sec;
            tim.Text = $"Осталось времени : {min}:{sec}";
            timer1.Interval = 1000 / (Settings.difficult * 5);
            timer1.Start();
            timer2.Start();
        }

        private void Exit()
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int x = button1.Location.X + rnd.Next(-50, 50);
            int y = button1.Location.Y + rnd.Next(-50, 50);

            while (x < 100 || x > this.Width - 100)
                x = button1.Location.X + rnd.Next(-50, 50);
            while (y < 100 || y > this.Height - 100)
                y = button1.Location.Y + rnd.Next(-50, 50);

            button1.Location = new Point(x, y);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sec <= 0)
            {
                min--;
                sec = 60;
            }

            sec--;
            tim.Text = $"Осталось времени : {min}:{sec}";

            if (min <= 0 && sec <= 0)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show($"Время закончилось. Ваш результат {sc}");
                Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc++;
            score.Text = $"Счет : {sc}";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
