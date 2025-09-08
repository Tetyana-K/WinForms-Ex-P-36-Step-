using System.Diagnostics;

namespace Listbox_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // якісь початкові дії
            Debug.WriteLine("Ctor  form works");
        }
        string[] namesProd = { "yougurt", "tea", "coffee", "juice" };
        private void Form1_Load(object sender, EventArgs e)
        {
            // якісь початкові дії -  тут теж  добре
            Debug.WriteLine("Load form event raised");

            lboxProducts.Items.AddRange(namesProd);
            checkSort.Checked = false;

            // domainUpdown налаштування
            domainModes.Items.Clear(); // очистили
            for (SelectionMode m = SelectionMode.None; m <= SelectionMode.MultiExtended; m++) // перебрали всі значення enum
            {
                domainModes.Items.Add(m); // додали в список
            }
            //domainModes.SelectedItem = SelectionMode.MultiExtended; // встановили вибране значення
            domainModes.SelectedItem = SelectionMode.None; // встановили вибране значення
                                                           // lboxProducts.SelectionMode = (SelectionMode)domainModes.SelectedItem; // необовязково, бо є обробник події domainModes_SelectedItemChanged
        }

        private void checkSort_CheckedChanged(object sender, EventArgs e)
        {
            lboxProducts.Sorted = checkSort.Checked;
            lboxProducts_SelectedIndexChanged(lboxProducts, null); // оновити інформацію про вибраний елемент (my func)
            //lboxProducts.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim(); // Trim() = відсікає ведучі та завершуючі пропуски '    orange    ' ---> 'orange' 
            if (!String.IsNullOrWhiteSpace(name) && !lboxProducts.Items.Contains(name))
            {
                lboxProducts.Items.Add(name);
            }
            //textName.Text = String.Empty;
            textName.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really  exit?", "Exit", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                this.Close();
        }

        private void checkMultiColums_CheckedChanged(object sender, EventArgs e)
        {
            lboxProducts.MultiColumn = checkMultiColums.Checked;
        }

        private void lboxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxProducts.SelectionMode == SelectionMode.One)
            {
                labelSelected.Text = $"{lboxProducts.SelectedItem} # {lboxProducts.SelectedIndex}";
            }

            else
            {
                // SelectedItems - колекція вибраних елементів apple, milk
                // SelectedIndices - колекція індексів вибраних елементів 0, 3
                string values = String.Join(", ", lboxProducts.SelectedItems.Cast<string>());
                //string result = String.Empty;
                //foreach (var item in lboxProducts.SelectedItems)
                //{
                //    result += item + " ";
                //}
                string indices = String.Join(", ", lboxProducts.SelectedIndices.Cast<int>()); // 0 3 7
                labelSelected.Text = $"{values}\n{indices}";
            }
        }

        private void labelSelected_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lboxProducts.SelectedIndex; // отримали індекс виділеного елемента  0
            while (index != -1) // є виділений елемент ?   
            {
                Debug.WriteLine($"Was deleted : {lboxProducts.Items[index]}");
                lboxProducts.Items.RemoveAt(index); // вилучили з  списку елемент за  індексом

                index = lboxProducts.SelectedIndex; // отримали індекс наступного виділеного елемента 
            }
            //lboxProducts.Items.Clear();
        }

        private void domainModes_SelectedItemChanged(object sender, EventArgs e)
        {
            lboxProducts.SelectionMode = (SelectionMode)domainModes.SelectedItem;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
