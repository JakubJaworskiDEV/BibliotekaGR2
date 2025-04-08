using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class AddUser : Form
    {
        private DataTable userData;
        private string connectionString;
        private PeselValidator peselValidator;

        public AddUser(DataTable userData, string connectionString)
        {
            InitializeComponent();
            this.userData = userData;
            this.connectionString = connectionString;
            this.peselValidator = new PeselValidator(userData);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string imie = txtImie.Text.Trim();
            string nazwisko = txtNazwisko.Text.Trim();
            string miejscowosc = txtMiejscowosc.Text.Trim();
            string kodPocztowy = txtKodPocztowy.Text.Trim();
            string numerPosesji = txtNumerPosesji.Text.Trim();
            string ulica = txtUlica.Text.Trim();
            string numerLokalu = txtNumerLokalu.Text.Trim();
            string pesel = txtPESEL.Text.Trim();
            string dataUrodzenia = dtpDataUrodzenia.Value.ToString("yyyy-MM-dd");
            string plec = cmbPlec.SelectedItem?.ToString();
            string email = txtEmail.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            bool aktywny = chkAktywny.Checked;
            string adres = txtAdres.Text.Trim();
            string statlog = txtstLog.Text.Trim();
            string rodzaj = txtRodzaj.Text.Trim();
            string ksiazka = txtKsiazka.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwisko) ||
                string.IsNullOrEmpty(miejscowosc) || string.IsNullOrEmpty(kodPocztowy) || string.IsNullOrEmpty(numerPosesji) ||
                string.IsNullOrEmpty(pesel) || string.IsNullOrEmpty(dataUrodzenia) || string.IsNullOrEmpty(plec) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Brak wymaganych pól.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Niepoprawny adres e-mail.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(telefon, @"^\d{9}$"))
            {
                MessageBox.Show("Niepoprawny numer telefonu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if (!peselValidator.ValidatePesel(pesel))
            //{
                //return;
            //}

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string checkEmailQuery = "SELECT COUNT(*) FROM Uzytkownik WHERE Email = @Email";
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkEmailQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Użytkownik o podanym e-mailu już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string checkPeselQuery = "SELECT COUNT(*) FROM Uzytkownik WHERE PESEL = @PESEL";
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkPeselQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@PESEL", pesel);
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Użytkownik o podanym numerze PESEL już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                try
                {
                    string insertUserQuery = @"
                        INSERT INTO Uzytkownik (Login, Imie, Nazwisko, PESEL, Data_ur, Plec, Email, Nr_tel, Status_log, Status_akt, Adres, Rodzaj, Ksiazka) 
                        VALUES (@Login, @Imie, @Nazwisko, @PESEL, @Data_ur, @Plec, @Email, @Nr_tel, @Status_log, @Status_akt, @Adres, @Rodzaj, @Ksiazka);
                        SELECT last_insert_rowid();";

                    long userId;
                    using (SQLiteCommand insertUserCmd = new SQLiteCommand(insertUserQuery, conn))
                    {
                        insertUserCmd.Parameters.AddWithValue("@Login", login);
                        insertUserCmd.Parameters.AddWithValue("@Imie", imie);
                        insertUserCmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                        insertUserCmd.Parameters.AddWithValue("@PESEL", pesel);
                        insertUserCmd.Parameters.AddWithValue("@Data_ur", dataUrodzenia);
                        insertUserCmd.Parameters.AddWithValue("@Plec", plec);
                        insertUserCmd.Parameters.AddWithValue("@Email", email);
                        insertUserCmd.Parameters.AddWithValue("@Nr_tel", telefon);
                        insertUserCmd.Parameters.AddWithValue("@Status_akt", aktywny ? 1 : 0);
                        insertUserCmd.Parameters.AddWithValue("@Status_log", statlog);
                        insertUserCmd.Parameters.AddWithValue("@Rodzaj", rodzaj);
                        insertUserCmd.Parameters.AddWithValue("@Ksiazka", ksiazka);
                        insertUserCmd.Parameters.AddWithValue("@Adres", adres);
                        userId = (long)insertUserCmd.ExecuteScalar();
                    }

                    long adresId;
                    string insertAdresQuery = @"
                        INSERT INTO Adres_zamieszkania (Miejscowosc, Kod_pocztowy, Ulica, Nr_posesji, Nr_lokalu) 
                        VALUES (@Miejscowosc, @Kod_pocztowy, @Ulica, @Nr_posesji, @Nr_lokalu);
                        SELECT last_insert_rowid();";

                    using (SQLiteCommand insertAdresCmd = new SQLiteCommand(insertAdresQuery, conn))
                    {
                        insertAdresCmd.Parameters.AddWithValue("@Miejscowosc", miejscowosc);
                        insertAdresCmd.Parameters.AddWithValue("@Kod_pocztowy", kodPocztowy);
                        insertAdresCmd.Parameters.AddWithValue("@Ulica", ulica);
                        insertAdresCmd.Parameters.AddWithValue("@Nr_posesji", numerPosesji);
                        insertAdresCmd.Parameters.AddWithValue("@Nr_lokalu", string.IsNullOrEmpty(numerLokalu) ? DBNull.Value : numerLokalu);

                        adresId = (long)insertAdresCmd.ExecuteScalar();
                    }

                    MessageBox.Show("Pomyślnie dodano użytkownika.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtLogin.Clear();
            txtImie.Clear();
            txtNazwisko.Clear();
            txtMiejscowosc.Clear();
            txtKodPocztowy.Clear();
            txtNumerPosesji.Clear();
            txtUlica.Clear();
            txtPESEL.Clear();
            txtEmail.Clear();
            txtTelefon.Clear();
            chkAktywny.Checked = true;
            cmbPlec.SelectedIndex = -1;
        }

        private void cmbPlec_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
