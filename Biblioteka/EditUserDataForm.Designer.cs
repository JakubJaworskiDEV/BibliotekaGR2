namespace Biblioteka
{
    partial class EditUserDataForm
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
            txtEditSurname = new TextBox();
            txtEditPesel = new TextBox();
            txtEditEmail = new TextBox();
            txtEditBirthDate = new TextBox();
            txtEditName = new TextBox();
            lblName = new Label();
            lblSurname = new Label();
            lblPesel = new Label();
            lblEmail = new Label();
            label5 = new Label();
            lblPlec = new Label();
            txtEditGender = new TextBox();
            txtEditPhone = new TextBox();
            txtEditAddress = new TextBox();
            lblAddress = new Label();
            lblPhoneNumber = new Label();
            btnSaveEditUserData = new Button();
            SuspendLayout();
            // 
            // txtEditSurname
            // 
            txtEditSurname.Location = new Point(268, 310);
            txtEditSurname.Name = "txtEditSurname";
            txtEditSurname.Size = new Size(248, 25);
            txtEditSurname.TabIndex = 0;
            // 
            // txtEditPesel
            // 
            txtEditPesel.Location = new Point(268, 365);
            txtEditPesel.Name = "txtEditPesel";
            txtEditPesel.Size = new Size(248, 25);
            txtEditPesel.TabIndex = 1;
            // 
            // txtEditEmail
            // 
            txtEditEmail.Location = new Point(268, 423);
            txtEditEmail.Name = "txtEditEmail";
            txtEditEmail.Size = new Size(248, 25);
            txtEditEmail.TabIndex = 2;
            // 
            // txtEditBirthDate
            // 
            txtEditBirthDate.Location = new Point(268, 475);
            txtEditBirthDate.Name = "txtEditBirthDate";
            txtEditBirthDate.Size = new Size(248, 25);
            txtEditBirthDate.TabIndex = 3;
            // 
            // txtEditName
            // 
            txtEditName.Location = new Point(268, 262);
            txtEditName.Name = "txtEditName";
            txtEditName.Size = new Size(248, 25);
            txtEditName.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(96, 265);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 17);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(96, 318);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(59, 17);
            lblSurname.TabIndex = 6;
            lblSurname.Text = "Surname";
            // 
            // lblPesel
            // 
            lblPesel.AutoSize = true;
            lblPesel.Location = new Point(96, 368);
            lblPesel.Name = "lblPesel";
            lblPesel.Size = new Size(42, 17);
            lblPesel.TabIndex = 7;
            lblPesel.Text = "PESEL";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(96, 423);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 17);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 478);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 9;
            label5.Text = "Birth Date";
            // 
            // lblPlec
            // 
            lblPlec.AutoSize = true;
            lblPlec.Location = new Point(96, 535);
            lblPlec.Name = "lblPlec";
            lblPlec.Size = new Size(51, 17);
            lblPlec.TabIndex = 10;
            lblPlec.Text = "Gender";
            // 
            // txtEditGender
            // 
            txtEditGender.Location = new Point(268, 532);
            txtEditGender.Name = "txtEditGender";
            txtEditGender.Size = new Size(248, 25);
            txtEditGender.TabIndex = 11;
            // 
            // txtEditPhone
            // 
            txtEditPhone.Location = new Point(268, 588);
            txtEditPhone.Name = "txtEditPhone";
            txtEditPhone.Size = new Size(248, 25);
            txtEditPhone.TabIndex = 12;
            // 
            // txtEditAddress
            // 
            txtEditAddress.Location = new Point(268, 649);
            txtEditAddress.Name = "txtEditAddress";
            txtEditAddress.Size = new Size(248, 25);
            txtEditAddress.TabIndex = 13;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(95, 652);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(56, 17);
            lblAddress.TabIndex = 14;
            lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(95, 591);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(96, 17);
            lblPhoneNumber.TabIndex = 15;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // btnSaveEditUserData
            // 
            btnSaveEditUserData.Location = new Point(192, 717);
            btnSaveEditUserData.Name = "btnSaveEditUserData";
            btnSaveEditUserData.Size = new Size(193, 49);
            btnSaveEditUserData.TabIndex = 16;
            btnSaveEditUserData.Text = "Save Changes";
            btnSaveEditUserData.UseVisualStyleBackColor = true;
            btnSaveEditUserData.Click += btnSaveEditUserData_Click;
            // 
            // EditUserDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 778);
            Controls.Add(btnSaveEditUserData);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblAddress);
            Controls.Add(txtEditAddress);
            Controls.Add(txtEditPhone);
            Controls.Add(txtEditGender);
            Controls.Add(lblPlec);
            Controls.Add(label5);
            Controls.Add(lblEmail);
            Controls.Add(lblPesel);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(txtEditName);
            Controls.Add(txtEditBirthDate);
            Controls.Add(txtEditEmail);
            Controls.Add(txtEditPesel);
            Controls.Add(txtEditSurname);
            Name = "EditUserDataForm";
            Text = "EditUserDataForm";
            Load += EditUserDataForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEditSurname;
        private TextBox txtEditPesel;
        private TextBox txtEditEmail;
        private TextBox txtEditBirthDate;
        private TextBox txtEditName;
        private Label lblName;
        private Label lblSurname;
        private Label lblPesel;
        private Label lblEmail;
        private Label label5;
        private Label lblPlec;
        private TextBox txtEditGender;
        private TextBox txtEditPhone;
        private TextBox txtEditAddress;
        private Label lblAddress;
        private Label lblPhoneNumber;
        private Button btnSaveEditUserData;
    }
}