using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Пицц_
{
    public partial class Dostavka : Form
    {
        public Dostavka()
        {
            InitializeComponent();
            flag = false;
        }
        static string connectString = "server=localhost;user=root;password=;database=pizza;charset=utf8;";

        private MySqlConnection myConnection = new MySqlConnection(connectString);
        private MySqlDataReader sqlReader;
        private MySqlCommand command;
        public static int kod_Dostavki;
        int kod_Dostavshika;
        string Familiya;
        bool flag;
        private void zavershit_zakaz_Click(object sender, EventArgs e)
        {
            try
            {
                if (familiya.Text != "" && name.Text != "" && ulitsa.Text != "" && dom.Text != "" && kvartira.Text != "" && comboBox_dostavshik.Text != "")
                {
                    if(flag == false)
                    {
                        flag = true;
                        myConnection.Open();
                        command = new MySqlCommand("INSERT INTO `dostavka`(`Familiya`, `Name`, `Ulitsa`, `Dom`, `Kvartira`, `Kod_Dostavshika`, `Status_Dostavki`) VALUES (@Familiya, @Name, @Ulitsa, @Dom, @Kvartira,@Kod_Dostavshika,'0')", myConnection);
                        command.Parameters.AddWithValue("@Familiya", familiya.Text);
                        command.Parameters.AddWithValue("@Name", name.Text);
                        command.Parameters.AddWithValue("@Ulitsa", ulitsa.Text);
                        command.Parameters.AddWithValue("@Dom", dom.Text);
                        command.Parameters.AddWithValue("@Kvartira", kvartira.Text);
                        command.Parameters.AddWithValue("@Kod_Dostavshika", kod_Dostavshika);

                        command.ExecuteNonQuery();
                        myConnection.Close();

                        myConnection.Open();
                        command = new MySqlCommand("SELECT `Kod_Dostavky` FROM `dostavka` WHERE `Kod_Dostavky`=(SELECT max(`Kod_Dostavky`) FROM `dostavka`)", myConnection);

                        MySqlDataReader sqlReader = command.ExecuteReader();
                        {
                            while (sqlReader.Read())
                            {
                                kod_Dostavki = sqlReader.GetInt32(0);
                            }
                        }
                        myConnection.Close();

                        myConnection.Open();
                        command = new MySqlCommand("UPDATE `zakazy` SET `Kod_Dostavky`=@Kod_Dostavky WHERE `Kod_Oplaty`=@Kod_Oplaty", myConnection);
                        command.Parameters.AddWithValue("@Kod_Dostavky", kod_Dostavki.ToString());
                        command.Parameters.AddWithValue("@Kod_Oplaty", Sozdaniye_Zakaza.kod_oplati.ToString());

                        command.ExecuteNonQuery();
                        myConnection.Close();
                    }
                    else
                    {
                        myConnection.Open();
                        command = new MySqlCommand("UPDATE `dostavka` SET `Familiya` = @Familiya,`Name`= @Name,`Ulitsa`= @Ulitsa,`Dom`= @Dom,`Kvartira`= @Kvartira,`Kod_Dostavshika`= @Kod_Dostavshika WHERE `Kod_Dostavky`=@Kod_Dostavky", myConnection);
                        command.Parameters.AddWithValue("@Familiya", familiya.Text);
                        command.Parameters.AddWithValue("@Name", name.Text);
                        command.Parameters.AddWithValue("@Ulitsa", ulitsa.Text);
                        command.Parameters.AddWithValue("@Dom", dom.Text);
                        command.Parameters.AddWithValue("@Kvartira", kvartira.Text);
                        command.Parameters.AddWithValue("@Kod_Dostavshika", kod_Dostavshika);
                        command.Parameters.AddWithValue("@Kod_Dostavky", kod_Dostavki.ToString());

                        command.ExecuteNonQuery();
                        myConnection.Close();
                    }
                    

                    Oplata Oplata = new Oplata();
                    Oplata.Show();
                }
                else MessageBox.Show("Заполните все пустые поля!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Проверьте ввод!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Dostavka_Load(object sender, EventArgs e)
        {
            myConnection.Open();
            command = new MySqlCommand("SELECT `Kod_Sotrudnika`, `Familiya`, `Name`, `Otchestvo` FROM `personal` WHERE `Kod_Dolzhnosty`='3'", myConnection);

            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    comboBox_dostavshik.Items.Add(sqlReader[1].ToString()+" "+ sqlReader[2].ToString() + " "+ sqlReader[3].ToString());
                    Familiya = sqlReader[1].ToString();
                }
            }
            myConnection.Close();
        }

        private void comboBox_dostavshik_TextChanged(object sender, EventArgs e)
        {
            myConnection.Open();
            command = new MySqlCommand("SELECT `Kod_Sotrudnika` FROM `personal` WHERE Concat(Familiya, ' ', Name, ' ', Otchestvo) = @FIO", myConnection);
            command.Parameters.AddWithValue("@FIO", comboBox_dostavshik.Text);

            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    kod_Dostavshika = sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();
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

                if(flag == true)
                {
                    myConnection.Open();
                    command = new MySqlCommand("DELETE FROM `dostavka` WHERE `Kod_Dostavky`=@Kod_Dostavky", myConnection);
                    command.Parameters.AddWithValue("@Kod_Dostavky", Dostavka.kod_Dostavki.ToString());
                    command.ExecuteNonQuery();
                    myConnection.Close();
                }

                Application.Exit();
            }
        }
    }
}
