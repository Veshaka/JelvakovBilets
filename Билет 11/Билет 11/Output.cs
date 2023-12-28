using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Билет_11
{
    internal class Output
    {
        public void Print(int[,] mas, DataGridView dataGridView1)
        {
            dataGridView1.ColumnCount = 0;

            for (int i = 0; i < 7; i++)
                dataGridView1.Columns.Add(ToString(), " ");
            for (int i = 0; i < 7; i++)
                dataGridView1.Rows.Add();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int j = 0; j < 8; j++)
                for (int i = 0; i < 7; i++)
                    dataGridView1.Rows[j].Cells[i].Value = mas[j,i];
        }
    }
}
