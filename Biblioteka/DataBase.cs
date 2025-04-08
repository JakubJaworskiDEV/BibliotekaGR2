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
            this.FormBorderStyle = FormBorderStyle.None;
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
                    string query = "SELECT Imie, Nazwisko, PESEL, Login, Email, Nr_tel FROM Uzytkownik WHERE Status_akt = 1";

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

                //sprawdzanie czy status aktywności jest = 0 w bazie danych - jeżeli tak to tylko wyświetlamy komunikat
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string checkStatusQuery = "SELECT Status_akt FROM Uzytkownik WHERE Login = @login";
                    using (SQLiteCommand command = new SQLiteCommand(checkStatusQuery, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        object result = command.ExecuteScalar();
                        if (result != null && Convert.ToInt32(result) == 0)
                        {
                            MessageBox.Show("Użytkownik jest nieaktywny.");
                            return;
                        }
                    }
                }

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
                    string query = @"SELECT 
                        Uzytkownik.Uzytkownik_id, 
                        Uzytkownik.Imie, 
                        Uzytkownik.Nazwisko, 
                        Uzytkownik.PESEL, 
                        Uzytkownik.Login,
                        Uzytkownik.Email,
                        Uzytkownik.Data_ur, 
                        Uzytkownik.Plec, 
                        Uzytkownik.Nr_tel, 
                        Uzytkownik.Status_log,
                        Uzytkownik.Status_akt,
                        Uzytkownik.Rodzaj,
                        Uzytkownik.Ksiazka,
                        Uzytkownik.Adres,
                        Adres_zamieszkania.Adres_id, 
                        Adres_zamieszkania.Kod_pocztowy, 
                        Adres_zamieszkania.Miejscowosc, 
                        Adres_zamieszkania.Ulica, 
                        Adres_zamieszkania.Nr_posesji, 
                        Adres_zamieszkania.Nr_lokalu FROM Uzytkownik INNER JOIN Adres_zamieszkania ON Uzytkownik.Adres = Adres_zamieszkania.Adres_id  
                        WHERE Login = @login AND PESEL = @pesel AND Nazwisko = @nazwisko";
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

            ValidateCheckboxCriteria(chkName, txtName, "Imie", "@name", conditions, parameters, ref selectedCriteriaCount, ref filledCriteriaCount);
            ValidateCheckboxCriteria(chkSurname, txtSurname, "Nazwisko", "@surname", conditions, parameters, ref selectedCriteriaCount, ref filledCriteriaCount);
            ValidateCheckboxCriteria(chkEmail, txtEmail, "Email", "@email", conditions, parameters, ref selectedCriteriaCount, ref filledCriteriaCount);
            ValidateCheckboxCriteria(chkLogin, txtLogin, "Login", "@login", conditions, parameters, ref selectedCriteriaCount, ref filledCriteriaCount);

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

            string query = "SELECT Imie, Nazwisko, PESEL, Login, Email, Nr_tel FROM Uzytkownik WHERE Status_akt = 1 AND " + string.Join(" AND ", conditions);
            SearchUsers(query, parameters);
        }

        private void ValidateCheckboxCriteria(CheckBox checkBox, TextBox textBox, string columnName, string paramName, List<string> conditions, List<SQLiteParameter> parameters, ref int selectedCount, ref int filledCount)
        {
            if (checkBox.Checked)
            {
                selectedCount++;
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    conditions.Add($"{columnName} LIKE {paramName}");
                    parameters.Add(new SQLiteParameter(paramName, "%" + textBox.Text + "%"));
                    filledCount++;
                }
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            chkName.Checked = false;
            chkSurname.Checked = false;
            chkEmail.Checked = false;
            chkLogin.Checked = false;

            txtName.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
            txtLogin.Text = "";

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

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser(userData, connectionString);
            addUserForm.Show();
        }

        private void btnShowNonActiveUsers_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Imie, Nazwisko, PESEL, Login, Email, Nr_tel FROM Uzytkownik WHERE Status_akt = 0";

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

        private void chkName_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Visible = chkName.Checked;
            if (!chkName.Checked) txtName.Text = "";
        }

        private void chkSurname_CheckedChanged(object sender, EventArgs e)
        {
            txtSurname.Visible = chkSurname.Checked;
            if (!chkSurname.Checked) txtSurname.Text = "";
        }

        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Visible = chkEmail.Checked;
            if (!chkEmail.Checked) txtEmail.Text = "";
        }

        private void chkLogin_CheckedChanged(object sender, EventArgs e)
        {
            txtLogin.Visible = chkLogin.Checked;
            if (!chkLogin.Checked) txtLogin.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
