namespace Билет_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 5);
            Rectangle rg = new Rectangle(100,100,600,200);
            g.DrawRectangle(pen, rg);
        }

        private void элипсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 5);
            Rectangle rg = new Rectangle(100, 100, 600, 200);
            g.DrawEllipse(pen, rg);
        }

        private void рядОкружностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 5);
            Rectangle rg = new Rectangle();
            for (int i = 100; i < 550; i+=50)
            { 
                rg = new Rectangle(i,100,200,200);
                g.DrawEllipse(pen, rg);
            }
        }
    }
}