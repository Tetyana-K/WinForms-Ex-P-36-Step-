namespace First_Demo
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
            buttonLogin = new Button();
            textboxPassword = new TextBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(168, 175);
            buttonLogin.Margin = new Padding(4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(310, 69);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textboxPassword
            // 
            textboxPassword.Location = new Point(168, 71);
            textboxPassword.Margin = new Padding(4);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.PasswordChar = '*';
            textboxPassword.PlaceholderText = "Enter password";
            textboxPassword.Size = new Size(309, 29);
            textboxPassword.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 358);
            Controls.Add(textboxPassword);
            Controls.Add(buttonLogin);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "My Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox textboxPassword;
    }
}
