using System;
using System.Windows.Forms;

namespace экзамен
{
    public partial class Модификаторы_пироги : Form
    {
        public Модификаторы_пироги()
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
                nachinka = 40;
            }
            else
            {
                if (radioButton3.Checked == true || radioButton6.Checked == true)
                {
                    nachinka = 25;
                }
                else
                {
                    if (radioButton2.Checked == true || radioButton5.Checked == true || radioButton7.Checked == true)
                    {
                        nachinka = 20;
                    }
                    else
                    {
                        if (radioButton4.Checked == true)
                        {
                            nachinka = 30;
                        }
                    }
                }
            }

            if (int.TryParse(Colvo.Text, out int colvo))
            {
                colvo = int.Parse(Colvo.Text);
                GlobalPeremen.itogo += colvo * nachinka;
                Выбор_товара выбор_Товара = new Выбор_товара();
                GlobalPeremen.itogoPirogi += colvo * nachinka;
                this.Close();
            }
            else MessageBox.Show("Введите количество цифрами!");
        }
    }
}
