using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Билет_20
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Initial();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Initial()
        {
            if (File.Exists("Workers.txt"))
            {
                string[] fil = File.ReadAllLines("Workers.txt");
                string[,] filDone = new string[fil.Length, 5];

                string[] mas = { "Фамилия", "Дата рождения", "Телефон", "Адрес", "E-mail" };

                for (int i = 0; i < 5; i++)
                    dataGridView1.Columns.Add(ToString(), mas[i]);
                for (int i = 0; i < fil.Length; i++)
                    dataGridView1.Rows.Add();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                for (int i = 0; i < fil.Length; i++)
                {
                    string[] filSplit = fil[i].Split(' ');

                    dataGridView1.Rows[i].Cells[0].Value = filSplit[0];
                    dataGridView1.Rows[i].Cells[1].Value = filSplit[1];
                    dataGridView1.Rows[i].Cells[2].Value = filSplit[2];
                    dataGridView1.Rows[i].Cells[3].Value = filSplit[3].Replace('_',' ');
                    dataGridView1.Rows[i].Cells[4].Value = filSplit[4];

                }
            }
        }
    }
}
