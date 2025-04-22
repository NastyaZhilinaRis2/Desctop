using System;
using System.Windows.Forms;

namespace экзамен
{
    public partial class Модификаторы_круассаны : Form
    {
        public Модификаторы_круассаны()
        {
            InitializeComponent();
        }
        private void otmena_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void add_Click(object sender, EventArgs e)
        {
            int nachinka = 0;
            if (radioButton1.Checked == true)
            {
                nachinka = 10;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    nachinka = 25;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        nachinka = 20;
                    }
                }
            }
            if (int.TryParse(Colvo.Text, out int colvo))
            {
                colvo = int.Parse(Colvo.Text);
                GlobalPeremen.itogo += colvo * nachinka;
                Выбор_товара выбор_Товара = new Выбор_товара();
                GlobalPeremen.itogoKruassan += colvo * nachinka;
                this.Close();
            }
            else MessageBox.Show("Введите количество цифрами!");
        }
    }
}
