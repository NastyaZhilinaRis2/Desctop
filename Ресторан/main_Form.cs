using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class main_Form : Form
    {
        public main_Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2_menu Form2_menu = new Form2_menu();
            Form2_menu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_zakaz Form_zakaz = new Form_zakaz();
            Form_zakaz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_prosmotr_zakazov Form_prosmotr_zakazov = new Form_prosmotr_zakazov();
            Form_prosmotr_zakazov.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_personal Form_personal = new Form_personal();
            Form_personal.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Forma_dolzhnosti Forma_dolzhnosti = new Forma_dolzhnosti();
            Forma_dolzhnosti.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Otchet_po_prodazham Otchet_po_prodazham = new Otchet_po_prodazham();
            Otchet_po_prodazham.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sclad Sclad = new Sclad();
            Sclad.Show();
        }
    }
}
