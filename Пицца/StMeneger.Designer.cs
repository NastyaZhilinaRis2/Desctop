
namespace Пицц_
{
    partial class StMeneger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StMeneger));
            this.Back = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Prosmotr_Tovarov = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.Back.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.Back.Location = new System.Drawing.Point(12, 385);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(131, 53);
            this.Back.TabIndex = 18;
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
            this.Output.TabIndex = 17;
            this.Output.Text = "Выход";
            this.Output.UseVisualStyleBackColor = false;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(323, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 126);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Prosmotr_Tovarov
            // 
            this.Prosmotr_Tovarov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Prosmotr_Tovarov.AutoSize = true;
            this.Prosmotr_Tovarov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Prosmotr_Tovarov.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prosmotr_Tovarov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(82)))), ((int)(((byte)(8)))));
            this.Prosmotr_Tovarov.Location = new System.Drawing.Point(168, 188);
            this.Prosmotr_Tovarov.Name = "Prosmotr_Tovarov";
            this.Prosmotr_Tovarov.Size = new System.Drawing.Size(456, 67);
            this.Prosmotr_Tovarov.TabIndex = 14;
            this.Prosmotr_Tovarov.Text = "Просмотр товаров";
            this.Prosmotr_Tovarov.Click += new System.EventHandler(this.Prosmotr_Tovarov_Click);
            // 
            // StMeneger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Prosmotr_Tovarov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StMeneger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StMeneger";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Prosmotr_Tovarov;
    }
}