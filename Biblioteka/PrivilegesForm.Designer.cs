namespace Biblioteka
{
    partial class PrivilegesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivilegesForm));
            dgvPrivileges = new DataGridView();
            btnShowUsers = new Button();
            btnPrivFormClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrivileges).BeginInit();
            SuspendLayout();
            // 
            // dgvPrivileges
            // 
            dgvPrivileges.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvPrivileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrivileges.GridColor = Color.FromArgb(255, 224, 192);
            dgvPrivileges.Location = new Point(91, 170);
            dgvPrivileges.Name = "dgvPrivileges";
            dgvPrivileges.Size = new Size(555, 185);
            dgvPrivileges.TabIndex = 0;
            // 
            // btnShowUsers
            // 
            btnShowUsers.BackColor = Color.FromArgb(64, 64, 64);
            btnShowUsers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnShowUsers.ForeColor = SystemColors.Control;
            btnShowUsers.Location = new Point(614, 21);
            btnShowUsers.Name = "btnShowUsers";
            btnShowUsers.Size = new Size(75, 36);
            btnShowUsers.TabIndex = 1;
            btnShowUsers.Text = "Pokaż";
            btnShowUsers.UseVisualStyleBackColor = false;
            btnShowUsers.Click += btnShowUsers_Click;
            // 
            // btnPrivFormClose
            // 
            btnPrivFormClose.BackColor = Color.FromArgb(64, 64, 64);
            btnPrivFormClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPrivFormClose.ForeColor = SystemColors.Control;
            btnPrivFormClose.Location = new Point(32, 18);
            btnPrivFormClose.Name = "btnPrivFormClose";
            btnPrivFormClose.Size = new Size(92, 43);
            btnPrivFormClose.TabIndex = 2;
            btnPrivFormClose.Text = "Powrót";
            btnPrivFormClose.UseVisualStyleBackColor = false;
            btnPrivFormClose.Click += btnPrivFormClose_Click;
            // 
            // PrivilegesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrivFormClose);
            Controls.Add(btnShowUsers);
            Controls.Add(dgvPrivileges);
            Name = "PrivilegesForm";
            Text = "PrivilegesForm";
            ((System.ComponentModel.ISupportInitialize)dgvPrivileges).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPrivileges;
        private Button btnShowUsers;
        private Button btnPrivFormClose;
    }
}