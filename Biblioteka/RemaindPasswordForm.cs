using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Biblioteka
{
    public partial class RemaindPasswordForm : Form
    {

        
        private string connectionString = "Data Source=..\\..\\..\\..\\BazaDanychProjekt.db;Version=3;";
        private Form loginForm;
        public RemaindPasswordForm(Form loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private string GenerateSecurePassword(int length = 12)
        {
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string special = "!@#$%^&*()-_=+[]{};:<>/?";

            string allChars = upper + lower + digits + special;
            StringBuilder password = new StringBuilder();
            Random rnd = new Random();

            password.Append(upper[rnd.Next(upper.Length)]);
            password.Append(lower[rnd.Next(lower.Length)]);
            password.Append(digits[rnd.Next(digits.Length)]);
            password.Append(special[rnd.Next(special.Length)]);

            for (int i = password.Length; i < length; i++)
            {
                password.Append(allChars[rnd.Next(allChars.Length)]);
            }

            return Shuffle(password.ToString(), rnd);
        }

        private string Shuffle(string input, Random rnd)
        {
            char[] array = input.ToCharArray();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (array[i], array[j]) = (array[j], array[i]);
            }
            return new string(array);
        }


        private void SendPasswordToEmail(string recipientEmail, string newPassword)
        {
            string fromEmail = "no-reply@yourapp.local";
            string smtpHost = "sandbox.smtp.mailtrap.io";
            int smtpPort = 587;
            string smtpUsername = "b0b6c59255e62c"; // username z mailtrapa
            string smtpPassword = "8ae9ca0f9bbb35";  // password z mailtrapa

            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromEmail);
                message.To.Add(recipientEmail);
                message.Subject = "Nowe hasło";
                message.Body = $"Twoje nowe hasło to: {newPassword}";

                SmtpClient smtp = new SmtpClient(smtpHost, smtpPort);
                smtp.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtp.EnableSsl = true;
                smtp.Send(message);

                MessageBox.Show("Hasło zostało wysłane na e-mail.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wysyłania e-maila: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = LoginRemind.Text.Trim();
            string email = EmailPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Niepoprawne Dane Logowania");
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Uzytkownik_id FROM Uzytkownik WHERE Login = @login AND Email = @mail";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@mail", email);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string newPassword = GenerateSecurePassword();

                            string updateQuery = "UPDATE Uzytkownik SET Haslo = @haslo, Reset = 1 WHERE Login = @login";
                            using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@haslo", newPassword);
                                updateCmd.Parameters.AddWithValue("@login", login);
                                updateCmd.ExecuteNonQuery();
                            }

                            SendPasswordToEmail(email, newPassword);
                        }
                        else
                        {
                            MessageBox.Show("Niepoprawne Dane Logowania");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void ExitButtonRemindPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}