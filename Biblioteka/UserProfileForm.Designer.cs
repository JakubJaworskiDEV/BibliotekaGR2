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
            btnEditUserData = new Button();
            label5 = new Label();
            label7 = new Label();
            label10 = new Label();
            label14 = new Label();
            label16 = new Label();
            label18 = new Label();
            label20 = new Label();
            label24 = new Label();
            label22 = new Label();
            label26 = new Label();
            label28 = new Label();
            label30 = new Label();
            label32 = new Label();
            btnBackToList = new Button();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtGender = new TextBox();
            txtPesel = new TextBox();
            txtLogin = new TextBox();
            txtBldNr = new TextBox();
            txtStreetName = new TextBox();
            txtPlace = new TextBox();
            txtPhoneNr = new TextBox();
            txtEmail = new TextBox();
            txtPostalCode = new TextBox();
            txtFlatNr = new TextBox();
            txtBirthDate = new TextBox();
            SuspendLayout();
            // 
            // btnEditUserData
            // 
            btnEditUserData.Location = new Point(183, 453);
            btnEditUserData.Name = "btnEditUserData";
            btnEditUserData.Size = new Size(176, 45);
            btnEditUserData.TabIndex = 6;
            btnEditUserData.Text = "Edytuj Dane Użytkownika";
            btnEditUserData.UseVisualStyleBackColor = true;
            btnEditUserData.Click += btnEditUserData_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 18);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 12;
            label5.Text = "Imię:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 49);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 14;
            label7.Text = "Nazwisko:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(70, 142);
            label10.Name = "label10";
            label10.Size = new Size(45, 17);
            label10.TabIndex = 16;
            label10.Text = "PESEL:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(73, 200);
            label14.Name = "label14";
            label14.Size = new Size(42, 17);
            label14.TabIndex = 20;
            label14.Text = "Email:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(36, 283);
            label16.Name = "label16";
            label16.Size = new Size(85, 17);
            label16.TabIndex = 22;
            label16.Text = "Miejscowość:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(72, 170);
            label18.Name = "label18";
            label18.Size = new Size(43, 17);
            label18.TabIndex = 24;
            label18.Text = "Login:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(62, 235);
            label20.Name = "label20";
            label20.Size = new Size(53, 17);
            label20.TabIndex = 26;
            label20.Text = "Telefon:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(42, 309);
            label24.Name = "label24";
            label24.Size = new Size(79, 17);
            label24.TabIndex = 30;
            label24.Text = "Nazwa ulicy:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(21, 340);
            label22.Name = "label22";
            label22.Size = new Size(104, 17);
            label22.TabIndex = 32;
            label22.Text = "Numer budynku:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(7, 368);
            label26.Name = "label26";
            label26.Size = new Size(118, 17);
            label26.TabIndex = 34;
            label26.Text = "Numer mieszkania:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(27, 399);
            label28.Name = "label28";
            label28.Size = new Size(94, 17);
            label28.TabIndex = 36;
            label28.Text = "Kod pocztowy:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(15, 111);
            label30.Name = "label30";
            label30.Size = new Size(100, 17);
            label30.TabIndex = 38;
            label30.Text = "Data urodzenia:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(81, 80);
            label32.Name = "label32";
            label32.Size = new Size(34, 17);
            label32.TabIndex = 40;
            label32.Text = "Płeć:";
            // 
            // btnBackToList
            // 
            btnBackToList.Location = new Point(12, 453);
            btnBackToList.Name = "btnBackToList";
            btnBackToList.Size = new Size(114, 42);
            btnBackToList.TabIndex = 42;
            btnBackToList.Text = "Powrót";
            btnBackToList.UseVisualStyleBackColor = true;
            btnBackToList.Click += btnBackToList_Click;
            // 
            // txtName
            // 
            txtName.ForeColor = SystemColors.Window;
            txtName.Location = new Point(142, 15);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(217, 25);
            txtName.TabIndex = 43;
            // 
            // txtSurname
            // 
            txtSurname.ForeColor = SystemColors.Window;
            txtSurname.Location = new Point(142, 46);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(217, 25);
            txtSurname.TabIndex = 44;
            // 
            // txtGender
            // 
            txtGender.ForeColor = SystemColors.Window;
            txtGender.Location = new Point(142, 77);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(217, 25);
            txtGender.TabIndex = 45;
            // 
            // txtPesel
            // 
            txtPesel.ForeColor = SystemColors.Window;
            txtPesel.Location = new Point(142, 139);
            txtPesel.Name = "txtPesel";
            txtPesel.ReadOnly = true;
            txtPesel.Size = new Size(217, 25);
            txtPesel.TabIndex = 47;
            // 
            // txtLogin
            // 
            txtLogin.ForeColor = SystemColors.Window;
            txtLogin.Location = new Point(142, 170);
            txtLogin.Name = "txtLogin";
            txtLogin.ReadOnly = true;
            txtLogin.Size = new Size(217, 25);
            txtLogin.TabIndex = 48;
            // 
            // txtBldNr
            // 
            txtBldNr.ForeColor = SystemColors.Window;
            txtBldNr.Location = new Point(142, 337);
            txtBldNr.Name = "txtBldNr";
            txtBldNr.ReadOnly = true;
            txtBldNr.Size = new Size(217, 25);
            txtBldNr.TabIndex = 54;
            // 
            // txtStreetName
            // 
            txtStreetName.ForeColor = SystemColors.Window;
            txtStreetName.Location = new Point(142, 306);
            txtStreetName.Name = "txtStreetName";
            txtStreetName.ReadOnly = true;
            txtStreetName.Size = new Size(217, 25);
            txtStreetName.TabIndex = 53;
            // 
            // txtPlace
            // 
            txtPlace.ForeColor = SystemColors.Window;
            txtPlace.Location = new Point(142, 275);
            txtPlace.Name = "txtPlace";
            txtPlace.ReadOnly = true;
            txtPlace.Size = new Size(217, 25);
            txtPlace.TabIndex = 52;
            // 
            // txtPhoneNr
            // 
            txtPhoneNr.ForeColor = SystemColors.Window;
            txtPhoneNr.Location = new Point(142, 232);
            txtPhoneNr.Name = "txtPhoneNr";
            txtPhoneNr.ReadOnly = true;
            txtPhoneNr.Size = new Size(217, 25);
            txtPhoneNr.TabIndex = 50;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = SystemColors.Window;
            txtEmail.Location = new Point(142, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(217, 25);
            txtEmail.TabIndex = 49;
            // 
            // txtPostalCode
            // 
            txtPostalCode.ForeColor = SystemColors.Window;
            txtPostalCode.Location = new Point(142, 399);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.ReadOnly = true;
            txtPostalCode.Size = new Size(217, 25);
            txtPostalCode.TabIndex = 56;
            // 
            // txtFlatNr
            // 
            txtFlatNr.ForeColor = SystemColors.Window;
            txtFlatNr.Location = new Point(142, 368);
            txtFlatNr.Name = "txtFlatNr";
            txtFlatNr.ReadOnly = true;
            txtFlatNr.Size = new Size(217, 25);
            txtFlatNr.TabIndex = 55;
            // 
            // txtBirthDate
            // 
            txtBirthDate.ForeColor = SystemColors.Window;
            txtBirthDate.Location = new Point(142, 111);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.ReadOnly = true;
            txtBirthDate.Size = new Size(217, 25);
            txtBirthDate.TabIndex = 57;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 511);
            Controls.Add(txtBirthDate);
            Controls.Add(txtPostalCode);
            Controls.Add(txtFlatNr);
            Controls.Add(txtBldNr);
            Controls.Add(txtStreetName);
            Controls.Add(txtPlace);
            Controls.Add(txtPhoneNr);
            Controls.Add(txtEmail);
            Controls.Add(txtLogin);
            Controls.Add(txtPesel);
            Controls.Add(txtGender);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(btnBackToList);
            Controls.Add(label32);
            Controls.Add(label30);
            Controls.Add(label28);
            Controls.Add(label26);
            Controls.Add(label22);
            Controls.Add(label24);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(btnEditUserData);
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            Load += UserProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEditUserData;
        private Label label5;
        private Label label7;
        private Label label10;
        private Label label14;
        private Label label16;
        private Label label18;
        private Label label20;
        private Label label24;
        private Label label22;
        private Label label26;
        private Label label28;
        private Label label30;
        private Label label32;
        private Button btnBackToList;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtGender;
        private TextBox txtPesel;
        private TextBox txtLogin;
        private TextBox txtBldNr;
        private TextBox txtStreetName;
        private TextBox txtPlace;
        private TextBox txtPhoneNr;
        private TextBox txtEmail;
        private TextBox txtPostalCode;
        private TextBox txtFlatNr;
        private TextBox txtBirthDate;
    }
}