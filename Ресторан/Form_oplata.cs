using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class Form_oplata : Form
    {
        public Form_oplata()
        {
            InitializeComponent();
        }
        public int kod_zakaza, kod_oplati, summa = 0, i, colvo;
        public bool tumb1;
        string connectString = "server=localhost;user=root;password=;database=restaurant;charset=utf8;";

        private void Form_oplata_Load(object sender, EventArgs e)
        {
            if (tumb1 != true)
            {
                MySqlConnection myConnection = new MySqlConnection(connectString);

                myConnection.Open();
                MySqlCommand command = new MySqlCommand("SELECT  `Сумма` FROM `оплата`  ", myConnection);
                MySqlDataReader sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        summa = sqlReader.GetInt32(0);
                    }
                }
            }
            label4.Text = summa.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tumb1 != true)
            {
                if (MessageBox.Show("Отменить заказ?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    MySqlConnection myConnection = new MySqlConnection(connectString);

                    //Отмена операции
                    myConnection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `Код_оплаты` FROM `оплата`", myConnection);
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

                    this.Close();
                }
            }
            else MessageBox.Show("На данном этапе нельзя отменить операцию!");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);

            //Отсрочка оплаты
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT `Код_оплаты` FROM `оплата`", myConnection);
            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    kod_oplati = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();

            myConnection.Open();
            command = new MySqlCommand("UPDATE `оплата` SET `Форма_оплаты`=@Форма_оплаты WHERE `Код_оплаты`=@Код_оплаты", myConnection);
            command.Parameters.AddWithValue("@Форма_оплаты", comboBox1.Text);
            command.Parameters.AddWithValue("@Код_оплаты", kod_oplati);
            sqlReader = command.ExecuteReader();
            vichet_na_sclade();
            if (MessageBox.Show("Заказ принят, но ожидает оплаты!", "Сообщение") == System.Windows.Forms.DialogResult.OK) this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_prosmotr_zakazov Form_prosmotr_zakazov = new Form_prosmotr_zakazov();
            if (comboBox1.Text != "")
            {
                MySqlConnection myConnection = new MySqlConnection(connectString);
                MySqlCommand command = new MySqlCommand();
                MySqlDataReader sqlReader;

                if (Form_prosmotr_zakazov.tumb == false)
                {

                    myConnection.Open();
                    //Оплата заказа
                    command = new MySqlCommand("SELECT `Код_оплаты` FROM `оплата`", myConnection);
                    sqlReader = command.ExecuteReader();
                    {
                        while (sqlReader.Read())
                        {
                            kod_oplati = sqlReader.GetInt32(0);
                        }
                    }
                    myConnection.Close();
                }
                else kod_oplati = Form_prosmotr_zakazov.Kod_oplati;

                myConnection.Open();
                command = new MySqlCommand("UPDATE `оплата` SET `Форма_оплаты`=@Форма_оплаты,`Статус`='оплачено' WHERE `Код_оплаты`=@Код_оплаты", myConnection);
                command.Parameters.AddWithValue("@Форма_оплаты", comboBox1.Text);
                command.Parameters.AddWithValue("@Код_оплаты", kod_oplati);
                sqlReader = command.ExecuteReader();
                if (MessageBox.Show("Заказ успешно оплачен!", "Сообщение") == System.Windows.Forms.DialogResult.OK) this.Close();
                vichet_na_sclade();
                myConnection.Close();

                Form_prosmotr_zakazov.tumb = false;
                tumb1 = false;
            }
            else MessageBox.Show("Введите форму оплаты!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
        private void vichet_na_sclade()
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);

            //Запоминаем код заказа
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT `Код_заказа` FROM `открытые_заказы` WHERE `Код_оплаты`=@Код_оплаты", myConnection);
            command.Parameters.AddWithValue("@Код_оплаты", kod_oplati.ToString());
            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                if (sqlReader.Read())
                {
                    kod_zakaza = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();

            //Запоминаем коды заказанных блюд и их количество
            myConnection.Open();
            command = new MySqlCommand("SELECT `Код_блюда`, `Количество_порций` FROM `строка_заказа` WHERE `Код_заказа`=@Код_заказа", myConnection);
            command.Parameters.AddWithValue("@Код_заказа", kod_zakaza.ToString());
            List<int[]>bludo_colvo = new List<int[]>();
            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    //заполняем лист кодами блюд и количествами их порций
                    bludo_colvo.Add(new int[2]);

                    bludo_colvo[bludo_colvo.Count - 1][0] = sqlReader.GetInt32(0);
                    bludo_colvo[bludo_colvo.Count - 1][1] = sqlReader.GetInt32(1);
                }
            }
            myConnection.Close();

            //по коду блюда узнаем код состава
            command = new MySqlCommand("SELECT `Код_состава` FROM `меню` WHERE `Код_блюда` = @Код_блюда", myConnection);
            foreach (int[] s in bludo_colvo)
            {
                command.Parameters.AddWithValue("@Код_блюда", s[0]);
                myConnection.Open();
                sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        s[0] = sqlReader.GetInt32(0);
                    }
                }
                myConnection.Close();
                command.Parameters.Clear();
            }



            //Перебор по каждому блюду, запоминание кода ингредиента и нужный вес
            List<int[]> ingregient_colvo_colvopor = new List<int[]>();
            command = new MySqlCommand("SELECT `Код_ингредиента`, `Вес_ингредиента` FROM `состав` WHERE `Код_состава`=@Код_состава", myConnection);
            foreach (int[] s in bludo_colvo)
            {
                command.Parameters.AddWithValue("@Код_состава", s[0]);
                myConnection.Open();
                sqlReader = command.ExecuteReader();
                {
                    while (sqlReader.Read())
                    {
                        //заполняем лист кодами блюд, количествами их порций и количествами заказанных блюд
                        ingregient_colvo_colvopor.Add(new int[3]);

                        ingregient_colvo_colvopor[ingregient_colvo_colvopor.Count - 1][0] = sqlReader.GetInt32(0);
                        ingregient_colvo_colvopor[ingregient_colvo_colvopor.Count - 1][1] = sqlReader.GetInt32(1);
                        ingregient_colvo_colvopor[ingregient_colvo_colvopor.Count - 1][2] = s[1];
                    }
                }
                myConnection.Close();
                command.Parameters.Clear();
            }
            //Перебор по кодам ингредиентов
            i = 0;
            command = new MySqlCommand("UPDATE `склад` SET `Количество`= `Количество` - @Количество WHERE `Код_ингредиента` = @Код_ингредиента", myConnection);
            foreach (int[] s in ingregient_colvo_colvopor)
            {
                myConnection.Open();
                command.Parameters.AddWithValue("@Код_ингредиента", s[0].ToString());
                colvo = s[1] * s[2];
                command.Parameters.AddWithValue("@Количество", colvo.ToString());
                command.ExecuteNonQuery();
                myConnection.Close();
                command.Parameters.Clear();
                i++;
            }
            bludo_colvo.Clear();
            ingregient_colvo_colvopor.Clear();
        }
    }
}
