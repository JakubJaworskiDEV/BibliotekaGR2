using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class UserProfileForm : Form
    {
        public UserProfileForm(DataTable userData)
        {
            InitializeComponent();
            this.userData = userData;
            this.connectionString = connectionString;
            LoadUserData(userData);
        }
        private void LoadUserData(DataTable userData)
        {
            if (userData.Rows.Count > 0) // sprawdzamy czy otrzymaliśmy przynajmniej 1 rekord z bazy
            {
                DataRow row = userData.Rows[0];
                txtName.Text = $"{row["Imie"]}";
                txtSurname.Text = $"{row["Nazwisko"]}";
                txtPesel.Text = $"{row["PESEL"]}";
                txtEmail.Text = $"{row["Email"]}";
                txtPostalCode.Text = $"{row["Kod_pocztowy"]}";
                txtLogin.Text = $"{row["Login"]}";
                txtPlace.Text = $"{row["Miejscowosc"]}";
                txtPhoneNr.Text = $"{row["Nr_tel"]}";
                txtStreetName.Text = $"{row["Ulica"]}";
                txtBldNr.Text = $"{row["Nr_posesji"]}";
                txtFlatNr.Text = $"{row["Nr_lokalu"]}";
                if (Convert.ToInt32($"{row["Plec"]}") == 0)
                {
                    txtGender.Text = "Mężczyzna";
                }
                else { txtGender.Text = "Kobieta"; }

            }
        }
        private DataTable userData;
        private string connectionString;

        public UserProfileForm(DataTable userData, string connectionString)
        {
            InitializeComponent();
            this.userData = userData;
            this.connectionString = connectionString;
            LoadUserData(userData);
        }


        private void UserProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEditUserData_Click(object sender, EventArgs e)
        {

            EditUserDataForm editForm = new EditUserDataForm(userData, connectionString, this);
            editForm.Show();
        }

        private void btnBackToList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUserEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
