using System.Windows.Forms;

namespace Билет_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[,] filDone = new string[0, 0];

        private void button1_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fil = File.ReadAllLines(openFileDialog.FileName);
                numericUpDown1.Maximum = fil.Length;
                filDone = new string[fil.Length, 5];
                richTextBox1.Text = "Фамилия   Должность   Зарплата   Год рождения   Пол\n";

                for (int i = 0; i < fil.Length; i++)
                {
                    string[] filSplit = fil[i].Split(' ');

                    filDone[i, 0] = filSplit[0];
                    filDone[i, 1] = filSplit[1];
                    filDone[i, 2] = filSplit[2];
                    filDone[i, 3] = filSplit[3];
                    filDone[i, 4] = filSplit[4];
                    richTextBox1.Text += $"{filSplit[0]}   {filSplit[1]}   {filSplit[2]}   {filSplit[3]}   {filSplit[4]}\n";
                }
            }*/

            if (File.Exists("Workers.txt"))
            {
                double sum = 0;
                string[] fil = File.ReadAllLines("Workers.txt");
                numericUpDown1.Maximum = fil.Length;
                filDone = new string[fil.Length, 5];
                richTextBox1.Text = "Фамилия   Должность   Зарплата   Год рождения   Пол\n";

                for (int i = 0; i < fil.Length; i++)
                {
                    string[] filSplit = fil[i].Split(' ');

                    filDone[i, 0] = filSplit[0];
                    filDone[i, 1] = filSplit[1];
                    filDone[i, 2] = filSplit[2];
                    filDone[i, 3] = filSplit[3];
                    filDone[i, 4] = filSplit[4];
                    sum += Convert.ToInt32(filSplit[2]);
                    richTextBox1.Text += $"{filSplit[0]}   {filSplit[1]}   {filSplit[2]}   {filSplit[3]}   {filSplit[4]}\n";
                }

                richTextBox1.Text += $"Средняя зарплата = {sum / fil.Length}";
            }
            else
            {
                MessageBox.Show("Файл не выбран");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fam.Text = filDone[(int)numericUpDown1.Value-1, 0];
            work.Text = filDone[(int)numericUpDown1.Value-1, 1];
            zapr.Text = filDone[(int)numericUpDown1.Value-1, 2];
            year.Text = filDone[(int)numericUpDown1.Value-1, 3];
            sex.Text = filDone[(int)numericUpDown1.Value-1, 4];
        }
    }
}