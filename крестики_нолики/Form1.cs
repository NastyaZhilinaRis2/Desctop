using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace крестики_нолики
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool a = true; //пусть если true, то рисуется крестик
        private void label1_Click(object sender, EventArgs e)
        {

            if (label1.Text == "")
            {
                if (a == true) label1.Text = "X";
                else label1.Text = "O";
                label1.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                label1.Enabled = true;
                a = !a;
                proverka();
            }
            else MessageBox.Show("Это поле занято!");

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "")
            {
                if (a == true) label2.Text = "X";
                else label2.Text = "O";
                label2.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                label2.Enabled = true;
                a = !a;
                proverka();
            }
            else MessageBox.Show("Это поле занято!");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                if (a == true) label3.Text = "X";
                else label3.Text = "O";
                label3.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                label3.Enabled = true;
                a = !a;
                proverka();
            }
            else MessageBox.Show("Это поле занято!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "")
            {
                if (a == true) label4.Text = "X";
                else label4.Text = "O";
                label4.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                label4.Enabled = true;
                a = !a;
                proverka();
            }
            else MessageBox.Show("Это поле занято!");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "")
            {
                if (a == true) label5.Text = "X";
                else label5.Text = "O";
                label5.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                label5.Enabled = true;
                a = !a;
                proverka();
            }
            else MessageBox.Show("Это поле занято!");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "")
            {
                if (a == true) label6.Text = "X";
                else label6.Text = "O";
                label6.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                label6.Enabled = true;
                a = !a;
                proverka();
            }
            else MessageBox.Show("Это поле занято!");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == "")
            {
                if (a == true) label7.Text = "X";
                else label7.Text = "O";
                label7.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                label7.Enabled = true;
                a = !a;
                proverka();
            }
            else MessageBox.Show("Это поле занято!");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "")
            {
                if (a == true) label8.Text = "X";
                else label8.Text = "O";
                label8.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                label8.Enabled = true;
                a = !a;
                proverka();
            }
            else MessageBox.Show("Это поле занято!");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.Text == "")
            {
                if (a == true) label9.Text = "X";
                else label9.Text = "O";
                label9.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                label9.Enabled = true;
                a = !a;
                proverka();
            }
            else MessageBox.Show("Это поле занято!");
        }
        private void proverka()
        {
            if (label1.Text == "X" && label2.Text == "X" && label3.Text == "X" || label1.Text == "O" && label2.Text == "O" && label3.Text == "O" || label4.Text == "X" && label5.Text == "X" && label6.Text == "X" || label4.Text == "O" && label5.Text == "O" && label6.Text == "O" || label7.Text == "X" && label8.Text == "X" && label9.Text == "X" || label7.Text == "O" && label8.Text == "O" && label9.Text == "O"|| label1.Text == "X" && label4.Text == "X" && label7.Text == "X" || label1.Text == "O" && label4.Text == "O" && label7.Text == "O"|| label2.Text == "X" && label5.Text == "X" && label8.Text == "X" || label2.Text == "O" && label5.Text == "O" && label8.Text == "O"|| label3.Text == "X" && label6.Text == "X" && label9.Text == "X" || label3.Text == "O" && label6.Text == "O" && label9.Text == "O"|| label1.Text == "X" && label5.Text == "X" && label9.Text == "X" || label1.Text == "O" && label5.Text == "O" && label9.Text == "O"|| label7.Text == "X" && label5.Text == "X" && label3.Text == "X" || label7.Text == "O" && label5.Text == "O" && label3.Text == "O")
            {
                MessageBox.Show("Вы выиграли!");
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                a = true;
            }
        }


    }
}
