using System;
using System.Drawing;
using System.Windows.Forms;

namespace экзамен
{
    public partial class чек : Form
    {
        public чек()
        {
            InitializeComponent();
        }

        private void чек_Load(object sender, EventArgs e)
        {
            int x = 30;
            if (GlobalPeremen.itogoKruassan != 0)
            {
                Label label1 = new Label(); 
                label1.Location = new Point(20, x);
                label1.AutoSize = true;
                label1.Text = "Круассаны.........................." + GlobalPeremen.itogoKruassan; 
                Controls.Add(label1); 
                x += 30;
            }
            if (GlobalPeremen.itogoPirogi != 0)
            {
                Label label1 = new Label();
                label1.Location = new Point(20, x);
                label1.AutoSize = true;
                label1.Text = "Пироги................................" + GlobalPeremen.itogoPirogi;
                Controls.Add(label1);
                x += 30;
            }
            if (GlobalPeremen.itogoBulki != 0)
            {
                Label label1 = new Label();
                label1.Location = new Point(20, x);
                label1.AutoSize = true;
                label1.Text = "Булочки..............................." + GlobalPeremen.itogoBulki;
                Controls.Add(label1);
                x += 30;
            }
            if (GlobalPeremen.itogoEcleri != 0)
            {
                Label label1 = new Label();
                label1.Location = new Point(20, x);
                label1.AutoSize = true;
                label1.Text = "Эклеры..............................." + GlobalPeremen.itogoEcleri;
                Controls.Add(label1);
                x += 30;
            }
            if (GlobalPeremen.itogoPechnki != 0)
            {
                Label label1 = new Label();
                label1.Location = new Point(20, x);
                label1.AutoSize = true;
                label1.Text = "Печенье.............................." + GlobalPeremen.itogoPechnki;
                Controls.Add(label1);
                x += 30;
            }
            if (GlobalPeremen.itogoPirozhki != 0)
            {
                Label label1 = new Label();
                label1.Location = new Point(20, x);
                label1.AutoSize = true;
                label1.Text = "Пирожные.........................." + GlobalPeremen.itogoPirozhki;
                Controls.Add(label1);
                x += 30;
            }
            itogo.Text = GlobalPeremen.itogo.ToString();
        }
    }
}
