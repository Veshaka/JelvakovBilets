namespace Билет_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            factor.Text = Factorial((ulong)Convert.ToUInt32(domainUpDown1.Text)).ToString();
            fibonachi.Text = "";
            for(ulong i = 0; i < Convert.ToUInt32(domainUpDown1.Text); i++)
                fibonachi.Text += Fibonachi(i).ToString() + " ";
        }

        ulong Factorial(ulong n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }

        ulong Fibonachi(ulong f)
        {
            if (f == 0 || f == 1) return f;
            return Fibonachi(f - 1) + Fibonachi(f - 2);
        }
    }
}