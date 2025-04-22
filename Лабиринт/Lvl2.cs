using System;
using System.Drawing;
using System.Windows.Forms;

namespace Лабиринт
{
    public partial class Lvl2 : Form
    {
        public Lvl2()
        {
            InitializeComponent();
        }
        private void Lvl2_Shown(object sender, EventArgs e)
        {
            start_game();
        }
        private void start_game()
        {

            start.Location = new Point(26, 710);
            start.Location = new Point(26, 710);
            finish.Location = new Point(1113, 23);
            finish.Location = new Point(1113, 23);

            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer6.Start();
            timer8.Start();

            Point point = start.Location;
            point.Offset(start.Width / 2, start.Height / 2);
            Cursor.Position = PointToScreen(point);
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы проиграли..Попробуем еще раз?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                start_game();
            }

            else Application.Exit();
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Select_a_level.otcr_lvl.lvl_3 = true;
            MessageBox.Show("Туц туц! Вам открыт новый уровень.");
            Select_a_level select_A_Level = new Select_a_level();
            select_A_Level.Show();
            this.Close();
        }
        bool napravlenie2 = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((label7.Location.X + label7.Size.Width) <= this.Width && napravlenie2 == true)
            {
                label7.Location = new Point(label7.Location.X + 10, label7.Location.Y);
            }
            if ((label7.Location.X + label7.Size.Width) > this.Width)
            {
                napravlenie2 = false;
            }
            if ((label7.Location.X) > 0 && napravlenie2 == false)
            {
                label7.Location = new Point(label7.Location.X - 10, label7.Location.Y);
            }
            if ((label7.Location.X) <= 0)
            {
                napravlenie2 = true;
            }
        }
        bool napravlenie3 = false;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if ((label8.Location.X + label8.Size.Width) <= this.Width && napravlenie3 == true)
            {
                label8.Location = new Point(label8.Location.X + 10, label8.Location.Y);
            }
            if ((label8.Location.X + label8.Size.Width) > this.Width)
            {
                napravlenie3 = false;
            }
            if ((label8.Location.X) > 0 && napravlenie3 == false)
            {
                label8.Location = new Point(label8.Location.X - 10, label8.Location.Y);
            }
            if ((label8.Location.X) <= 0)
            {
                napravlenie3 = true;
            }
        }
        bool napravlenie4 = true;
        private void timer4_Tick(object sender, EventArgs e)
        {
            if ((label9.Location.X + label9.Size.Width) <= this.Width && napravlenie4 == true)
            {
                label9.Location = new Point(label9.Location.X + 10, label9.Location.Y);
            }
            if ((label9.Location.X + label9.Size.Width) > this.Width)
            {
                napravlenie4 = false;
            }
            if ((label9.Location.X) > 0 && napravlenie4 == false)
            {
                label9.Location = new Point(label9.Location.X - 10, label9.Location.Y);
            }
            if ((label9.Location.X) <= 0)
            {
                napravlenie4 = true;
            }
        }
        bool napravlenie6 = true;
        private void timer6_Tick(object sender, EventArgs e)
        {
            if ((label11.Location.X + label11.Size.Width) <= this.Width && napravlenie6 == true)
            {
                label11.Location = new Point(label11.Location.X + 10, label11.Location.Y);
            }
            if ((label11.Location.X + label11.Size.Width) > this.Width)
            {
                napravlenie6 = false;
            }
            if ((label11.Location.X) > 0 && napravlenie6 == false)
            {
                label11.Location = new Point(label11.Location.X - 10, label11.Location.Y);
            }
            if ((label11.Location.X) <= 0)
            {
                napravlenie6 = true;
            }
        }
        bool napravlenie8 = true;
        private void timer8_Tick(object sender, EventArgs e)
        {
            if ((label13.Location.X + label13.Size.Width) <= this.Width && napravlenie8 == true)
            {
                label13.Location = new Point(label13.Location.X + 10, label13.Location.Y);
            }
            if ((label13.Location.X + label13.Size.Width) > this.Width)
            {
                napravlenie8 = false;
            }
            if ((label13.Location.X) > 0 && napravlenie8 == false)
            {
                label13.Location = new Point(label13.Location.X - 10, label13.Location.Y);
            }
            if ((label13.Location.X) <= 0)
            {
                napravlenie8 = true;
            }
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            finish.Location = new Point(26, 710);
            finish.Location = new Point(26, 710);
            start.Location = new Point(1144, 23);
            start.Location = new Point(1144, 23);
        }
    }
}
