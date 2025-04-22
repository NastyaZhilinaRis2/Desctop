using System;
using System.Windows.Forms;

namespace Лабиринт
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Activated(object sender, EventArgs e)
        {
            if (this.Size.Width > SystemInformation.PrimaryMonitorSize.Width || this.Size.Height > SystemInformation.PrimaryMonitorSize.Height)
            {
                this.Size = SystemInformation.PrimaryMonitorSize;
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            Select_a_level Frm2 = new Select_a_level();
            Frm2.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Box_sound_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_sound.Checked)
            {
                music.music_on();
                music.music_play();
            }
            else
            {
                music.music_off(); 
                music.music_play();
            }
        }
    }
}
