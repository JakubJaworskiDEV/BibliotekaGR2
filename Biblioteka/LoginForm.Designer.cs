namespace Biblioteka
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginButton = new Button();
            RemindPassword = new Button();
            Login = new Label();
            Password = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginExitButton = new Button();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(299, 261);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(186, 70);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Zaloguj";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // RemindPassword
            // 
            RemindPassword.Location = new Point(299, 352);
            RemindPassword.Name = "RemindPassword";
            RemindPassword.Size = new Size(204, 24);
            RemindPassword.TabIndex = 1;
            RemindPassword.Text = "Przypomnij moje hasło";
            RemindPassword.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Location = new Point(281, 135);
            Login.Name = "Login";
            Login.Size = new Size(94, 15);
            Login.TabIndex = 2;
            Login.Text = "Podaj swój login";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(281, 198);
            Password.Name = "Password";
            Password.Size = new Size(101, 15);
            Password.TabIndex = 3;
            Password.Text = "Podaj swoje hasło";
            Password.Click += label2_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(281, 162);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(241, 23);
            LoginTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(281, 216);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(241, 23);
            PasswordTextBox.TabIndex = 5;
            // 
            // LoginExitButton
            // 
            LoginExitButton.Location = new Point(12, 12);
            LoginExitButton.Name = "LoginExitButton";
            LoginExitButton.Size = new Size(81, 23);
            LoginExitButton.TabIndex = 6;
            LoginExitButton.Text = "Wyjdź";
            LoginExitButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginExitButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(Password);
            Controls.Add(Login);
            Controls.Add(RemindPassword);
            Controls.Add(LoginButton);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Button RemindPassword;
        private Label Login;
        private Label Password;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button LoginExitButton;
    }
}