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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsers.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.FromArgb(255, 224, 192);
            dgvUsers.Location = new Point(60, 147);
            dgvUsers.Name = "dgvUsers";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 224, 192);
            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
            dgvUsers.Size = new Size(868, 458);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
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
            btnSearchWithPrivileges.BackColor = Color.FromArgb(64, 64, 64);
            btnSearchWithPrivileges.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearchWithPrivileges.ForeColor = SystemColors.Control;
            btnSearchWithPrivileges.Location = new Point(653, 18);
            btnSearchWithPrivileges.Name = "btnSearchWithPrivileges";
            btnSearchWithPrivileges.Size = new Size(135, 27);
            btnSearchWithPrivileges.TabIndex = 2;
            btnSearchWithPrivileges.Text = "Wyszukaj";
            btnSearchWithPrivileges.UseVisualStyleBackColor = false;
            btnSearchWithPrivileges.Click += btnSearchWithPrivileges_Click;
            // 
            // chkNamePriv
            // 
            chkNamePriv.AutoSize = true;
            chkNamePriv.BackColor = Color.Transparent;
            chkNamePriv.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            chkNamePriv.Location = new Point(209, 43);
            chkNamePriv.Name = "chkNamePriv";
            chkNamePriv.Size = new Size(59, 24);
            chkNamePriv.TabIndex = 3;
            chkNamePriv.Text = "Imię";
            chkNamePriv.UseVisualStyleBackColor = false;
            chkNamePriv.CheckedChanged += chkNamePriv_CheckedChanged;
            // 
            // chkSurnamePriv
            // 
            chkSurnamePriv.AutoSize = true;
            chkSurnamePriv.BackColor = Color.Transparent;
            chkSurnamePriv.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            chkSurnamePriv.Location = new Point(209, 68);
            chkSurnamePriv.Name = "chkSurnamePriv";
            chkSurnamePriv.Size = new Size(95, 24);
            chkSurnamePriv.TabIndex = 4;
            chkSurnamePriv.Text = "Nazwisko";
            chkSurnamePriv.UseVisualStyleBackColor = false;
            chkSurnamePriv.CheckedChanged += chkSurnamePriv_CheckedChanged;
            // 
            // chkLoginPriv
            // 
            chkLoginPriv.AutoSize = true;
            chkLoginPriv.BackColor = Color.Transparent;
            chkLoginPriv.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            chkLoginPriv.Location = new Point(209, 93);
            chkLoginPriv.Name = "chkLoginPriv";
            chkLoginPriv.Size = new Size(67, 24);
            chkLoginPriv.TabIndex = 5;
            chkLoginPriv.Text = "Login";
            chkLoginPriv.UseVisualStyleBackColor = false;
            chkLoginPriv.CheckedChanged += chkLoginPriv_CheckedChanged;
            // 
            // txtNamePriv
            // 
            txtNamePriv.Location = new Point(302, 39);
            txtNamePriv.Name = "txtNamePriv";
            txtNamePriv.Size = new Size(195, 23);
            txtNamePriv.TabIndex = 6;
            txtNamePriv.Visible = false;
            txtNamePriv.TextChanged += textBox1_TextChanged;
            // 
            // txtSurnamePriv
            // 
            txtSurnamePriv.Location = new Point(302, 66);
            txtSurnamePriv.Name = "txtSurnamePriv";
            txtSurnamePriv.Size = new Size(195, 23);
            txtSurnamePriv.TabIndex = 7;
            txtSurnamePriv.Visible = false;
            // 
            // txtLoginPriv
            // 
            txtLoginPriv.Location = new Point(302, 91);
            txtLoginPriv.Name = "txtLoginPriv";
            txtLoginPriv.Size = new Size(195, 23);
            txtLoginPriv.TabIndex = 8;
            txtLoginPriv.Visible = false;
            // 
            // btnResetPrivSearch
            // 
            btnResetPrivSearch.BackColor = Color.FromArgb(64, 64, 64);
            btnResetPrivSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnResetPrivSearch.ForeColor = SystemColors.Control;
            btnResetPrivSearch.Location = new Point(651, 54);
            btnResetPrivSearch.Name = "btnResetPrivSearch";
            btnResetPrivSearch.Size = new Size(137, 33);
            btnResetPrivSearch.TabIndex = 9;
            btnResetPrivSearch.Text = "Reset";
            btnResetPrivSearch.UseVisualStyleBackColor = false;
            btnResetPrivSearch.Click += btnResetPrivSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(209, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 20);
            label1.TabIndex = 10;
            label1.Text = "Wybierz kryteria wyszukiwania";
            // 
            // UsersWithPrivilegesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1029, 669);
            Controls.Add(label1);
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
        private Label label1;
    }
}