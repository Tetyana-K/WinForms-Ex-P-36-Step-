using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Listbox_Datasource_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //BindingList<Student> students;
        List<Student> students;//
        private void Form1_Load(object sender, EventArgs e)
        {
            // Створюємо список студентів
            students =
            [
                new Student { Name = "Олена", Age = 20 },
                new Student { Name = "Андрій", Age = 22 },
                new Student { Name = "Марія", Age = 19 },
                new Student { Name = "Іван", Age = 21 }
            ];

            // Прив’язуємо список до ListBox
            listBox1.DataSource = students;
            listBox1.DisplayMember = "Name"; // що показувати у списку
            listBox1.ValueMember = "Age";    // приховане значення (вік)
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Student selectedStudent)
            {
                label1.Text = $"Вік {selectedStudent.Name}: {selectedStudent.Age} років";
                textBoxName.Text = selectedStudent.Name;
                textBoxAge.Text = selectedStudent.Age.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Student s)
            {
                if (!string.IsNullOrWhiteSpace(textBoxName.Text) && int.TryParse(textBoxAge.Text, out int age))
                {
                    s.Name = textBoxName.Text;
                    s.Age = age;

                    // Оновити відображення
                    listBox1.DataSource = null;
                    listBox1.DataSource = students;
                    listBox1.DisplayMember = "Name";
                    //listBox1.Refresh();
                }
                else
                {
                    MessageBox.Show("Помилка введення даних!");
                }
            }
        }
    }
}
