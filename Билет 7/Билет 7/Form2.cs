using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Билет_7.Form1;

namespace Билет_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
            Inital();
        }

        public int Chislo = 0;
        public int popit = 0;
        public int min = 0;
        public int sec = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value < Chislo)
            {
                result.Text = "Число больше";
                popit--;
            }
            else
                if ((int)numericUpDown1.Value > Chislo)
            {
                result.Text = "Число меньше";
                popit--;
            }
            else
            {
                MessageBox.Show("Вы угадали число");
                Exit();
            }
            if (popit <= 0)
            {
                MessageBox.Show($"Вы проиграли число было {Chislo}");
                Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec <= 0)
            {
                min--;
                sec = 60;
            }

            sec--;
            tim.Text = $"Осталось времени = {min}:{sec}";

            if (min <= 0 && sec <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Время закончилось");
                Exit();
                return;
            }
        }

        private void Exit()
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void Inital()
        {
            popit = Settings.Prob;
            min = Settings.Min;
            sec = Settings.Sec;
            tim.Text = $"Осталось времени = {min}:{sec}";

            Random rnd = new Random();
            Chislo = rnd.Next(0, 100);
        }
    }
}
