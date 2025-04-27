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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBase));
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
            btnPrivilagesShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewUser.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewUser.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUser.EnableHeadersVisualStyles = false;
            dataGridViewUser.GridColor = Color.FromArgb(255, 224, 192);
            dataGridViewUser.Location = new Point(42, 183);
            dataGridViewUser.Margin = new Padding(2, 3, 2, 3);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewUser.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewUser.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewUser.Size = new Size(1114, 533);
            dataGridViewUser.TabIndex = 0;
            // 
            // btnSearchUser
            // 
            btnSearchUser.BackColor = Color.FromArgb(64, 64, 64);
            btnSearchUser.ForeColor = SystemColors.Control;
            btnSearchUser.Location = new Point(75, 53);
            btnSearchUser.Margin = new Padding(3, 4, 3, 4);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(152, 31);
            btnSearchUser.TabIndex = 3;
            btnSearchUser.Text = "Wyszukaj";
            btnSearchUser.UseVisualStyleBackColor = false;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // btnResetSearch
            // 
            btnResetSearch.BackColor = Color.FromArgb(64, 64, 64);
            btnResetSearch.ForeColor = SystemColors.Control;
            btnResetSearch.Location = new Point(78, 95);
            btnResetSearch.Margin = new Padding(3, 4, 3, 4);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Size = new Size(151, 31);
            btnResetSearch.TabIndex = 4;
            btnResetSearch.Text = "Reset";
            btnResetSearch.UseVisualStyleBackColor = false;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // AddUser
            // 
            AddUser.BackColor = Color.FromArgb(64, 64, 64);
            AddUser.ForeColor = SystemColors.Control;
            AddUser.Location = new Point(946, 24);
            AddUser.Margin = new Padding(3, 4, 3, 4);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(262, 48);
            AddUser.TabIndex = 12;
            AddUser.Text = "Dodaj użytkownika";
            AddUser.UseVisualStyleBackColor = false;
            AddUser.Click += AddUser_Click;
            // 
            // btnShowNonActiveUsers
            // 
            btnShowNonActiveUsers.BackColor = Color.FromArgb(64, 64, 64);
            btnShowNonActiveUsers.ForeColor = SystemColors.Control;
            btnShowNonActiveUsers.Location = new Point(946, 80);
            btnShowNonActiveUsers.Margin = new Padding(3, 4, 3, 4);
            btnShowNonActiveUsers.Name = "btnShowNonActiveUsers";
            btnShowNonActiveUsers.Size = new Size(262, 48);
            btnShowNonActiveUsers.TabIndex = 13;
            btnShowNonActiveUsers.Text = "Pokaż użytkowników nieaktywnych";
            btnShowNonActiveUsers.UseVisualStyleBackColor = false;
            btnShowNonActiveUsers.Click += btnShowNonActiveUsers_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(387, 36);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 14;
            txtName.Visible = false;
            // 
            // txtSurname
            // 
            txtSurname.BackColor = Color.White;
            txtSurname.Location = new Point(387, 72);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(229, 27);
            txtSurname.TabIndex = 15;
            txtSurname.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(387, 111);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 16;
            txtEmail.Visible = false;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.White;
            txtLogin.Location = new Point(387, 149);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(229, 27);
            txtLogin.TabIndex = 17;
            txtLogin.Visible = false;
            // 
            // chkName
            // 
            chkName.AutoSize = true;
            chkName.BackColor = Color.Transparent;
            chkName.Location = new Point(281, 39);
            chkName.Margin = new Padding(3, 4, 3, 4);
            chkName.Name = "chkName";
            chkName.Size = new Size(59, 24);
            chkName.TabIndex = 18;
            chkName.Text = "Imie";
            chkName.UseVisualStyleBackColor = false;
            chkName.CheckedChanged += chkName_CheckedChanged;
            // 
            // chkSurname
            // 
            chkSurname.AutoSize = true;
            chkSurname.BackColor = Color.Transparent;
            chkSurname.Location = new Point(281, 77);
            chkSurname.Margin = new Padding(3, 4, 3, 4);
            chkSurname.Name = "chkSurname";
            chkSurname.Size = new Size(95, 24);
            chkSurname.TabIndex = 19;
            chkSurname.Text = "Nazwisko";
            chkSurname.UseVisualStyleBackColor = false;
            chkSurname.CheckedChanged += chkSurname_CheckedChanged;
            // 
            // chkEmail
            // 
            chkEmail.AutoSize = true;
            chkEmail.BackColor = Color.Transparent;
            chkEmail.Location = new Point(281, 111);
            chkEmail.Margin = new Padding(3, 4, 3, 4);
            chkEmail.Name = "chkEmail";
            chkEmail.Size = new Size(66, 24);
            chkEmail.TabIndex = 20;
            chkEmail.Text = "Email";
            chkEmail.UseVisualStyleBackColor = false;
            chkEmail.CheckedChanged += chkEmail_CheckedChanged;
            // 
            // chkLogin
            // 
            chkLogin.AutoSize = true;
            chkLogin.BackColor = Color.Transparent;
            chkLogin.Location = new Point(281, 152);
            chkLogin.Margin = new Padding(3, 4, 3, 4);
            chkLogin.Name = "chkLogin";
            chkLogin.Size = new Size(67, 24);
            chkLogin.TabIndex = 21;
            chkLogin.Text = "Login";
            chkLogin.UseVisualStyleBackColor = false;
            chkLogin.CheckedChanged += chkLogin_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(281, 12);
            label1.Name = "label1";
            label1.Size = new Size(245, 20);
            label1.TabIndex = 22;
            label1.Text = "Wybierz Kryterium Wyszukiwania";
            label1.Click += label1_Click;
            // 
            // btnPrivilagesShow
            // 
            btnPrivilagesShow.Location = new Point(947, 138);
            btnPrivilagesShow.Name = "btnPrivilagesShow";
            btnPrivilagesShow.Size = new Size(261, 38);
            btnPrivilagesShow.TabIndex = 23;
            btnPrivilagesShow.Text = "Pokaż Liste Uprawnień";
            btnPrivilagesShow.UseVisualStyleBackColor = true;
            btnPrivilagesShow.Click += btnPrivilagesShow_Click;
            // 
            // DataBase
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1254, 747);
            Controls.Add(btnPrivilagesShow);
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
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Margin = new Padding(2, 3, 2, 3);
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
        private Button btnPrivilagesShow;
    }
}