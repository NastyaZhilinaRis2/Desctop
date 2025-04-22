using System;
using System.Windows.Forms;

namespace экзамен
{
    public partial class Выбор_товара : Form
    {
        public Выбор_товара()
        {
            InitializeComponent();
        }

        private void kruassan_Click(object sender, EventArgs e)
        {
            Модификаторы_круассаны modificator = new Модификаторы_круассаны();
            modificator.ShowDialog();
            itog.Text = GlobalPeremen.itogo.ToString();
            this.Refresh();
        }

        private void pirog_Click(object sender, EventArgs e)
        {
            Модификаторы_пироги modificator = new Модификаторы_пироги();
            modificator.ShowDialog();
            itog.Text = GlobalPeremen.itogo.ToString();
            this.Refresh();
        }

        private void bulochki_Click(object sender, EventArgs e)
        {
            Модификаторы_булочки modificator = new Модификаторы_булочки();
            modificator.ShowDialog();
            itog.Text = GlobalPeremen.itogo.ToString();
            this.Refresh();
        }

        private void ecler_Click(object sender, EventArgs e)
        {
            Модификаторы_эклеры modificator = new Модификаторы_эклеры();
            modificator.ShowDialog();
            itog.Text = GlobalPeremen.itogo.ToString();
            this.Refresh();
        }

        private void pechene_Click(object sender, EventArgs e)
        {
            Модификаторы_печенья modificator = new Модификаторы_печенья();
            modificator.ShowDialog();
            itog.Text = GlobalPeremen.itogo.ToString();
            this.Refresh();
        }

        private void piroznki_Click(object sender, EventArgs e)
        {
            Модификаторы_пирожные modificator = new Модификаторы_пирожные();
            modificator.ShowDialog();
            itog.Text = GlobalPeremen.itogo.ToString();
            this.Refresh();
        }

        private void add_Click(object sender, EventArgs e)
        {
            чек чек = new чек();
            чек.Show();
        }
    }
}