namespace Biblioteka
{
    partial class RemaindPasswordForm
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
            label1 = new Label();
            EmailPassword = new TextBox();
            button1 = new Button();
            ExitButtonRemindPassword = new Button();
            label3 = new Label();
            LoginRemind = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 118);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Podaj email";
            // 
            // EmailPassword
            // 
            EmailPassword.Location = new Point(227, 146);
            EmailPassword.Name = "EmailPassword";
            EmailPassword.Size = new Size(100, 23);
            EmailPassword.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(256, 242);
            button1.Name = "button1";
            button1.Size = new Size(202, 66);
            button1.TabIndex = 4;
            button1.Text = "Wyślij nowe hasło";
            button1.UseVisualStyleBackColor = true;
            // 
            // ExitButtonRemindPassword
            // 
            ExitButtonRemindPassword.Location = new Point(33, 21);
            ExitButtonRemindPassword.Name = "ExitButtonRemindPassword";
            ExitButtonRemindPassword.Size = new Size(75, 23);
            ExitButtonRemindPassword.TabIndex = 5;
            ExitButtonRemindPassword.Text = "Wyjdź";
            ExitButtonRemindPassword.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 172);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Podaj login";
            // 
            // LoginRemind
            // 
            LoginRemind.Location = new Point(227, 190);
            LoginRemind.Name = "LoginRemind";
            LoginRemind.Size = new Size(100, 23);
            LoginRemind.TabIndex = 7;
            // 
            // RemaindPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginRemind);
            Controls.Add(label3);
            Controls.Add(ExitButtonRemindPassword);
            Controls.Add(button1);
            Controls.Add(EmailPassword);
            Controls.Add(label1);
            Name = "RemaindPasswordForm";
            Text = "RemaindPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox EmailPassword;
        private Button button1;
        private Button ExitButtonRemindPassword;
        private Label label3;
        private TextBox LoginRemind;
    }
}