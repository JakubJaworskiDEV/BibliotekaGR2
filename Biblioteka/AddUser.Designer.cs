namespace Biblioteka
{
    partial class AddUser
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
            AddBtn = new Button();
            Login = new Label();
            NameLabel = new Label();
            Surname = new Label();
            town = new Label();
            ZipCode = new Label();
            propertyNumber = new Label();
            street = new Label();
            apartmentNumber = new Label();
            PESEL = new Label();
            email = new Label();
            tel = new Label();
            dateOfbirth = new Label();
            sex = new Label();
            Activity = new Label();
            txtLogin = new TextBox();
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            txtMiejscowosc = new TextBox();
            txtKodPocztowy = new TextBox();
            txtNumerPosesji = new TextBox();
            txtUlica = new TextBox();
            txtNumerLokalu = new TextBox();
            txtPESEL = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            cmbPlec = new ComboBox();
            chkAktywny = new CheckBox();
            ExitBtn = new Button();
            dtpDataUrodzenia = new DateTimePicker();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(274, 391);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(193, 47);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Dodaj nowego użytkownika";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Location = new Point(12, 19);
            Login.Name = "Login";
            Login.Size = new Size(70, 15);
            Login.TabIndex = 1;
            Login.Text = "Podaj login ";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 73);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(66, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Podaj imię ";
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Location = new Point(12, 125);
            Surname.Name = "Surname";
            Surname.Size = new Size(91, 15);
            Surname.TabIndex = 3;
            Surname.Text = "Podaj nazwisko ";
            // 
            // town
            // 
            town.AutoSize = true;
            town.Location = new Point(12, 181);
            town.Name = "town";
            town.Size = new Size(108, 15);
            town.TabIndex = 4;
            town.Text = "Podaj miejscowość";
            // 
            // ZipCode
            // 
            ZipCode.AutoSize = true;
            ZipCode.Location = new Point(12, 239);
            ZipCode.Name = "ZipCode";
            ZipCode.Size = new Size(115, 15);
            ZipCode.TabIndex = 5;
            ZipCode.Text = "Podaj Kod pocztowy";
            // 
            // propertyNumber
            // 
            propertyNumber.AutoSize = true;
            propertyNumber.Location = new Point(12, 292);
            propertyNumber.Name = "propertyNumber";
            propertyNumber.Size = new Size(114, 15);
            propertyNumber.TabIndex = 6;
            propertyNumber.Text = "Podaj numer posesji";
            // 
            // street
            // 
            street.AutoSize = true;
            street.Location = new Point(274, 19);
            street.Name = "street";
            street.Size = new Size(65, 15);
            street.TabIndex = 7;
            street.Text = "Podaj ulicę";
            // 
            // apartmentNumber
            // 
            apartmentNumber.AutoSize = true;
            apartmentNumber.Location = new Point(274, 73);
            apartmentNumber.Name = "apartmentNumber";
            apartmentNumber.Size = new Size(110, 15);
            apartmentNumber.TabIndex = 8;
            apartmentNumber.Text = "Podaj numer lokalu";
            // 
            // PESEL
            // 
            PESEL.AutoSize = true;
            PESEL.Location = new Point(274, 125);
            PESEL.Name = "PESEL";
            PESEL.Size = new Size(71, 15);
            PESEL.TabIndex = 9;
            PESEL.Text = "Podaj PESEL";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(274, 181);
            email.Name = "email";
            email.Size = new Size(69, 15);
            email.TabIndex = 10;
            email.Text = "Podaj email";
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.Location = new Point(274, 239);
            tel.Name = "tel";
            tel.Size = new Size(122, 15);
            tel.TabIndex = 11;
            tel.Text = "Podaj numer telefonu";
            // 
            // dateOfbirth
            // 
            dateOfbirth.AutoSize = true;
            dateOfbirth.Location = new Point(550, 19);
            dateOfbirth.Name = "dateOfbirth";
            dateOfbirth.Size = new Size(118, 15);
            dateOfbirth.TabIndex = 12;
            dateOfbirth.Text = "Podaj datę urodzenia";
            // 
            // sex
            // 
            sex.AutoSize = true;
            sex.Location = new Point(550, 73);
            sex.Name = "sex";
            sex.Size = new Size(62, 15);
            sex.TabIndex = 13;
            sex.Text = "Podaj płeć";
            // 
            // Activity
            // 
            Activity.AutoSize = true;
            Activity.Location = new Point(550, 125);
            Activity.Name = "Activity";
            Activity.Size = new Size(133, 15);
            Activity.TabIndex = 14;
            Activity.Text = "Podaj status aktywności";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(12, 37);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(191, 23);
            txtLogin.TabIndex = 15;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(12, 91);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(191, 23);
            txtImie.TabIndex = 16;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(3, 143);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(191, 23);
            txtNazwisko.TabIndex = 17;
            // 
            // txtMiejscowosc
            // 
            txtMiejscowosc.Location = new Point(3, 199);
            txtMiejscowosc.Name = "txtMiejscowosc";
            txtMiejscowosc.Size = new Size(191, 23);
            txtMiejscowosc.TabIndex = 18;
            // 
            // txtKodPocztowy
            // 
            txtKodPocztowy.Location = new Point(3, 257);
            txtKodPocztowy.Name = "txtKodPocztowy";
            txtKodPocztowy.Size = new Size(191, 23);
            txtKodPocztowy.TabIndex = 19;
            // 
            // txtNumerPosesji
            // 
            txtNumerPosesji.Location = new Point(3, 310);
            txtNumerPosesji.Name = "txtNumerPosesji";
            txtNumerPosesji.Size = new Size(191, 23);
            txtNumerPosesji.TabIndex = 20;
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(274, 37);
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(191, 23);
            txtUlica.TabIndex = 21;
            // 
            // txtNumerLokalu
            // 
            txtNumerLokalu.Location = new Point(274, 91);
            txtNumerLokalu.Name = "txtNumerLokalu";
            txtNumerLokalu.Size = new Size(191, 23);
            txtNumerLokalu.TabIndex = 22;
            // 
            // txtPESEL
            // 
            txtPESEL.Location = new Point(274, 143);
            txtPESEL.Name = "txtPESEL";
            txtPESEL.Size = new Size(191, 23);
            txtPESEL.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(276, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 24;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(276, 257);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(191, 23);
            txtTelefon.TabIndex = 25;
            // 
            // cmbPlec
            // 
            cmbPlec.FormattingEnabled = true;
            cmbPlec.Items.AddRange(new object[] { "mężczyzna", "kobieta" });
            cmbPlec.Location = new Point(550, 91);
            cmbPlec.Name = "cmbPlec";
            cmbPlec.Size = new Size(121, 23);
            cmbPlec.TabIndex = 26;
            cmbPlec.SelectedIndexChanged += cmbPlec_SelectedIndexChanged;
            // 
            // chkAktywny
            // 
            chkAktywny.AutoSize = true;
            chkAktywny.Location = new Point(550, 147);
            chkAktywny.Name = "chkAktywny";
            chkAktywny.Size = new Size(92, 19);
            chkAktywny.TabIndex = 28;
            chkAktywny.Text = "Czy aktywny";
            chkAktywny.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(525, 391);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(189, 47);
            ExitBtn.TabIndex = 29;
            ExitBtn.Text = "wyjdź";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // dtpDataUrodzenia
            // 
            dtpDataUrodzenia.Location = new Point(550, 37);
            dtpDataUrodzenia.Name = "dtpDataUrodzenia";
            dtpDataUrodzenia.Size = new Size(200, 23);
            dtpDataUrodzenia.TabIndex = 30;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDataUrodzenia);
            Controls.Add(ExitBtn);
            Controls.Add(chkAktywny);
            Controls.Add(cmbPlec);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtPESEL);
            Controls.Add(txtNumerLokalu);
            Controls.Add(txtUlica);
            Controls.Add(txtNumerPosesji);
            Controls.Add(txtKodPocztowy);
            Controls.Add(txtMiejscowosc);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Controls.Add(txtLogin);
            Controls.Add(Activity);
            Controls.Add(sex);
            Controls.Add(dateOfbirth);
            Controls.Add(tel);
            Controls.Add(email);
            Controls.Add(PESEL);
            Controls.Add(apartmentNumber);
            Controls.Add(street);
            Controls.Add(propertyNumber);
            Controls.Add(ZipCode);
            Controls.Add(town);
            Controls.Add(Surname);
            Controls.Add(NameLabel);
            Controls.Add(Login);
            Controls.Add(AddBtn);
            Name = "AddUser";
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private Label Login;
        private Label NameLabel;
        private Label Surname;
        private Label town;
        private Label ZipCode;
        private Label propertyNumber;
        private Label street;
        private Label apartmentNumber;
        private Label PESEL;
        private Label email;
        private Label tel;
        private Label dateOfbirth;
        private Label sex;
        private Label Activity;
        private TextBox txtLogin;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtMiejscowosc;
        private TextBox txtKodPocztowy;
        private TextBox txtNumerPosesji;
        private TextBox txtUlica;
        private TextBox txtNumerLokalu;
        private TextBox txtPESEL;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private ComboBox cmbPlec;
        private CheckBox chkAktywny;
        private Button ExitBtn;
        private DateTimePicker dtpDataUrodzenia;
    }
}