namespace Combobox_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.AutoSize = false;
        }
        string[] colors = { "Red", "Green", "Blue", "Yellow", "Black", "White" };
        string[] colors2 = { "Cyan", "Magenta", "Orange", "Violet", "Brown", "Gray", "Teal" };
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(colors); // Додавання елементів у ComboBox 1 (Colors) 

            comboBox2.DataSource = colors2; // Прив’язка масиву як джерела даних для ComboBox 2 (BackColors)
            comboBox2.SelectedIndex = 0;

            string[] wfColor = typeof(Color) // Отримання всіх кольорів із структури Color
                .GetProperties() // отримуємо всі властивості структури Color
                .Where(p => p.PropertyType == typeof(Color)) // фільтруємо тільки ті, які є типу Color
                .Select(p => p.Name).ToArray();
            //comboBox3.Items.AddRange(wfColor);
            comboBox3.DataSource = wfColor;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = $"Selected Color: {comboBox1.SelectedItem}"; // Вибраний колір
            label1.BackColor = Color.FromName(comboBox1.SelectedItem.ToString()!);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = $"Selected Color: {comboBox2.SelectedItem}"; // Вибраний колір
            label2.BackColor = Color.FromName(comboBox2.SelectedItem.ToString()!);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(comboBox3.SelectedItem.ToString()!);
        }
    }
}
