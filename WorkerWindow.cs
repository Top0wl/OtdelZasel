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

        long worker_id = 0;

        public WorkerWindow(long ID)
        {
            worker_id = ID;
            InitializeComponent();
        }

        protected void updateUnproccessedPetition()
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
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for(int j = 0; j < dt.Columns.Count; j++)
                    {
                        dt.Rows[i][j] = dt.Rows[i][j].ToString().Trim();
                    }
                }

                Connection.getInstance().connection.Close();
                dataGridView_Petitions.DataSource = null;
                dataGridView_Petitions.DataSource = dt;

                // скрою ID
                dataGridView_Petitions.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                Connection.getInstance().connection.Close();
                MessageBox.Show("Не удалось загрузить необработанные заявления: " + ex.Message);
                throw;
            }
        }


        private void WorkerWindow_Load(object sender, EventArgs e)
        {
            updateUnproccessedPetition();
        }

        private void tabControl_Petitions_Selecting(object sender, TabControlCancelEventArgs e)
        {
            updateUnproccessedPetition();
        }
    }
}