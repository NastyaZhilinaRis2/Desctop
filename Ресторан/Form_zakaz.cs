using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class Form_zakaz : Form
    {
        public Form_zakaz()
        {
            InitializeComponent();
            spisok_menu();
            spisok_stolov();
        }
        string connectString = "server=localhost;user=root;password=;database=restaurant;charset=utf8;";
        int kod_zakaza=0, kod_bluda, kod_oplati, cena, summa = 0, colvo;
        bool bil_li_zakaz = false;
        private void button8_Click(object sender, EventArgs e)
        {
            //Отмена операции
            if (bil_li_zakaz == true)
            {
                if (MessageBox.Show("Отменить заказ?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    MySqlConnection myConnection = new MySqlConnection(connectString);

                    myConnection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `оплата`", myConnection);
                    MySqlDataReader sqlReader = command.ExecuteReader();
                    {
                        while (sqlReader.Read())
                        {
                            kod_oplati = sqlReader.GetInt32(0);
                        }
                    }
                    myConnection.Close();

                    myConnection.Open();
                    command = new MySqlCommand("DELETE FROM `оплата` WHERE `Код_оплаты`=@Код_оплаты", myConnection);
                    command.Parameters.AddWithValue("@Код_оплаты", kod_oplati);
                    command.ExecuteNonQuery();
                    myConnection.Close();

                    myConnection.Open();
                    command = new MySqlCommand("UPDATE `столы` SET `Статус`='0' WHERE `Код_стола`= @Код_стола", myConnection);
                    command.Parameters.AddWithValue("@Код_стола", comboBox2.Text);
                    command.ExecuteNonQuery();
                    myConnection.Close();

                    this.Close();
                }
            }
            else this.Close();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            int textBox = int.Parse(textBox1.Text);
            if (textBox >= 10)
            {
                textBox1.Text = "";
                MessageBox.Show("Нельзя ввести число, большее 9", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
        private void spisok_menu()
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT `Название_блюда` FROM меню", myConnection);

                MySqlDataReader sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        comboBox1.Items.Add(sqlReader[0].ToString());
                    }
                }
            myConnection.Close();
        }
        private void spisok_stolov()
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);
            myConnection.Open();

            MySqlCommand command = new MySqlCommand("SELECT `Код_стола` FROM `столы` WHERE `Статус`= 0", myConnection);

            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    comboBox2.Items.Add(sqlReader[0].ToString());
                }
            }
            myConnection.Close();
        }
        private void sozdaniye_zakaza()
        {
            bil_li_zakaz = true;
            MySqlConnection myConnection = new MySqlConnection(connectString);

            //Если автоинкремент достиг пика
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT `Код_заказа` FROM `открытые_заказы`", myConnection);
            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    kod_zakaza = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();
            if (kod_zakaza == 65)
            {
                myConnection.Open();
                command = new MySqlCommand("ALTER TABLE `открытые_заказы` AUTO_INCREMENT = 1;", myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
                myConnection.Open();
                command = new MySqlCommand("ALTER TABLE `оплата` AUTO_INCREMENT = 1;", myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
            }

            //Создание строки оплаты и запоминание кода последней оплаты
            myConnection.Open();
            command = new MySqlCommand("INSERT INTO `оплата`(`Сумма`,`Форма_оплаты`, `Статус`) VALUES (@Сумма, @Форма_оплаты, @Статус)", myConnection);
            {
                command.Parameters.AddWithValue("Сумма", summa);
                command.Parameters.AddWithValue("Форма_оплаты", "нет");
                command.Parameters.AddWithValue("Статус", "не оплачено");
                command.ExecuteNonQuery();
            }
            myConnection.Close();

            myConnection.Open();
            command = new MySqlCommand("SELECT `Код_оплаты` FROM `оплата`", myConnection);
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
            command = new MySqlCommand("INSERT INTO `открытые_заказы`(`Код_стола`, `Код_оплаты`) VALUES (@Код_стола, @Код_оплаты)", myConnection);
            command.Parameters.AddWithValue("@Код_стола", comboBox2.Text);
            command.Parameters.AddWithValue("@Код_оплаты", kod_oplati.ToString());
            command.ExecuteNonQuery();
            myConnection.Close();

            //Запоминание последнего кода заказа 
            myConnection.Open();
            command = new MySqlCommand("SELECT `Код_заказа` FROM `открытые_заказы`", myConnection);
            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    kod_zakaza = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();

            //Перевод столика в статус "занято"
            myConnection.Open();
            command = new MySqlCommand("UPDATE `столы` SET `Статус`='1' WHERE `Код_стола`=@Код_стола", myConnection);
            command.Parameters.AddWithValue("@Код_стола", comboBox2.Text);
            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    kod_zakaza = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Запоминание суммы оплаты
            MySqlConnection myConnection = new MySqlConnection(connectString);
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("UPDATE `оплата` SET `Сумма`=@Сумма WHERE `Код_оплаты`=@Код_оплаты", myConnection);
            {
                command.Parameters.AddWithValue("@Код_оплаты", kod_oplati);
                command.Parameters.AddWithValue("@Сумма", summa);
                command.ExecuteNonQuery();
            }
            myConnection.Close();
            bil_li_zakaz = false;
            Form_oplata Form_oplata = new Form_oplata();
            Form_oplata.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != ""&& textBox1.Text!="" && comboBox2.Text != "")
            {
                button2.Enabled = true;
                comboBox2.Enabled = false;
                if (bil_li_zakaz == false) sozdaniye_zakaza();

                MySqlConnection myConnection = new MySqlConnection(connectString);

                //Запоминаем в переменную код выбранного блюда
                myConnection.Open();
                MySqlCommand command = new MySqlCommand("SELECT Код_блюда, Цена FROM `меню` WHERE `Название_блюда` = @Название_блюда", myConnection);
                command.Parameters.AddWithValue("@Название_блюда", comboBox1.Text);

                MySqlDataReader sqlReader = command.ExecuteReader();
                {
                    if (sqlReader.Read())
                    {
                        kod_bluda = sqlReader.GetInt32(0);
                        cena = sqlReader.GetInt32(1);
                    }
                }
                myConnection.Close();
                colvo = int.Parse(textBox1.Text);
                summa += colvo * cena;

                //Добавляем строку заказа
                myConnection.Open();
                command = new MySqlCommand("INSERT INTO `строка_заказа`(`Код_заказа`, `Код_блюда`, `Количество_порций`) VALUES(@Код_заказа, @Код_блюда, @Количество_порций)", myConnection);
                command.Parameters.AddWithValue("Код_заказа", kod_zakaza.ToString());
                command.Parameters.AddWithValue("Код_блюда", kod_bluda.ToString());
                command.Parameters.AddWithValue("Количество_порций", textBox1.Text);
                command.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Добавлено!", "Сообщение");
                myConnection.Close();
            }
            else MessageBox.Show("Заполните все пустые поля!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
    }
}


