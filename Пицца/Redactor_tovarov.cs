using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Пицц_
{
    public partial class Redactor_tovarov : Form
    {
        public Redactor_tovarov()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        static string connectString = "server=localhost;user=root;password=;database=pizza;charset=utf8;";


        private MySqlConnection myConnection = new MySqlConnection(connectString);
        private MySqlDataReader sqlReader;
        private MySqlCommand command;
        bool flag = false;
        List<string[]> data = new List<string[]>();
        //Удаление
        private void Udalit_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            command = new MySqlCommand("UPDATE `menu` SET `prodazha`='0' WHERE `Kod_Bluda`=@Kod_Bluda", myConnection);
            command.Parameters.AddWithValue("Kod_Bluda", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            command.ExecuteNonQuery();
            myConnection.Close();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
        private void load_bd()
        {
            data.Clear();
            myConnection.Open();

            command = new MySqlCommand("SELECT `Kod_Bluda`, `Kod_Kategory`, `Name`, `Kkal`, `Ves`, `Cena` FROM `menu` WHERE `prodazha`='1'", myConnection);
            {

                sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();//код блюда
                    data[data.Count - 1][1] = sqlReader[1].ToString();//код категории
                    data[data.Count - 1][2] = sqlReader[2].ToString();//Название блюда

                    data[data.Count - 1][4] = sqlReader[3].ToString();//Ккал
                    data[data.Count - 1][5] = sqlReader[4].ToString();//Вес
                    data[data.Count - 1][6] = sqlReader[5].ToString();//Цена
                }
            }
            myConnection.Close();

            //Дополняем строки категориями
            for (int i = 0; i < data.Count; i++)
            {
                myConnection.Open();
                command = new MySqlCommand("SELECT `Name` FROM `category` WHERE `Kod_Category`=@Kod_Category", myConnection);
                command.Parameters.AddWithValue("@Kod_Category", data[i][1].ToString());
                {
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        data[i][3] = sqlReader[0].ToString();//Название категории
                    }
                }
                myConnection.Close();
            }
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
            dataGridView1.ClearSelection();
        }
        //Заполняем все строки из меню
        private void Redactor_zakazov_Load(object sender, EventArgs e)
        {
            load_bd();
            flag = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void Dobavit_Click(object sender, EventArgs e)
        {
            Dobabit_tovar Dobabit_tovar = new Dobabit_tovar();
            if (Dobabit_tovar.ShowDialog() == DialogResult.OK)
            {
                Update();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            StMeneger StMeneger = new StMeneger();
            StMeneger.Show();
            this.Close();
        }

        private void Output_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK) Application.Exit();
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (flag != false)
            {
                myConnection.Open();
                command = new MySqlCommand("UPDATE `menu` SET `Name`= @Name,`Kkal`= @Kkal,`Ves`= @Ves,`Cena`= @Cena WHERE `Kod_Bluda`= @Kod_Bluda", myConnection);
                command.Parameters.AddWithValue("@Kod_Bluda", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                command.Parameters.AddWithValue("@Name", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                command.Parameters.AddWithValue("@Kkal", dataGridView1.CurrentRow.Cells[4].Value.ToString());
                command.Parameters.AddWithValue("@Ves", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                command.Parameters.AddWithValue("@Cena", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                command.ExecuteNonQuery();
                myConnection.Close();

                myConnection.Open();
                command = new MySqlCommand("UPDATE `category` SET `Name`=@Name WHERE `Kod_Category`=@Kod_Category", myConnection);
                command.Parameters.AddWithValue("@Name", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                command.Parameters.AddWithValue("@Kod_Category", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                command.ExecuteNonQuery();
                myConnection.Close();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Visible == true)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                        if (dataGridView1.Rows[i].Cells[j].ToString() != null)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(poisk.Text.ToLower()))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                dataGridView1.Rows[i].Visible = true;
                            }
                            else if (dataGridView1.Rows[i].Selected == false) { dataGridView1.CurrentCell = null; dataGridView1.Rows[i].Visible = false;}
                        }
                }

            }
            dataGridView1.ClearSelection();
        }

        private void obnovit_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            load_bd();
        }

    }
}
