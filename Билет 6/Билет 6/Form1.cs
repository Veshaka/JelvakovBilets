namespace Билет_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            this.Height = 160;

            double a = Convert.ToDouble(textBox1.Text.Replace('.', ','));
            double b = Convert.ToDouble(textBox2.Text.Replace('.', ','));
            double c = Convert.ToDouble(textBox3.Text.Replace('.', ','));

            Fun fun = new Fun();

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    summ.Text = $"Сумма = {fun.Sum(a, b, c)}";
                    break;
                case 1:
                    summ.Text = $"Произведение = {fun.Multiply(a, b, c)}";
                    break;
                case 2:
                    summ.Text = $"Ср.Арифметическое = {fun.SrArifmetic(a, b, c)}";
                    break;
            }
        }
    }
}