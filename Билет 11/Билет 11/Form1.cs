namespace Билет_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] mas = new int[8,7];

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int j = 0; j < 8; j++)
                for (int i = 0; i < 7; i++)
                    mas[j, i] = rnd.Next(-50, 50);

            Output op = new Output();
            op.Print(mas, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 8; j++)
                for (int i = 0; i < 7; i++)
                    if (mas[j,i] < 0)
                        mas[j,i] = 0;

            Output op = new Output();
            op.Print(mas, dataGridView1);
        }
    }
}