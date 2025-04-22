
namespace Пицц_
{
    partial class Oplata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oplata));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beznal_oplata = new System.Windows.Forms.CheckBox();
            this.label_summa = new System.Windows.Forms.Label();
            this.zavershit_zakaz = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.oplata_posle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(323, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 126);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(82)))), ((int)(((byte)(8)))));
            this.label4.Location = new System.Drawing.Point(41, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Заполните данные об оплате\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Сумма:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Безналичная оплата:";
            // 
            // beznal_oplata
            // 
            this.beznal_oplata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beznal_oplata.AutoSize = true;
            this.beznal_oplata.Location = new System.Drawing.Point(272, 272);
            this.beznal_oplata.Name = "beznal_oplata";
            this.beznal_oplata.Size = new System.Drawing.Size(15, 14);
            this.beznal_oplata.TabIndex = 33;
            this.beznal_oplata.UseVisualStyleBackColor = true;
            // 
            // label_summa
            // 
            this.label_summa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_summa.AutoSize = true;
            this.label_summa.BackColor = System.Drawing.Color.Transparent;
            this.label_summa.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_summa.ForeColor = System.Drawing.Color.Black;
            this.label_summa.Location = new System.Drawing.Point(131, 204);
            this.label_summa.Name = "label_summa";
            this.label_summa.Size = new System.Drawing.Size(19, 29);
            this.label_summa.TabIndex = 34;
            this.label_summa.Text = " ";
            // 
            // zavershit_zakaz
            // 
            this.zavershit_zakaz.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.zavershit_zakaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(82)))), ((int)(((byte)(8)))));
            this.zavershit_zakaz.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.zavershit_zakaz.Location = new System.Drawing.Point(149, 383);
            this.zavershit_zakaz.Name = "zavershit_zakaz";
            this.zavershit_zakaz.Size = new System.Drawing.Size(195, 53);
            this.zavershit_zakaz.TabIndex = 43;
            this.zavershit_zakaz.Text = "Оплатить";
            this.zavershit_zakaz.UseVisualStyleBackColor = false;
            this.zavershit_zakaz.Click += new System.EventHandler(this.zavershit_zakaz_Click);
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.Back.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.Back.Location = new System.Drawing.Point(12, 385);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(131, 53);
            this.Back.TabIndex = 44;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.Output.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.Output.Location = new System.Drawing.Point(657, 385);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(131, 53);
            this.Output.TabIndex = 45;
            this.Output.Text = "Выход";
            this.Output.UseVisualStyleBackColor = false;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // oplata_posle
            // 
            this.oplata_posle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.oplata_posle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(82)))), ((int)(((byte)(8)))));
            this.oplata_posle.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.oplata_posle.Location = new System.Drawing.Point(363, 383);
            this.oplata_posle.Name = "oplata_posle";
            this.oplata_posle.Size = new System.Drawing.Size(288, 53);
            this.oplata_posle.TabIndex = 46;
            this.oplata_posle.Text = "После доставки";
            this.oplata_posle.UseVisualStyleBackColor = false;
            this.oplata_posle.Click += new System.EventHandler(this.oplata_posle_Click);
            // 
            // Oplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oplata_posle);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.zavershit_zakaz);
            this.Controls.Add(this.label_summa);
            this.Controls.Add(this.beznal_oplata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Oplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата";
            this.Load += new System.EventHandler(this.Oplata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox beznal_oplata;
        private System.Windows.Forms.Label label_summa;
        private System.Windows.Forms.Button zavershit_zakaz;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.Button oplata_posle;
    }
}