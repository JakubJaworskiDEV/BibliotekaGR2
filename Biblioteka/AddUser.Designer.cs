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
            AddBtn.Location = new Point(363, 391);
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
            Login.Location = new Point(24, 19);
            Login.Name = "Login";
            Login.Size = new Size(70, 15);
            Login.TabIndex = 1;
            Login.Text = "Podaj login ";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(24, 73);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(66, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Podaj imię ";
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Location = new Point(24, 128);
            Surname.Name = "Surname";
            Surname.Size = new Size(91, 15);
            Surname.TabIndex = 3;
            Surname.Text = "Podaj nazwisko ";
            // 
            // town
            // 
            town.AutoSize = true;
            town.Location = new Point(278, 128);
            town.Name = "town";
            town.Size = new Size(108, 15);
            town.TabIndex = 4;
            town.Text = "Podaj miejscowość";
            town.Click += town_Click;
            // 
            // ZipCode
            // 
            ZipCode.AutoSize = true;
            ZipCode.Location = new Point(278, 182);
            ZipCode.Name = "ZipCode";
            ZipCode.Size = new Size(115, 15);
            ZipCode.TabIndex = 5;
            ZipCode.Text = "Podaj Kod pocztowy";
            ZipCode.Click += ZipCode_Click;
            // 
            // propertyNumber
            // 
            propertyNumber.AutoSize = true;
            propertyNumber.Location = new Point(479, 290);
            propertyNumber.Name = "propertyNumber";
            propertyNumber.Size = new Size(114, 15);
            propertyNumber.TabIndex = 6;
            propertyNumber.Text = "Podaj numer posesji";
            propertyNumber.Click += propertyNumber_Click;
            // 
            // street
            // 
            street.AutoSize = true;
            street.Location = new Point(278, 235);
            street.Name = "street";
            street.Size = new Size(65, 15);
            street.TabIndex = 7;
            street.Text = "Podaj ulicę";
            // 
            // apartmentNumber
            // 
            apartmentNumber.AutoSize = true;
            apartmentNumber.Location = new Point(278, 290);
            apartmentNumber.Name = "apartmentNumber";
            apartmentNumber.Size = new Size(110, 15);
            apartmentNumber.TabIndex = 8;
            apartmentNumber.Text = "Podaj numer lokalu";
            // 
            // PESEL
            // 
            PESEL.AutoSize = true;
            PESEL.Location = new Point(24, 235);
            PESEL.Name = "PESEL";
            PESEL.Size = new Size(71, 15);
            PESEL.TabIndex = 9;
            PESEL.Text = "Podaj PESEL";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(274, 19);
            email.Name = "email";
            email.Size = new Size(69, 15);
            email.TabIndex = 10;
            email.Text = "Podaj email";
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.Location = new Point(276, 73);
            tel.Name = "tel";
            tel.Size = new Size(122, 15);
            tel.TabIndex = 11;
            tel.Text = "Podaj numer telefonu";
            // 
            // dateOfbirth
            // 
            dateOfbirth.AutoSize = true;
            dateOfbirth.Location = new Point(24, 290);
            dateOfbirth.Name = "dateOfbirth";
            dateOfbirth.Size = new Size(118, 15);
            dateOfbirth.TabIndex = 12;
            dateOfbirth.Text = "Podaj datę urodzenia";
            // 
            // sex
            // 
            sex.AutoSize = true;
            sex.Location = new Point(24, 182);
            sex.Name = "sex";
            sex.Size = new Size(62, 15);
            sex.TabIndex = 13;
            sex.Text = "Podaj płeć";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(24, 37);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(191, 23);
            txtLogin.TabIndex = 15;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(24, 91);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(191, 23);
            txtImie.TabIndex = 16;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(24, 145);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(191, 23);
            txtNazwisko.TabIndex = 17;
            // 
            // txtMiejscowosc
            // 
            txtMiejscowosc.Location = new Point(278, 146);
            txtMiejscowosc.Name = "txtMiejscowosc";
            txtMiejscowosc.Size = new Size(191, 23);
            txtMiejscowosc.TabIndex = 18;
            // 
            // txtKodPocztowy
            // 
            txtKodPocztowy.Location = new Point(278, 200);
            txtKodPocztowy.Name = "txtKodPocztowy";
            txtKodPocztowy.Size = new Size(191, 23);
            txtKodPocztowy.TabIndex = 19;
            // 
            // txtNumerPosesji
            // 
            txtNumerPosesji.Location = new Point(479, 308);
            txtNumerPosesji.Name = "txtNumerPosesji";
            txtNumerPosesji.Size = new Size(191, 23);
            txtNumerPosesji.TabIndex = 20;
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(278, 253);
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(191, 23);
            txtUlica.TabIndex = 21;
            // 
            // txtNumerLokalu
            // 
            txtNumerLokalu.Location = new Point(278, 308);
            txtNumerLokalu.Name = "txtNumerLokalu";
            txtNumerLokalu.Size = new Size(191, 23);
            txtNumerLokalu.TabIndex = 22;
            // 
            // txtPESEL
            // 
            txtPESEL.Location = new Point(24, 253);
            txtPESEL.Name = "txtPESEL";
            txtPESEL.Size = new Size(191, 23);
            txtPESEL.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(276, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 24;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(278, 91);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(191, 23);
            txtTelefon.TabIndex = 25;
            // 
            // cmbPlec
            // 
            cmbPlec.FormattingEnabled = true;
            cmbPlec.Items.AddRange(new object[] { "mężczyzna", "kobieta" });
            cmbPlec.Location = new Point(24, 200);
            cmbPlec.Name = "cmbPlec";
            cmbPlec.Size = new Size(121, 23);
            cmbPlec.TabIndex = 26;
            cmbPlec.SelectedIndexChanged += cmbPlec_SelectedIndexChanged;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(586, 391);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(189, 47);
            ExitBtn.TabIndex = 29;
            ExitBtn.Text = "wyjdź";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(675, 269);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 23);
            txtAdres.TabIndex = 31;
            txtAdres.Visible = false;
            // 
            // txtstLog
            // 
            txtstLog.Location = new Point(675, 298);
            txtstLog.Name = "txtstLog";
            txtstLog.Size = new Size(100, 23);
            txtstLog.TabIndex = 32;
            txtstLog.Visible = false;
            // 
            // txtRodzaj
            // 
            txtRodzaj.Location = new Point(675, 327);
            txtRodzaj.Name = "txtRodzaj";
            txtRodzaj.Size = new Size(100, 23);
            txtRodzaj.TabIndex = 33;
            txtRodzaj.Visible = false;
            // 
            // txtKsiazka
            // 
            txtKsiazka.Location = new Point(675, 362);
            txtKsiazka.Name = "txtKsiazka";
            txtKsiazka.Size = new Size(100, 23);
            txtKsiazka.TabIndex = 34;
            txtKsiazka.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 423);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 36;
            label1.Text = "* pola wymagane";
            // 
            // DateTimePickers
            // 
            DateTimePickers.Location = new Point(24, 308);
            DateTimePickers.Name = "DateTimePickers";
            DateTimePickers.Size = new Size(200, 23);
            DateTimePickers.TabIndex = 37;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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