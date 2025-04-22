using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class Form_personal : Form
    {
        public Form_personal()
        {
            InitializeComponent();
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            LOAD();
        }
        string connectString = "server=localhost;user=root;password=;database=restaurant;charset=utf8;";
        int i;
        string kods_tables = "";
        List<string[]> data = new List<string[]>();
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LOAD()
        {
            MySqlConnection myConnection = new MySqlConnection(connectString);

            //выписываем ФИО и ГР сотрудников
            myConnection.Open();
            MySqlCommand command = new MySqlCommand("SELECT `Фамилия`, `Имя`, `Отчество`, DATE_FORMAT( `Дата_рождения` , '%d.%m.%Y' ) AS `Дата_рождения` ,`Код_должности`, `Код_сотрудника` FROM `персонал`", myConnection);
            {
                
                MySqlDataReader sqlReader = command.ExecuteReader();
                i = 0;
                while (sqlReader.Read())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();
                    data[data.Count - 1][2] = sqlReader[2].ToString();
                    data[data.Count - 1][3] = sqlReader[3].ToString();
                    //запомиаем код должности и код сотрудника по очереди
                    data[data.Count - 1][4] = sqlReader[4].ToString();
                    data[data.Count - 1][5] = sqlReader[5].ToString();
                }
                
                foreach (string[] s in data)
                {
                    
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[1].Value = s[0];
                    dataGridView1.Rows[i].Cells[2].Value = s[1];
                    dataGridView1.Rows[i].Cells[3].Value = s[2];
                    dataGridView1.Rows[i].Cells[4].Value = s[3];
                    i++;
                }
            }
           
            myConnection.Close();

            //Выписываем должность сотрудника
            i = 0;
            foreach (string[] s in data)
            {
                myConnection.Open();
                command = new MySqlCommand(" SELECT `Название_должности` FROM `должности` WHERE `Код_должности`= @Код_должности", myConnection);
                command.Parameters.AddWithValue("@Код_должности", s[4]);
                MySqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    dataGridView1.Rows[i].Cells[0].Value = sqlReader[0].ToString();
                }
                i++;
                myConnection.Close();
            }


            //Выписываем столики, закрепленные над официантом
            i = 0;
            foreach (string[] s in data)
            {
                myConnection.Open();
                command = new MySqlCommand("SELECT `Код_стола` FROM `столы` WHERE `Код_официанта` = @Код_официанта", myConnection);
                command.Parameters.AddWithValue("@Код_официанта", s[5]);
                MySqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    kods_tables += sqlReader[0].ToString() + ", ";
                    dataGridView1.Rows[i].Cells[5].Value = kods_tables;
                }
                myConnection.Close();
                int ind = kods_tables.Length -2;
                if (kods_tables != "")
                {
                    kods_tables = kods_tables.Remove(ind);
                    dataGridView1[5, i].Value = kods_tables;
                } 
                kods_tables = "";
                i++;
            }
            
        }
    }
}
