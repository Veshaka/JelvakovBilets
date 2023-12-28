namespace Билет_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] mas = new int[10, 10];

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int j = 0; j < 10; j++)
                for (int i = 0; i < 10; i++)
                    mas[j,i] = rnd.Next(0,50);


            dataGridView1.ColumnCount = 0;

            for (int i = 0; i < 10; i++)
                dataGridView1.Columns.Add(ToString(), " ");
            for (int i = 0; i < 9; i++)
                dataGridView1.Rows.Add();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int j = 0; j < 10; j++)
                for (int i = 0; i < 10; i++)
                    dataGridView1.Rows[j].Cells[i].Value = mas[j,i];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*for (int j = 0; j < 10; j++)
                for (int i = 0; i < 9; i++)
                    if (mas[0, i] > mas[0, i + 1])
                        (mas[0, i], mas[0, i + 1]) = (mas[0, i + 1], mas[0, i]);*/

            for (int j = 0; j < 10; j++)
                for (int i = 0; i < 9; i++)
                    if (mas[0, i] > mas[0, i + 1])
                        for(int g = 0; g<10;g++)
                        (mas[g, i], mas[g, i + 1]) = (mas[g, i + 1], mas[g, i]);

            dataGridView1.ColumnCount = 0;
            for (int i = 0; i < 10; i++)
                dataGridView1.Columns.Add(ToString(), " ");
            for (int i = 0; i < 9; i++)
                dataGridView1.Rows.Add();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int j = 0; j < 10; j++)
                for (int i = 0; i < 10; i++)
                    dataGridView1.Rows[j].Cells[i].Value = mas[j, i];
        }
    }
}