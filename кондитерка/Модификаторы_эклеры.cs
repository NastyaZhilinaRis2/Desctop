using System;
using System.Windows.Forms;

namespace экзамен
{
    public partial class Модификаторы_эклеры : Form
    {
        public Модификаторы_эклеры()
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
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                nachinka = 40;
            }
            else
            {
                if (radioButton3.Checked == true)
                {
                    nachinka = 35;
                }
            }

            if (int.TryParse(Colvo.Text, out int colvo))
            {
                colvo = int.Parse(Colvo.Text);
                GlobalPeremen.itogo += colvo * nachinka;
                Выбор_товара выбор_Товара = new Выбор_товара();
                GlobalPeremen.itogoEcleri += colvo * nachinka;
                this.Close();
            }
            else MessageBox.Show("Введите количество цифрами!");
        }
    }
}
