using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class PrivilegesForm : Form
    {
        private string connectionString;
        public PrivilegesForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            ConfigureDataGridView();
            LoadPrivileges();
        }

        private void ConfigureDataGridView()
        {
            dgvPrivileges.Columns.Clear();
            dgvPrivileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrivileges.AllowUserToAddRows = false;
            dgvPrivileges.AllowUserToDeleteRows = false;
            dgvPrivileges.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrivileges.MultiSelect = false;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Nazwa uprawnienia";
            nameColumn.Name = "PrivilegeName";
            nameColumn.ReadOnly = true;

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.HeaderText = "Opis uprawnienia";
            descriptionColumn.Name = "PrivilegeDescription";
            descriptionColumn.ReadOnly = true;

            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Wybór";
            checkboxColumn.Name = "IsSelected";

            dgvPrivileges.Columns.Add(nameColumn);
            dgvPrivileges.Columns.Add(descriptionColumn);
            dgvPrivileges.Columns.Add(checkboxColumn);
        }

        private void LoadPrivileges()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Nazwa, Opis FROM Uprawnienia";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string privilegeName = reader["Nazwa"].ToString();
                            string privilegeDescription = reader["Opis"].ToString();
                            dgvPrivileges.Rows.Add(privilegeName, privilegeDescription, false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania uprawnień: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            List<string> selectedPrivileges = new List<string>();

            foreach (DataGridViewRow row in dgvPrivileges.Rows)
            {
                if (Convert.ToBoolean(row.Cells["IsSelected"].Value))
                {
                    selectedPrivileges.Add(row.Cells["PrivilegeName"].Value.ToString());
                }
            }

            if (selectedPrivileges.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć przynajmniej jedno uprawnienie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UsersWithPrivilegesForm usersForm = new UsersWithPrivilegesForm(connectionString, selectedPrivileges);
            usersForm.ShowDialog();
        }

        private void btnPrivFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
