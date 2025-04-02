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
using System.Xml.Linq;

namespace Biblioteka
{
    public partial class EditUserDataForm : Form
    {
        private string connectionString;
        private DataRow userRow;
        private UserProfileForm userProfileForm;
        public EditUserDataForm(DataTable userData, string connectionString, UserProfileForm userProfileForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.userProfileForm = userProfileForm;
            if (userData.Rows.Count > 0)
            {
                userRow = userData.Rows[0];
                LoadUserData();

            }
        }
        private void LoadUserData()
        {
            txtEditName.Text = userRow["Imie"].ToString();
            txtEditSurname.Text = userRow["Nazwisko"].ToString();
            txtEditPesel.Text = userRow["PESEL"].ToString();
            txtEditEmail.Text = userRow["Email"].ToString();
            txtEditBirthDate.Text = userRow["Data_ur"].ToString();
            txtEditPhone.Text = userRow["Nr_tel"].ToString();
            txtEditPlace.Text = userRow["Miejscowosc"].ToString();
            txtPostalCode.Text = userRow["Kod_pocztowy"].ToString();
            txtStreet.Text = userRow["Ulica"].ToString();
            txtBldNumber.Text = userRow["Nr_posesji"].ToString();
            txtFlatNumber.Text = userRow["Nr_lokalu"].ToString();
            cmbEditGender.SelectedItem = Convert.ToInt32(userRow["Plec"]) == 0 ? "Mężczyzna" : "Kobieta";
        }

        private void btnSaveEditUserData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    UPDATE Uzytkownik 
                    SET Imie = @Imie, Nazwisko = @Nazwisko, PESEL = @PESEL, Email = @Email, Data_ur = @Data_ur, Plec = @Plec, Nr_tel = @Nr_tel 
                    WHERE Login = @Login;
                    
                    UPDATE Adres_zamieszkania 
                    SET Miejscowosc = @Miejscowosc, Kod_pocztowy = @Kod_pocztowy, Ulica = @Ulica, Nr_posesji = @Nr_posesji, Nr_lokalu = @Nr_lokalu
                    WHERE Adres_id = @Adres_id";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        if (string.IsNullOrEmpty(txtEditName.Text) || string.IsNullOrEmpty(txtEditSurname.Text)
                            || string.IsNullOrEmpty(txtEditPesel.Text) || string.IsNullOrEmpty(txtEditEmail.Text)
                            || string.IsNullOrEmpty(txtEditBirthDate.Text) || string.IsNullOrEmpty(txtEditPhone.Text)
                            || string.IsNullOrEmpty(txtEditPlace.Text) || string.IsNullOrEmpty(txtPostalCode.Text)
                            || string.IsNullOrEmpty(txtStreet.Text) || string.IsNullOrEmpty(txtBldNumber.Text)
                            || string.IsNullOrEmpty(txtFlatNumber.Text))
                        {
                            MessageBox.Show("Wprowadź wszytkie dane do zapisu", "Błąd wprowadzania", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else if (!IsValidEmail(txtEditEmail.Text))
                        {
                            MessageBox.Show("Podany email jest nieprawidłowy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        else if (!IsValidPhone(txtEditPhone.Text))
                        {
                            MessageBox.Show("Podany numer telefonu jest nieprawidłowy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        else if (!IsValidPesel(txtEditPesel.Text))
                        {
                            MessageBox.Show("Podany PESEL jest nieprawidłowy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (!IsUnique("PESEL", txtEditPesel.Text))
                        {
                            MessageBox.Show("Podany PESEL już istnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (!IsUnique("Email", txtEditEmail.Text))
                        {
                            MessageBox.Show("Podany email już istnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (!IsUnique("Nr_tel", txtEditPhone.Text))
                        {
                            MessageBox.Show("Podany numer telefonu już istnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (txtEditPesel.Text.Length != 11)
                        {
                            MessageBox.Show("Wprowadź poprawny numer PESEL", "Błąd wpprowadzania", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            command.Parameters.AddWithValue("@Imie", txtEditName.Text);
                            command.Parameters.AddWithValue("@Nazwisko", txtEditSurname.Text);
                            command.Parameters.AddWithValue("@PESEL", txtEditPesel.Text);
                            command.Parameters.AddWithValue("@Email", txtEditEmail.Text);
                            command.Parameters.AddWithValue("@Data_ur", txtEditBirthDate.Text);
                            command.Parameters.AddWithValue("@Plec", cmbEditGender.SelectedItem.ToString() == "Mężczyzna" ? 0 : 1);
                            command.Parameters.AddWithValue("@Nr_tel", txtEditPhone.Text);
                            command.Parameters.AddWithValue("@Miejscowosc", txtEditPlace.Text);
                            command.Parameters.AddWithValue("@Kod_pocztowy", txtPostalCode.Text);
                            command.Parameters.AddWithValue("@Ulica", txtStreet.Text);
                            command.Parameters.AddWithValue("@Nr_posesji", txtBldNumber.Text);
                            command.Parameters.AddWithValue("@Nr_lokalu", txtFlatNumber.Text);
                            command.Parameters.AddWithValue("@Login", userRow["Login"].ToString());
                            command.Parameters.AddWithValue("@Adres_id", userRow["Adres_id"]);
                            command.ExecuteNonQuery();
                        }
                    }

                }
                MessageBox.Show("Dane użytkownika zostały zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                userProfileForm.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas aktualizacji danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsUnique(string column, string value)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM Uzytkownik WHERE {column} = @value AND Login != @Login";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@value", value);
                        command.Parameters.AddWithValue("@Login", userRow["Login"].ToString());
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count == 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas sprawdzania unikalności danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPhone(string phone)
        {
            var phonePattern = @"^\d{9,15}$"; // Zakładając, że numer telefonu ma od 9 do 15 cyfr
            return System.Text.RegularExpressions.Regex.IsMatch(phone, phonePattern);
        }

        private bool IsValidPesel(string pesel)
        {
            var peselPattern = @"^\d{11}$"; // PESEL powinien mieć dokładnie 11 cyfr
            return System.Text.RegularExpressions.Regex.IsMatch(pesel, peselPattern);
        }
        private void EditUserDataForm_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Uzytkownik SET Status = 0 WHERE Login = @Login";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", userRow["Login"].ToString());
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Użytkownik został oznaczony jako nieaktywny.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                userProfileForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas aktualizacji statusu użytkownika: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
