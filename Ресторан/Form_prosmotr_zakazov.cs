using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class Form_prosmotr_zakazov : Form
    {
        public Form_prosmotr_zakazov()
        {
            InitializeComponent(); 
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Form_load();
        }
        string connectString = "server=localhost;user=root;password=;database=restaurant;charset=utf8;";
        int Kod_stola;
        string status;
        public static int Kod_oplati,Summa;
        public static bool tumb = false;
        private void Form_load()
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);

            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM открытые_заказы", myConnection);
            List<string[]> data = new List<string[]>();
            List<string> kods_zakazov = new List<string>();
            List<string> kods_oplat = new List<string>();
            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    data.Add(new string[3]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();
                    //заполняем лист кодами заказов
                    kods_zakazov.Add(sqlReader[0].ToString());
                    //заполняем лист кодами оплаты
                    kods_oplat.Add(sqlReader[2].ToString());
                }
                foreach (string[] s in data) dataGridView1.Rows.Add(s);
            }
            myConnection.Close();

            int i = 0;
            foreach (string s in kods_oplat)
            {
                myConnection.Open();
                command = new MySqlCommand("SELECT `Форма_оплаты`, `Статус` FROM `оплата` WHERE `Код_оплаты`=@Код_оплаты", myConnection);
                command.Parameters.AddWithValue("@Код_оплаты", s);

                sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        dataGridView1[2, i].Value = sqlReader[0].ToString();
                        dataGridView1[3, i].Value = sqlReader[1].ToString();

                    }
                }
                i++;
                myConnection.Close();
            }


            string nasvaniye_bluda = "";
            i = 0;
            List<string[]> kods_blud = new List<string[]>();
            foreach (string s in kods_zakazov)
            {
                myConnection.Open();
                command = new MySqlCommand("SELECT `Код_блюда`,`Количество_порций` FROM `строка_заказа` WHERE `Код_заказа` = @Код_заказа", myConnection);
                command.Parameters.AddWithValue("@Код_заказа", s);

                sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        kods_blud.Add(new string[2]);

                        kods_blud[kods_blud.Count - 1][0] = sqlReader[0].ToString();
                        kods_blud[kods_blud.Count - 1][1] = sqlReader[1].ToString();
                    }
                }
                myConnection.Close();


                foreach (string[] s1 in kods_blud)
                {
                    myConnection.Open();
                    command = new MySqlCommand("SELECT `Название_блюда` FROM `меню` WHERE `Код_блюда`=@Код_блюда", myConnection);
                    command.Parameters.AddWithValue("@Код_блюда", s1[0]);

                    sqlReader = command.ExecuteReader();
                    {
                        while (sqlReader.Read())
                        {
                            nasvaniye_bluda += sqlReader[0].ToString()+", "+ s1[1] +" шт" + "\n";
                            dataGridView1[4, i].Value = nasvaniye_bluda;
                        }
                    }
                    myConnection.Close();
                }
                kods_blud.Clear();
                int ind = nasvaniye_bluda.Length - 1;
                nasvaniye_bluda = nasvaniye_bluda.Remove(ind);
                dataGridView1[4, i].Value = nasvaniye_bluda;
                nasvaniye_bluda = "";

                i++;
            }
        }

        //Удаление заказа
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);

            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT `Код_оплаты` FROM `открытые_заказы` WHERE `Код_заказа` = @Код_заказа", myConnection);
            command.Parameters.AddWithValue("@Код_заказа", textBox1.Text);
            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    Kod_oplati = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();

            myConnection.Open();
            command = new MySqlCommand("SELECT `Статус` FROM `оплата` WHERE `Код_оплаты` = @Код_оплаты", myConnection);
            command.Parameters.AddWithValue("@Код_оплаты", Kod_oplati);
            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    status = sqlReader["Статус"].ToString();
                }
            }
            myConnection.Close();
            if (status == "оплачено")
            {
                myConnection.Open();
                command = new MySqlCommand("SELECT `Код_стола` FROM `открытые_заказы` WHERE `Код_заказа`=@Код_заказа", myConnection);
                command.Parameters.AddWithValue("@Код_заказа", textBox1.Text);
                sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        Kod_stola = sqlReader.GetInt32(0);
                    }
                }
                myConnection.Close();

                myConnection.Open();
                command = new MySqlCommand("UPDATE `столы` SET `статус`='0' WHERE `Код_стола`=@Код_стола", myConnection);
                command.Parameters.AddWithValue("@Код_стола", Kod_stola);
                command.ExecuteNonQuery();
                myConnection.Close();

                myConnection.Open();
                command = new MySqlCommand("DELETE FROM `открытые_заказы` WHERE `Код_заказа`=@Код_заказа", myConnection);
                command.Parameters.AddWithValue("@Код_заказа", textBox1.Text);
                command.ExecuteNonQuery();
                sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        Kod_stola = sqlReader.GetInt32(1);
                    }
                }
                myConnection.Close();

                Form_prosmotr_zakazov Form_prosmotr_zakazov = new Form_prosmotr_zakazov();
                Form_prosmotr_zakazov.Show();
                this.Close();
            }
            else
            {
                Form_prosmotr_zakazov Form_prosmotr_zakazov = new Form_prosmotr_zakazov();
                Form_prosmotr_zakazov.tumb = true;
                myConnection.Open();
                command = new MySqlCommand("SELECT `Код_оплаты` FROM `открытые_заказы` WHERE `Код_заказа` = @Код_заказа", myConnection);
                command.Parameters.AddWithValue("@Код_заказа", textBox1.Text);
                sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        Kod_oplati = sqlReader.GetInt32(0);
                    }
                }
                myConnection.Close();

                myConnection.Open();
                command = new MySqlCommand("SELECT `Сумма` FROM `оплата` WHERE `Код_оплаты` = @Код_оплаты", myConnection);
                command.Parameters.AddWithValue("@Код_оплаты", Kod_oplati);
                sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        Summa = sqlReader.GetInt32(0);
                    }
                }
                myConnection.Close();

                MessageBox.Show("Оплатите заказ!");
                Form_oplata Form_oplata = new Form_oplata();
                Form_oplata.kod_oplati = Kod_oplati;
                Form_oplata.summa = Summa;
                Form_oplata.tumb1 = true;
                Form_oplata.Show();
                this.Close();
            }
        }
        //Кнопка назад
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


