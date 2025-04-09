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
        private PeselValidator peselValidator;

        public EditUserDataForm(DataTable userData, string connectionString, UserProfileForm userProfileForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.userProfileForm = userProfileForm;

            if (userData.Rows.Count > 0)
            {
                userRow = userData.Rows[0];
                this.peselValidator = new PeselValidator(userData, userRow["Login"].ToString());
                LoadUserData();
            }
            else
            {
                MessageBox.Show("Błąd podczas ładowania danych. Nie znaleziono danych użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserData()
        {
            DateTime parsedDate;
            txtEditName.Text = userRow["Imie"].ToString();
            txtEditSurname.Text = userRow["Nazwisko"].ToString();
            txtEditPesel.Text = userRow["PESEL"].ToString();
            txtEditEmail.Text = userRow["Email"].ToString();
            dtpEditBirthDate.Value = ParseDateFromData(userRow["Data_ur"].ToString());
            txtEditPhone.Text = userRow["Nr_tel"].ToString();
            txtEditPlace.Text = userRow["Miejscowosc"].ToString();
            txtPostalCode.Text = userRow["Kod_pocztowy"].ToString();
            txtStreet.Text = userRow["Ulica"].ToString();
            txtBldNumber.Text = userRow["Nr_posesji"].ToString();
            txtFlatNumber.Text = userRow["Nr_lokalu"].ToString();
            cmbEditGender.SelectedItem = Convert.ToInt32(userRow["Plec"]) == 0 ? "Mężczyzna" : "Kobieta";
        }
        private string HashData(string input)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input));
        }
        private DateTime ParseDateFromData(string dateString)
        {
            DateTime parsedDate;

            if (DateTime.TryParseExact(
                    dateString,
                    "dd.MM.yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out parsedDate))
            {
                return parsedDate;
            }
            else
            {
                MessageBox.Show("Nie udało się sparsować daty z bazy: " + dateString, "Błąd formatu daty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return DateTime.Today;
            }
        }
        private bool HasUserChangedData()
        {
            return
                txtEditName.Text.Trim() != userRow["Imie"].ToString().Trim() ||
                txtEditSurname.Text.Trim() != userRow["Nazwisko"].ToString().Trim() ||
                txtEditPesel.Text.Trim() != userRow["PESEL"].ToString().Trim() ||
                txtEditEmail.Text.Trim().ToLower() != userRow["Email"].ToString().Trim().ToLower() ||
                dtpEditBirthDate.Value.ToString("dd.MM.yyyy") != userRow["Data_ur"].ToString() ||
                txtEditPhone.Text.Trim() != userRow["Nr_tel"].ToString().Trim() ||
                txtEditPlace.Text.Trim() != userRow["Miejscowosc"].ToString().Trim() ||
                txtPostalCode.Text.Trim() != userRow["Kod_pocztowy"].ToString().Trim() ||
                txtStreet.Text.Trim() != userRow["Ulica"].ToString().Trim() ||
                txtBldNumber.Text.Trim() != userRow["Nr_posesji"].ToString().Trim() ||
                txtFlatNumber.Text.Trim() != userRow["Nr_lokalu"].ToString().Trim() ||
                (cmbEditGender.SelectedItem.ToString() == "Mężczyzna" ? 0 : 1) != Convert.ToInt32(userRow["Plec"]);
        }
        private void btnSaveEditUserData_Click(object sender, EventArgs e)
        {
            if (!HasUserChangedData())
            {
                MessageBox.Show("Nie wykryto zmian w danych.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var result = MessageBox.Show("Czy na pewno chcesz zaktualizować dane użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            // Proceed with validation only if data has changed
            if (string.IsNullOrEmpty(txtEditName.Text) ||
                    string.IsNullOrEmpty(txtEditSurname.Text) ||
                    string.IsNullOrEmpty(txtEditPesel.Text) ||
                    string.IsNullOrEmpty(txtEditEmail.Text) ||
                    string.IsNullOrEmpty(dtpEditBirthDate.Text) ||
                    string.IsNullOrEmpty(txtEditPhone.Text) ||
                    string.IsNullOrEmpty(txtEditPlace.Text) ||
                    string.IsNullOrEmpty(txtPostalCode.Text) ||
                    string.IsNullOrEmpty(txtStreet.Text) ||
                    string.IsNullOrEmpty(txtBldNumber.Text) ||
                    string.IsNullOrEmpty(txtFlatNumber.Text))
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
            if (dtpEditBirthDate.Value > DateTime.Now)
            {
                MessageBox.Show("Data urodzenia nie może być z przyszłości.");
                return;
            }

            if (!peselValidator.ValidatePesel(txtEditPesel.Text.Trim()))
            {
                return;
            }

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
                        command.Parameters.AddWithValue("@Imie", txtEditName.Text);
                        command.Parameters.AddWithValue("@Nazwisko", txtEditSurname.Text);
                        command.Parameters.AddWithValue("@PESEL", txtEditPesel.Text);
                        command.Parameters.AddWithValue("@Email", txtEditEmail.Text);
                        command.Parameters.AddWithValue("@Data_ur", dtpEditBirthDate.Value.ToString("dd.MM.yyyy"));
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
            var phonePattern = @"^\d{9,15}$"; // numer telefonu ma od 9 do 15 cyfr
            return System.Text.RegularExpressions.Regex.IsMatch(phone, phonePattern);
        }

        private void EditUserDataForm_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnForgetUser_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz zapomnieć użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
        UPDATE Uzytkownik 
        SET Status_akt = 0,
            Imie = @Imie,
            Nazwisko = @Nazwisko,
            PESEL = @PESEL,
            Email = @Email,
            Data_ur = @Data_ur,
            Nr_tel = @Nr_tel
        WHERE Login = @LoginCurrent;

        UPDATE Adres_zamieszkania 
        SET Miejscowosc = @Miejscowosc,
            Kod_pocztowy = @Kod_pocztowy,
            Ulica = @Ulica,
            Nr_posesji = @Nr_posesji,
            Nr_lokalu = @Nr_lokalu
        WHERE Adres_id IN (SELECT Adres FROM Uzytkownik WHERE Login = @LoginCurrent);";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        string loginCurrent = userRow["Login"].ToString();

                        // Parametr do WHERE
                        command.Parameters.AddWithValue("@LoginCurrent", loginCurrent);

                        // Hashowane dane użytkownika
                        command.Parameters.AddWithValue("@Imie", HashData(userRow["Imie"].ToString()));
                        command.Parameters.AddWithValue("@Nazwisko", HashData(userRow["Nazwisko"].ToString()));
                        command.Parameters.AddWithValue("@PESEL", HashData(userRow["PESEL"].ToString()));
                        command.Parameters.AddWithValue("@Email", HashData(userRow["Email"].ToString()));
                        command.Parameters.AddWithValue("@Data_ur", HashData(userRow["Data_ur"].ToString()));
                        command.Parameters.AddWithValue("@Nr_tel", HashData(userRow["Nr_tel"].ToString()));

                        // Hashowane dane adresowe
                        command.Parameters.AddWithValue("@Miejscowosc", HashData(userRow["Miejscowosc"].ToString()));
                        command.Parameters.AddWithValue("@Kod_pocztowy", HashData(userRow["Kod_pocztowy"].ToString()));
                        command.Parameters.AddWithValue("@Ulica", HashData(userRow["Ulica"].ToString()));
                        command.Parameters.AddWithValue("@Nr_posesji", HashData(userRow["Nr_posesji"].ToString()));
                        command.Parameters.AddWithValue("@Nr_lokalu", HashData(userRow["Nr_lokalu"].ToString()));

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Użytkownik został zapomniany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                userProfileForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapominania użytkownika.: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}
