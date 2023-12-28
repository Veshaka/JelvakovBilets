using System.Linq.Expressions;

namespace Билет_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("Workers.txt"))
            {
                string s = File.ReadAllText("Workers.txt");
                s += $"\n{fam.Text} {date.Value.Date.Day}.{date.Value.Date.Month}.{date.Value.Date.Year} {phone.Text} {addres.Text.Replace(' ', '_')} {mail.Text}";

                File.Delete("Workers.txt");

                File.AppendAllText("Workers.txt", s);
            }
            else
            {
                File.AppendAllText("Workers.txt", $"{fam.Text} {date.Value.Date.Day}.{date.Value.Date.Month}.{date.Value.Date.Year} {phone.Text} {addres.Text.Replace(' ','_')} {mail.Text}");
            }
            MessageBox.Show("Данные внесены");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.ShowDialog();
        }
    }
}