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
            cmbSearchCriteria1 = new ComboBox();
            txtSearch1 = new TextBox();
            btnSearchUser = new Button();
            btnResetSearch = new Button();
            txtSurnameProfile = new TextBox();
            txtLoginProfile = new TextBox();
            txtPeselProfile = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnShowProfile = new Button();
            AddUser = new Button();
            btnShowNonActiveUsers = new Button();
            cmbSearchCriteria2 = new ComboBox();
            cmbSearchCriteria3 = new ComboBox();
            cmbSearchCriteria4 = new ComboBox();
            txtSearch2 = new TextBox();
            txtSearch3 = new TextBox();
            txtSearch4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(11, 149);
            dataGridViewUser.Margin = new Padding(2);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 62;
            dataGridViewUser.Size = new Size(917, 403);
            dataGridViewUser.TabIndex = 0;
            // 
            // cmbSearchCriteria1
            // 
            cmbSearchCriteria1.FormattingEnabled = true;
            cmbSearchCriteria1.Items.AddRange(new object[] { "Imie", "Nazwisko", "PESEL", "Login" });
            cmbSearchCriteria1.Location = new Point(337, 12);
            cmbSearchCriteria1.Name = "cmbSearchCriteria1";
            cmbSearchCriteria1.Size = new Size(138, 23);
            cmbSearchCriteria1.TabIndex = 1;
            // 
            // txtSearch1
            // 
            txtSearch1.Location = new Point(495, 12);
            txtSearch1.Name = "txtSearch1";
            txtSearch1.Size = new Size(207, 23);
            txtSearch1.TabIndex = 2;
            // 
            // btnSearchUser
            // 
            btnSearchUser.Location = new Point(728, 12);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(118, 23);
            btnSearchUser.TabIndex = 3;
            btnSearchUser.Text = "Wyszukaj";
            btnSearchUser.UseVisualStyleBackColor = true;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // btnResetSearch
            // 
            btnResetSearch.Location = new Point(729, 41);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Size = new Size(117, 23);
            btnResetSearch.TabIndex = 4;
            btnResetSearch.Text = "Reset";
            btnResetSearch.UseVisualStyleBackColor = true;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // txtSurnameProfile
            // 
            txtSurnameProfile.Location = new Point(22, 633);
            txtSurnameProfile.Name = "txtSurnameProfile";
            txtSurnameProfile.Size = new Size(187, 23);
            txtSurnameProfile.TabIndex = 5;
            // 
            // txtLoginProfile
            // 
            txtLoginProfile.Location = new Point(471, 633);
            txtLoginProfile.Name = "txtLoginProfile";
            txtLoginProfile.Size = new Size(188, 23);
            txtLoginProfile.TabIndex = 6;
            // 
            // txtPeselProfile
            // 
            txtPeselProfile.Location = new Point(252, 633);
            txtPeselProfile.Name = "txtPeselProfile";
            txtPeselProfile.Size = new Size(185, 23);
            txtPeselProfile.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 605);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 8;
            label1.Text = "Nazwisko";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 605);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "PESEL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(542, 605);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 10;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // btnShowProfile
            // 
            btnShowProfile.Location = new Point(689, 593);
            btnShowProfile.Name = "btnShowProfile";
            btnShowProfile.Size = new Size(157, 63);
            btnShowProfile.TabIndex = 11;
            btnShowProfile.Text = "Wyświetl dane użytkownika";
            btnShowProfile.UseVisualStyleBackColor = true;
            btnShowProfile.Click += btnShowProfile_Click;
            // 
            // AddUser
            // 
            AddUser.Location = new Point(11, 60);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(150, 23);
            AddUser.TabIndex = 12;
            AddUser.Text = "Dodaj użytkownika";
            AddUser.UseVisualStyleBackColor = true;
            AddUser.Click += AddUser_Click;
            // 
            // btnShowNonActiveUsers
            // 
            btnShowNonActiveUsers.Location = new Point(12, 109);
            btnShowNonActiveUsers.Name = "btnShowNonActiveUsers";
            btnShowNonActiveUsers.Size = new Size(204, 23);
            btnShowNonActiveUsers.TabIndex = 13;
            btnShowNonActiveUsers.Text = "Pokaż użytkowników nieaktywnych";
            btnShowNonActiveUsers.UseVisualStyleBackColor = true;
            btnShowNonActiveUsers.Click += btnShowNonActiveUsers_Click;
            // 
            // cmbSearchCriteria2
            // 
            cmbSearchCriteria2.FormattingEnabled = true;
            cmbSearchCriteria2.Items.AddRange(new object[] { "Imie", "Nazwisko", "PESEL", "Login" });
            cmbSearchCriteria2.Location = new Point(337, 42);
            cmbSearchCriteria2.Name = "cmbSearchCriteria2";
            cmbSearchCriteria2.Size = new Size(138, 23);
            cmbSearchCriteria2.TabIndex = 14;
            // 
            // cmbSearchCriteria3
            // 
            cmbSearchCriteria3.FormattingEnabled = true;
            cmbSearchCriteria3.Items.AddRange(new object[] { "Imie", "Nazwisko", "PESEL", "Login" });
            cmbSearchCriteria3.Location = new Point(337, 71);
            cmbSearchCriteria3.Name = "cmbSearchCriteria3";
            cmbSearchCriteria3.Size = new Size(138, 23);
            cmbSearchCriteria3.TabIndex = 15;
            // 
            // cmbSearchCriteria4
            // 
            cmbSearchCriteria4.FormattingEnabled = true;
            cmbSearchCriteria4.Items.AddRange(new object[] { "Imie", "Nazwisko", "PESEL", "Login" });
            cmbSearchCriteria4.Location = new Point(337, 100);
            cmbSearchCriteria4.Name = "cmbSearchCriteria4";
            cmbSearchCriteria4.Size = new Size(138, 23);
            cmbSearchCriteria4.TabIndex = 16;
            // 
            // txtSearch2
            // 
            txtSearch2.Location = new Point(495, 42);
            txtSearch2.Name = "txtSearch2";
            txtSearch2.Size = new Size(207, 23);
            txtSearch2.TabIndex = 17;
            // 
            // txtSearch3
            // 
            txtSearch3.Location = new Point(495, 71);
            txtSearch3.Name = "txtSearch3";
            txtSearch3.Size = new Size(207, 23);
            txtSearch3.TabIndex = 18;
            // 
            // txtSearch4
            // 
            txtSearch4.Location = new Point(495, 100);
            txtSearch4.Name = "txtSearch4";
            txtSearch4.Size = new Size(207, 23);
            txtSearch4.TabIndex = 19;
            // 
            // DataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 668);
            Controls.Add(txtSearch4);
            Controls.Add(txtSearch3);
            Controls.Add(txtSearch2);
            Controls.Add(cmbSearchCriteria4);
            Controls.Add(cmbSearchCriteria3);
            Controls.Add(cmbSearchCriteria2);
            Controls.Add(btnShowNonActiveUsers);
            Controls.Add(AddUser);
            Controls.Add(btnShowProfile);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPeselProfile);
            Controls.Add(txtLoginProfile);
            Controls.Add(txtSurnameProfile);
            Controls.Add(btnResetSearch);
            Controls.Add(btnSearchUser);
            Controls.Add(txtSearch1);
            Controls.Add(cmbSearchCriteria1);
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
        private ComboBox cmbSearchCriteria1;
        private TextBox txtSearch1;
        private Button btnSearchUser;
        private Button btnResetSearch;
        private TextBox txtSurnameProfile;
        private TextBox txtLoginProfile;
        private TextBox txtPeselProfile;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnShowProfile;
        private Button AddUser;
        private Button btnShowNonActiveUsers;
        private ComboBox cmbSearchCriteria2;
        private ComboBox cmbSearchCriteria3;
        private ComboBox cmbSearchCriteria4;
        private TextBox txtSearch2;
        private TextBox txtSearch3;
        private TextBox txtSearch4;
    }
}