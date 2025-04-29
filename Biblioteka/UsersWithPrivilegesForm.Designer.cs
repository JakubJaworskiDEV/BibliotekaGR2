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
            dgvUsers = new DataGridView();
            btnUsrWPrivFormClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(59, 82);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(630, 371);
            dgvUsers.TabIndex = 0;
            // 
            // btnUsrWPrivFormClose
            // 
            btnUsrWPrivFormClose.Location = new Point(59, 12);
            btnUsrWPrivFormClose.Name = "btnUsrWPrivFormClose";
            btnUsrWPrivFormClose.Size = new Size(84, 37);
            btnUsrWPrivFormClose.TabIndex = 1;
            btnUsrWPrivFormClose.Text = "Powrót";
            btnUsrWPrivFormClose.UseVisualStyleBackColor = true;
            btnUsrWPrivFormClose.Click += btnUsrWPrivFormClose_Click;
            // 
            // UsersWithPrivilegesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
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