namespace Билет_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initial();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Initial();
        }

        private void Initial()
        {
            dataGridView1.ColumnCount = 0;
            for (int i = 1; i < 11; i++)
            {
                dataGridView1.Columns.Add(ToString(),i.ToString());
                dataGridView1.Rows.Add();
            }
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                dataGridView1.RowHeadersWidth = 50;
            }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = ((i + 1) * (j + 1)).ToString();

                }
                dataGridView1.Rows[(int)numericUpDown1.Value-1].Cells[j].Style.BackColor = Color.Red;
                dataGridView1.Rows[j].Cells[(int)numericUpDown2.Value-1].Style.BackColor = Color.Red;
            }
            dataGridView1.Rows[(int)numericUpDown1.Value - 1].Cells[(int)numericUpDown2.Value - 1].Style.BackColor = Color.Blue;
        }
    }
}