namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            if (textBox3.Text == "+")
            {
                textBox4.Text = Convert.ToString(num1 + num2);
            }
            else if (textBox3.Text == "-")
            {
                textBox4.Text = Convert.ToString(num1 - num2);
            }
            else if (textBox3.Text == "*")
            {
                textBox4.Text = Convert.ToString(num1 * num2);
            }
            else if (textBox3.Text == "/")
            {
                textBox4.Text = Convert.ToString(num1 / num2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

























































        }
    }
}