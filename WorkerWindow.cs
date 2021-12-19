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
                var sql = @"select * from UnProcessedPetitions;";
                //Подключние команды
                var cmd = new NpgsqlCommand(sql, Connection.getInstance().connection);
                var dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                Connection.getInstance().connection.Close();
                dataGridView_Petitions.DataSource = null;
                dataGridView_Petitions.DataSource = dt;
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