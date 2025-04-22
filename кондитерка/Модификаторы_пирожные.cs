using System;
using System.Windows.Forms;

namespace экзамен
{
    public partial class Модификаторы_пирожные : Form
    {
        public Модификаторы_пирожные()
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
            if (radioButton1.Checked == true || radioButton5.Checked == true)
            {
                nachinka = 70;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    nachinka = 90;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        nachinka = 80;
                    }
                    else
                    {
                        if (radioButton4.Checked == true || radioButton6.Checked == true || radioButton8.Checked == true)
                        {
                            nachinka = 100;
                        }
                        else
                        {
                            if (radioButton7.Checked == true)
                            {
                                nachinka = 75;
                            }
                        }
                    }
                }
            }

            if (int.TryParse(Colvo.Text, out int colvo))
            {
                colvo = int.Parse(Colvo.Text);
                GlobalPeremen.itogo += colvo * nachinka;
                Выбор_товара выбор_Товара = new Выбор_товара();
                GlobalPeremen.itogoPirozhki += colvo * nachinka;
                this.Close();
            }
            else MessageBox.Show("Введите количество цифрами!");
        }
    }
}
