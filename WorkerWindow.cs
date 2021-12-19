using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace OtdelZasel
{
    public partial class WorkerWindow : Form
    {
        public WorkerWindow(long ID)
        {
            InitializeComponent();
        }

        private void WorkerWindow_Load(object sender, EventArgs e)
        {
            try
            {
                //Обязательный коннект
                Connection.getInstance().connection.Open();
                //SQL команда
                var sql = @"select * from loginuser(:login, :password)";
                //Подключние команды
                var cmd = new NpgsqlCommand(sql, Connection.getInstance().connection);

                //Параметры
                {
                    //cmd.Parameters.AddWithValue("login", login.Text);
                    //cmd.Parameters.AddWithValue("password", password.Text);
                    cmd.Parameters.AddWithValue("login", "ivankod");
                    cmd.Parameters.AddWithValue("password", "qwe");
                }
                //Прочитать то что получили от БД
                //Примеры:
                //Для таблицы:
                //var auth = cmd.ExecuteReader();
                //auth.Read();
                //int role = (int)auth.GetValue(0);
                //long id = (long)auth.GetValue(1);
                var auth = cmd.ExecuteReader();
                auth.Read();
                int role = (int)auth.GetValue(0);
                long id = (long)auth.GetValue(1);
                Connection.getInstance().connection.Close();
                if (role == 1)
                {
                    // Application.Run(new WorkerWindow());
                }
                else if (role == 2)
                {
                    Form workerWindow = new WorkerWindow(id);
                    this.Hide();
                    workerWindow.ShowDialog();
                    this.Close();
                }
                else if (role == 3)
                {
                    Form citizenWindow = new CitizenWindow(id);
                    this.Hide();
                    citizenWindow.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                Connection.getInstance().connection.Close();
                MessageBox.Show("Auth fail. Error: " + ex.Message);
                throw;
            }
        }
    }
}