namespace Listbox_demo
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
            lboxProducts = new ListBox();
            checkSort = new CheckBox();
            textName = new TextBox();
            btnAdd = new Button();
            btnClose = new Button();
            checkMultiColums = new CheckBox();
            labelSelected = new Label();
            btnRemove = new Button();
            domainModes = new DomainUpDown();
            SuspendLayout();
            // 
            // lboxProducts
            // 
            lboxProducts.FormattingEnabled = true;
            lboxProducts.Items.AddRange(new object[] { "apple", "bread", "butter", "milk", "plum" });
            lboxProducts.Location = new Point(27, 25);
            lboxProducts.Margin = new Padding(4);
            lboxProducts.MultiColumn = true;
            lboxProducts.Name = "lboxProducts";
            lboxProducts.SelectionMode = SelectionMode.None;
            lboxProducts.Size = new Size(245, 196);
            lboxProducts.TabIndex = 0;
            lboxProducts.SelectedIndexChanged += lboxProducts_SelectedIndexChanged;
            // 
            // checkSort
            // 
            checkSort.AutoSize = true;
            checkSort.Location = new Point(27, 234);
            checkSort.Name = "checkSort";
            checkSort.Size = new Size(53, 21);
            checkSort.TabIndex = 1;
            checkSort.Text = "Sort";
            checkSort.UseVisualStyleBackColor = true;
            checkSort.CheckedChanged += checkSort_CheckedChanged;
            // 
            // textName
            // 
            textName.Location = new Point(332, 25);
            textName.Name = "textName";
            textName.Size = new Size(145, 23);
            textName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(332, 72);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Location = new Point(332, 285);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(145, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // checkMultiColums
            // 
            checkMultiColums.AutoSize = true;
            checkMultiColums.Location = new Point(156, 234);
            checkMultiColums.Name = "checkMultiColums";
            checkMultiColums.Size = new Size(116, 21);
            checkMultiColums.TabIndex = 5;
            checkMultiColums.Text = "Multi  columns";
            checkMultiColums.UseVisualStyleBackColor = true;
            checkMultiColums.CheckedChanged += checkMultiColums_CheckedChanged;
            // 
            // labelSelected
            // 
            labelSelected.AutoSize = true;
            labelSelected.Location = new Point(329, 162);
            labelSelected.Name = "labelSelected";
            labelSelected.Size = new Size(75, 17);
            labelSelected.TabIndex = 6;
            labelSelected.Text = "Selected : ";
            labelSelected.Click += labelSelected_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(332, 116);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(145, 23);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // domainModes
            // 
            domainModes.Items.Add("four");
            domainModes.Items.Add("one");
            domainModes.Items.Add("three");
            domainModes.Items.Add("two");
            domainModes.Location = new Point(27, 286);
            domainModes.Name = "domainModes";
            domainModes.Size = new Size(245, 23);
            domainModes.TabIndex = 9;
            domainModes.Text = "one";
            domainModes.Wrap = true;
            domainModes.SelectedItemChanged += domainModes_SelectedItemChanged;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(534, 332);
            Controls.Add(domainModes);
            Controls.Add(btnRemove);
            Controls.Add(labelSelected);
            Controls.Add(checkMultiColums);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(textName);
            Controls.Add(checkSort);
            Controls.Add(lboxProducts);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Demo  listbox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxProducts;
        private System.Windows.Forms.CheckBox checkSort;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkMultiColums;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DomainUpDown domainModes;

//#endregion
    }
}
