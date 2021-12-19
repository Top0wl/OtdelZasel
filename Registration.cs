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
                Connection.getInstance().connection.Close();
                MessageBox.Show("Не удалось зарегистрироваться. Error: " + ex.Message);
                throw;
            }
        }

    }
}