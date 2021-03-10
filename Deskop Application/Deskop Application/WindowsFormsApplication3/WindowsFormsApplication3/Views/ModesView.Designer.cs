namespace ShootingRange
{
    partial class ModesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModesView));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSlowShooter = new System.Windows.Forms.Button();
            this.btnFastShooter = new System.Windows.Forms.Button();
            this.btnCowboy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReflex = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz tryb:";
            // 
            // btnSlowShooter
            // 
            this.btnSlowShooter.Location = new System.Drawing.Point(8, 64);
            this.btnSlowShooter.Name = "btnSlowShooter";
            this.btnSlowShooter.Size = new System.Drawing.Size(120, 40);
            this.btnSlowShooter.TabIndex = 1;
            this.btnSlowShooter.Text = "Tryb wolnostrzelny";
            this.btnSlowShooter.UseVisualStyleBackColor = true;
            this.btnSlowShooter.Click += new System.EventHandler(this.tryb1_przycisk_Click);
            // 
            // btnFastShooter
            // 
            this.btnFastShooter.Location = new System.Drawing.Point(8, 139);
            this.btnFastShooter.Name = "btnFastShooter";
            this.btnFastShooter.Size = new System.Drawing.Size(120, 40);
            this.btnFastShooter.TabIndex = 2;
            this.btnFastShooter.Text = "Tryb szybkostrzelny";
            this.btnFastShooter.UseVisualStyleBackColor = true;
            this.btnFastShooter.Click += new System.EventHandler(this.tryb2_przycisk_Click);
            // 
            // btnCowboy
            // 
            this.btnCowboy.Location = new System.Drawing.Point(8, 223);
            this.btnCowboy.Name = "btnCowboy";
            this.btnCowboy.Size = new System.Drawing.Size(120, 40);
            this.btnCowboy.TabIndex = 3;
            this.btnCowboy.Text = "Tryb kowbojski";
            this.btnCowboy.UseVisualStyleBackColor = true;
            this.btnCowboy.Click += new System.EventHandler(this.tryb3_przycisk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 230);
            this.label2.MaximumSize = new System.Drawing.Size(450, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tryb ten polega na jednoczesnym zapaleniu się diod nad każdą tarczą. Zadaniem str" +
    "zelca jest jak najszybciej trafić do każdej z tarcz.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 139);
            this.label3.MaximumSize = new System.Drawing.Size(450, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tryb ten polega na oddaniu, jak największej ilości trafień w tarcze, nad którymi " +
    "losowo będzie zapalać się dioda. Maksymalne opóźnienie strzału wynosi 0,5 sekund" +
    "y.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 65);
            this.label4.MaximumSize = new System.Drawing.Size(450, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // btnReflex
            // 
            this.btnReflex.Location = new System.Drawing.Point(8, 312);
            this.btnReflex.Name = "btnReflex";
            this.btnReflex.Size = new System.Drawing.Size(120, 40);
            this.btnReflex.TabIndex = 3;
            this.btnReflex.Text = "Tryb refleks";
            this.btnReflex.UseVisualStyleBackColor = true;
            this.btnReflex.Click += new System.EventHandler(this.refleks_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 319);
            this.label5.MaximumSize = new System.Drawing.Size(450, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(440, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tryb ten polega na jak najszybszym trafieniu do tarczy, nad którą włączona jest d" +
    "ioda sygnalizująca. Światło diody pojawia się losowo, a czas jego trwania to 2,5" +
    "s-3s-3,5s-4s-4,5s.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(8, 409);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(120, 40);
            this.btnBD.TabIndex = 15;
            this.btnBD.Text = "Baza danych";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(492, 409);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 31;
            this.btnLogout.Text = "Wyloguj";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // ModesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReflex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCowboy);
            this.Controls.Add(this.btnFastShooter);
            this.Controls.Add(this.btnSlowShooter);
            this.Controls.Add(this.label1);
            this.Name = "ModesView";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSlowShooter;
        private System.Windows.Forms.Button btnFastShooter;
        private System.Windows.Forms.Button btnCowboy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReflex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btnLogout;
    }
}