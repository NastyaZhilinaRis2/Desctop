using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пицц_
{
    public partial class StMeneger : Form
    {
        public StMeneger()
        {
            InitializeComponent();
        }

        private void Output_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prosmotr_Tovarov_Click(object sender, EventArgs e)
        {
            Redactor_tovarov Redactor_zakazov = new Redactor_tovarov();
            Redactor_zakazov.Show();
            this.Close();
        }
    }
}
