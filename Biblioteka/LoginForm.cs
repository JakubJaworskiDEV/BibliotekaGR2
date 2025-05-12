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
                MessageBox.Show("Niepoprawne Dane Logowania");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Uzytkownik WHERE Login = @login AND Haslo = @password AND Status_akt = 1";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
                    {
                        Hide();
                        DataBase dataBaseForm = new DataBase();
                        dataBaseForm.FormClosed += (s, args) => Close();
                        dataBaseForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Niepoprawne Dane Logowania");
                    }
                }
            }
        }

        private void RemindPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemaindPasswordForm remindForm = new RemaindPasswordForm();
            remindForm.Show();
        }
    }
}
