namespace Билет_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] mas = new int[(int)comboBox2.SelectedIndex+1, (int)comboBox1.SelectedIndex+1];
            int srArifm = 0;
            int x = 0;

            Random rnd = new Random();

            for (int i = 0; i < (int)comboBox1.SelectedIndex+1; i++)
                dataGridView1.Columns.Add(ToString(), " ");
            for (int i = 0; i< (int)comboBox2.SelectedIndex; i ++)
                dataGridView1.Rows.Add();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int j = 0; j < (int)comboBox2.SelectedIndex+1; j++)
                for (int i = 0; i < (int)comboBox1.SelectedIndex+1; i++)
                {
                    mas[j,i] = rnd.Next(0,99);
                    dataGridView1.Rows[j].Cells[i].Value = mas[j, i];
                }

            for (int j = 0; j < (int)comboBox2.SelectedIndex+1; j++)
            {
                int min = mas[j, 0];
                for (int i = 0; i < (int)comboBox1.SelectedIndex+1; i++)
                {
                    if (min > mas[j, i])
                    {
                        min = mas[j, i];
                        x = i;
                    }
                }
                srArifm += min;
                dataGridView1.Rows[j].Cells[x].Style.BackColor = Color.Red;
            }

            summ.Text = (srArifm / ((int)comboBox2.SelectedIndex + 1)).ToString();
        }
    }
}