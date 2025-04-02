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
            dataGridViewUser.Location = new Point(11, 169);
            dataGridViewUser.Margin = new Padding(2);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 62;
            dataGridViewUser.Size = new Size(917, 457);
            dataGridViewUser.TabIndex = 0;
            // 
            // cmbSearchCriteria1
            // 
            cmbSearchCriteria1.FormattingEnabled = true;
            cmbSearchCriteria1.Items.AddRange(new object[] { "Imie", "Nazwisko", "PESEL", "Login" });
            cmbSearchCriteria1.Location = new Point(337, 14);
            cmbSearchCriteria1.Name = "cmbSearchCriteria1";
            cmbSearchCriteria1.Size = new Size(138, 25);
            cmbSearchCriteria1.TabIndex = 1;
            // 
            // txtSearch1
            // 
            txtSearch1.Location = new Point(495, 14);
            txtSearch1.Name = "txtSearch1";
            txtSearch1.Size = new Size(207, 25);
            txtSearch1.TabIndex = 2;
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
            // cmbSearchCriteria2
            // 
            cmbSearchCriteria2.FormattingEnabled = true;
            cmbSearchCriteria2.Items.AddRange(new object[] { "Imie", "Nazwisko", "PESEL", "Login" });
            cmbSearchCriteria2.Location = new Point(337, 48);
            cmbSearchCriteria2.Name = "cmbSearchCriteria2";
            cmbSearchCriteria2.Size = new Size(138, 25);
            cmbSearchCriteria2.TabIndex = 14;
            // 
            // cmbSearchCriteria3
            // 
            cmbSearchCriteria3.FormattingEnabled = true;
            cmbSearchCriteria3.Items.AddRange(new object[] { "Imie", "Nazwisko", "PESEL", "Login" });
            cmbSearchCriteria3.Location = new Point(337, 80);
            cmbSearchCriteria3.Name = "cmbSearchCriteria3";
            cmbSearchCriteria3.Size = new Size(138, 25);
            cmbSearchCriteria3.TabIndex = 15;
            // 
            // cmbSearchCriteria4
            // 
            cmbSearchCriteria4.FormattingEnabled = true;
            cmbSearchCriteria4.Items.AddRange(new object[] { "Imie", "Nazwisko", "PESEL", "Login" });
            cmbSearchCriteria4.Location = new Point(337, 113);
            cmbSearchCriteria4.Name = "cmbSearchCriteria4";
            cmbSearchCriteria4.Size = new Size(138, 25);
            cmbSearchCriteria4.TabIndex = 16;
            // 
            // txtSearch2
            // 
            txtSearch2.Location = new Point(495, 48);
            txtSearch2.Name = "txtSearch2";
            txtSearch2.Size = new Size(207, 25);
            txtSearch2.TabIndex = 17;
            // 
            // txtSearch3
            // 
            txtSearch3.Location = new Point(495, 80);
            txtSearch3.Name = "txtSearch3";
            txtSearch3.Size = new Size(207, 25);
            txtSearch3.TabIndex = 18;
            // 
            // txtSearch4
            // 
            txtSearch4.Location = new Point(495, 113);
            txtSearch4.Name = "txtSearch4";
            txtSearch4.Size = new Size(207, 25);
            txtSearch4.TabIndex = 19;
            // 
            // DataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 635);
            Controls.Add(txtSearch4);
            Controls.Add(txtSearch3);
            Controls.Add(txtSearch2);
            Controls.Add(cmbSearchCriteria4);
            Controls.Add(cmbSearchCriteria3);
            Controls.Add(cmbSearchCriteria2);
            Controls.Add(btnShowNonActiveUsers);
            Controls.Add(AddUser);
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