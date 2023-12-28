namespace Билет_7
{
    public partial class Form1 : Form
    {

        public static class Settings
        {
            public static int Prob { get; set; }
            public static int Min { get; set; }
            public static int Sec { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown2.Value == 0 && (int)numericUpDown3.Value < 1)
            {
                MessageBox.Show("Время игры не заданно, минимальное время 1 сек");
                return;
            }
            Settings.Prob = (int)numericUpDown1.Value;
            Settings.Min = (int)numericUpDown2.Value;
            Settings.Sec = (int)numericUpDown3.Value;

            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}