using System;
using System.Windows.Forms;

namespace экзамен
{
    public partial class Модификаторы_печенья : Form
    {
        public Модификаторы_печенья()
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
            if (radioButton1.Checked == true || radioButton8.Checked == true || radioButton10.Checked == true)
            {
                nachinka = 40;
            }
            else
            {
                if (radioButton2.Checked == true || radioButton5.Checked == true || radioButton9.Checked == true)
                {
                    nachinka = 35;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        nachinka = 70;
                    }
                    else
                    {
                        if (radioButton4.Checked == true || radioButton7.Checked == true)
                        {
                            nachinka = 50;
                        }
                        else
                        {
                            if (radioButton6.Checked == true)
                            {
                                nachinka = 20;
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
                GlobalPeremen.itogoPechnki += colvo * nachinka;
                this.Close();
            }
            else MessageBox.Show("Введите количество цифрами!");
        }
    }
}
