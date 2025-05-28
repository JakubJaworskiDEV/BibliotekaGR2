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
                string query = "SELECT Haslo, Reset FROM Uzytkownik WHERE Login = @login";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader["Haslo"].ToString();
                            bool mustReset = Convert.ToBoolean(reader["Reset"]);

                            if (password == storedPassword)
                            {
                                if (mustReset)
                                {
                                    this.Hide();
                                    ChangePasswordForm changePasswordForm = new ChangePasswordForm(connectionString, login, loginForm);
                                    changePasswordForm.Show();
                                }
                                else
                                {
                                    this.Hide();
                                    DataBase dbForm = new DataBase(this);
                                    dbForm.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nieprawidłowe hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
