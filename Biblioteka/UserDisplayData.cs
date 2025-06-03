using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Biblioteka
{
    public partial class UserDisplayData : Form
    {

        private DataTable userData;
        private string connectionString;
        private Form parentform;

        public UserDisplayData(DataTable userData, string connectionString, Form parentForm)
        {
            InitializeComponent();

            this.userData = userData;
            this.connectionString = connectionString;
            this.parentform = parentForm;
            LoadUserData();

        }

        private void LoadUserData()
        {
            if (userData.Rows.Count > 0)
            {
                DataRow row = userData.Rows[0];
                txtLogin.Text = row["Login"].ToString();
                txtName.Text = row["Imie"].ToString();
                txtSurname.Text = row["Nazwisko"].ToString();
                txtPlace.Text = row["Miejscowosc"].ToString();
                txtPostalCode.Text = row["Kod_pocztowy"].ToString();
                txtStreet.Text = row["Ulica"].ToString();
                txtBldNr.Text = row["Nr_posesji"].ToString();
                txtFlatNr.Text = row["Nr_lokalu"].ToString();
                txtPesel.Text = row["PESEL"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtPhone.Text = row["Nr_tel"].ToString();
                txtGender.Text = Convert.ToInt32(row["Plec"]) == 0 ? "Mężczyzna" : "Kobieta";
                
                if (DateTime.TryParse(row["Data_ur"].ToString(), out DateTime birthDate))
                    dtpBirthDate.Value = birthDate;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parentform.Show();
        }

        private void btnMenagePassword_Click(object sender, EventArgs e)
        {
            string userLogin = txtLogin.Text;

            if (string.IsNullOrEmpty(userLogin))
            {
                MessageBox.Show("Nie można określić użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(connectionString, userLogin, this);
            this.Hide();
            changePasswordForm.ShowDialog();

            if (changePasswordForm.ShouldLogout)
            {
                this.Close(); // zamyka UserDisplayData
                parentform.Close(); // zamyka DataBase
                LoginForm loginForm = new LoginForm();
                loginForm.Show(); // pokazuje ekran logowania
            }

        }
    }
}
