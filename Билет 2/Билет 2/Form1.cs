namespace Билет_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultX1.Text = "";
            resultX2.Text = "";
            resultX3.Text = "";
            resultX4.Text = "";

            double ad;
            double bd;
            double cd;

            if (a.Text == "")
                ad = 1;
            else
                ad = Convert.ToDouble(a.Text);

            if (b.Text == "")
                bd = 1;
            else
                bd = Convert.ToDouble(b.Text);

            if (c.Text == "")
                cd = 1;
            else
                cd = Convert.ToDouble(c.Text);

            double d = Math.Pow(bd, 2) - 4 * ad * cd;
            double x1 = (-bd + Math.Sqrt(d)) / (2 * ad);
            double x2 = (-bd - Math.Sqrt(d)) / (2 * ad);
            if (radioButton1.Checked)
            {
                if (d < 0)
                {
                    resultX1.Text = $"x1= нет корня";
                    resultX2.Text = $"x2= нет корня";
                    return;
                }
                if (d == 0)
                {
                    resultX1.Text = $"x1= {x1}";
                    return;
                }
                resultX1.Text = $"x1= {x1}";
                resultX2.Text = $"x2= {x2}";
            }
            else
            {
                if (d < 0)
                {
                    resultX1.Text = $"x1= нет корня";
                    resultX2.Text = $"x2= нет корня";
                    resultX3.Text = $"x3= нет корня";
                    resultX4.Text = $"x4= нет корня";
                    return;
                }
                if (d == 0)
                {
                    resultX1.Text = $"x1= {Math.Sqrt(x1)}";
                    resultX2.Text = $"x2= {-Math.Sqrt(x1)}";
                    resultX3.Text = $"x3= нет корня";
                    resultX4.Text = $"x4= нет корня";
                    return;
                }
                resultX1.Text = $"x1= {Math.Sqrt(x1)}";
                resultX2.Text = $"x2= {-Math.Sqrt(x1)}";
                resultX3.Text = $"x3= {Math.Sqrt(x2)}";
                resultX4.Text = $"x4= {-Math.Sqrt(x2)}";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                index1.Text = "2";
                index2.Text = "";
            }
            else
            {
                index1.Text = "4";
                index2.Text = "2";
            }
        }
    }
}