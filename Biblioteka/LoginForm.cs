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
    public partial class LoginForm : Form
    {
        private string connectionString = "Data Source=..\\..\\..\\..\\BazaDanychProjekt.db;Version=3;";
        private Form loginForm;
        private Dictionary<string, int> loginAttempts = new();
        private Dictionary<string, DateTime> blockedUsers = new();
        public LoginForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Wprowadź login i hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Haslo, Reset, Blokada, DataBlokady FROM Uzytkownik WHERE Login = @login";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool isBlocked = Convert.ToBoolean(reader["Blokada"]);
                            string storedPassword = reader["Haslo"].ToString();
                            bool mustReset = Convert.ToBoolean(reader["Reset"]);

                            if (isBlocked)
                            {
                                if (DateTime.TryParse(reader["DataBlokady"]?.ToString(), out DateTime blockTime))
                                {
                                    if ((DateTime.Now - blockTime).TotalMinutes < 1)
                                    {
                                        MessageBox.Show("Konto jest zablokowane. Spróbuj ponownie za minutę.", "Zablokowano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        loginAttempts[login] = 0;
                                        return;
                                    }
                                    else
                                    {
                                        string unblock = "UPDATE Uzytkownik SET Blokada = 0, DataBlokady = NULL WHERE Login = @login";
                                        using var unCmd = new SQLiteCommand(unblock, connection);
                                        unCmd.Parameters.AddWithValue("@login", login);
                                        unCmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            if (password == storedPassword)
                            {
                                loginAttempts[login] = 0;

                                if (mustReset)
                                {
                                    this.Hide();
                                    new ChangePasswordForm(connectionString, login, this).Show();
                                }
                                else
                                {
                                    this.Hide();
                                    new DataBase(this, login).Show();
                                }
                            }
                            else
                            {
                                if (!loginAttempts.ContainsKey(login))
                                    loginAttempts[login] = 0;

                                loginAttempts[login]++;

                                if (loginAttempts[login] >= 3)
                                {
                                    string blockQuery = "UPDATE Uzytkownik SET Blokada = 1, DataBlokady = @czas WHERE Login = @login";
                                    using var blockCmd = new SQLiteCommand(blockQuery, connection);
                                    blockCmd.Parameters.AddWithValue("@login", login);
                                    blockCmd.Parameters.AddWithValue("@czas", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                    blockCmd.ExecuteNonQuery();

                                    MessageBox.Show("Konto zostało zablokowane", "Zablokowano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show("Niepoprawne Dane Logowania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Niepoprawne Dane Logowania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void RemindPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemaindPasswordForm remindForm = new RemaindPasswordForm(this);
            remindForm.Show();
        }

        private void LoginExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }
    }
}
