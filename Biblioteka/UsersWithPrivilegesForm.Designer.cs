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
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.GridColor = Color.FromArgb(255, 224, 192);
            dgvUsers.Location = new Point(59, 72);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(630, 327);
            dgvUsers.TabIndex = 0;
            // 
            // btnUsrWPrivFormClose
            // 
            btnUsrWPrivFormClose.BackColor = Color.FromArgb(64, 64, 64);
            btnUsrWPrivFormClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUsrWPrivFormClose.ForeColor = SystemColors.Control;
            btnUsrWPrivFormClose.Location = new Point(59, 11);
            btnUsrWPrivFormClose.Name = "btnUsrWPrivFormClose";
            btnUsrWPrivFormClose.Size = new Size(84, 33);
            btnUsrWPrivFormClose.TabIndex = 1;
            btnUsrWPrivFormClose.Text = "Powrót";
            btnUsrWPrivFormClose.UseVisualStyleBackColor = false;
            btnUsrWPrivFormClose.Click += btnUsrWPrivFormClose_Click;
            // 
            // UsersWithPrivilegesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnUsrWPrivFormClose);
            Controls.Add(dgvUsers);
            Name = "UsersWithPrivilegesForm";
            Text = "UsersWithPrivilegesForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnUsrWPrivFormClose;
    }
}