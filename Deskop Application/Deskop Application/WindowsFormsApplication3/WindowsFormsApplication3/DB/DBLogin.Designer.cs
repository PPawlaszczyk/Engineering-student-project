namespace WindowsFormsApplication3
{
    partial class DBLogin
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
            this.dodaj_uzytkownika = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_dodaj_haslo = new System.Windows.Forms.TextBox();
            this.textBox_dodaj_login = new System.Windows.Forms.TextBox();
            this.back_main_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodaj_uzytkownika
            // 
            this.dodaj_uzytkownika.Location = new System.Drawing.Point(99, 249);
            this.dodaj_uzytkownika.Name = "dodaj_uzytkownika";
            this.dodaj_uzytkownika.Size = new System.Drawing.Size(120, 40);
            this.dodaj_uzytkownika.TabIndex = 10;
            this.dodaj_uzytkownika.Text = "Dodaj użytkownika";
            this.dodaj_uzytkownika.UseVisualStyleBackColor = true;
            this.dodaj_uzytkownika.Click += new System.EventHandler(this.dodaj_uzytkownika_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "HASŁO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOGIN";
            // 
            // textBox_dodaj_haslo
            // 
            this.textBox_dodaj_haslo.Location = new System.Drawing.Point(86, 189);
            this.textBox_dodaj_haslo.Name = "textBox_dodaj_haslo";
            this.textBox_dodaj_haslo.Size = new System.Drawing.Size(156, 20);
            this.textBox_dodaj_haslo.TabIndex = 7;
            // 
            // textBox_dodaj_login
            // 
            this.textBox_dodaj_login.Location = new System.Drawing.Point(86, 120);
            this.textBox_dodaj_login.Name = "textBox_dodaj_login";
            this.textBox_dodaj_login.Size = new System.Drawing.Size(156, 20);
            this.textBox_dodaj_login.TabIndex = 6;
            // 
            // back_main_menu
            // 
            this.back_main_menu.Location = new System.Drawing.Point(202, 12);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(120, 40);
            this.back_main_menu.TabIndex = 11;
            this.back_main_menu.Text = "Powrót do menu";
            this.back_main_menu.UseVisualStyleBackColor = true;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // EditPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.back_main_menu);
            this.Controls.Add(this.dodaj_uzytkownika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_dodaj_haslo);
            this.Controls.Add(this.textBox_dodaj_login);
            this.Name = "EditPassword";
            this.Text = "dodaj_login_haslo";
            this.Load += new System.EventHandler(this.dodaj_login_haslo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dodaj_uzytkownika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_dodaj_haslo;
        private System.Windows.Forms.TextBox textBox_dodaj_login;
        private System.Windows.Forms.Button back_main_menu;
    }
}