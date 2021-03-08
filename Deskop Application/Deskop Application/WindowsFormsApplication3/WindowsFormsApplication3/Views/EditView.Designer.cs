namespace WindowsFormsApplication3
{
    partial class EditView
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
            this.modyfikuj_bron = new System.Windows.Forms.Button();
            this.zmien_haslo = new System.Windows.Forms.Button();
            this.back_main_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dodaj_bron
            // 
            this.Dodaj_bron.Location = new System.Drawing.Point(104, 115);
            this.Dodaj_bron.Name = "Dodaj_bron";
            this.Dodaj_bron.Size = new System.Drawing.Size(120, 40);
            this.Dodaj_bron.TabIndex = 0;
            this.Dodaj_bron.Text = "Dodaj nową broń";
            this.Dodaj_bron.UseVisualStyleBackColor = true;
            this.Dodaj_bron.Click += new System.EventHandler(this.Dodaj_bron_Click);
            // 
            // modyfikuj_bron
            // 
            this.modyfikuj_bron.Location = new System.Drawing.Point(104, 176);
            this.modyfikuj_bron.Name = "modyfikuj_bron";
            this.modyfikuj_bron.Size = new System.Drawing.Size(120, 40);
            this.modyfikuj_bron.TabIndex = 2;
            this.modyfikuj_bron.Text = "Modyfikuj/Usuń broń";
            this.modyfikuj_bron.UseVisualStyleBackColor = true;
            this.modyfikuj_bron.Click += new System.EventHandler(this.modyfikuj_bron_Click);
            // 
            // zmien_haslo
            // 
            this.zmien_haslo.Location = new System.Drawing.Point(104, 240);
            this.zmien_haslo.Name = "zmien_haslo";
            this.zmien_haslo.Size = new System.Drawing.Size(120, 40);
            this.zmien_haslo.TabIndex = 3;
            this.zmien_haslo.Text = "Dodaj/Usuń użytkownika";
            this.zmien_haslo.UseVisualStyleBackColor = true;
            this.zmien_haslo.Click += new System.EventHandler(this.zmien_haslo_Click);
            // 
            // back_main_menu
            // 
            this.back_main_menu.Location = new System.Drawing.Point(202, 12);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(120, 40);
            this.back_main_menu.TabIndex = 12;
            this.back_main_menu.Text = "Powrót do menu";
            this.back_main_menu.UseVisualStyleBackColor = true;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // edytuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.back_main_menu);
            this.Controls.Add(this.zmien_haslo);
            this.Controls.Add(this.modyfikuj_bron);
            this.Controls.Add(this.Dodaj_bron);
            this.Name = "edytuj";
            this.Text = "Menu Edycji";
            this.Load += new System.EventHandler(this.edytuj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dodaj_bron;
        private System.Windows.Forms.Button modyfikuj_bron;
        private System.Windows.Forms.Button zmien_haslo;
        private System.Windows.Forms.Button back_main_menu;
    }
}