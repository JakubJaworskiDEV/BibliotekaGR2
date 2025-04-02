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
        private DataTable userData;

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
                MessageBox.Show("Nie znaleziono użytkownika.");
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
            List<string> conditions = new List<string>();
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            int selectedCriteriaCount = 0;
            int filledCriteriaCount = 0;

            ValidateCriteria(cmbSearchCriteria1, txtSearch1, "@param1", conditions, parameters, ref selectedCriteriaCount, ref filledCriteriaCount);
            ValidateCriteria(cmbSearchCriteria2, txtSearch2, "@param2", conditions, parameters, ref selectedCriteriaCount, ref filledCriteriaCount);
            ValidateCriteria(cmbSearchCriteria3, txtSearch3, "@param3", conditions, parameters, ref selectedCriteriaCount, ref filledCriteriaCount);
            ValidateCriteria(cmbSearchCriteria4, txtSearch4, "@param4", conditions, parameters, ref selectedCriteriaCount, ref filledCriteriaCount);

            if (selectedCriteriaCount > 1 && filledCriteriaCount < selectedCriteriaCount)
            {
                MessageBox.Show("Proszę wypełnić wszystkie wybrane pola");
                return;
            }

            if (selectedCriteriaCount > 0 && selectedCriteriaCount < 2 && filledCriteriaCount < selectedCriteriaCount)
            {
                MessageBox.Show("Proszę wypełnić wybrane pole");
                return;
            }

            if (conditions.Count == 0)
            {
                MessageBox.Show("Proszę wybrać przynajmniej jedno kryterium wyszukiwania.");
                return;
            }

            string query = "SELECT * FROM Uzytkownik WHERE Status_akt = 1 AND " + string.Join(" AND ", conditions);
            SearchUsers(query, parameters);
        }

        private void ValidateCriteria(ComboBox comboBox, TextBox textBox, string paramName, List<string> conditions, List<SQLiteParameter> parameters, ref int selectedCount, ref int filledCount)
        {
            if (comboBox.SelectedItem != null)
            {
                selectedCount++;
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    conditions.Add($"{comboBox.SelectedItem} LIKE {paramName}");
                    parameters.Add(new SQLiteParameter(paramName, "%" + textBox.Text + "%"));
                    filledCount++;
                }
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtSearch1.Text = "";
            txtSearch2.Text = "";
            txtSearch3.Text = "";
            txtSearch4.Text = "";

            cmbSearchCriteria1.SelectedIndex = -1;
            cmbSearchCriteria2.SelectedIndex = -1;
            cmbSearchCriteria3.SelectedIndex = -1;
            cmbSearchCriteria4.SelectedIndex = -1;

            LoadUsers();
        }

        private void SearchUsers(string query, List<SQLiteParameter> parameters)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridViewUser.DataSource = dt;
                        }
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
            AddUser addUserForm = new AddUser(userData, connectionString);
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
