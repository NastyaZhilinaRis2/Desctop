
namespace Пицц_
{
    partial class Sozdaniye_Zakaza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sozdaniye_Zakaza));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2_Bludo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colvo_porciy = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.dobavit_k_zakazu = new System.Windows.Forms.Button();
            this.zavershit_zakaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_categoriya = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Meneger = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Количество порций:";
            // 
            // comboBox2_Bludo
            // 
            this.comboBox2_Bludo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2_Bludo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.comboBox2_Bludo.FormattingEnabled = true;
            this.comboBox2_Bludo.Location = new System.Drawing.Point(246, 237);
            this.comboBox2_Bludo.Name = "comboBox2_Bludo";
            this.comboBox2_Bludo.Size = new System.Drawing.Size(316, 34);
            this.comboBox2_Bludo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Название блюда:";
            // 
            // colvo_porciy
            // 
            this.colvo_porciy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colvo_porciy.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.colvo_porciy.Location = new System.Drawing.Point(275, 280);
            this.colvo_porciy.Name = "colvo_porciy";
            this.colvo_porciy.Size = new System.Drawing.Size(62, 34);
            this.colvo_porciy.TabIndex = 17;
            this.colvo_porciy.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.Back.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.Back.Location = new System.Drawing.Point(12, 385);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(131, 53);
            this.Back.TabIndex = 21;
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
            this.Output.TabIndex = 22;
            this.Output.Text = "Выход";
            this.Output.UseVisualStyleBackColor = false;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // dobavit_k_zakazu
            // 
            this.dobavit_k_zakazu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dobavit_k_zakazu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(82)))), ((int)(((byte)(8)))));
            this.dobavit_k_zakazu.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.dobavit_k_zakazu.Location = new System.Drawing.Point(156, 385);
            this.dobavit_k_zakazu.Name = "dobavit_k_zakazu";
            this.dobavit_k_zakazu.Size = new System.Drawing.Size(181, 53);
            this.dobavit_k_zakazu.TabIndex = 23;
            this.dobavit_k_zakazu.Text = "Добавить";
            this.dobavit_k_zakazu.UseVisualStyleBackColor = false;
            this.dobavit_k_zakazu.Click += new System.EventHandler(this.dobavit_k_zakazu_Click);
            // 
            // zavershit_zakaz
            // 
            this.zavershit_zakaz.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.zavershit_zakaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(82)))), ((int)(((byte)(8)))));
            this.zavershit_zakaz.Enabled = false;
            this.zavershit_zakaz.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.zavershit_zakaz.Location = new System.Drawing.Point(443, 385);
            this.zavershit_zakaz.Name = "zavershit_zakaz";
            this.zavershit_zakaz.Size = new System.Drawing.Size(191, 53);
            this.zavershit_zakaz.TabIndex = 24;
            this.zavershit_zakaz.Text = "Завершить";
            this.zavershit_zakaz.UseVisualStyleBackColor = false;
            this.zavershit_zakaz.Click += new System.EventHandler(this.zavershit_zakaz_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Категория товара:";
            // 
            // comboBox1_categoriya
            // 
            this.comboBox1_categoriya.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1_categoriya.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.comboBox1_categoriya.FormattingEnabled = true;
            this.comboBox1_categoriya.Location = new System.Drawing.Point(246, 190);
            this.comboBox1_categoriya.Name = "comboBox1_categoriya";
            this.comboBox1_categoriya.Size = new System.Drawing.Size(316, 34);
            this.comboBox1_categoriya.TabIndex = 26;
            this.comboBox1_categoriya.TextChanged += new System.EventHandler(this.comboBox1_categoriya_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(355, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Доставка:";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(472, 297);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(82)))), ((int)(((byte)(8)))));
            this.label5.Location = new System.Drawing.Point(41, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Заполните данные заказа";
            // 
            // comboBox_Meneger
            // 
            this.comboBox_Meneger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Meneger.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.comboBox_Meneger.FormattingEnabled = true;
            this.comboBox_Meneger.Location = new System.Drawing.Point(167, 326);
            this.comboBox_Meneger.Name = "comboBox_Meneger";
            this.comboBox_Meneger.Size = new System.Drawing.Size(344, 34);
            this.comboBox_Meneger.TabIndex = 50;
            this.comboBox_Meneger.TextChanged += new System.EventHandler(this.comboBox_Meneger_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(41, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 49;
            this.label6.Text = "Менеджер:";
            // 
            // Sozdaniye_Zakaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Meneger);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1_categoriya);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zavershit_zakaz);
            this.Controls.Add(this.dobavit_k_zakazu);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2_Bludo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colvo_porciy);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sozdaniye_Zakaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заказа";
            this.Load += new System.EventHandler(this.Sozdaniye_Zakaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2_Bludo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colvo_porciy;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.Button dobavit_k_zakazu;
        private System.Windows.Forms.Button zavershit_zakaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_categoriya;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Meneger;
        private System.Windows.Forms.Label label6;
    }
}