namespace Biblioteka
{
    partial class UsersWithPrivilegesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersWithPrivilegesForm));
            dgvUsers = new DataGridView();
            btnUsrWPrivFormClose = new Button();
            btnSearchWithPrivileges = new Button();
            chkNamePriv = new CheckBox();
            chkSurnamePriv = new CheckBox();
            chkLoginPriv = new CheckBox();
            txtNamePriv = new TextBox();
            txtSurnamePriv = new TextBox();
            txtLoginPriv = new TextBox();
            btnResetPrivSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.GridColor = Color.FromArgb(255, 224, 192);
            dgvUsers.Location = new Point(59, 120);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(630, 327);
            dgvUsers.TabIndex = 0;
            // 
            // btnUsrWPrivFormClose
            // 
            btnUsrWPrivFormClose.BackColor = Color.FromArgb(64, 64, 64);
            btnUsrWPrivFormClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUsrWPrivFormClose.ForeColor = SystemColors.Control;
            btnUsrWPrivFormClose.Location = new Point(24, 12);
            btnUsrWPrivFormClose.Name = "btnUsrWPrivFormClose";
            btnUsrWPrivFormClose.Size = new Size(84, 33);
            btnUsrWPrivFormClose.TabIndex = 1;
            btnUsrWPrivFormClose.Text = "Powrót";
            btnUsrWPrivFormClose.UseVisualStyleBackColor = false;
            btnUsrWPrivFormClose.Click += btnUsrWPrivFormClose_Click;
            // 
            // btnSearchWithPrivileges
            // 
            btnSearchWithPrivileges.Location = new Point(653, 18);
            btnSearchWithPrivileges.Name = "btnSearchWithPrivileges";
            btnSearchWithPrivileges.Size = new Size(135, 27);
            btnSearchWithPrivileges.TabIndex = 2;
            btnSearchWithPrivileges.Text = "Wyszukaj";
            btnSearchWithPrivileges.UseVisualStyleBackColor = true;
            btnSearchWithPrivileges.Click += btnSearchWithPrivileges_Click;
            // 
            // chkNamePriv
            // 
            chkNamePriv.AutoSize = true;
            chkNamePriv.Location = new Point(209, 18);
            chkNamePriv.Name = "chkNamePriv";
            chkNamePriv.Size = new Size(49, 19);
            chkNamePriv.TabIndex = 3;
            chkNamePriv.Text = "Imię";
            chkNamePriv.UseVisualStyleBackColor = true;
            chkNamePriv.CheckedChanged += chkNamePriv_CheckedChanged;
            // 
            // chkSurnamePriv
            // 
            chkSurnamePriv.AutoSize = true;
            chkSurnamePriv.Location = new Point(209, 43);
            chkSurnamePriv.Name = "chkSurnamePriv";
            chkSurnamePriv.Size = new Size(76, 19);
            chkSurnamePriv.TabIndex = 4;
            chkSurnamePriv.Text = "Nazwisko";
            chkSurnamePriv.UseVisualStyleBackColor = true;
            chkSurnamePriv.CheckedChanged += chkSurnamePriv_CheckedChanged;
            // 
            // chkLoginPriv
            // 
            chkLoginPriv.AutoSize = true;
            chkLoginPriv.Location = new Point(209, 68);
            chkLoginPriv.Name = "chkLoginPriv";
            chkLoginPriv.Size = new Size(56, 19);
            chkLoginPriv.TabIndex = 5;
            chkLoginPriv.Text = "Login";
            chkLoginPriv.UseVisualStyleBackColor = true;
            chkLoginPriv.CheckedChanged += chkLoginPriv_CheckedChanged;
            // 
            // txtNamePriv
            // 
            txtNamePriv.Location = new Point(302, 14);
            txtNamePriv.Name = "txtNamePriv";
            txtNamePriv.Size = new Size(195, 23);
            txtNamePriv.TabIndex = 6;
            txtNamePriv.Visible = false;
            txtNamePriv.TextChanged += textBox1_TextChanged;
            // 
            // txtSurnamePriv
            // 
            txtSurnamePriv.Location = new Point(302, 41);
            txtSurnamePriv.Name = "txtSurnamePriv";
            txtSurnamePriv.Size = new Size(195, 23);
            txtSurnamePriv.TabIndex = 7;
            txtSurnamePriv.Visible = false;
            // 
            // txtLoginPriv
            // 
            txtLoginPriv.Location = new Point(302, 66);
            txtLoginPriv.Name = "txtLoginPriv";
            txtLoginPriv.Size = new Size(195, 23);
            txtLoginPriv.TabIndex = 8;
            txtLoginPriv.Visible = false;
            // 
            // btnResetPrivSearch
            // 
            btnResetPrivSearch.Location = new Point(651, 54);
            btnResetPrivSearch.Name = "btnResetPrivSearch";
            btnResetPrivSearch.Size = new Size(137, 33);
            btnResetPrivSearch.TabIndex = 9;
            btnResetPrivSearch.Text = "Reset";
            btnResetPrivSearch.UseVisualStyleBackColor = true;
            btnResetPrivSearch.Click += btnResetPrivSearch_Click;
            // 
            // UsersWithPrivilegesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnResetPrivSearch);
            Controls.Add(txtLoginPriv);
            Controls.Add(txtSurnamePriv);
            Controls.Add(txtNamePriv);
            Controls.Add(chkLoginPriv);
            Controls.Add(chkSurnamePriv);
            Controls.Add(chkNamePriv);
            Controls.Add(btnSearchWithPrivileges);
            Controls.Add(btnUsrWPrivFormClose);
            Controls.Add(dgvUsers);
            Name = "UsersWithPrivilegesForm";
            Text = "UsersWithPrivilegesForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnUsrWPrivFormClose;
        private Button btnSearchWithPrivileges;
        private CheckBox chkNamePriv;
        private CheckBox chkSurnamePriv;
        private CheckBox chkLoginPriv;
        private TextBox txtNamePriv;
        private TextBox txtSurnamePriv;
        private TextBox txtLoginPriv;
        private Button btnResetPrivSearch;
    }
}