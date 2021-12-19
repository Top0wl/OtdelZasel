using Npgsql;
using System;
using System.Windows.Forms;

namespace OtdelZasel
{
    public partial class Registration : Form
    {
        public Registration()
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
                connection.Open();
                var sql = @"select * from createCitizen(:surname, :firstname, :lastname, :login, :password)";
                var cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("surname", Surname.Text);
                cmd.Parameters.AddWithValue("firstname", Name.Text);
                cmd.Parameters.AddWithValue("lastname", FatherName.Text);
                cmd.Parameters.AddWithValue("login", login.Text);
                cmd.Parameters.AddWithValue("password", password.Text);
                var answer = cmd.ExecuteReader();
                answer.Read();
                long idCitizen = (long)answer.GetValue(0);
                connection.Close();
                Form citizenWindow = new CitizenWindow(idCitizen);
                this.Hide();
                citizenWindow.Show();
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