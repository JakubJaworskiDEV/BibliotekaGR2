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

        public EditUserDataForm(DataTable userData, string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
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
            txtEditGender.Text = userRow["Plec"].ToString();
            txtEditPhone.Text = userRow["Nr_tel"].ToString();
            txtEditAddress.Text = userRow["Adres"].ToString();
        }

        private void btnSaveEditUserData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Uzytkownik SET Imie = @Imie, Nazwisko = @Nazwisko, PESEL = @PESEL, Email = @Email, Data_ur = @Data_ur, Plec = @Plec, Nr_tel = @Nr_tel, Adres = @Adres WHERE Login = @Login";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Imie", txtEditName.Text);
                        command.Parameters.AddWithValue("@Nazwisko", txtEditSurname.Text);
                        command.Parameters.AddWithValue("@PESEL", txtEditPesel.Text);
                        command.Parameters.AddWithValue("@Email", txtEditEmail.Text);
                        command.Parameters.AddWithValue("@Data_ur", txtEditBirthDate.Text);
                        command.Parameters.AddWithValue("@Plec", txtEditGender.Text);
                        command.Parameters.AddWithValue("@Nr_tel", txtEditPhone.Text);
                        command.Parameters.AddWithValue("@Adres", txtEditAddress.Text);
                        command.Parameters.AddWithValue("@Login", userRow["Login"].ToString());
                        /// dodać tutaj: 
                        /// sprawdzanie pooprawnoći danych z ramek
                        /// czy wpisane są jakiekolwiek dane i wyświetlenie komunikatu
                        /// chcemy widzieć id ale nie edytować
                        /// idotoodporne 
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Dane użytkownika zostały zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas aktualizacji danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditUserDataForm_Load(object sender, EventArgs e)
        {


        }


        

    }
}
