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
        private string userLogin;
        private Dictionary<string, int> privilegeNameToIdMap = new();
        public PrivilegesUserForm(string connectionString, string userLogin)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.userLogin = userLogin;
            ConfigureDataGridView();
            LoadAllPrivileges();
        }

        private void LoadAllPrivileges()
        {
            HashSet<int> userPrivileges = GetUserPrivileges();

            using SQLiteConnection connection = new(connectionString);
            connection.Open();
            string query = "SELECT Uprawnienia_ID, Nazwa, Opis FROM Uprawnienia";

            using SQLiteCommand command = new(query, connection);
            using SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Uprawnienia_ID"]);
                string name = reader["Nazwa"].ToString();
                string description = reader["Opis"].ToString();
                privilegeNameToIdMap[name] = id;
                bool isChecked = userPrivileges.Contains(id);
                dvgUserPrivilages.Rows.Add(name, description, isChecked);
            }
        }

        private HashSet<int> GetUserPrivileges()
        {
            HashSet<int> privilegeIds = new();
            using SQLiteConnection connection = new(connectionString);
            connection.Open();

            string query = @"SELECT Uprawnienia_ID FROM Uprawnienia_Uzytkownik 
                             WHERE Uzytkownik_ID = (SELECT Uzytkownik_id FROM Uzytkownik WHERE Login = @login)";

            using SQLiteCommand command = new(query, connection);
            command.Parameters.AddWithValue("@login", userLogin);
            using SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
                privilegeIds.Add(Convert.ToInt32(reader["Uprawnienia_ID"]));

            return privilegeIds;
        }

        private void btnEditPrivilages_Click(object sender, EventArgs e)
        {
            
        }

        private int GetUserIdByLogin(string login)
        {
            using SQLiteConnection connection = new(connectionString);
            connection.Open();
            string query = "SELECT Uzytkownik_id FROM Uzytkownik WHERE Login = @login";
            using SQLiteCommand cmd = new(query, connection);
            cmd.Parameters.AddWithValue("@login", login);
            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : -1;
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

            DataGridViewTextBoxColumn nameColumn = new()
            {
                HeaderText = "Nazwa uprawnienia",
                Name = "PrivilegeName",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn descriptionColumn = new()
            {
                HeaderText = "Opis uprawnienia",
                Name = "PrivilegeDescription",
                ReadOnly = true
            };

            DataGridViewCheckBoxColumn checkboxColumn = new()
            {
                HeaderText = "Wybór",
                Name = "IsSelected"
            };

            dvgUserPrivilages.Columns.Add(nameColumn);
            dvgUserPrivilages.Columns.Add(descriptionColumn);
            dvgUserPrivilages.Columns.Add(checkboxColumn);
        }

        private void btnEditPrivilages_Click_1(object sender, EventArgs e)
        {
            int userId = GetUserIdByLogin(userLogin);
            if (userId == -1)
            {
                MessageBox.Show("Nie znaleziono użytkownika.");
                return;
            }

            using SQLiteConnection connection = new(connectionString);
            connection.Open();

            using SQLiteTransaction transaction = connection.BeginTransaction();

            try
            {
                string deleteQuery = "DELETE FROM Uprawnienia_Uzytkownik WHERE Uzytkownik_ID = @userId";
                using SQLiteCommand deleteCmd = new(deleteQuery, connection, transaction);
                deleteCmd.Parameters.AddWithValue("@userId", userId);
                deleteCmd.ExecuteNonQuery();

                string insertQuery = "INSERT INTO Uprawnienia_Uzytkownik (Uzytkownik_ID, Uprawnienia_ID) VALUES (@userId, @privId)";
                using SQLiteCommand insertCmd = new(insertQuery, connection, transaction);
                insertCmd.Parameters.AddWithValue("@userId", userId);
                var paramPrivId = insertCmd.Parameters.Add("@privId", DbType.Int32);

                foreach (DataGridViewRow row in dvgUserPrivilages.Rows)
                {
                    if (row.Cells["IsSelected"].Value != null && Convert.ToBoolean(row.Cells["IsSelected"].Value))
                    {
                        string privName = row.Cells["PrivilegeName"].Value.ToString();
                        if (privilegeNameToIdMap.TryGetValue(privName, out int privId))
                        {
                            paramPrivId.Value = privId;
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                transaction.Commit();
                MessageBox.Show("Uprawnienia użytkownika zostały zaktualizowane.", "Sukces");
                this.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Błąd podczas zapisywania uprawnień: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
