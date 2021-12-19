using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtdelZasel
{
    public partial class CitizenWindow : Form
    {
        long ID_Citizen;
        public CitizenWindow(long ID)
        {
            InitializeComponent();
            ID_Citizen = ID;
        }

        private void button_send_petiton_Click(object sender, EventArgs e)
        {
            try
            {
                //Обязательный коннект
                Connection.getInstance().connection.Open();
                //SQL команда
                var sql = @"select * from createcheckinpetition(:text, :id_citizen)";
                //Подключние команды
                var cmd = new NpgsqlCommand(sql, Connection.getInstance().connection);

                //Параметры
                {
                    cmd.Parameters.AddWithValue("text", richTextBox_Petition.Text);
                    cmd.Parameters.AddWithValue("id_citizen", ID_Citizen);
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
    }
}
