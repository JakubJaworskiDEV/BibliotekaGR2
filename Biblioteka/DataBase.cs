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

                    LoadUsers(); // Załaduj użytkowników do DataGridView
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
                    string query = "SELECT * FROM Uzytkownik";

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
                    case "Nazwisko":
                        column = "Nazwisko";
                        break;
                    case "PESEL":
                        column = "PESEL";
                        break;
                    case "Login":
                        column = "Login";
                        break;
                    case "Email":
                        column = "Email";
                        break;
                    case "Telefon":
                        column = "Telefon";
                        break;
                    default:
                        MessageBox.Show("Nieprawidłowe kryterium wyszukiwania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT * FROM Uzytkownik WHERE {column} LIKE @searchText";
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
            string login = txtLoginProfile.Text.Trim();
            string pesel = txtPeselProfile.Text.Trim();
            string nazwisko = txtSurnameProfile.Text.Trim();

            if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(pesel) && string.IsNullOrEmpty(nazwisko))
            {
                MessageBox.Show("Proszę wprowadzić wszystkie kryteria wyszukiwania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable userData = GetUserProfile(login, pesel, nazwisko);
            if (userData.Rows.Count > 0) // sprawdzamy czy otrzymaliśmy przynajmniej 1 rekord z bazy
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
    }
}
