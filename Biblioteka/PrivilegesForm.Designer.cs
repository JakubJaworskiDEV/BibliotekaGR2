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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivilegesForm));
            dgvPrivileges = new DataGridView();
            btnShowUsers = new Button();
            btnPrivFormClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrivileges).BeginInit();
            SuspendLayout();
            // 
            // dgvPrivileges
            // 
            dgvPrivileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPrivileges.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvPrivileges.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPrivileges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrivileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPrivileges.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPrivileges.EnableHeadersVisualStyles = false;
            dgvPrivileges.GridColor = Color.FromArgb(255, 224, 192);
            dgvPrivileges.Location = new Point(70, 171);
            dgvPrivileges.Name = "dgvPrivileges";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPrivileges.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 224, 192);
            dgvPrivileges.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPrivileges.Size = new Size(1044, 541);
            dgvPrivileges.TabIndex = 0;
            // 
            // btnShowUsers
            // 
            btnShowUsers.BackColor = Color.FromArgb(64, 64, 64);
            btnShowUsers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnShowUsers.ForeColor = SystemColors.Control;
            btnShowUsers.Location = new Point(723, 25);
            btnShowUsers.Name = "btnShowUsers";
            btnShowUsers.Size = new Size(391, 36);
            btnShowUsers.TabIndex = 1;
            btnShowUsers.Text = "Pokaż użytkowników o konkretnych uprawnieniach";
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
            ClientSize = new Size(1191, 756);
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