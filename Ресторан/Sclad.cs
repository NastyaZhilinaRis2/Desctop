using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class Sclad : Form
    {
        public Sclad()
        {
            InitializeComponent();
            LOAD();
            spisok_prod();
        }
        int i;
        string connectString = "server=localhost;user=root;password=;database=restaurant;charset=utf8;";

        private void LOAD()
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);

            List<string[]> data = new List<string[]>();
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT `Название_ингредиента`, `Количество` FROM `склад`", myConnection);
            {

                MySqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();
                }
            }
            i = 0;
            myConnection.Close();
            foreach (string[] s in data)
            {

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = s[0];
                dataGridView1.Rows[i].Cells[1].Value = s[1];
                i++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);

            List<string[]> data = new List<string[]>();
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("UPDATE `склад` SET `Количество`=`Количество`+ @Количество WHERE `Название_ингредиента`=@Название_ингредиента", myConnection);
            command.Parameters.AddWithValue("@Название_ингредиента", comboBox1.Text);
            command.Parameters.AddWithValue("@Количество", textBox1.Text);
            MySqlDataReader sqlReader = command.ExecuteReader();
            myConnection.Close();
            Sclad Sclad = new Sclad();
            Sclad.Show();
            this.Close();
        }
        private void spisok_prod()
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);
            myConnection.Open();

            string sql = "SELECT `Название_ингредиента` FROM `склад`";

            MySqlCommand command = new MySqlCommand(sql, myConnection);

            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    comboBox1.Items.Add(sqlReader[0].ToString());
                }
            }
            myConnection.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int textBox = int.Parse(textBox1.Text);
                if (textBox >= 10)
                {
                    textBox1.Text = "";
                    MessageBox.Show("Нельзя ввести число, большее 99999", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
