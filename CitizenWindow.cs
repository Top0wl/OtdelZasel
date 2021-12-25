﻿using Npgsql;
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
        // Подача заявления на заселение
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
                var petition = cmd.ExecuteScalar();
                Connection.getInstance().connection.Close();
                MessageBox.Show("Заявление на заселение успешно подано");
                richTextBox_Petition.Text = "";
            }
            catch (Exception ex)
            {
                Connection.getInstance().connection.Close();
                MessageBox.Show("Auth fail. Error: " + ex.Message);
                throw;
            }
        }
        // Подача заявления на выселение
        private void button_send_PetitonOut_Click(object sender, EventArgs e)
        {
            Connection.getInstance().connection.Open();
            //SQL команда
            var sql = @"select * from isLiving(:id_citizen)";
            //Подключние команды
            var cmd = new NpgsqlCommand(sql, Connection.getInstance().connection);
            cmd.Parameters.AddWithValue("id_citizen", ID_Citizen);
            bool have_citizen = Convert.ToBoolean(cmd.ExecuteScalar());
            Connection.getInstance().connection.Close();
            if (have_citizen)
            {
                try
                {
                    long id_leaving_reason = 0;
                    Connection.getInstance().connection.Open();
                    //SQL команда
                    sql = "select * from \"LeavingReason\"";
                    //Подключние команды
                    cmd = new NpgsqlCommand(sql, Connection.getInstance().connection);
                    var dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    foreach (DataRow row in dt.Rows)
                    {
                        if (comboBox_LeavingReason.Text == row[dt.Columns[1]].ToString().Trim())
                            id_leaving_reason = (long)row[dt.Columns[0]];
                    }
                    Connection.getInstance().connection.Close();

                    try
                    {
                        // Посмотреть вызов функции и передать параметр, который отвечает за причину выселения
                        //Обязательный коннект
                        Connection.getInstance().connection.Open();
                        //SQL команда
                        sql = @"select * from createcheckoutpetition(:text, :id_citizen, :id_leavingreason)";
                        //Подключние команды
                        cmd = new NpgsqlCommand(sql, Connection.getInstance().connection);

                        //Параметры
                        {
                            cmd.Parameters.AddWithValue("text", richTextBox_PetitonOut.Text);
                            cmd.Parameters.AddWithValue("id_citizen", ID_Citizen);
                            cmd.Parameters.AddWithValue("id_leavingreason", id_leaving_reason);
                        }
                        var petition = cmd.ExecuteScalar();
                        Connection.getInstance().connection.Close();
                        MessageBox.Show("Заявление на выселение успешно подано");
                        richTextBox_PetitonOut.Text = "";
                        comboBox_LeavingReason.Text = "";
                    }
                    catch (Exception ex)
                    {
                        Connection.getInstance().connection.Close();
                        MessageBox.Show("Auth fail. Error: " + ex.Message);
                        throw;
                    }
                }
                catch (Exception ex)
                {
                    Connection.getInstance().connection.Close();
                    MessageBox.Show("Не выбрана причина выселения");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("В данный момент вы не заселены");
            }
        }
        private void CitizenWindow_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.getInstance().connection.Open();
                //SQL команда
                var sql = "select * from \"LeavingReason\"";
                //Подключние команды
                var cmd = new NpgsqlCommand(sql, Connection.getInstance().connection);
                var dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                foreach (DataRow row in dt.Rows)
                {
                    string now_reason = row[dt.Columns[1]].ToString();
                    comboBox_LeavingReason.Items.Add(now_reason);
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

        private void button_pay_Click(object sender, EventArgs e)
        {
            try
            {
                //Обязательный коннект
                Connection.getInstance().connection.Open();
                //SQL команда
                var sql = @"select * from createpaymentnote(:sum::money, :id_citizen)";
                //Подключние команды
                var cmd = new NpgsqlCommand(sql, Connection.getInstance().connection);
                //Параметры
                {
                    cmd.Parameters.AddWithValue("sum", (long) numericUpDown_Sum.Value);
                    cmd.Parameters.AddWithValue("id_citizen", ID_Citizen);
                } 
                var pay = cmd.ExecuteScalar();
                Connection.getInstance().connection.Close();
                MessageBox.Show("Оплата совершена");
            }
            catch (Exception ex)
            {
                Connection.getInstance().connection.Close();
                MessageBox.Show("Pay fail. Error: " + ex.Message);
                throw;
            }
            Update_Balance();
        }

        private void Update_Balance()
        {
            try
            {
                //Обязательный коннект
                Connection.getInstance().connection.Open();
                //SQL команда
                var sql = @"select * from getbalance(:id_citizen)";
                //Подключние команды
                var cmd = new NpgsqlCommand(sql, Connection.getInstance().connection);
                //Параметры
                {
                    cmd.Parameters.AddWithValue("id_citizen", ID_Citizen);
                }
                var value = cmd.ExecuteScalar();
                float balance = (float)Convert.ToDouble(value) * -1;
                label_Balance2.Text = balance.ToString();
                Connection.getInstance().connection.Close();
            }
            catch (Exception ex)
            {
                Connection.getInstance().connection.Close();
                MessageBox.Show("Pay fail. Error: " + ex.Message);
                throw;
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            Update_Balance();
        }
    }
}
