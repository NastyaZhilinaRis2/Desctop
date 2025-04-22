using System;
using System.Windows.Forms;

namespace Пицц_
{
    public partial class Menedzher : Form
    {
        public Menedzher()
        {
            InitializeComponent();
        }
        
        private void Prosmotr_Tovarov_Click(object sender, EventArgs e)
        {
            Prosmotr_Tovarov Prosmotr_Tovarov = new Prosmotr_Tovarov();
            Prosmotr_Tovarov.Show();
            this.Close();
        }

        private void Sozdaniye_Zakazov_Click(object sender, EventArgs e)
        {
            Sozdaniye_Zakaza Sozdaniye_Zakaza = new Sozdaniye_Zakaza();
            Sozdaniye_Zakaza.Show();
            this.Close();
        }

        private void Output_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK) Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
