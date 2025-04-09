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
            btnSaveEditUserData = new Button();
            btnEiditUserDataAbort = new Button();
            txtEditName = new TextBox();
            txtEditSurname = new TextBox();
            txtEditPesel = new TextBox();
            txtEditEmail = new TextBox();
            txtEditPhone = new TextBox();
            txtEditPlace = new TextBox();
            txtStreet = new TextBox();
            txtBldNumber = new TextBox();
            txtFlatNumber = new TextBox();
            txtPostalCode = new TextBox();
            cmbEditGender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dtpEditBirthDate = new DateTimePicker();
            btnForgetUser = new Button();
            SuspendLayout();
            // 
            // btnSaveEditUserData
            // 
            btnSaveEditUserData.Location = new Point(363, 416);
            btnSaveEditUserData.Name = "btnSaveEditUserData";
            btnSaveEditUserData.Size = new Size(193, 49);
            btnSaveEditUserData.TabIndex = 16;
            btnSaveEditUserData.Text = "Zapisz zmiany";
            btnSaveEditUserData.UseVisualStyleBackColor = true;
            btnSaveEditUserData.Click += btnSaveEditUserData_Click;
            // 
            // btnEiditUserDataAbort
            // 
            btnEiditUserDataAbort.Location = new Point(235, 416);
            btnEiditUserDataAbort.Name = "btnEiditUserDataAbort";
            btnEiditUserDataAbort.Size = new Size(122, 49);
            btnEiditUserDataAbort.TabIndex = 18;
            btnEiditUserDataAbort.Text = "Anuluj";
            btnEiditUserDataAbort.UseVisualStyleBackColor = true;
            btnEiditUserDataAbort.Click += button2_Click;
            // 
            // txtEditName
            // 
            txtEditName.Location = new Point(261, 25);
            txtEditName.MaxLength = 20;
            txtEditName.Name = "txtEditName";
            txtEditName.Size = new Size(295, 25);
            txtEditName.TabIndex = 19;
            // 
            // txtEditSurname
            // 
            txtEditSurname.Location = new Point(261, 56);
            txtEditSurname.MaxLength = 60;
            txtEditSurname.Name = "txtEditSurname";
            txtEditSurname.Size = new Size(295, 25);
            txtEditSurname.TabIndex = 20;
            // 
            // txtEditPesel
            // 
            txtEditPesel.Location = new Point(261, 87);
            txtEditPesel.MaxLength = 11;
            txtEditPesel.Name = "txtEditPesel";
            txtEditPesel.Size = new Size(295, 25);
            txtEditPesel.TabIndex = 21;
            // 
            // txtEditEmail
            // 
            txtEditEmail.Location = new Point(261, 149);
            txtEditEmail.MaxLength = 255;
            txtEditEmail.Name = "txtEditEmail";
            txtEditEmail.Size = new Size(295, 25);
            txtEditEmail.TabIndex = 23;
            // 
            // txtEditPhone
            // 
            txtEditPhone.Location = new Point(261, 216);
            txtEditPhone.MaxLength = 15;
            txtEditPhone.Name = "txtEditPhone";
            txtEditPhone.Size = new Size(295, 25);
            txtEditPhone.TabIndex = 24;
            // 
            // txtEditPlace
            // 
            txtEditPlace.Location = new Point(262, 247);
            txtEditPlace.MaxLength = 25;
            txtEditPlace.Name = "txtEditPlace";
            txtEditPlace.Size = new Size(295, 25);
            txtEditPlace.TabIndex = 25;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(262, 278);
            txtStreet.MaxLength = 40;
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(295, 25);
            txtStreet.TabIndex = 26;
            // 
            // txtBldNumber
            // 
            txtBldNumber.Location = new Point(262, 309);
            txtBldNumber.MaxLength = 10;
            txtBldNumber.Name = "txtBldNumber";
            txtBldNumber.Size = new Size(295, 25);
            txtBldNumber.TabIndex = 27;
            // 
            // txtFlatNumber
            // 
            txtFlatNumber.Location = new Point(262, 340);
            txtFlatNumber.MaxLength = 10;
            txtFlatNumber.Name = "txtFlatNumber";
            txtFlatNumber.Size = new Size(295, 25);
            txtFlatNumber.TabIndex = 28;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(261, 371);
            txtPostalCode.MaxLength = 6;
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(295, 25);
            txtPostalCode.TabIndex = 29;
            // 
            // cmbEditGender
            // 
            cmbEditGender.FormattingEnabled = true;
            cmbEditGender.Items.AddRange(new object[] { "Mężczyzna", "Kobieta" });
            cmbEditGender.Location = new Point(384, 180);
            cmbEditGender.Name = "cmbEditGender";
            cmbEditGender.Size = new Size(173, 25);
            cmbEditGender.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 28);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 31;
            label1.Text = "Imię:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 59);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 32;
            label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 90);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 33;
            label3.Text = "PESEL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 126);
            label4.Name = "label4";
            label4.Size = new Size(100, 17);
            label4.TabIndex = 34;
            label4.Text = "Data urodzenia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 152);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 35;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 188);
            label6.Name = "label6";
            label6.Size = new Size(34, 17);
            label6.TabIndex = 36;
            label6.Text = "Płeć:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 250);
            label7.Name = "label7";
            label7.Size = new Size(85, 17);
            label7.TabIndex = 37;
            label7.Text = "Miejscowość:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 281);
            label8.Name = "label8";
            label8.Size = new Size(39, 17);
            label8.TabIndex = 38;
            label8.Text = "Ulica:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(67, 312);
            label9.Name = "label9";
            label9.Size = new Size(96, 17);
            label9.TabIndex = 39;
            label9.Text = "Numer posesji:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(67, 343);
            label10.Name = "label10";
            label10.Size = new Size(89, 17);
            label10.TabIndex = 40;
            label10.Text = "Numer lokalu:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(66, 374);
            label11.Name = "label11";
            label11.Size = new Size(94, 17);
            label11.TabIndex = 41;
            label11.Text = "Kod pocztowy:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(66, 219);
            label12.Name = "label12";
            label12.Size = new Size(102, 17);
            label12.TabIndex = 42;
            label12.Text = "Numer telefonu:";
            // 
            // dtpEditBirthDate
            // 
            dtpEditBirthDate.CustomFormat = "dd-MM-rrrr";
            dtpEditBirthDate.Format = DateTimePickerFormat.Short;
            dtpEditBirthDate.Location = new Point(384, 120);
            dtpEditBirthDate.Name = "dtpEditBirthDate";
            dtpEditBirthDate.Size = new Size(172, 25);
            dtpEditBirthDate.TabIndex = 43;
            // 
            // btnForgetUser
            // 
            btnForgetUser.Location = new Point(60, 416);
            btnForgetUser.Name = "btnForgetUser";
            btnForgetUser.Size = new Size(96, 49);
            btnForgetUser.TabIndex = 44;
            btnForgetUser.Text = "Zapomnij użytkownika";
            btnForgetUser.UseVisualStyleBackColor = true;
            btnForgetUser.Click += btnForgetUser_Click;
            // 
            // EditUserDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 482);
            Controls.Add(btnForgetUser);
            Controls.Add(dtpEditBirthDate);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbEditGender);
            Controls.Add(txtPostalCode);
            Controls.Add(txtFlatNumber);
            Controls.Add(txtBldNumber);
            Controls.Add(txtStreet);
            Controls.Add(txtEditPlace);
            Controls.Add(txtEditPhone);
            Controls.Add(txtEditEmail);
            Controls.Add(txtEditPesel);
            Controls.Add(txtEditSurname);
            Controls.Add(txtEditName);
            Controls.Add(btnEiditUserDataAbort);
            Controls.Add(btnSaveEditUserData);
            Name = "EditUserDataForm";
            Text = "EditUserDataForm";
            Load += EditUserDataForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveEditUserData;
        private Button btnEiditUserDataAbort;
        private TextBox txtEditName;
        private TextBox txtEditSurname;
        private TextBox txtEditPesel;
        private TextBox txtEditEmail;
        private TextBox txtEditPhone;
        private TextBox txtEditPlace;
        private TextBox txtStreet;
        private TextBox txtBldNumber;
        private TextBox txtFlatNumber;
        private TextBox txtPostalCode;
        private ComboBox cmbEditGender;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DateTimePicker dtpEditBirthDate;
        private Button btnForgetUser;
    }
}