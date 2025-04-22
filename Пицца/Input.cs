using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Пицц_
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }
        static string connectString = "server=localhost;user=root;password=;database=pizza;charset=utf8;";
        private MySqlConnection myConnection = new MySqlConnection(connectString);
        private MySqlDataReader sqlReader;
        private MySqlCommand command;
        string login, parol;
        private void button1_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            command = new MySqlCommand("SELECT `Login`, `Parol` FROM `dolzhnosty` WHERE `Name`='Менеджер'", myConnection);
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                login = sqlReader[0].ToString();
                parol = sqlReader[1].ToString();
            }
            myConnection.Close();

            if (textBox1.Text == login && textBox2.Text == parol)
            {
                Menedzher Menedzher = new Menedzher();
                Menedzher.Show();
            }
            else
            {
                myConnection.Open();
                command = new MySqlCommand("SELECT `Login`, `Parol` FROM `dolzhnosty` WHERE `Name`='Старший менеджер'", myConnection);
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    login = sqlReader[0].ToString();
                    parol = sqlReader[1].ToString();
                }
                myConnection.Close();
                if (textBox1.Text == login && textBox2.Text == parol)
                {
                    StMeneger StMeneger = new StMeneger();
                    StMeneger.Show();
                }
                else if (MessageBox.Show("Проверьте введенные данные!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Логин")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Логин";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Пароль";
                textBox2.ForeColor = Color.DarkGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Пароль")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.Black;
            }
        }
    }
}
