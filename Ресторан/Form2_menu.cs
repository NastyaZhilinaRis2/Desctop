using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class Form2_menu : Form
    {
        public Form2_menu()
        {
            InitializeComponent();
        }
        private void Form2_menu_Load(object sender, EventArgs e)
        {
            string connectString = "server=localhost;user=root;password=;database=restaurant;charset=utf8;";

            MySqlConnection myConnection = new MySqlConnection(connectString);

            myConnection.Open();

            string sql = "SELECT * FROM меню";

            MySqlCommand command = new MySqlCommand(sql, myConnection);
            List<string[]> data = new List<string[]>();

            try
            {
                MySqlDataReader sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        data.Add(new string[4]);

                        data[data.Count - 1][0] = sqlReader[1].ToString();
                        data[data.Count - 1][1] = sqlReader[3].ToString();
                        data[data.Count - 1][2] = sqlReader[4].ToString();
                        data[data.Count - 1][3] = sqlReader[5].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConnection.Close();
                foreach (string[] s in data) dataGridView1.Rows.Add(s);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
