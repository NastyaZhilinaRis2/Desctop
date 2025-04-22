using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class Otchet_po_prodazham : Form
    {
        public Otchet_po_prodazham()
        {
            InitializeComponent();
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            LOAD();
        }
        int i, Summa = 0;
        string connectString = "server=localhost;user=root;password=;database=restaurant;charset=utf8;";

        //перечень дат и сумм заказов
        public void LOAD()
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);

            List<string[]> data = new List<string[]>();
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT DATE_FORMAT(`Дата`, '%d.%m.%Y') AS `Дата`, `Сумма` FROM `оплата`", myConnection);
            {

                MySqlDataReader sqlReader = command.ExecuteReader();
                i = 0;
                while (sqlReader.Read())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();
                }

                foreach (string[] s in data)
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = s[0];
                    dataGridView1.Rows[i].Cells[1].Value = s[1];
                    i++;
                }
            }
            myConnection.Close();
        }
        //Кнопка "Назад"
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //появление календаря при нажатии на textBox
        private void textBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            monthCalendar3.Visible = true;
        }

        //перенос даты на textBox при выборе ее в календаре и вывод отчета по продажам за эти даты
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = e.End.ToString("yyyy-MM-dd");
            monthCalendar1.Visible = false;

            MySqlConnection myConnection = new MySqlConnection(connectString);

            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT `Сумма` FROM `оплата` WHERE DATE(`Дата`) = @Дата", myConnection);
            command.Parameters.AddWithValue("@Дата", textBox1.Text);
            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                Summa = 0;
                while (sqlReader.Read())
                {
                    Summa += sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();
            label4.Text = Summa.ToString();
        }
        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = e.End.ToString("yyyy-MM-dd");
            monthCalendar2.Visible = false;
        }
        private void monthCalendar3_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox3.Text = e.End.ToString("yyyy-MM-dd");
            monthCalendar3.Visible = false;

            MySqlConnection myConnection = new MySqlConnection(connectString);

            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT `Сумма` FROM `оплата` WHERE DATE(`Дата`) >= @Дата AND DATE(`Дата`) <= @Дата1", myConnection);
            command.Parameters.AddWithValue("@Дата", textBox2.Text);
            command.Parameters.AddWithValue("@Дата1", textBox3.Text);
            MySqlDataReader sqlReader = command.ExecuteReader();
            {
                Summa = 0;
                while (sqlReader.Read())
                {
                    Summa += sqlReader.GetInt32(0);
                }
            }
            myConnection.Close();
            label7.Text = Summa.ToString();
        }
    }
}
