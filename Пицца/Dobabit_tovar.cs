using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Пицц_
{
    public partial class Dobabit_tovar : Form
    {
        public Dobabit_tovar()
        {
            InitializeComponent();
        }
        static string connectString = "server=localhost;user=root;password=;database=pizza;charset=utf8;";

        private MySqlConnection myConnection = new MySqlConnection(connectString);
        private MySqlDataReader sqlReader;
        private MySqlCommand command;
        int Kod_Category = 0, Kod_Ingredienta = 0, Kod_Bluda;
        bool flag = false;

        private void dobavit_tovar_Click(object sender, EventArgs e)
        {
            try
            {
            Found:
                if (name.Text != "" && comboBox_categoriya.Text != "" && Kkal.Text != "" && Ves.Text != "" && cena.Text != "")
                {
                    flag = true;
                    dobavit_product.Enabled = true;
                    myConnection.Open();
                    command = new MySqlCommand("SELECT `Kod_Category` FROM `category` WHERE `Name`=@Name", myConnection);
                    command.Parameters.AddWithValue("@Name", comboBox_categoriya.Text);
                    {
                        sqlReader = command.ExecuteReader();
                        while (sqlReader.Read())
                        {
                            Kod_Category = sqlReader.GetInt32(0);//Название категории
                        }
                    }
                    myConnection.Close();

                    if (Kod_Category == 0)
                    {
                        if (MessageBox.Show("Верно ли введена отрасль?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                        {
                            myConnection.Open();
                            command = new MySqlCommand("INSERT INTO `category`(`Name`) VALUES (@Name)", myConnection);
                            command.Parameters.AddWithValue("Name", comboBox_categoriya.Text);
                            command.ExecuteNonQuery();
                            myConnection.Close();

                            myConnection.Open();
                            command = new MySqlCommand("SELECT `Kod_Category` FROM `category` WHERE `Name`=@Name", myConnection);
                            command.Parameters.AddWithValue("Name", comboBox_categoriya.Text);

                            sqlReader = command.ExecuteReader();
                            {
                                while (sqlReader.Read())
                                {
                                    Kod_Category = sqlReader.GetInt32(0);
                                }
                            }
                            myConnection.Close();
                        }
                        else
                        {
                            comboBox_categoriya.Text = "";
                            goto Found;
                        }
                    }

                    myConnection.Open();
                    command = new MySqlCommand("INSERT INTO `menu`(`Name`, `Kod_Kategory`, `Kkal`, `Ves`, `Cena`, `prodazha`) VALUES (@Name, @Kod_Kategory, @Kkal,@Ves,@Cena,'1')", myConnection);
                    command.Parameters.AddWithValue("Name", name.Text);
                    command.Parameters.AddWithValue("Kod_Kategory", Kod_Category.ToString());
                    command.Parameters.AddWithValue("Kkal", Kkal.Text);
                    command.Parameters.AddWithValue("Ves", Ves.Text);
                    command.Parameters.AddWithValue("Cena", cena.Text);
                    command.ExecuteNonQuery();
                    myConnection.Close();

                    MessageBox.Show("Добавлено!");
                    dobavit_tovar.Enabled = false;
                }
                else MessageBox.Show("Заполните все пустые поля!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Проверьте ввод!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void uslovie_zavershenie_radact()
        {
            myConnection.Open();
            command = new MySqlCommand("DELETE FROM `sostav` WHERE `Kod_Bluda`=@Kod_Bluda", myConnection);
            command.Parameters.AddWithValue("Kod_Bluda", Kod_Bluda);
            command.ExecuteNonQuery();
            myConnection.Close();

            myConnection.Open();
            command = new MySqlCommand("DELETE FROM `menu` WHERE `Kod_Bluda`=@Kod_Bluda", myConnection);
            command.Parameters.AddWithValue("Kod_Bluda", Kod_Bluda);
            command.ExecuteNonQuery();
            myConnection.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (flag != false)
            {
                if (MessageBox.Show("Отменить добавление?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    uslovie_zavershenie_radact();
                }
            }
            else this.Close();
        }

        private void dobavit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Завершить добавление?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Output_Click(object sender, EventArgs e)
        {
            if (flag != false)
            {
                if (MessageBox.Show("Выйти? Введенные данные будут удалены", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    uslovie_zavershenie_radact();
                }
            }
            else if (MessageBox.Show("Выйти из приложения?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void Dobabit_tovar_Load(object sender, EventArgs e)
        {
            myConnection.Open();
            command = new MySqlCommand("SELECT `Name` FROM `category`", myConnection);

            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    comboBox_categoriya.Items.Add(sqlReader[0].ToString());
                }
            }
            myConnection.Close();

            myConnection.Open();
            command = new MySqlCommand("SELECT `Name` FROM `sclad`", myConnection);

            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    comboBox_ingredienty.Items.Add(sqlReader[0].ToString());
                }
            }
            myConnection.Close();
        }

        private void dobavit_product_Click(object sender, EventArgs e)
        {
            try
            {
                Found:
                if (comboBox_ingredienty.Text != "" && kolvo.Text != "" )
                {
                    myConnection.Open();
                    command = new MySqlCommand("SELECT `Kod_Indredienta` FROM `sclad` WHERE `Name`=@Name", myConnection);
                    command.Parameters.AddWithValue("Name", comboBox_ingredienty.Text);

                    sqlReader = command.ExecuteReader();
                    {
                        while (sqlReader.Read())
                        {
                            Kod_Ingredienta = sqlReader.GetInt32(0);
                        }
                    }
                    myConnection.Close();
                    if (Kod_Ingredienta == 0)
                    {
                        if (MessageBox.Show("Верно ли введен продукт?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                        {
                            myConnection.Open();
                            command = new MySqlCommand("INSERT INTO `sclad`(`Name`) VALUES (@Name)", myConnection);
                            command.Parameters.AddWithValue("Name", comboBox_ingredienty.Text);
                            command.ExecuteNonQuery();
                            myConnection.Close();

                            myConnection.Open();
                            command = new MySqlCommand("SELECT `Kod_Indredienta` FROM `sclad` WHERE `Name`=@Name", myConnection);
                            command.Parameters.AddWithValue("Name", comboBox_ingredienty.Text);

                            sqlReader = command.ExecuteReader();
                            {
                                while (sqlReader.Read())
                                {
                                    Kod_Ingredienta = sqlReader.GetInt32(0);
                                }
                            }
                            myConnection.Close();
                        }
                        else
                        {
                            comboBox_ingredienty.Text = "";
                            goto Found;
                        }
                    }

                    myConnection.Open();
                    command = new MySqlCommand("SELECT `Kod_Bluda` FROM `menu` WHERE `Name`=@Name", myConnection);
                    command.Parameters.AddWithValue("Name", name.Text);

                    sqlReader = command.ExecuteReader();
                    {
                        while (sqlReader.Read())
                        {
                            Kod_Bluda = sqlReader.GetInt32(0);
                        }
                    }
                    myConnection.Close();

                    myConnection.Open();
                    command = new MySqlCommand("INSERT INTO `sostav`(`Kod_Bluda`, `Kod_Indredienta`, `Kolichestvo`) VALUES (@Kod_Bluda,@Kod_Indredienta,@Kolichestvo)", myConnection);
                    command.Parameters.AddWithValue("Kod_Bluda", Kod_Bluda.ToString());
                    command.Parameters.AddWithValue("Kod_Indredienta", Kod_Ingredienta.ToString());
                    command.Parameters.AddWithValue("Kolichestvo", kolvo.Text);
                    command.ExecuteNonQuery();
                    myConnection.Close();

                    MessageBox.Show("Добавлено!");
                    dobavit.Enabled = true;

                }
                else MessageBox.Show("Заполните все пустые поля!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Проверьте ввод!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
