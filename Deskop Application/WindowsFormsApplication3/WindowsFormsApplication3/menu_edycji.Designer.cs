namespace WindowsFormsApplication3
{
    partial class edytuj
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
            this.Dodaj_bron = new System.Windows.Forms.Button();
            this.usun_bron = new System.Windows.Forms.Button();
            this.modyfikuj_bron = new System.Windows.Forms.Button();
            this.zmien_haslo = new System.Windows.Forms.Button();
            this.back_main_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dodaj_bron
            // 
            this.Dodaj_bron.Location = new System.Drawing.Point(149, 36);
            this.Dodaj_bron.Name = "Dodaj_bron";
            this.Dodaj_bron.Size = new System.Drawing.Size(145, 31);
            this.Dodaj_bron.TabIndex = 0;
            this.Dodaj_bron.Text = "Dodaj broń";
            this.Dodaj_bron.UseVisualStyleBackColor = true;
            this.Dodaj_bron.Click += new System.EventHandler(this.Dodaj_bron_Click);
            // 
            // usun_bron
            // 
            this.usun_bron.Location = new System.Drawing.Point(150, 93);
            this.usun_bron.Name = "usun_bron";
            this.usun_bron.Size = new System.Drawing.Size(144, 31);
            this.usun_bron.TabIndex = 1;
            this.usun_bron.Text = "Usuń Broń";
            this.usun_bron.UseVisualStyleBackColor = true;
            this.usun_bron.Click += new System.EventHandler(this.usun_bron_Click);
            // 
            // modyfikuj_bron
            // 
            this.modyfikuj_bron.Location = new System.Drawing.Point(149, 152);
            this.modyfikuj_bron.Name = "modyfikuj_bron";
            this.modyfikuj_bron.Size = new System.Drawing.Size(145, 34);
            this.modyfikuj_bron.TabIndex = 2;
            this.modyfikuj_bron.Text = "Modyfikuj broń";
            this.modyfikuj_bron.UseVisualStyleBackColor = true;
            this.modyfikuj_bron.Click += new System.EventHandler(this.modyfikuj_bron_Click);
            // 
            // zmien_haslo
            // 
            this.zmien_haslo.Location = new System.Drawing.Point(149, 218);
            this.zmien_haslo.Name = "zmien_haslo";
            this.zmien_haslo.Size = new System.Drawing.Size(144, 45);
            this.zmien_haslo.TabIndex = 3;
            this.zmien_haslo.Text = "Zmien haslo i login użytkownika";
            this.zmien_haslo.UseVisualStyleBackColor = true;
            this.zmien_haslo.Click += new System.EventHandler(this.zmien_haslo_Click);
            // 
            // back_main_menu
            // 
            this.back_main_menu.Location = new System.Drawing.Point(370, 12);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(105, 62);
            this.back_main_menu.TabIndex = 12;
            this.back_main_menu.Text = "COFNIJ DO MENU GŁÓWNEGO";
            this.back_main_menu.UseVisualStyleBackColor = true;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // edytuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 294);
            this.Controls.Add(this.back_main_menu);
            this.Controls.Add(this.zmien_haslo);
            this.Controls.Add(this.modyfikuj_bron);
            this.Controls.Add(this.usun_bron);
            this.Controls.Add(this.Dodaj_bron);
            this.Name = "edytuj";
            this.Text = "Menu Edycji";
            this.Load += new System.EventHandler(this.edytuj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dodaj_bron;
        private System.Windows.Forms.Button usun_bron;
        private System.Windows.Forms.Button modyfikuj_bron;
        private System.Windows.Forms.Button zmien_haslo;
        private System.Windows.Forms.Button back_main_menu;
    }
}