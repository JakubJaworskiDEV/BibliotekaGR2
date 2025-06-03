namespace Biblioteka
{
    partial class ChangePasswordForm
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
            ChangePassword = new Button();
            label1 = new Label();
            label2 = new Label();
            NewPassword = new TextBox();
            AgainNewPassword = new TextBox();
            btnBackToLogin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // ChangePassword
            // 
            ChangePassword.Location = new Point(256, 299);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Size = new Size(185, 50);
            ChangePassword.TabIndex = 0;
            ChangePassword.Text = "Zmień hasło";
            ChangePassword.UseVisualStyleBackColor = true;
            ChangePassword.Click += ChangePassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 81);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 1;
            label1.Text = "Podaj nowe hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 156);
            label2.Name = "label2";
            label2.Size = new Size(138, 17);
            label2.TabIndex = 2;
            label2.Text = "Potwierdź nowe hasło:";
            // 
            // NewPassword
            // 
            NewPassword.Location = new Point(134, 101);
            NewPassword.Name = "NewPassword";
            NewPassword.Size = new Size(252, 25);
            NewPassword.TabIndex = 3;
            // 
            // AgainNewPassword
            // 
            AgainNewPassword.Location = new Point(134, 176);
            AgainNewPassword.Name = "AgainNewPassword";
            AgainNewPassword.Size = new Size(252, 25);
            AgainNewPassword.TabIndex = 4;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Location = new Point(51, 299);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(185, 50);
            btnBackToLogin.TabIndex = 5;
            btnBackToLogin.Text = "Anuluj";
            btnBackToLogin.UseVisualStyleBackColor = true;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 231);
            label3.Name = "label3";
            label3.Size = new Size(399, 34);
            label3.TabIndex = 7;
            label3.Text = "* Hasło musi mieć od 8 do 15 znaków i zawierać co najmniej jedną \r\nwielką literę, małą literę, cyfrę oraz znak specjalny (- _ ! * # $ &).";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 380);
            Controls.Add(label3);
            Controls.Add(btnBackToLogin);
            Controls.Add(AgainNewPassword);
            Controls.Add(NewPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ChangePassword);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChangePassword;
        private Label label1;
        private Label label2;
        private TextBox NewPassword;
        private TextBox AgainNewPassword;
        private Button btnBackToLogin;
        private Label label3;
    }
}