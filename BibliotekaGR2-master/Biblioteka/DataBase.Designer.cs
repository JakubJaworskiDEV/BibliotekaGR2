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
            cmbSearchCriteria = new ComboBox();
            txtSearch = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(11, 88);
            dataGridViewUser.Margin = new Padding(2);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 62;
            dataGridViewUser.Size = new Size(834, 403);
            dataGridViewUser.TabIndex = 0;
            // 
            // cmbSearchCriteria
            // 
            cmbSearchCriteria.FormattingEnabled = true;
            cmbSearchCriteria.Items.AddRange(new object[] { "Nazwisko", "PESEL", "Login", "Email", "Telefon" });
            cmbSearchCriteria.Location = new Point(337, 36);
            cmbSearchCriteria.Name = "cmbSearchCriteria";
            cmbSearchCriteria.Size = new Size(138, 23);
            cmbSearchCriteria.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(481, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(207, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearchUser
            // 
            btnSearchUser.Location = new Point(708, 31);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(118, 23);
            btnSearchUser.TabIndex = 3;
            btnSearchUser.Text = "Wyszukaj";
            btnSearchUser.UseVisualStyleBackColor = true;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // btnResetSearch
            // 
            btnResetSearch.Location = new Point(709, 60);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Size = new Size(117, 23);
            btnResetSearch.TabIndex = 4;
            btnResetSearch.Text = "Reset";
            btnResetSearch.UseVisualStyleBackColor = true;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // txtSurnameProfile
            // 
            txtSurnameProfile.Location = new Point(39, 551);
            txtSurnameProfile.Name = "txtSurnameProfile";
            txtSurnameProfile.Size = new Size(187, 23);
            txtSurnameProfile.TabIndex = 5;
            // 
            // txtLoginProfile
            // 
            txtLoginProfile.Location = new Point(481, 551);
            txtLoginProfile.Name = "txtLoginProfile";
            txtLoginProfile.Size = new Size(188, 23);
            txtLoginProfile.TabIndex = 6;
            // 
            // txtPeselProfile
            // 
            txtPeselProfile.Location = new Point(260, 551);
            txtPeselProfile.Name = "txtPeselProfile";
            txtPeselProfile.Size = new Size(185, 23);
            txtPeselProfile.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 520);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 8;
            label1.Text = "Nazwisko";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 520);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "PESEL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(564, 520);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 10;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // btnShowProfile
            // 
            btnShowProfile.Location = new Point(688, 511);
            btnShowProfile.Name = "btnShowProfile";
            btnShowProfile.Size = new Size(157, 63);
            btnShowProfile.TabIndex = 11;
            btnShowProfile.Text = "Wyświetl dane użytkownika";
            btnShowProfile.UseVisualStyleBackColor = true;
            btnShowProfile.Click += btnShowProfile_Click;
            // 
            // AddUser
            // 
            AddUser.Location = new Point(22, 31);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(150, 23);
            AddUser.TabIndex = 12;
            AddUser.Text = "Dodaj użytkownika";
            AddUser.UseVisualStyleBackColor = true;
            AddUser.Click += AddUser_Click;
            // 
            // DataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 584);
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
            Controls.Add(txtSearch);
            Controls.Add(cmbSearchCriteria);
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
        private ComboBox cmbSearchCriteria;
        private TextBox txtSearch;
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
    }
}