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
            dgvPrivileges = new DataGridView();
            btnShowUsers = new Button();
            btnPrivFormClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrivileges).BeginInit();
            SuspendLayout();
            // 
            // dgvPrivileges
            // 
            dgvPrivileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrivileges.Location = new Point(91, 193);
            dgvPrivileges.Name = "dgvPrivileges";
            dgvPrivileges.Size = new Size(555, 210);
            dgvPrivileges.TabIndex = 0;
            // 
            // btnShowUsers
            // 
            btnShowUsers.Location = new Point(614, 24);
            btnShowUsers.Name = "btnShowUsers";
            btnShowUsers.Size = new Size(75, 26);
            btnShowUsers.TabIndex = 1;
            btnShowUsers.Text = "Pokaż";
            btnShowUsers.UseVisualStyleBackColor = true;
            btnShowUsers.Click += btnShowUsers_Click;
            // 
            // btnPrivFormClose
            // 
            btnPrivFormClose.Location = new Point(31, 27);
            btnPrivFormClose.Name = "btnPrivFormClose";
            btnPrivFormClose.Size = new Size(82, 37);
            btnPrivFormClose.TabIndex = 2;
            btnPrivFormClose.Text = "Powrót";
            btnPrivFormClose.UseVisualStyleBackColor = true;
            btnPrivFormClose.Click += btnPrivFormClose_Click;
            // 
            // PrivilegesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
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