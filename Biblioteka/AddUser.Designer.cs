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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
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
            AddBtn.BackColor = Color.FromArgb(64, 64, 64);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(467, 521);
            AddBtn.Margin = new Padding(4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(244, 63);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Dodaj nowego użytkownika";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.BackColor = Color.FromArgb(252, 240, 224);
            Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Login.Location = new Point(31, 25);
            Login.Margin = new Padding(4, 0, 4, 0);
            Login.Name = "Login";
            Login.Size = new Size(105, 21);
            Login.TabIndex = 1;
            Login.Text = "Podaj login*";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.FromArgb(252, 240, 224);
            NameLabel.Location = new Point(31, 97);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(89, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Podaj imię*";
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.BackColor = Color.FromArgb(252, 240, 224);
            Surname.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Surname.Location = new Point(31, 171);
            Surname.Margin = new Padding(4, 0, 4, 0);
            Surname.Name = "Surname";
            Surname.Size = new Size(123, 20);
            Surname.TabIndex = 3;
            Surname.Text = "Podaj nazwisko*";
            // 
            // town
            // 
            town.AutoSize = true;
            town.BackColor = Color.FromArgb(252, 240, 224);
            town.Location = new Point(357, 171);
            town.Margin = new Padding(4, 0, 4, 0);
            town.Name = "town";
            town.Size = new Size(147, 20);
            town.TabIndex = 4;
            town.Text = "Podaj miejscowość*";
            town.Click += town_Click;
            // 
            // ZipCode
            // 
            ZipCode.AutoSize = true;
            ZipCode.BackColor = Color.FromArgb(252, 240, 224);
            ZipCode.Location = new Point(357, 243);
            ZipCode.Margin = new Padding(4, 0, 4, 0);
            ZipCode.Name = "ZipCode";
            ZipCode.Size = new Size(158, 20);
            ZipCode.TabIndex = 5;
            ZipCode.Text = "Podaj Kod pocztowy*";
            ZipCode.Click += ZipCode_Click;
            // 
            // propertyNumber
            // 
            propertyNumber.AutoSize = true;
            propertyNumber.BackColor = Color.FromArgb(252, 240, 224);
            propertyNumber.Location = new Point(616, 387);
            propertyNumber.Margin = new Padding(4, 0, 4, 0);
            propertyNumber.Name = "propertyNumber";
            propertyNumber.Size = new Size(157, 20);
            propertyNumber.TabIndex = 6;
            propertyNumber.Text = "Podaj numer posesji*";
            propertyNumber.Click += propertyNumber_Click;
            // 
            // street
            // 
            street.AutoSize = true;
            street.BackColor = Color.FromArgb(252, 240, 224);
            street.Location = new Point(357, 313);
            street.Margin = new Padding(4, 0, 4, 0);
            street.Name = "street";
            street.Size = new Size(91, 20);
            street.TabIndex = 7;
            street.Text = "Podaj ulicę*";
            // 
            // apartmentNumber
            // 
            apartmentNumber.AutoSize = true;
            apartmentNumber.BackColor = Color.FromArgb(252, 240, 224);
            apartmentNumber.Location = new Point(357, 387);
            apartmentNumber.Margin = new Padding(4, 0, 4, 0);
            apartmentNumber.Name = "apartmentNumber";
            apartmentNumber.Size = new Size(151, 20);
            apartmentNumber.TabIndex = 8;
            apartmentNumber.Text = "Podaj numer lokalu*";
            // 
            // PESEL
            // 
            PESEL.AutoSize = true;
            PESEL.BackColor = Color.FromArgb(252, 240, 224);
            PESEL.Location = new Point(31, 313);
            PESEL.Margin = new Padding(4, 0, 4, 0);
            PESEL.Name = "PESEL";
            PESEL.Size = new Size(98, 20);
            PESEL.TabIndex = 9;
            PESEL.Text = "Podaj PESEL*";
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.FromArgb(252, 240, 224);
            email.Location = new Point(352, 25);
            email.Margin = new Padding(4, 0, 4, 0);
            email.Name = "email";
            email.Size = new Size(97, 20);
            email.TabIndex = 10;
            email.Text = "Podaj email*";
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.BackColor = Color.FromArgb(252, 240, 224);
            tel.Location = new Point(355, 97);
            tel.Margin = new Padding(4, 0, 4, 0);
            tel.Name = "tel";
            tel.Size = new Size(168, 20);
            tel.TabIndex = 11;
            tel.Text = "Podaj numer telefonu*";
            // 
            // dateOfbirth
            // 
            dateOfbirth.AutoSize = true;
            dateOfbirth.BackColor = Color.FromArgb(252, 240, 224);
            dateOfbirth.Location = new Point(31, 387);
            dateOfbirth.Margin = new Padding(4, 0, 4, 0);
            dateOfbirth.Name = "dateOfbirth";
            dateOfbirth.Size = new Size(163, 20);
            dateOfbirth.TabIndex = 12;
            dateOfbirth.Text = "Podaj datę urodzenia*";
            // 
            // sex
            // 
            sex.AutoSize = true;
            sex.BackColor = Color.FromArgb(252, 240, 224);
            sex.Location = new Point(31, 243);
            sex.Margin = new Padding(4, 0, 4, 0);
            sex.Name = "sex";
            sex.Size = new Size(88, 20);
            sex.TabIndex = 13;
            sex.Text = "Podaj płeć*";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(31, 57);
            txtLogin.Margin = new Padding(4);
            txtLogin.MaxLength = 18;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(244, 27);
            txtLogin.TabIndex = 15;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(31, 121);
            txtImie.Margin = new Padding(4);
            txtImie.MaxLength = 20;
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(244, 27);
            txtImie.TabIndex = 16;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(31, 193);
            txtNazwisko.Margin = new Padding(4);
            txtNazwisko.MaxLength = 60;
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(244, 27);
            txtNazwisko.TabIndex = 17;
            // 
            // txtMiejscowosc
            // 
            txtMiejscowosc.Location = new Point(357, 195);
            txtMiejscowosc.Margin = new Padding(4);
            txtMiejscowosc.MaxLength = 25;
            txtMiejscowosc.Name = "txtMiejscowosc";
            txtMiejscowosc.Size = new Size(244, 27);
            txtMiejscowosc.TabIndex = 18;
            // 
            // txtKodPocztowy
            // 
            txtKodPocztowy.Location = new Point(357, 267);
            txtKodPocztowy.Margin = new Padding(4);
            txtKodPocztowy.MaxLength = 6;
            txtKodPocztowy.Name = "txtKodPocztowy";
            txtKodPocztowy.Size = new Size(244, 27);
            txtKodPocztowy.TabIndex = 19;
            // 
            // txtNumerPosesji
            // 
            txtNumerPosesji.Location = new Point(616, 411);
            txtNumerPosesji.Margin = new Padding(4);
            txtNumerPosesji.MaxLength = 10;
            txtNumerPosesji.Name = "txtNumerPosesji";
            txtNumerPosesji.Size = new Size(244, 27);
            txtNumerPosesji.TabIndex = 20;
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(357, 337);
            txtUlica.Margin = new Padding(4);
            txtUlica.MaxLength = 40;
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(244, 27);
            txtUlica.TabIndex = 21;
            // 
            // txtNumerLokalu
            // 
            txtNumerLokalu.Location = new Point(357, 411);
            txtNumerLokalu.Margin = new Padding(4);
            txtNumerLokalu.MaxLength = 10;
            txtNumerLokalu.Name = "txtNumerLokalu";
            txtNumerLokalu.Size = new Size(244, 27);
            txtNumerLokalu.TabIndex = 22;
            // 
            // txtPESEL
            // 
            txtPESEL.Location = new Point(31, 337);
            txtPESEL.Margin = new Padding(4);
            txtPESEL.MaxLength = 11;
            txtPESEL.Name = "txtPESEL";
            txtPESEL.Size = new Size(244, 27);
            txtPESEL.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(355, 49);
            txtEmail.Margin = new Padding(4);
            txtEmail.MaxLength = 255;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 27);
            txtEmail.TabIndex = 24;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(357, 121);
            txtTelefon.Margin = new Padding(4);
            txtTelefon.MaxLength = 9;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(244, 27);
            txtTelefon.TabIndex = 25;
            // 
            // cmbPlec
            // 
            cmbPlec.FormattingEnabled = true;
            cmbPlec.Items.AddRange(new object[] { "mężczyzna", "kobieta" });
            cmbPlec.Location = new Point(31, 267);
            cmbPlec.Margin = new Padding(4);
            cmbPlec.Name = "cmbPlec";
            cmbPlec.Size = new Size(154, 28);
            cmbPlec.TabIndex = 26;
            cmbPlec.SelectedIndexChanged += cmbPlec_SelectedIndexChanged;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.FromArgb(64, 64, 64);
            ExitBtn.ForeColor = SystemColors.Control;
            ExitBtn.Location = new Point(753, 521);
            ExitBtn.Margin = new Padding(4);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(243, 63);
            ExitBtn.TabIndex = 29;
            ExitBtn.Text = "wyjdź";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(868, 16);
            txtAdres.Margin = new Padding(4);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(127, 27);
            txtAdres.TabIndex = 31;
            txtAdres.Visible = false;
            // 
            // txtstLog
            // 
            txtstLog.Location = new Point(868, 67);
            txtstLog.Margin = new Padding(4);
            txtstLog.Name = "txtstLog";
            txtstLog.Size = new Size(127, 27);
            txtstLog.TabIndex = 32;
            txtstLog.Visible = false;
            // 
            // txtRodzaj
            // 
            txtRodzaj.Location = new Point(868, 121);
            txtRodzaj.Margin = new Padding(4);
            txtRodzaj.Name = "txtRodzaj";
            txtRodzaj.Size = new Size(127, 27);
            txtRodzaj.TabIndex = 33;
            txtRodzaj.Visible = false;
            // 
            // txtKsiazka
            // 
            txtKsiazka.Location = new Point(868, 171);
            txtKsiazka.Margin = new Padding(4);
            txtKsiazka.Name = "txtKsiazka";
            txtKsiazka.Size = new Size(127, 27);
            txtKsiazka.TabIndex = 34;
            txtKsiazka.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(252, 240, 224);
            label1.Location = new Point(15, 564);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 36;
            label1.Text = "* pola wymagane";
            // 
            // DateTimePickers
            // 
            DateTimePickers.Location = new Point(31, 411);
            DateTimePickers.Margin = new Padding(4);
            DateTimePickers.Name = "DateTimePickers";
            DateTimePickers.Size = new Size(270, 27);
            DateTimePickers.TabIndex = 37;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1029, 600);
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
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Margin = new Padding(4);
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