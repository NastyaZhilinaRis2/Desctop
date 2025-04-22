using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Пицц_
{
    public partial class Sozdaniye_Zakaza : Form
    {
        public Sozdaniye_Zakaza()
        {
            InitializeComponent();
        }
        static string connectString = "server=localhost;user=root;password=;database=pizza;charset=utf8;";

        private MySqlConnection myConnection = new MySqlConnection(connectString);
        private MySqlDataReader sqlReader;
        private MySqlCommand command;

        int Kod_Categorii;
        bool bil_li_zakaz;
        int kod_bluda, cena, colvo;
        public static int kod_oplati, dostavka, kod_zakaza, summa = 0;

        int kod_Men;
        string Familiya;

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                int textBox = int.Parse(colvo_porciy.Text);
                if (textBox >= 10)
                {
                    colvo_porciy.Text = "";
                    MessageBox.Show("Нельзя ввести число, большее 9", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                if (colvo_porciy.Text != "")
                {
                    colvo_porciy.Text = "";
                    MessageBox.Show("Проверьте ввод!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void zavershit_zakaz_Click(object sender, EventArgs e)
        {
            //Запоминание суммы оплаты
            MySqlConnection myConnection = new MySqlConnection(connectString);
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("UPDATE `oplata` SET `Summa`=@Summa WHERE `Kod_Oplaty`=@Kod_Oplaty", myConnection);
            {
                command.Parameters.AddWithValue("@Kod_Oplaty", kod_oplati);
                command.Parameters.AddWithValue("@Summa", summa);
                command.ExecuteNonQuery();
            }
            myConnection.Close();

            Proverka_zakaza Proverka_zakaza = new Proverka_zakaza();
            if(Proverka_zakaza.ShowDialog() == DialogResult.OK)
            {
                if (checkBox1.Checked == true)
                {
                    dostavka = 1;
                    Dostavka Dostavka = new Dostavka();
                    Dostavka.Show();
                    this.Close();
                }
                else
                {
                    dostavka = 0;
                    myConnection.Open();
                    command = new MySqlCommand("UPDATE `zakazy` SET `Kod_Dostavky`= NULL  WHERE `Kod_Oplaty`=@Kod_Oplaty", myConnection);
                    {
                        command.Parameters.AddWithValue("@Kod_Oplaty", kod_oplati);
                        command.ExecuteNonQuery();
                    }
                    myConnection.Close();
                    Oplata Oplata = new Oplata();
                    Oplata.Show();
                    this.Close();
                }
            }
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (bil_li_zakaz == true)
            {
                if (MessageBox.Show("Отменить заказ?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    myConnection.Open();
                    command = new MySqlCommand("SELECT `Kod_Oplaty` FROM `oplata` WHERE `Kod_Oplaty`=(select max(`Kod_Oplaty`) from `oplata`)", myConnection);
                    sqlReader = command.ExecuteReader();
                    {
                        while (sqlReader.Read())
                        {
                            kod_oplati = sqlReader.GetInt32(0);
                        }
                    }
                    myConnection.Close();

                    myConnection.Open();
                    command = new MySqlCommand("DELETE FROM `oplata` WHERE `Kod_Oplaty`=@Kod_Oplaty", myConnection);
                    command.Parameters.AddWithValue("@Kod_Oplaty", kod_oplati);
                    command.ExecuteNonQuery();
                    myConnection.Close();

                    this.Close();
                    Menedzher Menedzher = new Menedzher();
                    Menedzher.Show();
                }
            }
            else
            {
                this.Close();
                Menedzher Menedzher = new Menedzher();
                Menedzher.Show();
            }
        }

        private void comboBox_Meneger_TextChanged(object sender, EventArgs e)
        {
            myConnection.Open();
            command = new MySqlCommand("SELECT `Kod_Sotrudnika` FROM `personal` WHERE Concat(Familiya, ' ', Name, ' ', Otchestvo) = @FIO", myConnection);
            command.Parameters.AddWithValue("@FIO", comboBox_Meneger.Text);

            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    kod_Men = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();
        }

        private void Output_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение? Заказ будет удален!", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (bil_li_zakaz == true)
                {
                    myConnection.Open();
                    command = new MySqlCommand("SELECT `Kod_Oplaty` FROM `oplata` WHERE `Kod_Oplaty`=(select max(`Kod_Oplaty`) from `oplata`)", myConnection);
                    sqlReader = command.ExecuteReader();
                    {
                        while (sqlReader.Read())
                        {
                            kod_oplati = sqlReader.GetInt32(0);
                        }
                    }
                    myConnection.Close();

                    myConnection.Open();
                    command = new MySqlCommand("DELETE FROM `oplata` WHERE `Kod_Oplaty`=@Kod_Oplaty", myConnection);
                    command.Parameters.AddWithValue("@Kod_Oplaty", kod_oplati);
                    command.ExecuteNonQuery();
                    myConnection.Close();

                    Application.Exit();
                }
                Application.Exit();
            }
        }

        private void Sozdaniye_Zakaza_Load(object sender, EventArgs e)
        {
            myConnection.Open();
            command = new MySqlCommand("SELECT `Kod_Sotrudnika`, `Familiya`, `Name`, `Otchestvo` FROM `personal` WHERE `Kod_Dolzhnosty`='1'", myConnection);

            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    comboBox_Meneger.Items.Add(sqlReader[1].ToString() + " " + sqlReader[2].ToString() + " " + sqlReader[3].ToString());
                    Familiya = sqlReader[1].ToString();
                }
            }
            myConnection.Close();
            dostavka = 0;
            bil_li_zakaz = false;
            myConnection.Open();
            command = new MySqlCommand("SELECT `Name` FROM `category`", myConnection);

            sqlReader = command.ExecuteReader();
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

            command = new MySqlCommand("SELECT `Name`, `Kkal`, `Ves`, `Cena` FROM `menu` WHERE `Kod_Kategory`=@Kod_Kategory AND `prodazha`='1'", myConnection);
            command.Parameters.AddWithValue("@Kod_Kategory", Kod_Categorii);

            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    comboBox2_Bludo.Items.Add(sqlReader[0].ToString());
                }
            }
            myConnection.Close();
        }

        private void comboBox1_categoriya_TextChanged(object sender, EventArgs e)
        {
            comboBox2_Bludo.Text = "";
            comboBox2_Bludo.Items.Clear();
            myConnection.Open();
            command = new MySqlCommand("SELECT `Kod_Category`FROM `category` WHERE `Name`=@Name", myConnection);
            command.Parameters.AddWithValue("@Name", comboBox1_categoriya.Text);

            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    Kod_Categorii = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();
            
            bd_load();
        }
        private void sozdaniye_zakaza()
        {
            bil_li_zakaz = true;
            comboBox_Meneger.Enabled = false;
            //Создание строки оплаты и запоминание кода последней оплаты
            myConnection.Open();
            command = new MySqlCommand("INSERT INTO `oplata`(`Summa`, `Beznalich`, `Status_Oplaty`) VALUES ('@Summa','@Beznalich','@Status_Oplaty')", myConnection);
            {
                command.Parameters.AddWithValue("Summa", summa);
                command.Parameters.AddWithValue("Beznalich", "0");
                command.Parameters.AddWithValue("Status_Oplaty", "0");
                command.ExecuteNonQuery();
            }
            myConnection.Close();

            myConnection.Open();
            command = new MySqlCommand("SELECT `Kod_Oplaty` FROM `oplata` WHERE `Kod_Oplaty`=(select max(`Kod_Oplaty`) from `oplata`)", myConnection);
            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    kod_oplati = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();

            //Создание нового заказа
            myConnection.Open();
            command = new MySqlCommand("INSERT INTO `zakazy`(`Kod_Oplaty`, `Kod_Menedzhera`) VALUES (@kod_oplati,@Kod_Menedzhera)", myConnection);
            command.Parameters.AddWithValue("@kod_oplati", kod_oplati.ToString());
            command.Parameters.AddWithValue("@Kod_Menedzhera", kod_Men.ToString());
            command.ExecuteNonQuery();
            myConnection.Close();

            //Запоминание последнего кода заказа 
            myConnection.Open();
            command = new MySqlCommand("SELECT `Kod_Zakaza` FROM `zakazy` WHERE `Kod_Zakaza`=(select max(`Kod_Zakaza`) from `zakazy`)", myConnection);
            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    kod_zakaza = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();
        }
        private void dobavit_k_zakazu_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1_categoriya.Text != "" && comboBox2_Bludo.Text != "" && colvo_porciy.Text != "" && comboBox_Meneger.Text != "")
                {
                    zavershit_zakaz.Enabled = true;
                    if (bil_li_zakaz == false) sozdaniye_zakaza();


                    //Запоминаем в переменную код выбранного блюда
                    myConnection.Open();
                    command = new MySqlCommand("SELECT `Kod_Bluda`, `Cena` FROM `menu` WHERE `Name`=@Name AND `prodazha`='1'", myConnection);
                    command.Parameters.AddWithValue("@Name", comboBox2_Bludo.Text);

                    sqlReader = command.ExecuteReader();
                    {
                        if (sqlReader.Read())
                        {
                            kod_bluda = sqlReader.GetInt32(0);
                            cena = sqlReader.GetInt32(1);
                        }
                    }
                    myConnection.Close();
                    colvo = int.Parse(colvo_porciy.Text);
                    summa += colvo * cena;

                    //Добавляем строку заказа
                    myConnection.Open();
                    command = new MySqlCommand("INSERT INTO `str_zakaza`(`Kod_Zakaza`, `Kod_Bluda`, `Kolichestvo_Porciy`) VALUES (@Kod_Zakaza,@Kod_Bluda,@Kolichestvo_Porciy)", myConnection);
                    command.Parameters.AddWithValue("Kod_Zakaza", kod_zakaza.ToString());
                    command.Parameters.AddWithValue("Kod_Bluda", kod_bluda.ToString());
                    command.Parameters.AddWithValue("Kolichestvo_Porciy", colvo_porciy.Text);
                    command.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Добавлено!", "Сообщение");
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
