namespace Билет_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Convertation.Mass mass = new Convertation.Mass();
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        result1.Text = mass.pount(Convert.ToDouble(textBox1.Text)).ToString();
                        break;
                    case 1:
                        result1.Text = mass.ounces(Convert.ToDouble(textBox1.Text)).ToString();
                        break;
                    case 2:
                        result1.Text = mass.grams(Convert.ToDouble(textBox1.Text)).ToString();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Данные не заполнены");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                Convertation.Distance distance = new Convertation.Distance();
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        result2.Text = distance.inc(Convert.ToDouble(textBox4.Text)).ToString();
                        break;
                    case 1:
                        result2.Text = distance.sm(Convert.ToDouble(textBox4.Text)).ToString();
                        break;
                    case 2:
                        result2.Text = distance.pount(Convert.ToDouble(textBox4.Text)).ToString();
                        break;
                    case 3:
                        result2.Text = distance.seaMill(Convert.ToDouble(textBox4.Text)).ToString();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Данные не заполнены");
            }
        }
    }
}