namespace Билет_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 0;

            for (int j = 0; j < comboBox1.SelectedIndex + 1; j++)
                dataGridView1.Columns.Add(ToString(), j.ToString());
            for (int i = 0; i < comboBox2.SelectedIndex; i++)
                dataGridView1.Rows.Add();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int j = 0; j < comboBox2.SelectedIndex + 1; j++)
            {
                for (int i = 0; i < comboBox1.SelectedIndex + 1; i++)
                {
                    if ((j + i) % 2 == 0)
                        dataGridView1.Rows[j].Cells[i].Value = "0";
                    else
                        dataGridView1.Rows[j].Cells[i].Value = "1";
                }
                dataGridView1.Rows[j].HeaderCell.Value = j.ToString();
            }
        }
    }
}