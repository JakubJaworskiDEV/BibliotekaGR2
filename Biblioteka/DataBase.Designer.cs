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
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(11, 88);
            dataGridViewUser.Margin = new Padding(2, 2, 2, 2);
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
            // DataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 502);
            Controls.Add(btnResetSearch);
            Controls.Add(btnSearchUser);
            Controls.Add(txtSearch);
            Controls.Add(cmbSearchCriteria);
            Controls.Add(dataGridViewUser);
            Margin = new Padding(2, 2, 2, 2);
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
    }
}