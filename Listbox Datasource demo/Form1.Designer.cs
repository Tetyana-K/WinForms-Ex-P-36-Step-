namespace Listbox_Datasource_demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxAge = new TextBox();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(97, 57);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 199);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 281);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(436, 57);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(436, 118);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(100, 23);
            textBoxAge.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(436, 180);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(100, 23);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "buttonUpdate";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxAge;
        private Button buttonUpdate;
    }
}
