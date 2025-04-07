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
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(11, 169);
            dataGridViewUser.Margin = new Padding(2);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 62;
            dataGridViewUser.Size = new Size(917, 457);
            dataGridViewUser.TabIndex = 0;
            // 
            // btnSearchUser
            // 
            btnSearchUser.Location = new Point(728, 14);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(118, 26);
            btnSearchUser.TabIndex = 3;
            btnSearchUser.Text = "Wyszukaj";
            btnSearchUser.UseVisualStyleBackColor = true;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // btnResetSearch
            // 
            btnResetSearch.Location = new Point(729, 46);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Size = new Size(117, 26);
            btnResetSearch.TabIndex = 4;
            btnResetSearch.Text = "Reset";
            btnResetSearch.UseVisualStyleBackColor = true;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // AddUser
            // 
            AddUser.Location = new Point(11, 68);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(150, 26);
            AddUser.TabIndex = 12;
            AddUser.Text = "Dodaj użytkownika";
            AddUser.UseVisualStyleBackColor = true;
            AddUser.Click += AddUser_Click;
            // 
            // btnShowNonActiveUsers
            // 
            btnShowNonActiveUsers.Location = new Point(12, 124);
            btnShowNonActiveUsers.Name = "btnShowNonActiveUsers";
            btnShowNonActiveUsers.Size = new Size(204, 26);
            btnShowNonActiveUsers.TabIndex = 13;
            btnShowNonActiveUsers.Text = "Pokaż użytkowników nieaktywnych";
            btnShowNonActiveUsers.UseVisualStyleBackColor = true;
            btnShowNonActiveUsers.Click += btnShowNonActiveUsers_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(501, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 25);
            txtName.TabIndex = 14;
            txtName.Visible = false;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(501, 59);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(152, 25);
            txtSurname.TabIndex = 15;
            txtSurname.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(501, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 25);
            txtEmail.TabIndex = 16;
            txtEmail.Visible = false;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(501, 125);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(152, 25);
            txtLogin.TabIndex = 17;
            txtLogin.Visible = false;
            // 
            // chkName
            // 
            chkName.AutoSize = true;
            chkName.Location = new Point(412, 31);
            chkName.Name = "chkName";
            chkName.Size = new Size(51, 21);
            chkName.TabIndex = 18;
            chkName.Text = "Imie";
            chkName.UseVisualStyleBackColor = true;
            chkName.CheckedChanged += chkName_CheckedChanged;
            // 
            // chkSurname
            // 
            chkSurname.AutoSize = true;
            chkSurname.Location = new Point(412, 61);
            chkSurname.Name = "chkSurname";
            chkSurname.Size = new Size(82, 21);
            chkSurname.TabIndex = 19;
            chkSurname.Text = "Nazwisko";
            chkSurname.UseVisualStyleBackColor = true;
            chkSurname.CheckedChanged += chkSurname_CheckedChanged;
            // 
            // chkEmail
            // 
            chkEmail.AutoSize = true;
            chkEmail.Location = new Point(412, 94);
            chkEmail.Name = "chkEmail";
            chkEmail.Size = new Size(58, 21);
            chkEmail.TabIndex = 20;
            chkEmail.Text = "Email";
            chkEmail.UseVisualStyleBackColor = true;
            chkEmail.CheckedChanged += chkEmail_CheckedChanged;
            // 
            // chkLogin
            // 
            chkLogin.AutoSize = true;
            chkLogin.Location = new Point(412, 127);
            chkLogin.Name = "chkLogin";
            chkLogin.Size = new Size(59, 21);
            chkLogin.TabIndex = 21;
            chkLogin.Text = "Login";
            chkLogin.UseVisualStyleBackColor = true;
            chkLogin.CheckedChanged += chkLogin_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 8);
            label1.Name = "label1";
            label1.Size = new Size(198, 17);
            label1.TabIndex = 22;
            label1.Text = "Wybierz Kryterium Wyszukiwania";
            // 
            // DataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 635);
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