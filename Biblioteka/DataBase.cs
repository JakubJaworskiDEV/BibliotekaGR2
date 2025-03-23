using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class DataBase : Form
    {
        private string dbPath = @"..\..\..\..\BazaDanychProjekt.db";
        private string connectionString;

        public DataBase()
        {
            InitializeComponent();
            connectionString = $"Data Source={dbPath};Version=3;";
        }
        private void DataBase_Load(object sender, EventArgs e)
        {
            try
            {
                if (!System.IO.File.Exists(dbPath))
                {
                    SQLiteConnection.CreateFile(dbPath);
                    MessageBox.Show("Utworzono nową bazę danych.");
                }

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    
                    MessageBox.Show("Połączono z bazą danych!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsers(); // Załaduj użytkowników do DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia z bazą: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void LoadUsers()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Uzytkownik";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewUser.DataSource = dt; // Wyświetlenie danych w DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas pobierania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
