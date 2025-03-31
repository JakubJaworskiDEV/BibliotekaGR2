namespace Biblioteka
{
    partial class UserProfileForm
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
            lblName = new Label();
            lblSurname = new Label();
            lblPesel = new Label();
            lblLogin = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            btnEditUserData = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(211, 303);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 17);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(211, 390);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(43, 17);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "label2";
            // 
            // lblPesel
            // 
            lblPesel.AutoSize = true;
            lblPesel.Location = new Point(211, 473);
            lblPesel.Name = "lblPesel";
            lblPesel.Size = new Size(43, 17);
            lblPesel.TabIndex = 2;
            lblPesel.Text = "label3";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(519, 303);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(43, 17);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "label4";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(519, 390);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(43, 17);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "label5";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(519, 473);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(43, 17);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "label6";
            // 
            // btnEditUserData
            // 
            btnEditUserData.Location = new Point(12, 424);
            btnEditUserData.Name = "btnEditUserData";
            btnEditUserData.Size = new Size(170, 66);
            btnEditUserData.TabIndex = 6;
            btnEditUserData.Text = "Edytuj Dane Użytkownika";
            btnEditUserData.UseVisualStyleBackColor = true;
            btnEditUserData.Click += btnEditUserData_Click;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 547);
            Controls.Add(btnEditUserData);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblLogin);
            Controls.Add(lblPesel);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            Load += UserProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSurname;
        private Label lblPesel;
        private Label lblLogin;
        private Label lblEmail;
        private Label lblPhone;
        private Button btnEditUserData;
    }
}