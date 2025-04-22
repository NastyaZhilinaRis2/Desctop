using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Пицц_
{
    public partial class Proverka_zakaza : Form
    {
        public Proverka_zakaza()
        {
            InitializeComponent();
        }
        static string connectString = "server=localhost;user=root;password=;database=pizza;charset=utf8;";

        private MySqlConnection myConnection = new MySqlConnection(connectString);
        private MySqlDataReader sqlReader;
        private MySqlCommand command;

        private void Proverka_zakaza_Load(object sender, EventArgs e)
        {
            myConnection.Open();
            command = new MySqlCommand("SELECT `Kod_Bluda`, `Kolichestvo_Porciy` FROM `str_zakaza` WHERE `Kod_Zakaza`=@Kod_Zakaza", myConnection);
            command.Parameters.AddWithValue("@Kod_Zakaza", Sozdaniye_Zakaza.kod_zakaza);

            List<string[]> data = new List<string[]>();
            sqlReader = command.ExecuteReader();
            {
                {
                    while (sqlReader.Read())
                    {
                        data.Add(new string[2]);

                        data[data.Count - 1][0] = sqlReader[0].ToString();
                        data[data.Count - 1][1] = sqlReader[1].ToString();
                    }
                }
            }
            myConnection.Close();

            foreach (string[] s in data)
            {
                myConnection.Open();
                command = new MySqlCommand("SELECT `Name` FROM `menu` WHERE `Kod_Bluda`=@Kod_Bluda AND `prodazha`='1'", myConnection);
                command.Parameters.AddWithValue("@Kod_Bluda", s[0]);
                sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        dataGridView1.Rows.Add(sqlReader[0].ToString(), s[1].ToString());
                    }
                }
                myConnection.Close(); 
            }
            dataGridView1.ClearSelection();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Output_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение? Заказ будет удален!", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                myConnection.Open();
                command = new MySqlCommand("DELETE FROM `oplata` WHERE `Kod_Oplaty`=@Kod_Oplaty", myConnection);
                command.Parameters.AddWithValue("@Kod_Oplaty", Sozdaniye_Zakaza.kod_oplati.ToString());
                command.ExecuteNonQuery();
                myConnection.Close();

                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void gotovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("После данные заказа будет невозможно изменить. Продолжить?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Dobavit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Udalit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранный заказ?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                int kod_bluda_na_udaleniye = 0, cena = 0, colvo = 0;
                colvo = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());

                myConnection.Open();
                command = new MySqlCommand("SELECT `Cena` FROM `menu` WHERE `Name`=@Name AND `prodazha`='1'", myConnection);
                command.Parameters.AddWithValue("@Name", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        cena = sqlReader.GetInt32(0);
                    }
                }
                myConnection.Close();

                Sozdaniye_Zakaza.summa -= colvo * cena;

                myConnection.Open();
                command = new MySqlCommand("UPDATE `oplata` SET `Summa`= @Summa WHERE `Kod_Oplaty`=@Kod_Oplaty", myConnection);
                command.Parameters.AddWithValue("Summa", Sozdaniye_Zakaza.summa.ToString());
                command.Parameters.AddWithValue("Kod_Oplaty", Sozdaniye_Zakaza.kod_oplati.ToString());
                command.ExecuteNonQuery();
                myConnection.Close();

                myConnection.Open();
                command = new MySqlCommand("SELECT `Kod_Bluda` FROM `menu` WHERE `Name`=@Name AND `prodazha`='1'", myConnection);
                command.Parameters.AddWithValue("@Name", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        kod_bluda_na_udaleniye = sqlReader.GetInt32(0);
                    }
                }
                myConnection.Close();

                    myConnection.Open();
                    command = new MySqlCommand("DELETE FROM `str_zakaza` WHERE `Kod_Bluda`=@Kod_Bluda AND `Kod_Zakaza`=@Kod_Zakaza LIMIT 1", myConnection);
                    command.Parameters.AddWithValue("@Kod_Bluda", kod_bluda_na_udaleniye);
                    command.Parameters.AddWithValue("@Kod_Zakaza", Sozdaniye_Zakaza.kod_zakaza);
                    command.ExecuteNonQuery();
                    myConnection.Close();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                Refresh();
            }
        }
    }
}
