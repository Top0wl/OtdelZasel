using Npgsql;
using System;
using System.Windows.Forms;

namespace OtdelZasel
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }
        private string connectstr = String.Format(
            "Server={0};" +
            "Port={1};" +
            "User Id={2};" +
            "Password={3};" +
            "Database={4};",
            "rds-postgresql-otdel-zasel.cguxtch14lq2.eu-west-2.rds.amazonaws.com",
            5432,
            "Nikolai",
            "kkjBB334HE3#4bh",
            "Check_In_Department");

        private NpgsqlConnection connection;


        private void signUp_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.getInstance().connection.Open();
                var sql = @"select * from createcitizen(:surname, :firstname, :lastname, :login, :password)";
                var cmd = new NpgsqlCommand(sql, Connection.getInstance().connection);
                cmd.Parameters.AddWithValue("surname", Surname.Text);
                cmd.Parameters.AddWithValue("firstname", NameTextBox.Text);
                cmd.Parameters.AddWithValue("lastname", FatherName.Text);
                cmd.Parameters.AddWithValue("login", login.Text);
                cmd.Parameters.AddWithValue("password", password.Text);
                var answer = cmd.ExecuteScalar();
                long idCitizen = (long)answer;
                Connection.getInstance().connection.Close();
                Form citizenWindow = new CitizenWindow(idCitizen);
                this.Hide();
                citizenWindow.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Не удалось зарегистрироваться. Error: " + ex.Message);
                throw;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(connectstr);
        }
    }
}