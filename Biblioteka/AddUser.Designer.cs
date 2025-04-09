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
            ExitBtn = new Button();
            txtAdres = new TextBox();
            txtstLog = new TextBox();
            txtRodzaj = new TextBox();
            txtKsiazka = new TextBox();
            label1 = new Label();
            DateTimePickers = new DateTimePicker();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(363, 443);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(193, 53);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Dodaj nowego użytkownika";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Location = new Point(24, 22);
            Login.Name = "Login";
            Login.Size = new Size(78, 17);
            Login.TabIndex = 1;
            Login.Text = "Podaj login ";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(24, 83);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(73, 17);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Podaj imię ";
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Location = new Point(24, 145);
            Surname.Name = "Surname";
            Surname.Size = new Size(101, 17);
            Surname.TabIndex = 3;
            Surname.Text = "Podaj nazwisko ";
            // 
            // town
            // 
            town.AutoSize = true;
            town.Location = new Point(278, 145);
            town.Name = "town";
            town.Size = new Size(118, 17);
            town.TabIndex = 4;
            town.Text = "Podaj miejscowość";
            town.Click += town_Click;
            // 
            // ZipCode
            // 
            ZipCode.AutoSize = true;
            ZipCode.Location = new Point(278, 206);
            ZipCode.Name = "ZipCode";
            ZipCode.Size = new Size(128, 17);
            ZipCode.TabIndex = 5;
            ZipCode.Text = "Podaj Kod pocztowy";
            ZipCode.Click += ZipCode_Click;
            // 
            // propertyNumber
            // 
            propertyNumber.AutoSize = true;
            propertyNumber.Location = new Point(479, 329);
            propertyNumber.Name = "propertyNumber";
            propertyNumber.Size = new Size(127, 17);
            propertyNumber.TabIndex = 6;
            propertyNumber.Text = "Podaj numer posesji";
            propertyNumber.Click += propertyNumber_Click;
            // 
            // street
            // 
            street.AutoSize = true;
            street.Location = new Point(278, 266);
            street.Name = "street";
            street.Size = new Size(71, 17);
            street.TabIndex = 7;
            street.Text = "Podaj ulicę";
            // 
            // apartmentNumber
            // 
            apartmentNumber.AutoSize = true;
            apartmentNumber.Location = new Point(278, 329);
            apartmentNumber.Name = "apartmentNumber";
            apartmentNumber.Size = new Size(120, 17);
            apartmentNumber.TabIndex = 8;
            apartmentNumber.Text = "Podaj numer lokalu";
            // 
            // PESEL
            // 
            PESEL.AutoSize = true;
            PESEL.Location = new Point(24, 266);
            PESEL.Name = "PESEL";
            PESEL.Size = new Size(79, 17);
            PESEL.TabIndex = 9;
            PESEL.Text = "Podaj PESEL";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(274, 22);
            email.Name = "email";
            email.Size = new Size(76, 17);
            email.TabIndex = 10;
            email.Text = "Podaj email";
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.Location = new Point(276, 83);
            tel.Name = "tel";
            tel.Size = new Size(133, 17);
            tel.TabIndex = 11;
            tel.Text = "Podaj numer telefonu";
            // 
            // dateOfbirth
            // 
            dateOfbirth.AutoSize = true;
            dateOfbirth.Location = new Point(24, 329);
            dateOfbirth.Name = "dateOfbirth";
            dateOfbirth.Size = new Size(133, 17);
            dateOfbirth.TabIndex = 12;
            dateOfbirth.Text = "Podaj datę urodzenia";
            // 
            // sex
            // 
            sex.AutoSize = true;
            sex.Location = new Point(24, 206);
            sex.Name = "sex";
            sex.Size = new Size(69, 17);
            sex.TabIndex = 13;
            sex.Text = "Podaj płeć";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(24, 42);
            txtLogin.MaxLength = 18;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(191, 25);
            txtLogin.TabIndex = 15;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(24, 103);
            txtImie.MaxLength = 20;
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(191, 25);
            txtImie.TabIndex = 16;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(24, 164);
            txtNazwisko.MaxLength = 60;
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(191, 25);
            txtNazwisko.TabIndex = 17;
            // 
            // txtMiejscowosc
            // 
            txtMiejscowosc.Location = new Point(278, 165);
            txtMiejscowosc.MaxLength = 25;
            txtMiejscowosc.Name = "txtMiejscowosc";
            txtMiejscowosc.Size = new Size(191, 25);
            txtMiejscowosc.TabIndex = 18;
            // 
            // txtKodPocztowy
            // 
            txtKodPocztowy.Location = new Point(278, 227);
            txtKodPocztowy.MaxLength = 6;
            txtKodPocztowy.Name = "txtKodPocztowy";
            txtKodPocztowy.Size = new Size(191, 25);
            txtKodPocztowy.TabIndex = 19;
            // 
            // txtNumerPosesji
            // 
            txtNumerPosesji.Location = new Point(479, 349);
            txtNumerPosesji.MaxLength = 10;
            txtNumerPosesji.Name = "txtNumerPosesji";
            txtNumerPosesji.Size = new Size(191, 25);
            txtNumerPosesji.TabIndex = 20;
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(278, 287);
            txtUlica.MaxLength = 40;
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(191, 25);
            txtUlica.TabIndex = 21;
            // 
            // txtNumerLokalu
            // 
            txtNumerLokalu.Location = new Point(278, 349);
            txtNumerLokalu.MaxLength = 10;
            txtNumerLokalu.Name = "txtNumerLokalu";
            txtNumerLokalu.Size = new Size(191, 25);
            txtNumerLokalu.TabIndex = 22;
            // 
            // txtPESEL
            // 
            txtPESEL.Location = new Point(24, 287);
            txtPESEL.MaxLength = 11;
            txtPESEL.Name = "txtPESEL";
            txtPESEL.Size = new Size(191, 25);
            txtPESEL.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(276, 42);
            txtEmail.MaxLength = 255;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 25);
            txtEmail.TabIndex = 24;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(278, 103);
            txtTelefon.MaxLength = 15;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(191, 25);
            txtTelefon.TabIndex = 25;
            // 
            // cmbPlec
            // 
            cmbPlec.FormattingEnabled = true;
            cmbPlec.Items.AddRange(new object[] { "mężczyzna", "kobieta" });
            cmbPlec.Location = new Point(24, 227);
            cmbPlec.Name = "cmbPlec";
            cmbPlec.Size = new Size(121, 25);
            cmbPlec.TabIndex = 26;
            cmbPlec.SelectedIndexChanged += cmbPlec_SelectedIndexChanged;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(586, 443);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(189, 53);
            ExitBtn.TabIndex = 29;
            ExitBtn.Text = "wyjdź";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(675, 305);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 25);
            txtAdres.TabIndex = 31;
            txtAdres.Visible = false;
            // 
            // txtstLog
            // 
            txtstLog.Location = new Point(675, 338);
            txtstLog.Name = "txtstLog";
            txtstLog.Size = new Size(100, 25);
            txtstLog.TabIndex = 32;
            txtstLog.Visible = false;
            // 
            // txtRodzaj
            // 
            txtRodzaj.Location = new Point(675, 371);
            txtRodzaj.Name = "txtRodzaj";
            txtRodzaj.Size = new Size(100, 25);
            txtRodzaj.TabIndex = 33;
            txtRodzaj.Visible = false;
            // 
            // txtKsiazka
            // 
            txtKsiazka.Location = new Point(675, 410);
            txtKsiazka.Name = "txtKsiazka";
            txtKsiazka.Size = new Size(100, 25);
            txtKsiazka.TabIndex = 34;
            txtKsiazka.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 479);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 36;
            label1.Text = "* pola wymagane";
            // 
            // DateTimePickers
            // 
            DateTimePickers.Location = new Point(24, 349);
            DateTimePickers.Name = "DateTimePickers";
            DateTimePickers.Size = new Size(200, 25);
            DateTimePickers.TabIndex = 37;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(DateTimePickers);
            Controls.Add(label1);
            Controls.Add(txtKsiazka);
            Controls.Add(txtRodzaj);
            Controls.Add(txtstLog);
            Controls.Add(txtAdres);
            Controls.Add(ExitBtn);
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
            Load += AddUser_Load;
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
        private Button ExitBtn;
        private TextBox txtAdres;
        private TextBox txtstLog;
        private TextBox txtRodzaj;
        private TextBox txtKsiazka;
        private Label label1;
        private DateTimePicker DateTimePickers;
    }
}