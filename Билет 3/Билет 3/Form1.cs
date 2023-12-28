namespace Билет_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = Factorial((ulong)numericUpDown1.Value).ToString();
        }

        ulong Factorial(ulong n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}