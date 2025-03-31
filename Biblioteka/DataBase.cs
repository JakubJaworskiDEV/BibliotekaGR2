using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class DataBase : Form
    {
        private string dbPath = @"..\..\..\..\BazaDanychProjekt.db";
        private string connectionString;

        public DataBase()
        {
            InitializeComponent();
            connectionString = $"Data Source={dbPath};Version=3;";
        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            try
            {
                if (!System.IO.File.Exists(dbPath))
                {
                    SQLiteConnection.CreateFile(dbPath);
                    MessageBox.Show("Utworzono nową bazę danych.");
                }

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Połączono z bazą danych!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                    AddProfileButtonColumn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia z bazą: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsers()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Uzytkownik_id, Imie, Nazwisko, PESEL, Login, Email, Nr_tel FROM Uzytkownik WHERE Status_akt = 1";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewUser.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas pobierania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProfileButtonColumn()
        {
            if (dataGridViewUser.Columns.Contains("ProfileButton")) return;

            DataGridViewButtonColumn profileButton = new DataGridViewButtonColumn();
            profileButton.Name = "ProfileButton";
            profileButton.HeaderText = "Profil";
            profileButton.Text = "Pokaż profil";
            profileButton.UseColumnTextForButtonValue = true;

            dataGridViewUser.Columns.Add(profileButton);
            dataGridViewUser.CellClick += DataGridViewUser_CellClick;
        }

        private void DataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewUser.Columns["ProfileButton"].Index && e.RowIndex >= 0)
            {
                string login = dataGridViewUser.Rows[e.RowIndex].Cells["Login"].Value.ToString();
                string pesel = dataGridViewUser.Rows[e.RowIndex].Cells["PESEL"].Value.ToString();
                string nazwisko = dataGridViewUser.Rows[e.RowIndex].Cells["Nazwisko"].Value.ToString();
                ShowUserProfile(login, pesel, nazwisko);
            }
        }

        private void ShowUserProfile(string login, string pesel, string nazwisko)
        {
            DataTable userData = GetUserProfile(login, pesel, nazwisko);
            if (userData.Rows.Count > 0)
            {
                UserProfileForm profileForm = new UserProfileForm(userData, connectionString);
                profileForm.Show();
            }
            else
            {
                MessageBox.Show("Nie znaleziono użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private DataTable GetUserProfile(string login, string pesel, string nazwisko)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Uzytkownik WHERE Login = @login AND PESEL = @pesel AND Nazwisko = @nazwisko";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@pesel", pesel);
                        command.Parameters.AddWithValue("@nazwisko", nazwisko);
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas pobierania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (cmbSearchCriteria.SelectedItem != null)
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Proszę wpisać wartość do wyszukiwania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string selectedCriteria = cmbSearchCriteria.SelectedItem.ToString();
                SearchUsers(txtSearch.Text, selectedCriteria);
            }
            else
            {
                MessageBox.Show("Proszę wybrać kryterium wyszukiwania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbSearchCriteria.SelectedIndex = -1;
            LoadUsers();
        }

        private void SearchUsers(string searchText, string criteria)
        {
            try
            {
                string column;
                switch (criteria)
                {
                    case "Imie":
                        column = "Imie";
                        break;
                    case "Nazwisko":
                        column = "Nazwisko";
                        break;
                    case "PESEL":
                        column = "PESEL";
                        break;
                    case "Login":
                        column = "Login";
                        break;
                    default:
                        MessageBox.Show("Nieprawidłowe kryterium wyszukiwania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT * FROM Uzytkownik WHERE {column} LIKE @searchText AND Status_akt = 1";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewUser.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wyszukiwania: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnShowProfile_Click(object sender, EventArgs e)
        {
            
        }
        

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser();
            addUserForm.Show(); // Otwiera nowe okno
        }

        private void btnShowNonActiveUsers_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Uzytkownik_id, Imie, Nazwisko, PESEL, Login, Email, Nr_tel FROM Uzytkownik WHERE Status_akt Is NULL";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewUser.DataSource = dt; // Wyświetlenie danych w DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas pobierania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
