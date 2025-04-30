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
            dvgUserPrivilages = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgUserPrivilages).BeginInit();
            SuspendLayout();
            // 
            // dvgUserPrivilages
            // 
            dvgUserPrivilages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUserPrivilages.Location = new Point(65, 44);
            dvgUserPrivilages.Name = "dvgUserPrivilages";
            dvgUserPrivilages.Size = new Size(625, 319);
            dvgUserPrivilages.TabIndex = 0;
            // 
            // PrivilegesUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dvgUserPrivilages);
            Name = "PrivilegesUserForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgUserPrivilages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgUserPrivilages;
    }
}