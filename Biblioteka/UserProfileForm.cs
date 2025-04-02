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
                lblUserID.Text = $"{row["Uzytkownik_id"]}";
                lblName.Text = $"{row["Imie"]}";
                lblSurname.Text = $"{row["Nazwisko"]}";
                lblUserPesel.Text = $"{row["PESEL"]}";
                lblUserAdrsID.Text = $"{row["Adres_id"]}";
                lblUserEmail.Text = $"{row["Email"]}";
                lblUserAdresPostalCode.Text = $"{row["Kod_pocztowy"]}";
                lblUserLogin.Text = $"{row["Login"]}";
                lblUserLogin.Text = $"{row["Miejscowosc"]}";
                lblUserPhoneNr.Text = $"{row["Nr_tel"]}";
                lblUserAdresStreet.Text = $"{row["Ulica"]}";
                lblUserAdresBldNr.Text = $"{row["Nr_posesji"]}";
                lblUserAdresFlatNr.Text = $"{row["Nr_lokalu"]}";
                if (Convert.ToInt32($"{row["Plec"]}") == 0)
                {
                    lblGender.Text = "Mężczyzna";
                }
                else { lblGender.Text = "Kobieta"; }
                lblUserStatus.Text = row["Status_akt"] != DBNull.Value && Convert.ToInt32(row["Status_akt"]) == 1 ? "Aktywny" : "Nieaktywny";
                lblUserStatus.ForeColor = row["Status_akt"] != DBNull.Value && Convert.ToInt32(row["Status_akt"]) == 1 ? Color.Green : Color.Red;
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
    }
}
