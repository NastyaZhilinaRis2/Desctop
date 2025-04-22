using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class avtorizaciya_Form : Form
    {
        public avtorizaciya_Form()
        {
            InitializeComponent();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Login";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.DarkGray;
            }
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            string connectString = "server=localhost;user=root;password=;database=restaurant;charset=utf8;";
            MySqlConnection myConnection = new MySqlConnection(connectString);

            string login = textBox1.Text;
            string password = textBox2.Text;

            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `пользователи` WHERE `логин`=@login AND `пароль`= @password", myConnection);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);

            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                if (sqlReader.Read())
                {
                    main_Form main_Form = new main_Form();
                    main_Form.Show();
                }
                else if (MessageBox.Show("Проверьте введенные данные!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            myConnection.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
