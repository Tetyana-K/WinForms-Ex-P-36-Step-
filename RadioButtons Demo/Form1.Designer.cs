namespace RadioButtons_Demo
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
            radioButtonRed = new RadioButton();
            radioButtonYellow = new RadioButton();
            radioButtonGreen = new RadioButton();
            groupBoxTLight = new GroupBox();
            labelColor = new Label();
            checkBoxPython = new CheckBox();
            checkBoxOOP = new CheckBox();
            checkBoxCSharp = new CheckBox();
            groupBoxSkills = new GroupBox();
            labelSkills = new Label();
            groupBoxTLight.SuspendLayout();
            groupBoxSkills.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonRed
            // 
            radioButtonRed.AutoSize = true;
            radioButtonRed.BackgroundImageLayout = ImageLayout.Zoom;
            radioButtonRed.Location = new Point(47, 45);
            radioButtonRed.Margin = new Padding(4);
            radioButtonRed.Name = "radioButtonRed";
            radioButtonRed.Size = new Size(55, 25);
            radioButtonRed.TabIndex = 0;
            radioButtonRed.TabStop = true;
            radioButtonRed.Text = "Red";
            radioButtonRed.UseVisualStyleBackColor = true;
            radioButtonRed.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonYellow
            // 
            radioButtonYellow.AutoSize = true;
            radioButtonYellow.BackgroundImageLayout = ImageLayout.Zoom;
            radioButtonYellow.Location = new Point(47, 102);
            radioButtonYellow.Margin = new Padding(4);
            radioButtonYellow.Name = "radioButtonYellow";
            radioButtonYellow.Size = new Size(73, 25);
            radioButtonYellow.TabIndex = 1;
            radioButtonYellow.TabStop = true;
            radioButtonYellow.Text = "Yellow";
            radioButtonYellow.UseVisualStyleBackColor = true;
            radioButtonYellow.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonGreen
            // 
            radioButtonGreen.AutoSize = true;
            radioButtonGreen.BackgroundImageLayout = ImageLayout.Zoom;
            radioButtonGreen.Location = new Point(47, 156);
            radioButtonGreen.Margin = new Padding(4);
            radioButtonGreen.Name = "radioButtonGreen";
            radioButtonGreen.Size = new Size(70, 25);
            radioButtonGreen.TabIndex = 2;
            radioButtonGreen.TabStop = true;
            radioButtonGreen.Text = "Green";
            radioButtonGreen.UseVisualStyleBackColor = true;
            radioButtonGreen.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBoxTLight
            // 
            groupBoxTLight.Controls.Add(radioButtonRed);
            groupBoxTLight.Controls.Add(radioButtonYellow);
            groupBoxTLight.Controls.Add(radioButtonGreen);
            groupBoxTLight.Location = new Point(96, 45);
            groupBoxTLight.Name = "groupBoxTLight";
            groupBoxTLight.Size = new Size(196, 217);
            groupBoxTLight.TabIndex = 3;
            groupBoxTLight.TabStop = false;
            groupBoxTLight.Text = "Traffic Lights";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(105, 302);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(52, 21);
            labelColor.TabIndex = 4;
            labelColor.Text = "label1";
            // 
            // checkBoxPython
            // 
            checkBoxPython.AutoSize = true;
            checkBoxPython.Location = new Point(28, 39);
            checkBoxPython.Name = "checkBoxPython";
            checkBoxPython.Size = new Size(78, 25);
            checkBoxPython.TabIndex = 5;
            checkBoxPython.Text = "Python";
            checkBoxPython.UseVisualStyleBackColor = true;
            checkBoxPython.CheckedChanged += checkBoxSkill_CheckedChanged;
            // 
            // checkBoxOOP
            // 
            checkBoxOOP.AutoSize = true;
            checkBoxOOP.Location = new Point(28, 89);
            checkBoxOOP.Name = "checkBoxOOP";
            checkBoxOOP.Size = new Size(62, 25);
            checkBoxOOP.TabIndex = 6;
            checkBoxOOP.Text = "OOP";
            checkBoxOOP.UseVisualStyleBackColor = true;
            checkBoxOOP.CheckedChanged += checkBoxSkill_CheckedChanged;
            // 
            // checkBoxCSharp
            // 
            checkBoxCSharp.AutoSize = true;
            checkBoxCSharp.Location = new Point(28, 142);
            checkBoxCSharp.Name = "checkBoxCSharp";
            checkBoxCSharp.Size = new Size(48, 25);
            checkBoxCSharp.TabIndex = 7;
            checkBoxCSharp.Text = "C#";
            checkBoxCSharp.UseVisualStyleBackColor = true;
            checkBoxCSharp.CheckedChanged += checkBoxSkill_CheckedChanged;
            // 
            // groupBoxSkills
            // 
            groupBoxSkills.Controls.Add(checkBoxPython);
            groupBoxSkills.Controls.Add(checkBoxCSharp);
            groupBoxSkills.Controls.Add(checkBoxOOP);
            groupBoxSkills.Location = new Point(343, 45);
            groupBoxSkills.Name = "groupBoxSkills";
            groupBoxSkills.Size = new Size(196, 217);
            groupBoxSkills.TabIndex = 8;
            groupBoxSkills.TabStop = false;
            groupBoxSkills.Text = "Skills";
            // 
            // labelSkills
            // 
            labelSkills.AutoSize = true;
            labelSkills.Location = new Point(357, 302);
            labelSkills.Name = "labelSkills";
            labelSkills.Size = new Size(52, 21);
            labelSkills.TabIndex = 9;
            labelSkills.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 404);
            Controls.Add(labelSkills);
            Controls.Add(groupBoxSkills);
            Controls.Add(labelColor);
            Controls.Add(groupBoxTLight);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBoxTLight.ResumeLayout(false);
            groupBoxTLight.PerformLayout();
            groupBoxSkills.ResumeLayout(false);
            groupBoxSkills.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonRed;
        private RadioButton radioButtonYellow;
        private RadioButton radioButtonGreen;
        private GroupBox groupBoxTLight;
        private Label labelColor;
        private CheckBox checkBoxPython;
        private CheckBox checkBoxOOP;
        private CheckBox checkBoxCSharp;
        private GroupBox groupBoxSkills;
        private Label labelSkills;
    }
}
