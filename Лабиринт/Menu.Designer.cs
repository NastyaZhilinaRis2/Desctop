
namespace Лабиринт
{
    partial class Menu
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.start = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.Box_sound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start.AutoSize = true;
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Font = new System.Drawing.Font("Ravie", 35F);
            this.start.Location = new System.Drawing.Point(530, 94);
            this.start.MinimumSize = new System.Drawing.Size(250, 500);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(250, 500);
            this.start.TabIndex = 0;
            this.start.Text = "Start!";
            this.start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(1146, 692);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(87, 33);
            this.exit.TabIndex = 1;
            this.exit.Text = "exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Box_sound
            // 
            this.Box_sound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Box_sound.AutoSize = true;
            this.Box_sound.BackColor = System.Drawing.Color.Transparent;
            this.Box_sound.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24.75F, System.Drawing.FontStyle.Bold);
            this.Box_sound.ForeColor = System.Drawing.Color.Red;
            this.Box_sound.Location = new System.Drawing.Point(36, 688);
            this.Box_sound.Name = "Box_sound";
            this.Box_sound.Size = new System.Drawing.Size(124, 37);
            this.Box_sound.TabIndex = 2;
            this.Box_sound.Text = "sound";
            this.Box_sound.UseVisualStyleBackColor = false;
            this.Box_sound.CheckedChanged += new System.EventHandler(this.Box_sound_CheckedChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Лабиринт.Properties.Resources.меню;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 743);
            this.Controls.Add(this.Box_sound);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабиринт ";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label exit;
        public System.Windows.Forms.CheckBox Box_sound;
    }
}

