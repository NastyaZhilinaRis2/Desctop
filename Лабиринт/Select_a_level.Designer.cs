
namespace Лабиринт
{
    partial class Select_a_level
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_a_level));
            this.button_1_level = new System.Windows.Forms.Button();
            this.button_2_level = new System.Windows.Forms.Button();
            this.button_3_level = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_1_level
            // 
            this.button_1_level.BackColor = System.Drawing.Color.Sienna;
            this.button_1_level.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_1_level.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1_level.Location = new System.Drawing.Point(196, 362);
            this.button_1_level.Name = "button_1_level";
            this.button_1_level.Size = new System.Drawing.Size(207, 72);
            this.button_1_level.TabIndex = 0;
            this.button_1_level.Text = "1 level";
            this.button_1_level.UseVisualStyleBackColor = false;
            this.button_1_level.Click += new System.EventHandler(this.button_1_level_Click);
            // 
            // button_2_level
            // 
            this.button_2_level.BackColor = System.Drawing.Color.Sienna;
            this.button_2_level.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_2_level.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2_level.Location = new System.Drawing.Point(535, 362);
            this.button_2_level.Name = "button_2_level";
            this.button_2_level.Size = new System.Drawing.Size(207, 72);
            this.button_2_level.TabIndex = 1;
            this.button_2_level.Text = "2 level";
            this.button_2_level.UseVisualStyleBackColor = false;
            this.button_2_level.Click += new System.EventHandler(this.button_2_level_Click);
            // 
            // button_3_level
            // 
            this.button_3_level.BackColor = System.Drawing.Color.Sienna;
            this.button_3_level.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_3_level.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3_level.Location = new System.Drawing.Point(883, 362);
            this.button_3_level.Name = "button_3_level";
            this.button_3_level.Size = new System.Drawing.Size(207, 72);
            this.button_3_level.TabIndex = 2;
            this.button_3_level.Text = "3 level";
            this.button_3_level.UseVisualStyleBackColor = false;
            this.button_3_level.Click += new System.EventHandler(this.button_3_level_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(1155, 724);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(87, 33);
            this.exit.TabIndex = 3;
            this.exit.Text = "exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Red;
            this.back.Location = new System.Drawing.Point(31, 724);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(87, 33);
            this.back.TabIndex = 6;
            this.back.Text = "back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Select_a_level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Лабиринт.Properties.Resources.уровни;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 782);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button_3_level);
            this.Controls.Add(this.button_2_level);
            this.Controls.Add(this.button_1_level);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Select_a_level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите уровень";
            this.Activated += new System.EventHandler(this.Select_a_level_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_1_level;
        private System.Windows.Forms.Button button_2_level;
        private System.Windows.Forms.Button button_3_level;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label back;
    }
}