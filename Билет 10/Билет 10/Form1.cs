using System.Windows.Forms;

namespace Билет_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double otsenka = 0;
            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt| all files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            { 
                string[] fi = File.ReadAllLines(openFileDialog.FileName);

                for (int i = 0; i < fi.Length; i++)
                {
                    string[] fiSplit = fi[i].Split(' ');

                    otsenka += Convert.ToInt32(fiSplit[3]);
                    if (fiSplit[4] == "5" && fiSplit[5] == "5")
                        richTextBox1.Text += $"{fiSplit[0]}\n";
                }

                richTextBox1.Text += $"\nСреднй возраст студентов = {otsenka/fi.Length}";
            }*/


            if (File.Exists("Students.txt"))
            {
                string[] fi = File.ReadAllLines("Students.txt");

                for (int i = 0; i < fi.Length; i++)
                {
                    string[] fiSplit = fi[i].Split(' ');

                    otsenka += Convert.ToInt32(fiSplit[3]);
                    if (fiSplit[4] == "5" && fiSplit[5] == "5")
                        richTextBox1.Text += $"{fiSplit[0]}\n";
                }

                richTextBox1.Text += $"\nСреднй возраст студентов = {otsenka / fi.Length}";
            }
            else
            {
                MessageBox.Show("Файл Students.txt не найден в директории приложения");
            }
        }
    }
}