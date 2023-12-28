namespace Билет_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool firstWord = false;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int sLend = 0;
            int allLend = 0;
            string s = richTextBox1.Text;


            if (richTextBox1.Text != "" && richTextBox1.Text.Length > 3)
                if (s[0] != ' ' && s[1] != ' ' && s[2] != ' ')
                {
                    if ((s[0] == 'С' | s[0] == 'с') && s[1] != ' ' && s[2] != ' ')
                        sLend++;
                    allLend++;
                    firstWord = true;
                }
            if(richTextBox1.Text == "")
                firstWord = false;

            for (int i = 1; i < s.Length - 2; i++)
            {
                if (s[i - 1] == ' ' && (s[i] == 'С' | s[i] == 'с') && s[i + 1] != ' ' && s[i + 2] != ' ')
                    sLend++;
                if (s[i - 1] == ' ' && s[i] != ' ' && s[i + 1] != ' ' && s[i + 2] != ' ')
                    allLend++;
            }

            sl.Text = $"Слова на с = {sLend}";
            al.Text = $"Всего слов = {allLend}";

        }
    }
}