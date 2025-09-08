using System.Diagnostics;

namespace Listbox_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ���� �������� 䳿
            Debug.WriteLine("Ctor  form works");
        }
        string[] namesProd = { "yougurt", "tea", "coffee", "juice" };
        private void Form1_Load(object sender, EventArgs e)
        {
            // ���� �������� 䳿 -  ��� ���  �����
            Debug.WriteLine("Load form event raised");

            lboxProducts.Items.AddRange(namesProd);
            checkSort.Checked = false;

            // domainUpdown ������������
            domainModes.Items.Clear(); // ��������
            for (SelectionMode m = SelectionMode.None; m <= SelectionMode.MultiExtended; m++) // ��������� �� �������� enum
            {
                domainModes.Items.Add(m); // ������ � ������
            }
            //domainModes.SelectedItem = SelectionMode.MultiExtended; // ���������� ������� ��������
            domainModes.SelectedItem = SelectionMode.None; // ���������� ������� ��������
                                                           // lboxProducts.SelectionMode = (SelectionMode)domainModes.SelectedItem; // ������������, �� � �������� ��䳿 domainModes_SelectedItemChanged
        }

        private void checkSort_CheckedChanged(object sender, EventArgs e)
        {
            lboxProducts.Sorted = checkSort.Checked;
            lboxProducts_SelectedIndexChanged(lboxProducts, null); // ������� ���������� ��� �������� ������� (my func)
            //lboxProducts.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim(); // Trim() = ����� ������ �� ���������� �������� '    orange    ' ---> 'orange' 
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
                // SelectedItems - �������� �������� �������� apple, milk
                // SelectedIndices - �������� ������� �������� �������� 0, 3
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
            int index = lboxProducts.SelectedIndex; // �������� ������ ��������� ��������  0
            while (index != -1) // � �������� ������� ?   
            {
                Debug.WriteLine($"Was deleted : {lboxProducts.Items[index]}");
                lboxProducts.Items.RemoveAt(index); // �������� �  ������ ������� ��  ��������

                index = lboxProducts.SelectedIndex; // �������� ������ ���������� ��������� �������� 
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
