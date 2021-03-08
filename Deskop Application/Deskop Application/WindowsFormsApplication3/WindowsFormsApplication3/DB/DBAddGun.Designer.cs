namespace WindowsFormsApplication3
{
    partial class menu_dod_bron
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
            this.dodaj = new System.Windows.Forms.Button();
            this.model_broni = new System.Windows.Forms.Label();
            this.FPS = new System.Windows.Forms.TextBox();
            this.Naped = new System.Windows.Forms.TextBox();
            this.TYP = new System.Windows.Forms.TextBox();
            this.Poj_magazynka = new System.Windows.Forms.TextBox();
            this.pred_wyl_broni = new System.Windows.Forms.Label();
            this.naped_broni = new System.Windows.Forms.Label();
            this.typ_broni = new System.Windows.Forms.Label();
            this.poj_broni = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.back_main_menu = new System.Windows.Forms.Button();
            this.Model_bron = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(202, 273);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(157, 41);
            this.dodaj.TabIndex = 0;
            this.dodaj.Text = "DODAJ";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // model_broni
            // 
            this.model_broni.AutoSize = true;
            this.model_broni.Location = new System.Drawing.Point(12, 56);
            this.model_broni.Name = "model_broni";
            this.model_broni.Size = new System.Drawing.Size(63, 13);
            this.model_broni.TabIndex = 1;
            this.model_broni.Text = "Model Broni";
            // 
            // FPS
            // 
            this.FPS.Location = new System.Drawing.Point(202, 154);
            this.FPS.Name = "FPS";
            this.FPS.Size = new System.Drawing.Size(141, 20);
            this.FPS.TabIndex = 3;
            this.FPS.TextChanged += new System.EventHandler(this.FPS_TextChanged);
            // 
            // Naped
            // 
            this.Naped.Location = new System.Drawing.Point(202, 78);
            this.Naped.Name = "Naped";
            this.Naped.Size = new System.Drawing.Size(141, 20);
            this.Naped.TabIndex = 4;
            this.Naped.TextChanged += new System.EventHandler(this.Naped_TextChanged);
            // 
            // TYP
            // 
            this.TYP.Location = new System.Drawing.Point(12, 154);
            this.TYP.Name = "TYP";
            this.TYP.Size = new System.Drawing.Size(141, 20);
            this.TYP.TabIndex = 5;
            this.TYP.TextChanged += new System.EventHandler(this.TYP_TextChanged);
            // 
            // Poj_magazynka
            // 
            this.Poj_magazynka.Location = new System.Drawing.Point(425, 125);
            this.Poj_magazynka.Name = "Poj_magazynka";
            this.Poj_magazynka.Size = new System.Drawing.Size(126, 20);
            this.Poj_magazynka.TabIndex = 6;
            this.Poj_magazynka.TextChanged += new System.EventHandler(this.Poj_magazynka_TextChanged);
            // 
            // pred_wyl_broni
            // 
            this.pred_wyl_broni.AutoSize = true;
            this.pred_wyl_broni.Location = new System.Drawing.Point(199, 132);
            this.pred_wyl_broni.Name = "pred_wyl_broni";
            this.pred_wyl_broni.Size = new System.Drawing.Size(122, 13);
            this.pred_wyl_broni.TabIndex = 8;
            this.pred_wyl_broni.Text = "Prędkość wylotowa FPS";
            // 
            // naped_broni
            // 
            this.naped_broni.AutoSize = true;
            this.naped_broni.Location = new System.Drawing.Point(199, 56);
            this.naped_broni.Name = "naped_broni";
            this.naped_broni.Size = new System.Drawing.Size(39, 13);
            this.naped_broni.TabIndex = 9;
            this.naped_broni.Text = "Napęd";
            // 
            // typ_broni
            // 
            this.typ_broni.AutoSize = true;
            this.typ_broni.Location = new System.Drawing.Point(12, 132);
            this.typ_broni.Name = "typ_broni";
            this.typ_broni.Size = new System.Drawing.Size(25, 13);
            this.typ_broni.TabIndex = 10;
            this.typ_broni.Text = "Typ";
            // 
            // poj_broni
            // 
            this.poj_broni.AutoSize = true;
            this.poj_broni.Location = new System.Drawing.Point(428, 103);
            this.poj_broni.Name = "poj_broni";
            this.poj_broni.Size = new System.Drawing.Size(116, 13);
            this.poj_broni.TabIndex = 11;
            this.poj_broni.Text = "Pojemność magazynka";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(162, 84);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(162, 160);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(349, 81);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(349, 157);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(557, 128);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 17;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // back_main_menu
            // 
            this.back_main_menu.Location = new System.Drawing.Point(487, 12);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(105, 62);
            this.back_main_menu.TabIndex = 18;
            this.back_main_menu.Text = "Wróć do głównego menu";
            this.back_main_menu.UseVisualStyleBackColor = true;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // Model_bron
            // 
            this.Model_bron.Location = new System.Drawing.Point(12, 78);
            this.Model_bron.Name = "Model_bron";
            this.Model_bron.Size = new System.Drawing.Size(141, 20);
            this.Model_bron.TabIndex = 19;
            this.Model_bron.TextChanged += new System.EventHandler(this.Model_bron_TextChanged);
            // 
            // menu_dod_bron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(613, 319);
            this.Controls.Add(this.Model_bron);
            this.Controls.Add(this.back_main_menu);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.poj_broni);
            this.Controls.Add(this.typ_broni);
            this.Controls.Add(this.naped_broni);
            this.Controls.Add(this.pred_wyl_broni);
            this.Controls.Add(this.Poj_magazynka);
            this.Controls.Add(this.TYP);
            this.Controls.Add(this.Naped);
            this.Controls.Add(this.FPS);
            this.Controls.Add(this.model_broni);
            this.Controls.Add(this.dodaj);
            this.Name = "menu_dod_bron";
            this.Text = "Dodaj broń";
            this.Load += new System.EventHandler(this.menu_dod_bron_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Label model_broni;
        private System.Windows.Forms.TextBox FPS;
        private System.Windows.Forms.TextBox Naped;
        private System.Windows.Forms.TextBox TYP;
        private System.Windows.Forms.TextBox Poj_magazynka;
        private System.Windows.Forms.Label pred_wyl_broni;
        private System.Windows.Forms.Label naped_broni;
        private System.Windows.Forms.Label typ_broni;
        private System.Windows.Forms.Label poj_broni;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button back_main_menu;
        private System.Windows.Forms.TextBox Model_bron;
    }
}