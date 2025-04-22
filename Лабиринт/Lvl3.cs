using System;
using System.Drawing;
using System.Windows.Forms;

namespace Лабиринт
{
    public partial class Lvl3 : Form
    {
        public Lvl3()
        {
            InitializeComponent();
        }

        bool up1;
        bool down1;
        bool left1;
        bool right1;
        bool up;
        bool down;
        bool left;
        bool right;
        int ok_up;
        int ok_down;
        int ok_left;
        int ok_right;
        bool ящик_есть;

        //Движение человечка
        public void Lvl3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up1 = true;
                ящик_есть = false;
                steni();
                //Проверяем, есть ли ящик, если да, то переходим на "ящики", если нет, то переходим дальше
                PictureBox[] ящики = new PictureBox[] {ящик1, ящик2, ящик3, ящик4, ящик5};
                foreach (PictureBox c in ящики)
                {
                    if (new Point(picture_chel.Location.X, picture_chel.Location.Y - 62 - 6) == c.Location)
                    {
                        ящик_есть = true;
                        yashiki();
                        //ДВИЖЕНИЕ с ящиком РАЗРЕШЕНО
                        if (ok_up == 26 && up == true)
                        {
                            picture_chel.Location = new Point(picture_chel.Location.X, picture_chel.Location.Y - 62 - 6);
                        }
                    }
                }
                        //ДВИЖЕНИЕ без ящика РАЗРЕШЕНО
                        if (ok_up == 26 && ящик_есть == false)
                        {
                            picture_chel.Location = new Point(picture_chel.Location.X, picture_chel.Location.Y - 62 - 6);
                        }
                up1 = false; 
            }
            if (e.KeyCode == Keys.Down)
            {
                down1 = true;
                ящик_есть = false;
                steni();
                //Проверяем, есть ли ящик, если да, то переходим на "ящики", если нет, то переходим дальше
                PictureBox[] ящики = new PictureBox[] { ящик1, ящик2, ящик3, ящик4, ящик5 };
                foreach (PictureBox c in ящики)
                {
                    if (new Point(picture_chel.Location.X, picture_chel.Location.Y + 62 + 6) == c.Location)
                    {
                        ящик_есть = true;
                        yashiki();
                        //ДВИЖЕНИЕ с ящиком РАЗРЕШЕНО
                        if (ok_down == 26 && down == true)
                        {
                            picture_chel.Location = new Point(picture_chel.Location.X, picture_chel.Location.Y + 62 + 6);
                        }
                    }
                }
                //ДВИЖЕНИЕ без ящика РАЗРЕШЕНО
                if (ok_down == 26 && ящик_есть == false)
                {
                    picture_chel.Location = new Point(picture_chel.Location.X, picture_chel.Location.Y + 62 + 6);
                }
                down1 = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left1 = true;
                ящик_есть = false;
                steni();
                //Проверяем, есть ли ящик, если да, то переходим на "ящики", если нет, то переходим дальше
                PictureBox[] ящики = new PictureBox[] { ящик1, ящик2, ящик3, ящик4, ящик5 };
                foreach (PictureBox c in ящики)
                {
                    if (new Point(picture_chel.Location.X - 62 - 6, picture_chel.Location.Y) == c.Location)
                    {
                        ящик_есть = true;
                        yashiki();
                        //ДВИЖЕНИЕ с ящиком РАЗРЕШЕНО
                        if (ok_left == 26 && left == true)
                        {
                            picture_chel.Location = new Point(picture_chel.Location.X - 62 - 6, picture_chel.Location.Y);
                        }
                    }
                }
                //ДВИЖЕНИЕ без ящика РАЗРЕШЕНО
                if (ok_left == 26 && ящик_есть == false)
                {
                    picture_chel.Location = new Point(picture_chel.Location.X - 62 - 6, picture_chel.Location.Y);
                }
                //анимация картинки
                i = 1;
                timer1_left.Start();
                left1 = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right1 = true;
                ящик_есть = false;
                steni();
                //Проверяем, есть ли ящик, если да, то переходим на "ящики", если нет, то переходим дальше
                PictureBox[] ящики = new PictureBox[] { ящик1, ящик2, ящик3, ящик4, ящик5 };
                foreach (PictureBox c in ящики)
                {
                    if (new Point(picture_chel.Location.X + 62 + 6, picture_chel.Location.Y) == c.Location)
                    {
                        ящик_есть = true;
                        yashiki();
                        //ДВИЖЕНИЕ с ящиком РАЗРЕШЕНО
                        if (ok_right == 26 && right == true)
                        {
                            picture_chel.Location = new Point(picture_chel.Location.X + 62 + 6, picture_chel.Location.Y);
                        }
                    }
                }
                //ДВИЖЕНИЕ без ящика РАЗРЕШЕНО
                if (ok_right == 26 && ящик_есть == false)
                {
                    picture_chel.Location = new Point(picture_chel.Location.X + 62 + 6, picture_chel.Location.Y);
                }
                //анимация картинки
                i = 1;
                timer1_right.Start();
                right1 = false;
            }
            finish();
        }
       
        //Если задеты стенки
        public void steni()
        {
            ok_up = 0;
            ok_down = 0;
            ok_left = 0;
            ok_right = 0;

            Label[] stenki = new Label[] { стена1, стена2, стена3, стена4, стена5, стена6, стена7, стена8, стена9, стена10, стена11, стена12, стена13, стена14, стена15, стена16, стена17, стена18, стена19, стена20, стена21, стена22, стена23, стена24, стена25, стена26};
            foreach (Label c in stenki)
            {
                if (c.Location != new Point(picture_chel.Location.X, picture_chel.Location.Y - 62 - 6))
                {
                    ok_up++;
                }
                if (c.Location != new Point(picture_chel.Location.X, picture_chel.Location.Y + 62 + 6))
                {
                    ok_down++;
                }
                if (c.Location != new Point(picture_chel.Location.X - 62 - 6, picture_chel.Location.Y))
                {
                    ok_left++;
                }
                if (c.Location != new Point(picture_chel.Location.X + 62 + 6, picture_chel.Location.Y))
                {
                    ok_right++;
                }
            }
        }

        //Если есть ящик
        public void yashiki()
        {
            up = false;
            down = false;
            left = false;
            right = false;
            bool cancel = false;
            PictureBox[] ящики = new PictureBox[] { ящик1, ящик2, ящик3, ящик4, ящик5 };
            foreach (PictureBox ящик in ящики)
            {
                if (ящик.Location == new Point(picture_chel.Location.X, picture_chel.Location.Y - 62 - 6) && up1==true)//находим ящик, который следует за челом
                {
                    PictureBox[] ящики2 = new PictureBox[] { ящик1, ящик2, ящик3, ящик4, ящик5 };
                    foreach (PictureBox ящик2 in ящики2)
                    {
                        if (new Point(ящик.Location.X, ящик.Location.Y - 62 - 6) == ящик2.Location)//ищем возможный ящик за ящиком
                        {
                            up = false;
                            cancel = true;
                        }
                    }
                    if (cancel == false)
                    {
                        Label[] stenki = new Label[] { стена1, стена2, стена3, стена4, стена5, стена6, стена7, стена8, стена9, стена10, стена11, стена12, стена13, стена14, стена15, стена16, стена17, стена18, стена19, стена20, стена21, стена22, стена23, стена24, стена25, стена26 };
                        foreach (Label c in stenki)
                        {
                            if (new Point(picture_chel.Location.X, picture_chel.Location.Y - 62 - 6 - 62 - 6) == c.Location)//если на пути ящика нет стен
                            {
                                up = false;
                                cancel = true;
                            }
                        }
                    }
                    if (cancel == false)
                    {
                        ящик.Location = new Point(picture_chel.Location.X, picture_chel.Location.Y - 62 - 6 - 62 - 6);
                        up = true;
                    }
                    break;
                }
                if (ящик.Location == new Point(picture_chel.Location.X, picture_chel.Location.Y + 62 + 6) && down1 == true)//находим ящик, который следует за челом
                {
                    PictureBox[] ящики2 = new PictureBox[] { ящик1, ящик2, ящик3, ящик4, ящик5 };
                    foreach (PictureBox ящик2 in ящики2)
                    {
                        if (new Point(ящик.Location.X, ящик.Location.Y + 62 + 6) == ящик2.Location)//ищем возможный ящик за ящиком
                        {
                            down = false;
                            cancel = true;
                        }
                    }
                    if (cancel == false)
                    {
                        Label[] stenki = new Label[] { стена1, стена2, стена3, стена4, стена5, стена6, стена7, стена8, стена9, стена10, стена11, стена12, стена13, стена14, стена15, стена16, стена17, стена18, стена19, стена20, стена21, стена22, стена23, стена24, стена25, стена26 };
                        foreach (Label c in stenki)
                        {
                            if (new Point(picture_chel.Location.X, picture_chel.Location.Y + 62 + 6 + 62 + 6) == c.Location)//если на пути ящика нет стен
                            {
                                down = false;
                                cancel = true;
                            }
                        }
                    }
                    if (cancel == false)
                    {
                        ящик.Location = new Point(picture_chel.Location.X, picture_chel.Location.Y + 62 + 6 + 62 + 6);
                        down = true;
                    }
                    break;
                }
                if (ящик.Location == new Point(picture_chel.Location.X - 62 - 6, picture_chel.Location.Y) && left1 == true)//находим ящик, который следует за челом
                {
                    PictureBox[] ящики2 = new PictureBox[] { ящик1, ящик2, ящик3, ящик4, ящик5 };
                    foreach (PictureBox ящик2 in ящики2)
                    {
                        if (new Point(ящик.Location.X - 62 - 6, ящик.Location.Y) == ящик2.Location)//ищем возможный ящик за ящиком
                        {
                            left = false;
                            cancel = true;
                        }
                    }
                    if (cancel == false)
                    {
                        Label[] stenki = new Label[] { стена1, стена2, стена3, стена4, стена5, стена6, стена7, стена8, стена9, стена10, стена11, стена12, стена13, стена14, стена15, стена16, стена17, стена18, стена19, стена20, стена21, стена22, стена23, стена24, стена25, стена26 };
                        foreach (Label c in stenki)
                        {
                            if (new Point(picture_chel.Location.X - 62 - 6 - 62 - 6, picture_chel.Location.Y) == c.Location)//если на пути ящика нет стен
                            {
                                left = false;
                                cancel = true;
                            }
                        }
                    }
                    if (cancel == false)
                    {
                        ящик.Location = new Point(picture_chel.Location.X - 62 - 6 - 62 - 6, picture_chel.Location.Y);
                        left = true;
                    }
                    break;
                }
                if (ящик.Location == new Point(picture_chel.Location.X + 62 + 6, picture_chel.Location.Y) && right1 == true)//находим ящик, который следует за челом
                {
                    PictureBox[] ящики2 = new PictureBox[] { ящик1, ящик2, ящик3, ящик4, ящик5 };
                    foreach (PictureBox ящик2 in ящики2)
                    {
                        if (new Point(ящик.Location.X + 62 + 6, ящик.Location.Y) == ящик2.Location)//ищем возможный ящик за ящиком
                        {
                            right = false;
                            cancel = true;
                        }
                    }
                    if (cancel == false)
                    {
                        Label[] stenki = new Label[] { стена1, стена2, стена3, стена4, стена5, стена6, стена7, стена8, стена9, стена10, стена11, стена12, стена13, стена14, стена15, стена16, стена17, стена18, стена19, стена20, стена21, стена22, стена23, стена24, стена25, стена26 };
                        foreach (Label c in stenki)
                        {
                            if (new Point(picture_chel.Location.X + 62 + 6 + 62 + 6, picture_chel.Location.Y) == c.Location)//если на пути ящика нет стен
                            {
                                right = false;
                                cancel = true;
                            }
                        }
                    }
                    if (cancel == false)
                    {
                        ящик.Location = new Point(picture_chel.Location.X + 62 + 6 + 62 + 6, picture_chel.Location.Y);
                        right = true;
                    }
                    break;
                }
            }
        }

        public int i;
        private void timer1_left_Tick(object sender, EventArgs e)
        {
            if (i == 1)
                picture_chel.Image = Properties.Resources.движение_в_лево;
            if (i == 3)
            {
                picture_chel.Image = Properties.Resources.прямо_стоит;
                timer1_left.Stop();
            }
            i++;
        }
        private void timer1_right_Tick(object sender, EventArgs e)
        {
            if (i == 1)
                picture_chel.Image = Properties.Resources.движение_в_право;
            if (i == 3)
            {
                picture_chel.Image = Properties.Resources.прямо_стоит;
                timer1_right.Stop();
            } 
            i++;
        }
        int finish_ = 0;
        public void finish()
        {
            PictureBox[] ящики = new PictureBox[] { ящик1, ящик2, ящик3, ящик4, ящик5 };
            foreach (PictureBox c in ящики)
            {
                Label[] финиш = new Label[] { финиш1, финиш2, финиш3, финиш3, финиш5 };
                foreach (Label d in финиш)
                {
                    if (d.Location == c.Location)
                    {
                        c.Image = Properties.Resources.ящик2;

                        Label[] финиш_2 = new Label[] { финиш1, финиш2, финиш3, финиш4, финиш5 };
                        foreach (Label e in финиш_2)
                        {
                            if (c.Location == e.Location && c.Image != Properties.Resources.ящик)
                            {
                                finish_++;
                            }
                        }
                    }
                }
            }
            PictureBox[] ящики2 = new PictureBox[] { ящик1, ящик2, ящик3, ящик4, ящик5 };
            foreach (PictureBox c in ящики2)
            {
                Label[] финиш_ = new Label[] { финиш6, финиш7, финиш8, финиш9, финиш10, финиш11, финиш12 };
                foreach (Label d in финиш_)
                {
                    if (d.Location == c.Location && c.Image != Properties.Resources.ящик)
                    {
                        c.Image = Properties.Resources.ящик;
                    }
                }
            }
        
               if (finish_ == 5)
               {
               MessageBox.Show("Вы выйграли!!! Поздравляю! Если хотите еще уровней, пишите)))");
               Select_a_level select_A_Level = new Select_a_level();
               select_A_Level.Show();
               this.Close();
               }
            
            finish_ = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Lvl3 Lvl3 = new Lvl3();
            Lvl3.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
