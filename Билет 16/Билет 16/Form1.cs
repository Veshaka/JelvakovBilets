using System.Reflection.Metadata;
using System.Windows.Forms;

namespace Билет_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[,] filDone = new string[0, 0];
        public int sz = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("Students.txt"))
            {
                string[] fil = File.ReadAllLines("Students.txt");
                richTextBox1.Text = $"Фамилия   Группа   Год рождения\n";
                richTextBox2.Text = "";
                filDone = new string[fil.Length, 3];
                sz = fil.Length;

                for (int i = 0; i < fil.Length; i++)
                {
                    string[] filSplit = fil[i].Split(' ');

                    filDone[i, 0] = filSplit[0];
                    filDone[i, 1] = filSplit[1];
                    filDone[i, 2] = filSplit[2];

                    if (!comboBox1.Items.Contains(filSplit[1]))
                        comboBox1.Items.Add(filSplit[1]);

                    richTextBox1.Text += $"{filSplit[0]}   {filSplit[1]}   {filSplit[2]}\n";
                }

                result.Text = fil.Length.ToString();
                comboBox1.Items.Add("All");

                int min = Convert.ToInt32(filDone[0, 2]);
                for (int i = 0; i < fil.Length; i++)
                {
                    if (min > Convert.ToInt32(filDone[i, 2]))
                        min = Convert.ToInt32(filDone[i, 2]);
                }

                for (int i = 0; i < fil.Length; i++)
                {
                    if (Convert.ToInt32(filDone[i, 2]) == min)
                        richTextBox2.Text += $"{filDone[i, 0]}\n";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = $"Фамилия   Группа   Год рождения\n";
            if (comboBox1.SelectedItem.ToString() == "All")
                for (int i = 0; i < sz; i++)
                {
                    richTextBox1.Text += $"{filDone[i,0]}   {filDone[i, 1]}   {filDone[i, 2]}\n";
                }
            else
                for(int i = 0; i < sz; i++)
                    if(comboBox1.SelectedItem.ToString() == filDone[i,1])
                        richTextBox1.Text += $"{filDone[i, 0]}   {filDone[i, 1]}   {filDone[i, 2]}\n";
        }
    }
}