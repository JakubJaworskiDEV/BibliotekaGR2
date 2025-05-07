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

        private void LoadUsersWithPrivileges(string additionalCondition = "", List<SQLiteParameter> parameters = null)
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
                        WHERE up.Nazwa IN ({privilegeSubquery}) AND u.Status_akt = 1 {additionalCondition}
                        GROUP BY u.Uzytkownik_id
                        HAVING COUNT(DISTINCT up.Nazwa) = {privileges.Count};";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        if (parameters != null)
                            command.Parameters.AddRange(parameters.ToArray());

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvUsers.DataSource = dt;
                        }
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

        private void btnSearchWithPrivileges_Click(object sender, EventArgs e)
        {
            List<string> conditions = new List<string>();
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();

            if (chkNamePriv.Checked && !string.IsNullOrWhiteSpace(txtNamePriv.Text))
            {
                conditions.Add("AND u.Imie LIKE @name");
                parameters.Add(new SQLiteParameter("@name", "%" + txtNamePriv.Text + "%"));
            }
            if (chkSurnamePriv.Checked && !string.IsNullOrWhiteSpace(txtSurnamePriv.Text))
            {
                conditions.Add("AND u.Nazwisko LIKE @surname");
                parameters.Add(new SQLiteParameter("@surname", "%" + txtSurnamePriv.Text + "%"));
            }
            if (chkLoginPriv.Checked && !string.IsNullOrWhiteSpace(txtLoginPriv.Text))
            {
                conditions.Add("AND u.Login LIKE @login");
                parameters.Add(new SQLiteParameter("@login", "%" + txtLoginPriv.Text + "%"));
            }

            string conditionClause = string.Join(" ", conditions);
            LoadUsersWithPrivileges(conditionClause, parameters);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkNamePriv_CheckedChanged(object sender, EventArgs e)
        {
            txtNamePriv.Visible = chkNamePriv.Checked;
            if (!chkNamePriv.Checked) txtNamePriv.Clear();
        }

        private void chkSurnamePriv_CheckedChanged(object sender, EventArgs e)
        {
            txtSurnamePriv.Visible = chkSurnamePriv.Checked;
            if (!chkSurnamePriv.Checked) txtSurnamePriv.Clear();
        }

        private void chkLoginPriv_CheckedChanged(object sender, EventArgs e)
        {
            txtLoginPriv.Visible = chkLoginPriv.Checked;
            if (!chkLoginPriv.Checked) txtLoginPriv.Clear();
        }

        private void btnResetPrivSearch_Click(object sender, EventArgs e)
        {
            txtNamePriv.Text = "";
            txtSurnamePriv.Text = "";
            txtLoginPriv.Text = "";
            chkNamePriv.Checked = false;
            chkSurnamePriv.Checked = false;
            chkLoginPriv.Checked = false;
            LoadUsersWithPrivileges();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
