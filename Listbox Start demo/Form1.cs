using System.Diagnostics;

namespace Listbox_Start_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // якісь початкові дії
            listBox1.Items.Add("Apple");
            listBox1.Items.Add("Plum");
            Debug.WriteLine("Ctor  form works");
            Debug.WriteLine("apple and plum were added");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> fruits = new() { "Banana", "Orange", "Lemon", "Grapes" };
            listBox1.Items.AddRange(fruits.ToArray());
            //listBox1.DataSource = fruits;
            Debug.WriteLine("Load form event raised");
            Debug.WriteLine("banana, orange, lemon, grapes were added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var element = textBox1.Text.Trim();// '   12       ' ---> '12'
            if (!string.IsNullOrWhiteSpace(element) && !listBox1.Items.Contains(element))
            {
                listBox1.Items.Add(element);
                Debug.WriteLine($"{element} was added");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem?.ToString() ?? String.Empty;
        }
    }
}
