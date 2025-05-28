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
    public partial class ChangePasswordForm : Form
    {

        private string connectionString;
        private string userLogin;
        private Form loginForm;
        private string login;

        public ChangePasswordForm(string connectionString, string login, Form loginForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.userLogin = login;
            this.loginForm = loginForm;
        }

        public ChangePasswordForm(string connectionString, string login)
        {
            this.connectionString = connectionString;
            this.login = login;
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 8 || password.Length > 15)
                return false;

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecial = password.Any(c => "-_!*#$&".Contains(c));

            return hasUpper && hasLower && hasDigit && hasSpecial;
        }

        private bool IsPasswordPreviouslyUsed(string newPassword)
        {
            using SQLiteConnection connection = new(connectionString);
            connection.Open();

            string query = @"SELECT h.Haslo1, h.Haslo2, h.Haslo3
                             FROM Uzytkownik u
                             JOIN Uzytkownik_Hasla uh ON u.Uzytkownik_id = uh.Uzytkownik_ID
                             JOIN TrzyHasla h ON uh.Haslo_ID = h.Haslo_ID
                             WHERE u.Login = @login";

            using SQLiteCommand command = new(query, connection);
            command.Parameters.AddWithValue("@login", userLogin);

            using SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string h1 = reader["Haslo1"]?.ToString();
                string h2 = reader["Haslo2"]?.ToString();
                string h3 = reader["Haslo3"]?.ToString();

                if (newPassword == h1 || newPassword == h2 || newPassword == h3)
                    return true;
            }

            return false;
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = NewPassword.Text.Trim();
            string confirmPassword = AgainNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Wprowadź i potwierdź nowe hasło.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Hasła nie są zgodne.");
                return;
            }

            if (!IsPasswordValid(newPassword))
            {
                MessageBox.Show("Hasło nie spełnia wymaganych kryteriów.");
                return;
            }

            if (IsPasswordPreviouslyUsed(newPassword))
            {
                MessageBox.Show("Nowe hasło nie może być jednym z trzech ostatnio używanych.");
                return;
            }

            var result = MessageBox.Show("Czy na pewno chcesz takie hasło?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                using SQLiteConnection connection = new(connectionString);
                connection.Open();

                int hasloId = -1;
                string getIdQuery = @"SELECT uh.Haslo_ID
                                      FROM Uzytkownik u
                                      JOIN Uzytkownik_Hasla uh ON u.Uzytkownik_id = uh.Uzytkownik_ID
                                      WHERE u.Login = @login";

                using (SQLiteCommand getIdCmd = new(getIdQuery, connection))
                {
                    getIdCmd.Parameters.AddWithValue("@login", userLogin);
                    object resultId = getIdCmd.ExecuteScalar();
                    if (resultId != null)
                        hasloId = Convert.ToInt32(resultId);
                }

                if (hasloId == -1)
                {
                    string insertHasla = @"INSERT INTO TrzyHasla (Haslo1) VALUES (@newPassword);
                                           SELECT last_insert_rowid();";
                    using (SQLiteCommand insertCmd = new(insertHasla, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@newPassword", newPassword);
                        hasloId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }

                    string linkUser = @"INSERT INTO Uzytkownik_Hasla (Uzytkownik_ID, Haslo_ID)
                                        SELECT Uzytkownik_id, @hasloId FROM Uzytkownik WHERE Login = @login";
                    using (SQLiteCommand linkCmd = new(linkUser, connection))
                    {
                        linkCmd.Parameters.AddWithValue("@hasloId", hasloId);
                        linkCmd.Parameters.AddWithValue("@login", userLogin);
                        linkCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    string updateHaslaQuery = @"UPDATE TrzyHasla
                                               SET Haslo3 = Haslo2,
                                                   Haslo2 = Haslo1,
                                                   Haslo1 = @newPassword
                                               WHERE Haslo_ID = @hasloId";

                    using SQLiteCommand updateHaslaCmd = new(updateHaslaQuery, connection)
                    {
                        Parameters =
                        {
                            new SQLiteParameter("@newPassword", newPassword),
                            new SQLiteParameter("@hasloId", hasloId)
                        }
                    };
                    updateHaslaCmd.ExecuteNonQuery();
                }

                string updatePassword = "UPDATE Uzytkownik SET Haslo = @password, Reset = 0 WHERE Login = @login";
                using (SQLiteCommand command = new(updatePassword, connection))
                {
                    command.Parameters.AddWithValue("@password", newPassword);
                    command.Parameters.AddWithValue("@login", userLogin);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Hasło zostało zaktualizowane.");
                this.Hide();
                DataBase dbForm = new DataBase(this);
                dbForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas aktualizacji hasła: {ex.Message}");
            }
        }
    }
}
