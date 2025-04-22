using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class Forma_dolzhnosti : Form
    {
        public Forma_dolzhnosti()
        {
            InitializeComponent();
            Load();
        }
        int i;
        string connectString = "server=localhost;user=root;password=;database=restaurant;charset=utf8;";
        private void Load()
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);

            myConnection.Open();
            List<string[]> data = new List<string[]>();
            MySqlCommand command = new MySqlCommand("SELECT `Название_должности`, `Оклад` FROM `должности`", myConnection);
            {

                MySqlDataReader sqlReader = command.ExecuteReader();
                i = 0;
                while (sqlReader.Read())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();
                }

                foreach (string[] s in data)
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = s[0];
                    dataGridView1.Rows[i].Cells[1].Value = s[1];
                    i++;
                }
            }
            myConnection.Close();
        }
        //Кнопка "Назад"
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
