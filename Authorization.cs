using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Windows.Forms;
using Npgsql;

namespace OtdelZasel
{
    public partial class Authorization : Form
    {
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


        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(connectstr);
        }

        private void Select()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                var sql = @"select * from loginuser(:login, :password)";
                var cmd = new NpgsqlCommand(sql,connection);
                cmd.Parameters.AddWithValue("login", login.Text);
                cmd.Parameters.AddWithValue("password", password.Text);
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
                connection.Close();

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Auth fail. Error: " + ex.Message);
                throw;
            }
        }
    }
}