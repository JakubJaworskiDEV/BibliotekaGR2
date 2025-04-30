using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class UsersWithPrivilegesForm : Form
    {
        private string connectionString;
        private List<string> privileges;
        public UsersWithPrivilegesForm(string connectionString, List<string> privileges)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.privileges = privileges;
            LoadUsersWithPrivileges();
        }

        private void LoadUsersWithPrivileges()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string privilegeSubquery = string.Join(",", privileges.Select(p => $"'{p}'"));
                    string query = $@"
                        SELECT u.Imie AS 'Imię', u.Nazwisko AS 'Nazwisko', u.Login AS 'Login', GROUP_CONCAT(up.Nazwa, ', ') AS 'Uprawnienia'
                        FROM Uzytkownik u
                        JOIN Uprawnienia_Uzytkownik uu ON u.Uzytkownik_id = uu.Uzytkownik_ID
                        JOIN Uprawnienia up ON uu.Uprawnienia_ID = up.Uprawnienia_ID
                        WHERE up.Nazwa IN ({privilegeSubquery}) AND u.Status_akt = 1
                        GROUP BY u.Uzytkownik_id
                        HAVING COUNT(DISTINCT up.Nazwa) = {privileges.Count};";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvUsers.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania użytkowników: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsrWPrivFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
