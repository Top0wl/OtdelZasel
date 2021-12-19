using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Windows.Forms;
using Npgsql;

namespace OtdelZasel
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            
        }

        private void Auth_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.getInstance().connection.Open();
                var sql = @"select * from loginuser(:login, :password)";
                var cmd = new NpgsqlCommand(sql, Connection.getInstance().connection);
                //cmd.Parameters.AddWithValue("login", login.Text);
                //cmd.Parameters.AddWithValue("password", password.Text);
                cmd.Parameters.AddWithValue("login", "ivankod");
                cmd.Parameters.AddWithValue("password", "qwe");
                var auth = cmd.ExecuteReader();
                auth.Read();
                int role = (int)auth.GetValue(0);
                long id = (long)auth.GetValue(1);
                if (role == 1)
                {
                   // Application.Run(new WorkerWindow());
                }
                else if (role == 2)
                {
                    Form workerWindow = new WorkerWindow(id);
                    this.Hide();
                    workerWindow.Show();
                }
                else if (role == 3)
                {
                    Form citizenWindow = new CitizenWindow(id);
                    this.Hide();
                    citizenWindow.Show();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
                Connection.getInstance().connection.Close();
            }
            catch (Exception ex)
            {
                Connection.getInstance().connection.Close();
                MessageBox.Show("Auth fail. Error: " + ex.Message);
                throw;
            }
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            Form registrationWindow = new Registration();
            this.Hide();
            registrationWindow.Show();
        }
    }
}