using Microsoft.VisualBasic.Logging;
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

    public partial class EditUserPasswordForm : Form
    {
        private string connectionString;
        private string userLogin;
        private DataTable userData;
        public EditUserPasswordForm(string connectionString, string login, DataTable userData)
        {
            InitializeComponent();
            
            
            this.connectionString = connectionString;
            this.userLogin = login;
            this.userData = userData;
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

        private void BtnSaveUserPassword_Click(object sender, EventArgs e)
        {

            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

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
            var result = MessageBox.Show
                ("Czy na pewno chcesz zaktualizować hasło?","Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Uzytkownik SET Haslo = @password WHERE Login = @login";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@password", newPassword); // Można dodać hashowanie
                        command.Parameters.AddWithValue("@login", userLogin);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Hasło zostało zaktualizowane.");
                this.Close();
                
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas aktualizacji hasła: {ex.Message}");
            }

       
            
        }

        private void BtnBackToEditData_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfileForm profileForm = new UserProfileForm(userData, connectionString);
            profileForm.Show();
            this.Close();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
