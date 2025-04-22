using System;
using System.Drawing;
using System.Windows.Forms;

namespace Лабиринт
{
    public partial class Lvl1 : Form
    {
        public Lvl1()
        {
            InitializeComponent();
        }
        private void Lvl1_Activated(object sender, EventArgs e)
        {
            if (this.Size.Width > SystemInformation.PrimaryMonitorSize.Width || this.Size.Height > SystemInformation.PrimaryMonitorSize.Height)
            {
                this.Size = SystemInformation.PrimaryMonitorSize;
            }
        }

        private void start_game()
        {
            Point point = start.Location;
            point.Offset(start.Width / 2, start.Height / 2);
            Cursor.Position = PointToScreen(point);
        }
        private void finish_game()
        {
            if (MessageBox.Show("Вы проиграли..Попробуем еще раз?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                start_game();
            }

            else Application.Exit();
        }
        private void Lvl1_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Select_a_level.otcr_lvl.lvl_2 = true;
            MessageBox.Show("Вы выйграли! Вам открыт новый уровень.");
            Select_a_level select_A_Level = new Select_a_level();
            select_A_Level.Show();
            this.Close();
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
    }
}
