namespace RadioButtons_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Подія CheckedChanged означає, що стан перемикача змінився (вибрано або знято вибір)
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var radio = sender as RadioButton;
            this.Text = radio?.Text + $" {radio?.Checked}";
            //string info = radio?.Text + $" {radio?.Checked}";
            //MessageBox.Show(info, "Radio Button Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (radio.Checked)
                labelColor.Text = $"You selected: {radio.Text}";
        }

        //private void checkBoxPython_CheckedChanged(object sender, EventArgs e)
        //{
        //    labelSkills.Text = "You selected: ";
        //    var children = groupBoxSkills.Controls.OfType<CheckBox>();
        //    foreach (CheckBox check in children)
        //    {
        //        labelSkills.Text += check.Checked ? check.Text + " " : "";
        //    }
        //}
        private void checkBoxSkill_CheckedChanged(object sender, EventArgs e)
        {
            labelSkills.Text = "You selected: ";
            var children = groupBoxSkills.Controls.OfType<CheckBox>();
            foreach (CheckBox check in children)
            {
                labelSkills.Text += check.Checked ? check.Text + " " : "";
            }
        }
    }
}
