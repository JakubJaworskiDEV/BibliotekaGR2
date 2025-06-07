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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
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
            BtnChangeUserPasswd = new Button();
            SuspendLayout();
            // 
            // btnEditUserData
            // 
            btnEditUserData.BackColor = Color.FromArgb(64, 64, 64);
            btnEditUserData.ForeColor = SystemColors.Control;
            btnEditUserData.Location = new Point(239, 574);
            btnEditUserData.Margin = new Padding(3, 4, 3, 4);
            btnEditUserData.Name = "btnEditUserData";
            btnEditUserData.Size = new Size(226, 53);
            btnEditUserData.TabIndex = 6;
            btnEditUserData.Text = "Edytuj Dane Użytkownika";
            btnEditUserData.UseVisualStyleBackColor = false;
            btnEditUserData.Click += btnEditUserData_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(252, 240, 224);
            label5.Location = new Point(102, 21);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 12;
            label5.Text = "Imię:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(252, 240, 224);
            label7.Location = new Point(63, 57);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 14;
            label7.Text = "Nazwisko:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(252, 240, 224);
            label10.Location = new Point(90, 167);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 16;
            label10.Text = "PESEL:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(252, 240, 224);
            label14.Location = new Point(93, 235);
            label14.Name = "label14";
            label14.Size = new Size(51, 20);
            label14.TabIndex = 20;
            label14.Text = "Email:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(252, 240, 224);
            label16.Location = new Point(46, 333);
            label16.Name = "label16";
            label16.Size = new Size(101, 20);
            label16.TabIndex = 22;
            label16.Text = "Miejscowość:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(252, 240, 224);
            label18.Location = new Point(92, 200);
            label18.Name = "label18";
            label18.Size = new Size(52, 20);
            label18.TabIndex = 24;
            label18.Text = "Login:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(252, 240, 224);
            label20.Location = new Point(80, 276);
            label20.Name = "label20";
            label20.Size = new Size(65, 20);
            label20.TabIndex = 26;
            label20.Text = "Telefon:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.FromArgb(252, 240, 224);
            label24.Location = new Point(54, 364);
            label24.Name = "label24";
            label24.Size = new Size(96, 20);
            label24.TabIndex = 30;
            label24.Text = "Nazwa ulicy:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(252, 240, 224);
            label22.Location = new Point(27, 400);
            label22.Name = "label22";
            label22.Size = new Size(127, 20);
            label22.TabIndex = 32;
            label22.Text = "Numer budynku:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.FromArgb(252, 240, 224);
            label26.Location = new Point(9, 433);
            label26.Name = "label26";
            label26.Size = new Size(143, 20);
            label26.TabIndex = 34;
            label26.Text = "Numer mieszkania:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.FromArgb(252, 240, 224);
            label28.Location = new Point(35, 469);
            label28.Name = "label28";
            label28.Size = new Size(112, 20);
            label28.TabIndex = 36;
            label28.Text = "Kod pocztowy:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.FromArgb(252, 240, 224);
            label30.Location = new Point(19, 131);
            label30.Name = "label30";
            label30.Size = new Size(119, 20);
            label30.TabIndex = 38;
            label30.Text = "Data urodzenia:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = Color.FromArgb(252, 240, 224);
            label32.Location = new Point(105, 95);
            label32.Name = "label32";
            label32.Size = new Size(42, 20);
            label32.TabIndex = 40;
            label32.Text = "Płeć:";
            // 
            // btnBackToList
            // 
            btnBackToList.BackColor = Color.FromArgb(64, 64, 64);
            btnBackToList.ForeColor = SystemColors.Control;
            btnBackToList.Location = new Point(27, 574);
            btnBackToList.Margin = new Padding(3, 4, 3, 4);
            btnBackToList.Name = "btnBackToList";
            btnBackToList.Size = new Size(146, 49);
            btnBackToList.TabIndex = 42;
            btnBackToList.Text = "Powrót";
            btnBackToList.UseVisualStyleBackColor = false;
            btnBackToList.Click += btnBackToList_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(182, 17);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(277, 27);
            txtName.TabIndex = 43;
            // 
            // txtSurname
            // 
            txtSurname.BackColor = Color.White;
            txtSurname.ForeColor = Color.Black;
            txtSurname.Location = new Point(182, 55);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(277, 27);
            txtSurname.TabIndex = 44;
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.White;
            txtGender.ForeColor = Color.Black;
            txtGender.Location = new Point(182, 91);
            txtGender.Margin = new Padding(3, 4, 3, 4);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(277, 27);
            txtGender.TabIndex = 45;
            // 
            // txtPesel
            // 
            txtPesel.BackColor = Color.White;
            txtPesel.ForeColor = Color.Black;
            txtPesel.Location = new Point(182, 164);
            txtPesel.Margin = new Padding(3, 4, 3, 4);
            txtPesel.Name = "txtPesel";
            txtPesel.ReadOnly = true;
            txtPesel.Size = new Size(277, 27);
            txtPesel.TabIndex = 47;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.White;
            txtLogin.ForeColor = Color.Black;
            txtLogin.Location = new Point(182, 200);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.ReadOnly = true;
            txtLogin.Size = new Size(277, 27);
            txtLogin.TabIndex = 48;
            // 
            // txtBldNr
            // 
            txtBldNr.BackColor = Color.White;
            txtBldNr.ForeColor = Color.Black;
            txtBldNr.Location = new Point(182, 396);
            txtBldNr.Margin = new Padding(3, 4, 3, 4);
            txtBldNr.Name = "txtBldNr";
            txtBldNr.ReadOnly = true;
            txtBldNr.Size = new Size(277, 27);
            txtBldNr.TabIndex = 54;
            // 
            // txtStreetName
            // 
            txtStreetName.BackColor = Color.White;
            txtStreetName.ForeColor = Color.Black;
            txtStreetName.Location = new Point(182, 360);
            txtStreetName.Margin = new Padding(3, 4, 3, 4);
            txtStreetName.Name = "txtStreetName";
            txtStreetName.ReadOnly = true;
            txtStreetName.Size = new Size(277, 27);
            txtStreetName.TabIndex = 53;
            // 
            // txtPlace
            // 
            txtPlace.BackColor = Color.White;
            txtPlace.ForeColor = Color.Black;
            txtPlace.Location = new Point(182, 324);
            txtPlace.Margin = new Padding(3, 4, 3, 4);
            txtPlace.Name = "txtPlace";
            txtPlace.ReadOnly = true;
            txtPlace.Size = new Size(277, 27);
            txtPlace.TabIndex = 52;
            // 
            // txtPhoneNr
            // 
            txtPhoneNr.BackColor = Color.White;
            txtPhoneNr.ForeColor = Color.Black;
            txtPhoneNr.Location = new Point(182, 273);
            txtPhoneNr.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNr.Name = "txtPhoneNr";
            txtPhoneNr.ReadOnly = true;
            txtPhoneNr.Size = new Size(277, 27);
            txtPhoneNr.TabIndex = 50;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(182, 236);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(277, 27);
            txtEmail.TabIndex = 49;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = Color.White;
            txtPostalCode.ForeColor = Color.Black;
            txtPostalCode.Location = new Point(182, 469);
            txtPostalCode.Margin = new Padding(3, 4, 3, 4);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.ReadOnly = true;
            txtPostalCode.Size = new Size(277, 27);
            txtPostalCode.TabIndex = 56;
            // 
            // txtFlatNr
            // 
            txtFlatNr.BackColor = Color.White;
            txtFlatNr.ForeColor = Color.Black;
            txtFlatNr.Location = new Point(182, 433);
            txtFlatNr.Margin = new Padding(3, 4, 3, 4);
            txtFlatNr.Name = "txtFlatNr";
            txtFlatNr.ReadOnly = true;
            txtFlatNr.Size = new Size(277, 27);
            txtFlatNr.TabIndex = 55;
            // 
            // txtBirthDate
            // 
            txtBirthDate.BackColor = Color.White;
            txtBirthDate.ForeColor = Color.Black;
            txtBirthDate.Location = new Point(182, 131);
            txtBirthDate.Margin = new Padding(3, 4, 3, 4);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.ReadOnly = true;
            txtBirthDate.Size = new Size(277, 27);
            txtBirthDate.TabIndex = 57;
            // 
            // BtnChangeUserPasswd
            // 
            BtnChangeUserPasswd.BackColor = Color.RosyBrown;
            BtnChangeUserPasswd.ForeColor = Color.AliceBlue;
            BtnChangeUserPasswd.Location = new Point(182, 513);
            BtnChangeUserPasswd.Name = "BtnChangeUserPasswd";
            BtnChangeUserPasswd.Size = new Size(220, 37);
            BtnChangeUserPasswd.TabIndex = 58;
            BtnChangeUserPasswd.Text = "Zmień hasło";
            BtnChangeUserPasswd.UseVisualStyleBackColor = false;
            BtnChangeUserPasswd.Click += BtnChangeUserPasswd_Click;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(477, 648);
            Controls.Add(BtnChangeUserPasswd);
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
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserProfileForm";
            Text = "Dane użytkownika";
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
        private Button BtnChangeUserPasswd;
    }
}