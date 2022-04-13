namespace gameRandom
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        int computer_number, user_number;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            computer_number = r.Next(0, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            computer_number = r.Next(0, 100);
            textBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_number = Convert.ToInt32(textBox1.Text);

            if (computer_number == user_number)
            {
                label1.Text = "You won";
                button2.Enabled = true;
                button1.Enabled = false;
            }
            else if (computer_number > user_number)
            {
                label1.Text = "عدد بالاتری را حدس بزنید";
            }
            else if (computer_number < user_number)
            {
                label1.Text = "عدد  پایین تری را حدس بزنید";
            }
        }
    }
}