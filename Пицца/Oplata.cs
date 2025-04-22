using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Пицц_
{
    public partial class Oplata : Form
    {
        public Oplata()
        {
            InitializeComponent();
        }

        static string connectString = "server=localhost;user=root;password=;database=pizza;charset=utf8;";

        private MySqlConnection myConnection = new MySqlConnection(connectString);
        private MySqlDataReader sqlReader;
        private MySqlCommand command;
        public bool tumb1;
        public int summa = 0, i, colvo;

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oplata_posle_Click(object sender, EventArgs e)
        {
            int beznal_oplataText = 0;
            //Оплата заказа
            if (beznal_oplata.Checked == true) beznal_oplataText = 1;
            if (Sozdaniye_Zakaza.dostavka == 1)
            {
                myConnection.Open();
                command = new MySqlCommand("UPDATE `oplata` SET `Beznalich`=@Beznalich,`Status_Oplaty`='0' WHERE `Kod_Oplaty`=@Kod_Oplaty", myConnection);
                command.Parameters.AddWithValue("@Beznalich", beznal_oplataText);
                command.Parameters.AddWithValue("@Kod_Oplaty", Sozdaniye_Zakaza.kod_oplati);
                sqlReader = command.ExecuteReader();
                myConnection.Close();

                if (MessageBox.Show("Заказ ждет оплаты!", "Сообщение") == System.Windows.Forms.DialogResult.OK)
                {
                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        if (Application.OpenForms[i].Name != "Input") Application.OpenForms[i].Close();
                    }
                    Menedzher Menedzher = new Menedzher();
                    Menedzher.Show();
                }


            }
            else MessageBox.Show("Оплатите заказ!", "Сообщение");
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

                myConnection.Open();
                command = new MySqlCommand("DELETE FROM `dostavka` WHERE `Kod_Dostavky`=@Kod_Dostavky", myConnection);
                command.Parameters.AddWithValue("@Kod_Dostavky", Dostavka.kod_Dostavki.ToString());
                command.ExecuteNonQuery();
                myConnection.Close();

                Application.Exit();
            }
        }

        private void Oplata_Load(object sender, EventArgs e)
        {
            myConnection.Open();
            command = new MySqlCommand("SELECT `Summa` FROM `oplata` WHERE `Kod_Oplaty`=(SELECT max(`Kod_Oplaty`) FROM `oplata`)", myConnection);
            sqlReader = command.ExecuteReader();
            {
                while (sqlReader.Read())
                {
                    summa = sqlReader.GetInt32(0);
                }
            }
            label_summa.Text = summa.ToString();
            myConnection.Close();
        }

        private void zavershit_zakaz_Click(object sender, EventArgs e)
        {
            int beznal_oplataText = 0;
            //Оплата заказа
            if (beznal_oplata.Checked == true) beznal_oplataText = 1;
            if (Sozdaniye_Zakaza.dostavka == 0)
            {
                myConnection.Open();
                command = new MySqlCommand("UPDATE `oplata` SET `Beznalich`=@Beznalich,`Status_Oplaty`='1' WHERE `Kod_Oplaty`=@Kod_Oplaty", myConnection);
                command.Parameters.AddWithValue("@Beznalich", beznal_oplataText);
                command.Parameters.AddWithValue("@Kod_Oplaty", Sozdaniye_Zakaza.kod_oplati);
                sqlReader = command.ExecuteReader();
                myConnection.Close();

                if (MessageBox.Show("Заказ успешно оплачен!", "Сообщение") == System.Windows.Forms.DialogResult.OK)
                {
                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        if (Application.OpenForms[i].Name != "Input") Application.OpenForms[i].Close();
                    }
                    Menedzher Menedzher = new Menedzher();
                    Menedzher.Show();
                }


            }
            else MessageBox.Show("Заказ оплачивается после доставки!", "Сообщение");
        }
    }
}
