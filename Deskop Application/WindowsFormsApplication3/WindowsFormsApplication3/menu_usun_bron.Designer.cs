namespace WindowsFormsApplication3
{
    partial class menu_usun_bron
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
            this.combobox = new System.Windows.Forms.ComboBox();
            this.wysw_bron = new System.Windows.Forms.Label();
            this.Usun_bron = new System.Windows.Forms.Button();
            this.back_main_menu = new System.Windows.Forms.Button();
            this.bron_usuniecia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combobox
            // 
            this.combobox.FormattingEnabled = true;
            this.combobox.Location = new System.Drawing.Point(62, 37);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(121, 21);
            this.combobox.TabIndex = 1;
            this.combobox.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // wysw_bron
            // 
            this.wysw_bron.AutoSize = true;
            this.wysw_bron.BackColor = System.Drawing.Color.Tomato;
            this.wysw_bron.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.wysw_bron.Location = new System.Drawing.Point(43, 171);
            this.wysw_bron.Name = "wysw_bron";
            this.wysw_bron.Size = new System.Drawing.Size(77, 13);
            this.wysw_bron.TabIndex = 2;
            this.wysw_bron.Text = "Wybrana broń:";
            // 
            // Usun_bron
            // 
            this.Usun_bron.Location = new System.Drawing.Point(46, 201);
            this.Usun_bron.Name = "Usun_bron";
            this.Usun_bron.Size = new System.Drawing.Size(174, 39);
            this.Usun_bron.TabIndex = 3;
            this.Usun_bron.Text = "Usuń broń";
            this.Usun_bron.UseVisualStyleBackColor = true;
            this.Usun_bron.Click += new System.EventHandler(this.Usun_bron_Click);
            // 
            // back_main_menu
            // 
            this.back_main_menu.Location = new System.Drawing.Point(219, 15);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(105, 62);
            this.back_main_menu.TabIndex = 13;
            this.back_main_menu.Text = "COFNIJ DO MENU GŁÓWNEGO";
            this.back_main_menu.UseVisualStyleBackColor = true;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // bron_usuniecia
            // 
            this.bron_usuniecia.AutoSize = true;
            this.bron_usuniecia.BackColor = System.Drawing.Color.Tomato;
            this.bron_usuniecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bron_usuniecia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bron_usuniecia.Location = new System.Drawing.Point(126, 162);
            this.bron_usuniecia.Name = "bron_usuniecia";
            this.bron_usuniecia.Size = new System.Drawing.Size(24, 26);
            this.bron_usuniecia.TabIndex = 14;
            this.bron_usuniecia.Text = "_";
            // 
            // menu_usun_bron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.bron_usuniecia);
            this.Controls.Add(this.back_main_menu);
            this.Controls.Add(this.Usun_bron);
            this.Controls.Add(this.wysw_bron);
            this.Controls.Add(this.combobox);
            this.Name = "menu_usun_bron";
            this.Text = "Usuń broń";
            this.Load += new System.EventHandler(this.menu_usun_bron_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Label wysw_bron;
        private System.Windows.Forms.Button Usun_bron;
        private System.Windows.Forms.Button back_main_menu;
        private System.Windows.Forms.Label bron_usuniecia;
    }
}