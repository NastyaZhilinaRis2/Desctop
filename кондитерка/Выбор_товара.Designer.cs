
namespace экзамен
{
    partial class Выбор_товара
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Выбор_товара));
            this.label1 = new System.Windows.Forms.Label();
            this.итого = new System.Windows.Forms.Label();
            this.itog = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.bulochki = new System.Windows.Forms.Button();
            this.ecler = new System.Windows.Forms.Button();
            this.piroznki = new System.Windows.Forms.Button();
            this.pechene = new System.Windows.Forms.Button();
            this.pirog = new System.Windows.Forms.Button();
            this.kruassan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Итого: ";
            // 
            // итого
            // 
            this.итого.AutoSize = true;
            this.итого.Location = new System.Drawing.Point(54, 252);
            this.итого.Name = "итого";
            this.итого.Size = new System.Drawing.Size(0, 13);
            this.итого.TabIndex = 7;
            // 
            // itog
            // 
            this.itog.AutoSize = true;
            this.itog.Location = new System.Drawing.Point(86, 247);
            this.itog.Name = "itog";
            this.itog.Size = new System.Drawing.Size(0, 13);
            this.itog.TabIndex = 8;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(270, 241);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(117, 24);
            this.add.TabIndex = 9;
            this.add.Text = "Перейти к оплате";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // bulochki
            // 
            this.bulochki.BackgroundImage = global::экзамен.Properties.Resources.булочки;
            this.bulochki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bulochki.Location = new System.Drawing.Point(282, 26);
            this.bulochki.Name = "bulochki";
            this.bulochki.Size = new System.Drawing.Size(105, 91);
            this.bulochki.TabIndex = 5;
            this.bulochki.Text = "Булочки";
            this.bulochki.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bulochki.UseVisualStyleBackColor = true;
            this.bulochki.Click += new System.EventHandler(this.bulochki_Click);
            // 
            // ecler
            // 
            this.ecler.BackgroundImage = global::экзамен.Properties.Resources.эклеры;
            this.ecler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ecler.Location = new System.Drawing.Point(40, 140);
            this.ecler.Name = "ecler";
            this.ecler.Size = new System.Drawing.Size(105, 91);
            this.ecler.TabIndex = 4;
            this.ecler.Text = "Эклеры";
            this.ecler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ecler.UseVisualStyleBackColor = true;
            this.ecler.Click += new System.EventHandler(this.ecler_Click);
            // 
            // piroznki
            // 
            this.piroznki.BackgroundImage = global::экзамен.Properties.Resources.пирожные;
            this.piroznki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.piroznki.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.piroznki.Location = new System.Drawing.Point(282, 140);
            this.piroznki.Name = "piroznki";
            this.piroznki.Size = new System.Drawing.Size(105, 91);
            this.piroznki.TabIndex = 3;
            this.piroznki.Text = "Пирожные";
            this.piroznki.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.piroznki.UseVisualStyleBackColor = true;
            this.piroznki.Click += new System.EventHandler(this.piroznki_Click);
            // 
            // pechene
            // 
            this.pechene.BackgroundImage = global::экзамен.Properties.Resources.печенья;
            this.pechene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pechene.Location = new System.Drawing.Point(161, 140);
            this.pechene.Name = "pechene";
            this.pechene.Size = new System.Drawing.Size(105, 91);
            this.pechene.TabIndex = 2;
            this.pechene.Text = "Печенье";
            this.pechene.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pechene.UseVisualStyleBackColor = true;
            this.pechene.Click += new System.EventHandler(this.pechene_Click);
            // 
            // pirog
            // 
            this.pirog.BackgroundImage = global::экзамен.Properties.Resources.пироги;
            this.pirog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pirog.Location = new System.Drawing.Point(161, 26);
            this.pirog.Name = "pirog";
            this.pirog.Size = new System.Drawing.Size(105, 91);
            this.pirog.TabIndex = 1;
            this.pirog.Text = "Пироги";
            this.pirog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pirog.UseVisualStyleBackColor = true;
            this.pirog.Click += new System.EventHandler(this.pirog_Click);
            // 
            // kruassan
            // 
            this.kruassan.BackgroundImage = global::экзамен.Properties.Resources.круассан;
            this.kruassan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kruassan.Location = new System.Drawing.Point(40, 26);
            this.kruassan.Name = "kruassan";
            this.kruassan.Size = new System.Drawing.Size(105, 91);
            this.kruassan.TabIndex = 0;
            this.kruassan.Text = "Круассаны";
            this.kruassan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kruassan.UseVisualStyleBackColor = true;
            this.kruassan.Click += new System.EventHandler(this.kruassan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "руб";
            // 
            // Выбор_товара
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.itog);
            this.Controls.Add(this.итого);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bulochki);
            this.Controls.Add(this.ecler);
            this.Controls.Add(this.piroznki);
            this.Controls.Add(this.pechene);
            this.Controls.Add(this.pirog);
            this.Controls.Add(this.kruassan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Выбор_товара";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kruassan;
        private System.Windows.Forms.Button pirog;
        private System.Windows.Forms.Button pechene;
        private System.Windows.Forms.Button piroznki;
        private System.Windows.Forms.Button ecler;
        private System.Windows.Forms.Button bulochki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label итого;
        private System.Windows.Forms.Button add;
        public System.Windows.Forms.Label itog;
        private System.Windows.Forms.Label label2;
    }
}

