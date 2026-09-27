namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int score = 0;

        public Form1()
        {
            InitializeComponent();

            buttonone.Click += buttonone_Click;
            buttontwo.Click += buttontwo_Click;
            buttonthree.Click += buttonthree_Click;

            buttonfour.Click += buttonfour_Click;
            buttonfive.Click += buttonfive_Click;
            buttonsix.Click += buttonsix_Click;

            buttonseven.Click += buttonseven_Click;
            buttoneight.Click += buttoneight_Click;
            buttonnine.Click += buttonnine_Click;
        }

        private void buttonone_Click(object sender, EventArgs e)
        {
            // Question 1: correct answer is $300
            CheckAnswer(buttonone, false);
        }

        private void buttontwo_Click(object sender, EventArgs e)
        {
            // Question 1: $280 is incorrect
            CheckAnswer(buttontwo, false);
        }

        private void buttonthree_Click(object sender, EventArgs e)
        {
            // Question 1: $300 is correct
            CheckAnswer(buttonthree, true);
        }

        private void buttonfour_Click(object sender, EventArgs e)
        {
            // Question 2: $60 is correct
            CheckAnswer(buttonfour, true);
        }

        private void buttonfive_Click(object sender, EventArgs e)
        {
            // Question 2: $70 is incorrect
            CheckAnswer(buttonfive, false);
        }

        private void buttonsix_Click(object sender, EventArgs e)
        {
            // Question 2: $80 is incorrect
            CheckAnswer(buttonsix, false);
        }

        private void buttonseven_Click(object sender, EventArgs e)
        {
            // Question 3: 20 is incorrect
            CheckAnswer(buttonseven, false);
        }

        private void buttoneight_Click(object sender, EventArgs e)
        {
            // Question 3: 13 is correct
            CheckAnswer(buttoneight, true);
        }

        private void buttonnine_Click(object sender, EventArgs e)
        {
            // Question 3: 89 is incorrect
            CheckAnswer(buttonnine, false);
        }

        private void CheckAnswer(Button button, bool correct)
        {
            if (correct)
            {
                score++;
                textBox1.Text = "Correct!\r\nScore: " + score;
            }
            else
            {
                textBox1.Text = "Wrong!\r\nScore: " + score;
            }

            button.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
