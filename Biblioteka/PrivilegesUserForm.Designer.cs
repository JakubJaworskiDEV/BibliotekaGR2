namespace Biblioteka
{
    partial class PrivilegesUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivilegesUserForm));
            dvgUserPrivilages = new DataGridView();
            btnEditPrivilages = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgUserPrivilages).BeginInit();
            SuspendLayout();
            // 
            // dvgUserPrivilages
            // 
            dvgUserPrivilages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgUserPrivilages.BackgroundColor = Color.FromArgb(255, 224, 192);
            dvgUserPrivilages.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgUserPrivilages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgUserPrivilages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvgUserPrivilages.DefaultCellStyle = dataGridViewCellStyle2;
            dvgUserPrivilages.EnableHeadersVisualStyles = false;
            dvgUserPrivilages.GridColor = Color.FromArgb(255, 224, 192);
            dvgUserPrivilages.Location = new Point(49, 80);
            dvgUserPrivilages.Name = "dvgUserPrivilages";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dvgUserPrivilages.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 224, 192);
            dvgUserPrivilages.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dvgUserPrivilages.Size = new Size(1100, 579);
            dvgUserPrivilages.TabIndex = 0;
            // 
            // btnEditPrivilages
            // 
            btnEditPrivilages.BackColor = Color.FromArgb(64, 64, 64);
            btnEditPrivilages.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditPrivilages.ForeColor = SystemColors.Control;
            btnEditPrivilages.Location = new Point(904, 18);
            btnEditPrivilages.Name = "btnEditPrivilages";
            btnEditPrivilages.Size = new Size(245, 36);
            btnEditPrivilages.TabIndex = 1;
            btnEditPrivilages.Text = "Zatwierdz edycję uprawnień";
            btnEditPrivilages.UseVisualStyleBackColor = false;
            btnEditPrivilages.Click += btnEditPrivilages_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(49, 12);
            button1.Name = "button1";
            button1.Size = new Size(107, 42);
            button1.TabIndex = 2;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PrivilegesUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1215, 730);
            Controls.Add(button1);
            Controls.Add(btnEditPrivilages);
            Controls.Add(dvgUserPrivilages);
            Name = "PrivilegesUserForm";
            Text = "PrivilegesUserForm";
            Load += PrivilegesUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvgUserPrivilages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgUserPrivilages;
        private Button btnEditPrivilages;
        private Button button1;
    }
}