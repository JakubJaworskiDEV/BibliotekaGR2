using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class PrivilegesUserForm : Form
    {
        private string connectionString;
        public PrivilegesUserForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            ConfigureDataGridView();
            LoadUserPrivileges();
        }

        private void LoadUserPrivileges()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Uprawnienia_ID, Użytkownik_ID FROM Uprawnienia_Uzytkownik";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string privilegeName = reader["Nazwa"].ToString();
                            string privilegeDescription = reader["Opis"].ToString();
                            dvgUserPrivilages.Rows.Add(privilegeName, privilegeDescription, false);
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
            List<string> selectedUserPrivileges = new List<string>();

            foreach (DataGridViewRow row in dvgUserPrivilages.Rows)
            {
                if (Convert.ToBoolean(row.Cells["IsSelected"].Value))
                {
                    selectedUserPrivileges.Add(row.Cells["PrivilegeName"].Value.ToString());
                }
            }

            if (selectedUserPrivileges.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć przynajmniej jedno uprawnienie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UsersWithPrivilegesForm usersForm = new UsersWithPrivilegesForm(connectionString, selectedUserPrivileges);
            usersForm.ShowDialog();
        }

        private void btnPrivFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigureDataGridView()
        {
            dvgUserPrivilages.Columns.Clear();
            dvgUserPrivilages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgUserPrivilages.AllowUserToAddRows = false;
            dvgUserPrivilages.AllowUserToDeleteRows = false;
            dvgUserPrivilages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgUserPrivilages.MultiSelect = false;

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

            dvgUserPrivilages.Columns.Add(nameColumn);
            dvgUserPrivilages.Columns.Add(descriptionColumn);
            dvgUserPrivilages.Columns.Add(checkboxColumn);
        }
    }
}
