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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivilegesUserForm));
            dvgUserPrivilages = new DataGridView();
            btnEditPrivilages = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgUserPrivilages).BeginInit();
            SuspendLayout();
            // 
            // dvgUserPrivilages
            // 
            dvgUserPrivilages.BackgroundColor = Color.FromArgb(255, 224, 192);
            dvgUserPrivilages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUserPrivilages.GridColor = Color.FromArgb(255, 224, 192);
            dvgUserPrivilages.Location = new Point(65, 80);
            dvgUserPrivilages.Name = "dvgUserPrivilages";
            dvgUserPrivilages.Size = new Size(625, 319);
            dvgUserPrivilages.TabIndex = 0;
            // 
            // btnEditPrivilages
            // 
            btnEditPrivilages.BackColor = Color.FromArgb(64, 64, 64);
            btnEditPrivilages.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditPrivilages.ForeColor = SystemColors.Control;
            btnEditPrivilages.Location = new Point(508, 12);
            btnEditPrivilages.Name = "btnEditPrivilages";
            btnEditPrivilages.Size = new Size(182, 36);
            btnEditPrivilages.TabIndex = 1;
            btnEditPrivilages.Text = "Edytuj Uprawnienia";
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
            button1.Text = "Zamknij";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PrivilegesUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
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