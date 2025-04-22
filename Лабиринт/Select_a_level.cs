using System;
using System.Windows.Forms;

namespace Лабиринт
{
    public partial class Select_a_level : Form
    {
        public Select_a_level()
        {
            InitializeComponent();
        }
        public class otcr_lvl
        {
            public static bool lvl_2 = false;
            public static bool lvl_3 = false;
        }
        
        private void Select_a_level_Activated(object sender, EventArgs e)
        {
            if (this.Size.Width > SystemInformation.PrimaryMonitorSize.Width|| this.Size.Height > SystemInformation.PrimaryMonitorSize.Height)
            {
                this.Size = SystemInformation.PrimaryMonitorSize;
            }
            if (otcr_lvl.lvl_2 == false)
            {
                button_2_level.Enabled = false;
            }
            if (otcr_lvl.lvl_3 == false)
            {
                button_3_level.Enabled = false;
            }
        }

        //выход с кнопки
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //кнопка - переход назад на меню
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //кнопка - переход на 1 уровень
        private void button_1_level_Click(object sender, EventArgs e)
        {
            Lvl1 Lvl1 = new Lvl1();
            Lvl1.Show();
            this.Close();
        }
        //кнопка - переход на 2 уровень
        private void button_2_level_Click(object sender, EventArgs e)
        {
            Lvl2 Lvl2 = new Lvl2();
            Lvl2.Show();
            this.Close();
        }
        //кнопка - переход на 3 уровень
        private void button_3_level_Click(object sender, EventArgs e)
        {
            Lvl3 Lvl3 = new Lvl3();
            Lvl3.Show();
            this.Close();
        }
    }
}
