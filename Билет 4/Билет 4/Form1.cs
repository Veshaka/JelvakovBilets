namespace Билет_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 8);
            Color[] cl = { Color.Blue, Color.Yellow, Color.Black, Color.Green, Color.Red };
            int k = 0;

            /*Rectangle rg = new Rectangle();
            Rectangle rg1 = new Rectangle();

            int i = 200;
            int x = 200;
            int y = 200;

            for (int j = 200; j < 450; j += 50)
            {
                rg = new Rectangle(j, i, 90, 90);
                rg1 = new Rectangle(x, y, 90, 90);

                pen.Color = cl[k];

                switch (k)
                {
                    case 0:
                        g.DrawArc(pen, rg, 0, 360);
                        break;
                    case 1:
                    case 3:
                        g.DrawArc(pen, rg, 0, 360);
                        pen.Color = cl[k - 1];
                        g.DrawArc(pen, rg1, -30, 90);
                        break;
                    case 2:
                    case 4:
                        g.DrawArc(pen, rg, 0, 360);
                        pen.Color = cl[k - 1];
                        g.DrawArc(pen, rg1, -92, 50);
                        break;

                }

                x = j;
                y = i;
                i += 50;
                k++;

                if (i == 300) i = 200;
            }*/

            int j = 100;
            Rectangle rg = new Rectangle();
            for (int i = 100; i < 350; i += 50)
            { 
                rg = new Rectangle(i,j,90,90);
                pen.Color = cl[k];
                g.DrawEllipse(pen, rg);
                k++;
                j += 50;
                if(j == 200) j = 100;
            }
        }
    }
}