
namespace экзамен
{
    partial class Модификаторы_эклеры
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Модификаторы_эклеры));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Colvo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.otmena = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(30, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Эклеры";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::экзамен.Properties.Resources.эклеры;
            this.pictureBox1.Location = new System.Drawing.Point(34, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(30, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите количество: ";
            // 
            // Colvo
            // 
            this.Colvo.Location = new System.Drawing.Point(202, 162);
            this.Colvo.MaxLength = 2;
            this.Colvo.Name = "Colvo";
            this.Colvo.Size = new System.Drawing.Size(61, 20);
            this.Colvo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(30, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите начинку:";
            // 
            // otmena
            // 
            this.otmena.Location = new System.Drawing.Point(45, 368);
            this.otmena.Name = "otmena";
            this.otmena.Size = new System.Drawing.Size(117, 24);
            this.otmena.TabIndex = 11;
            this.otmena.Text = "Отмена";
            this.otmena.UseVisualStyleBackColor = true;
            this.otmena.Click += new System.EventHandler(this.otmena_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(243, 368);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(117, 24);
            this.add.TabIndex = 12;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 284);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.Text = "С шоколадом - 35 руб";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(34, 238);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(171, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "С заварным кремом - 40 руб";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(34, 261);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(137, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.Text = "Со сгущенкой - 40 руб";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Модификаторы_эклеры
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 440);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.otmena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Colvo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Модификаторы_эклеры";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор эклеров";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Colvo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button otmena;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}