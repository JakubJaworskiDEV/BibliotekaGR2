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
            SuspendLayout();
            // 
            // ChangePassword
            // 
            ChangePassword.Location = new Point(339, 339);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Size = new Size(185, 50);
            ChangePassword.TabIndex = 0;
            ChangePassword.Text = "Zmień hasło";
            ChangePassword.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 119);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 1;
            label1.Text = "Podaj nowe hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 194);
            label2.Name = "label2";
            label2.Size = new Size(138, 17);
            label2.TabIndex = 2;
            label2.Text = "Potwierdź nowe hasło:";
            // 
            // NewPassword
            // 
            NewPassword.Location = new Point(213, 139);
            NewPassword.Name = "NewPassword";
            NewPassword.Size = new Size(232, 25);
            NewPassword.TabIndex = 3;
            // 
            // AgainNewPassword
            // 
            AgainNewPassword.Location = new Point(213, 214);
            AgainNewPassword.Name = "AgainNewPassword";
            AgainNewPassword.Size = new Size(232, 25);
            AgainNewPassword.TabIndex = 4;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Location = new Point(134, 339);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(185, 50);
            btnBackToLogin.TabIndex = 5;
            btnBackToLogin.Text = "Anuluj";
            btnBackToLogin.UseVisualStyleBackColor = true;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 407);
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
    }
}