namespace Calc_demo
{
    public partial class Form1 : Form
    {
        public Form1() // ctor
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter numbers in both fields.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(textBox1.Text, out double number))
            {
                double result = number * number;
                label1.Text = $"Square: {result}";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = -100;
            numericUpDown1.Maximum = 100;
            numericUpDown1.Value = 0;
            numericUpDown1.Increment = 0.5m; // 5 ? 10
        }
    }
}
