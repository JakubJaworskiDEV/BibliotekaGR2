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

namespace Biblioteka
{
    public partial class RemaindPasswordForm : Form
    {
        public RemaindPasswordForm()
        {
            InitializeComponent();
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

            // Dodaj przynajmniej jeden znak z każdej kategorii
            password.Append(upper[rnd.Next(upper.Length)]);
            password.Append(lower[rnd.Next(lower.Length)]);
            password.Append(digits[rnd.Next(digits.Length)]);
            password.Append(special[rnd.Next(special.Length)]);

            // Dodaj pozostałe znaki
            for (int i = password.Length; i < length; i++)
            {
                password.Append(allChars[rnd.Next(allChars.Length)]);
            }

            // Wymieszaj hasło
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
            string fromEmail = "twojemail@gmail.com";
            string fromPassword = "haslo_aplikacji";

            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromEmail);
                message.To.Add(recipientEmail);
                message.Subject = "Nowe hasło";
                message.Body = $"Twoje nowe hasło to: {newPassword}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);
                smtp.EnableSsl = true;
                smtp.Send(message);

                MessageBox.Show("Hasło zostało wysłane na e-mail.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wysyłania e-maila: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}