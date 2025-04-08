namespace Biblioteka
{
    partial class DataBase
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
            dataGridViewUser = new DataGridView();
            btnSearchUser = new Button();
            btnResetSearch = new Button();
            AddUser = new Button();
            btnShowNonActiveUsers = new Button();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            txtLogin = new TextBox();
            chkName = new CheckBox();
            chkSurname = new CheckBox();
            chkEmail = new CheckBox();
            chkLogin = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.BackgroundColor = SystemColors.Control;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(11, 152);
            dataGridViewUser.Margin = new Padding(2);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 62;
            dataGridViewUser.Size = new Size(917, 400);
            dataGridViewUser.TabIndex = 0;
            // 
            // btnSearchUser
            // 
            btnSearchUser.BackColor = Color.FromArgb(64, 64, 64);
            btnSearchUser.ForeColor = SystemColors.Control;
            btnSearchUser.Location = new Point(810, 7);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(118, 23);
            btnSearchUser.TabIndex = 3;
            btnSearchUser.Text = "Wyszukaj";
            btnSearchUser.UseVisualStyleBackColor = false;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // btnResetSearch
            // 
            btnResetSearch.BackColor = Color.FromArgb(64, 64, 64);
            btnResetSearch.ForeColor = SystemColors.Control;
            btnResetSearch.Location = new Point(810, 36);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Size = new Size(117, 23);
            btnResetSearch.TabIndex = 4;
            btnResetSearch.Text = "Reset";
            btnResetSearch.UseVisualStyleBackColor = false;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // AddUser
            // 
            AddUser.BackColor = Color.FromArgb(64, 64, 64);
            AddUser.ForeColor = SystemColors.Control;
            AddUser.Location = new Point(12, 54);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(204, 36);
            AddUser.TabIndex = 12;
            AddUser.Text = "Dodaj użytkownika";
            AddUser.UseVisualStyleBackColor = false;
            AddUser.Click += AddUser_Click;
            // 
            // btnShowNonActiveUsers
            // 
            btnShowNonActiveUsers.BackColor = Color.FromArgb(64, 64, 64);
            btnShowNonActiveUsers.ForeColor = SystemColors.Control;
            btnShowNonActiveUsers.Location = new Point(12, 96);
            btnShowNonActiveUsers.Name = "btnShowNonActiveUsers";
            btnShowNonActiveUsers.Size = new Size(204, 36);
            btnShowNonActiveUsers.TabIndex = 13;
            btnShowNonActiveUsers.Text = "Pokaż użytkowników nieaktywnych";
            btnShowNonActiveUsers.UseVisualStyleBackColor = false;
            btnShowNonActiveUsers.Click += btnShowNonActiveUsers_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(612, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 23);
            txtName.TabIndex = 14;
            txtName.Visible = false;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(612, 50);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(152, 23);
            txtSurname.TabIndex = 15;
            txtSurname.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(612, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 16;
            txtEmail.Visible = false;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(612, 108);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(152, 23);
            txtLogin.TabIndex = 17;
            txtLogin.Visible = false;
            // 
            // chkName
            // 
            chkName.AutoSize = true;
            chkName.Location = new Point(530, 25);
            chkName.Name = "chkName";
            chkName.Size = new Size(49, 19);
            chkName.TabIndex = 18;
            chkName.Text = "Imie";
            chkName.UseVisualStyleBackColor = true;
            chkName.CheckedChanged += chkName_CheckedChanged;
            // 
            // chkSurname
            // 
            chkSurname.AutoSize = true;
            chkSurname.Location = new Point(530, 54);
            chkSurname.Name = "chkSurname";
            chkSurname.Size = new Size(76, 19);
            chkSurname.TabIndex = 19;
            chkSurname.Text = "Nazwisko";
            chkSurname.UseVisualStyleBackColor = true;
            chkSurname.CheckedChanged += chkSurname_CheckedChanged;
            // 
            // chkEmail
            // 
            chkEmail.AutoSize = true;
            chkEmail.Location = new Point(530, 79);
            chkEmail.Name = "chkEmail";
            chkEmail.Size = new Size(55, 19);
            chkEmail.TabIndex = 20;
            chkEmail.Text = "Email";
            chkEmail.UseVisualStyleBackColor = true;
            chkEmail.CheckedChanged += chkEmail_CheckedChanged;
            // 
            // chkLogin
            // 
            chkLogin.AutoSize = true;
            chkLogin.Location = new Point(530, 110);
            chkLogin.Name = "chkLogin";
            chkLogin.Size = new Size(56, 19);
            chkLogin.TabIndex = 21;
            chkLogin.Text = "Login";
            chkLogin.UseVisualStyleBackColor = true;
            chkLogin.CheckedChanged += chkLogin_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 5);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 22;
            label1.Text = "Wybierz Kryterium Wyszukiwania";
            label1.Click += label1_Click;
            // 
            // DataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(942, 560);
            Controls.Add(label1);
            Controls.Add(chkLogin);
            Controls.Add(chkEmail);
            Controls.Add(chkSurname);
            Controls.Add(chkName);
            Controls.Add(txtLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(btnShowNonActiveUsers);
            Controls.Add(AddUser);
            Controls.Add(btnResetSearch);
            Controls.Add(btnSearchUser);
            Controls.Add(dataGridViewUser);
            Margin = new Padding(2);
            Name = "DataBase";
            Text = "DataBase";
            Load += DataBase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUser;
        private Button btnSearchUser;
        private Button btnResetSearch;
        private Button AddUser;
        private Button btnShowNonActiveUsers;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtLogin;
        private CheckBox chkName;
        private CheckBox chkSurname;
        private CheckBox chkEmail;
        private CheckBox chkLogin;
        private Label label1;
    }
}