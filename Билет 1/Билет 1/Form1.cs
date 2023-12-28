namespace Билет_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rightPoint = 0;
            if (textBox1.Text == "Программист" || textBox1.Text == "программист")
                rightPoint++;
            if (radioButton1.Checked == true)
                rightPoint++;
            if(dateTimePicker1.Value.Date == Convert.ToDateTime("26.05.1799"))
                rightPoint++;
            if(numericUpDown1.Value == 52)
                rightPoint++;

            MessageBox.Show($"Ваш результат {rightPoint} / 4");

            textBox1.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 0;

        }
    }
}