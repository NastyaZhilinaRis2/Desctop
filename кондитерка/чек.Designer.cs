namespace экзамен
{
    partial class чек
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(чек));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.itogo1 = new System.Windows.Forms.Label();
            this.itogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Итого: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "руб";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(132, 246);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 24);
            this.add.TabIndex = 12;
            this.add.Text = "Оплатить";
            this.add.UseVisualStyleBackColor = true;
            // 
            // itogo1
            // 
            this.itogo1.AutoSize = true;
            this.itogo1.Location = new System.Drawing.Point(57, 252);
            this.itogo1.Name = "itogo1";
            this.itogo1.Size = new System.Drawing.Size(0, 13);
            this.itogo1.TabIndex = 13;
            // 
            // itogo
            // 
            this.itogo.AutoSize = true;
            this.itogo.Location = new System.Drawing.Point(63, 252);
            this.itogo.Name = "itogo";
            this.itogo.Size = new System.Drawing.Size(13, 13);
            this.itogo.TabIndex = 14;
            this.itogo.Text = "0";
            // 
            // чек
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 274);
            this.Controls.Add(this.itogo);
            this.Controls.Add(this.itogo1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "чек";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чек";
            this.Load += new System.EventHandler(this.чек_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label itogo1;
        private System.Windows.Forms.Label itogo;
    }
}