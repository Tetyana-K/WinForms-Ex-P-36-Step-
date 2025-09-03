namespace First_Demo
{
    //partial - частковий, клас може бути розбитий на кілька файлів, щоб полегшити керування великими проектами
    public partial class Form1 : Form
    {
        // програміст пише код тут, у цьому файлі (логіка програми)
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Hello", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Login Form";
            //this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));//Color.LightGreen;
            this.BackColor = Color.Teal;
        }
        string truePassword = 123.ToString();
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string password = textboxPassword.Text; // отримуємо текст з текстового поля
            if (password == truePassword)
            {
                MessageBox.Show("Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BackColor = Color.DarkRed;
            }
            textboxPassword.Clear(); // очищуємо текстове поле
            textboxPassword.Enabled = false; // блокуємо текстове поле
            //buttonLogin.Enabled = false; // блокуємо кнопку
            buttonLogin.Visible = false; // ховаємо кнопку
        }
    }
}
