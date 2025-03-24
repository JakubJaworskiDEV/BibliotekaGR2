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
            LoadUserData(userData);
        }
        private void LoadUserData(DataTable userData)
        {
            if (userData.Rows.Count > 0) // sprawdzamy czy otrzymaliśmy przynajmniej 1 rekord z bazy
            {
                DataRow row = userData.Rows[0];
                lblName.Text = $"Imię: {row["Imie"]}";
                lblSurname.Text = $"Nazwisko: {row["Nazwisko"]}";
                lblLogin.Text = $"Login: {row["Login"]}";
                lblPesel.Text = $"PESEL: {row["PESEL"]}";
                lblEmail.Text = $"Email: {row["Email"]}";
                lblPhone.Text = $"Telefon: {row["Nr_tel"]}";
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
    }
}
