namespace Билет_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class Settings
        {
            public static int difficult { get; set; }
            public static int min { get; set; }
            public static int sec { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown2.Value == 0 && (int)numericUpDown3.Value < 1)
            {
                MessageBox.Show("Время не должно быть меньше 1 секунды");
                return;
            }
            Settings.difficult = (int)numericUpDown1.Value;
            Settings.min = (int)numericUpDown2.Value;
            Settings.sec = (int)numericUpDown3.Value;

            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }
    }
}