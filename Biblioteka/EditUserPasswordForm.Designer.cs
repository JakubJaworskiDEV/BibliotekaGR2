namespace Biblioteka
{
    partial class EditUserPasswordForm
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
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            BtnSaveUserPassword = new Button();
            BtnBackToEditData = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(122, 111);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(298, 25);
            txtNewPassword.TabIndex = 0;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(122, 173);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(298, 25);
            txtConfirmPassword.TabIndex = 1;
            // 
            // BtnSaveUserPassword
            // 
            BtnSaveUserPassword.Location = new Point(304, 226);
            BtnSaveUserPassword.Name = "BtnSaveUserPassword";
            BtnSaveUserPassword.Size = new Size(116, 40);
            BtnSaveUserPassword.TabIndex = 2;
            BtnSaveUserPassword.Text = "Zapisz hasło";
            BtnSaveUserPassword.UseVisualStyleBackColor = true;
            BtnSaveUserPassword.Click += BtnSaveUserPassword_Click;
            // 
            // BtnBackToEditData
            // 
            BtnBackToEditData.Location = new Point(122, 226);
            BtnBackToEditData.Name = "BtnBackToEditData";
            BtnBackToEditData.Size = new Size(116, 40);
            BtnBackToEditData.TabIndex = 3;
            BtnBackToEditData.Text = "Anuluj";
            BtnBackToEditData.UseVisualStyleBackColor = true;
            BtnBackToEditData.Click += BtnBackToEditData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 91);
            label1.Name = "label1";
            label1.Size = new Size(149, 17);
            label1.TabIndex = 4;
            label1.Text = "Wprowadź nowe hasło*:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 153);
            label2.Name = "label2";
            label2.Size = new Size(170, 17);
            label2.TabIndex = 5;
            label2.Text = "Wprowadź hasło ponownie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 341);
            label3.Name = "label3";
            label3.Size = new Size(399, 34);
            label3.TabIndex = 6;
            label3.Text = "* Hasło musi mieć od 8 do 15 znaków i zawierać co najmniej jedną \r\nwielką literę, małą literę, cyfrę oraz znak specjalny (- _ ! * # $ &).";
            // 
            // EditUserPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 384);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnBackToEditData);
            Controls.Add(BtnSaveUserPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Name = "EditUserPasswordForm";
            Text = "EditUserPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button BtnSaveUserPassword;
        private Button BtnBackToEditData;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}