using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Пицц_
{
    public partial class Prosmotr_Tovarov : Form
    {
        public Prosmotr_Tovarov()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        static string connectString = "server=localhost;user=root;password=;database=pizza;charset=utf8;";


        private MySqlConnection myConnection = new MySqlConnection(connectString);
        private MySqlDataReader sqlReader;
        private MySqlCommand command;
        int i, Kod_Categorii;
        private void Output_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK) Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menedzher Menedzher = new Menedzher();
            Menedzher.Show();
            this.Close();
        }

        private void Prosmotr_Tovarov_Load(object sender, EventArgs e)
        {
            comboBox1_categoriya.Items.Add("Все");
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT `Name` FROM `category`", myConnection);

            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    comboBox1_categoriya.Items.Add(sqlReader[0].ToString());
                }
            }
            myConnection.Close();
            bd_load();
        }
        private void bd_load()
        {
            myConnection.Open();
            List<string[]> data = new List<string[]>();
            if (comboBox1_categoriya.Text != "Все")
            {
                command = new MySqlCommand("SELECT `Name`, `Kkal`, `Ves`, `Cena` FROM `menu` WHERE `Kod_Kategory`=@Kod_Kategory AND `prodazha`='1'", myConnection);
                command.Parameters.AddWithValue("@Kod_Kategory", Kod_Categorii);
            }
            else command = new MySqlCommand("SELECT `Name`, `Kkal`, `Ves`, `Cena` FROM `menu` WHERE `prodazha`='1'", myConnection);
            {

                sqlReader = command.ExecuteReader();
                i = 0;
                while (sqlReader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();
                    data[data.Count - 1][2] = sqlReader[2].ToString();
                    data[data.Count - 1][3] = sqlReader[3].ToString();
                }

                foreach (string[] s in data)
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = s[0];
                    dataGridView1.Rows[i].Cells[1].Value = s[1];
                    dataGridView1.Rows[i].Cells[2].Value = s[2];
                    dataGridView1.Rows[i].Cells[3].Value = s[3];
                    i++;
                }
            }
            myConnection.Close();
        }

        private void comboBox1_categoriya_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT `Kod_Category`FROM `category` WHERE `Name`=@Name", myConnection);
            command.Parameters.AddWithValue("@Name", comboBox1_categoriya.Text);

            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    Kod_Categorii = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();
            
            bd_load();
        }
    }
}
