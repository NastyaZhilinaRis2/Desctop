using System;
using System.Drawing;
using System.Windows.Forms;

namespace Приветствие
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            int h = DateTime.Now.Hour;

            //ночь
            if (h >= 0 && h <= 4)
            {
                this.BackgroundImage = Properties.Resources.ночь;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                Label label_text_privetstvie = new Label();
                label_text_privetstvie.Text = "Доброй ночи!";
                label_text_privetstvie.BackColor = Color.Transparent;
                label_text_privetstvie.ForeColor = Color.White;
                label_text_privetstvie.TextAlign = ContentAlignment.MiddleCenter;
                label_text_privetstvie.AutoSize = false;
                label_text_privetstvie.Location = new Point(0, 0);
                label_text_privetstvie.Size = this.Size;
                label_text_privetstvie.Font = new Font("Microsoft Sans Serif", 36, FontStyle.Regular);
                Controls.Add(label_text_privetstvie);
            }
            //утро
            if (h >= 5 && h <= 11)
            {

                this.BackgroundImage = Properties.Resources.утро;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                Label label_text_privetstvie = new Label();
                label_text_privetstvie.Text = "Доброе утро!";
                label_text_privetstvie.BackColor = Color.Transparent;
                label_text_privetstvie.ForeColor = Color.White;
                label_text_privetstvie.TextAlign = ContentAlignment.MiddleCenter;
                label_text_privetstvie.AutoSize = false;
                label_text_privetstvie.Location = new Point(0, 0);
                label_text_privetstvie.Size = this.Size;
                label_text_privetstvie.Font = new Font("Microsoft Sans Serif", 36, FontStyle.Regular);
                Controls.Add(label_text_privetstvie);
            }
            //день
            if (h >= 12 && h <= 16)
            {
                this.BackgroundImage = Properties.Resources.день;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                Label label_text_privetstvie = new Label();
                label_text_privetstvie.Text = "Добрый день!";
                label_text_privetstvie.BackColor = Color.Transparent;
                label_text_privetstvie.ForeColor = Color.Black;
                label_text_privetstvie.TextAlign = ContentAlignment.MiddleCenter;
                label_text_privetstvie.AutoSize = false;
                label_text_privetstvie.Location = new Point(0, 0);
                label_text_privetstvie.Size = this.Size;
                label_text_privetstvie.Font = new Font("Microsoft Sans Serif", 36, FontStyle.Regular);
                Controls.Add(label_text_privetstvie);
            }
            //вечер
            if (h >= 17 && h <= 23)
            {
                this.BackgroundImage = Properties.Resources.вечер;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                Label label_text_privetstvie = new Label();
                label_text_privetstvie.Text = "Добрый вечер!";
                label_text_privetstvie.BackColor = Color.Transparent;
                label_text_privetstvie.ForeColor = Color.White;
                label_text_privetstvie.TextAlign = ContentAlignment.MiddleCenter;
                label_text_privetstvie.AutoSize = false;
                label_text_privetstvie.Location = new Point(0, 0);
                label_text_privetstvie.Size = this.Size;
                label_text_privetstvie.Font = new Font("Microsoft Sans Serif", 36, FontStyle.Regular);
                Controls.Add(label_text_privetstvie);
            }
        }
    }
}
