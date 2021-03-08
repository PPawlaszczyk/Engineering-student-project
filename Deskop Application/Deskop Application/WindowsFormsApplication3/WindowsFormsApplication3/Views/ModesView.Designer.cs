namespace WindowsFormsApplication3
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
            this.tryb1_przycisk = new System.Windows.Forms.Button();
            this.tryb2_przycisk = new System.Windows.Forms.Button();
            this.tryb3_przycisk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.back_main_menu = new System.Windows.Forms.Button();
            this.refleks_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // tryb1_przycisk
            // 
            this.tryb1_przycisk.Location = new System.Drawing.Point(8, 64);
            this.tryb1_przycisk.Name = "tryb1_przycisk";
            this.tryb1_przycisk.Size = new System.Drawing.Size(120, 40);
            this.tryb1_przycisk.TabIndex = 1;
            this.tryb1_przycisk.Text = "Tryb wolnostrzelny";
            this.tryb1_przycisk.UseVisualStyleBackColor = true;
            this.tryb1_przycisk.Click += new System.EventHandler(this.tryb1_przycisk_Click);
            // 
            // tryb2_przycisk
            // 
            this.tryb2_przycisk.Location = new System.Drawing.Point(8, 139);
            this.tryb2_przycisk.Name = "tryb2_przycisk";
            this.tryb2_przycisk.Size = new System.Drawing.Size(120, 40);
            this.tryb2_przycisk.TabIndex = 2;
            this.tryb2_przycisk.Text = "Tryb szybkostrzelny";
            this.tryb2_przycisk.UseVisualStyleBackColor = true;
            this.tryb2_przycisk.Click += new System.EventHandler(this.tryb2_przycisk_Click);
            // 
            // tryb3_przycisk
            // 
            this.tryb3_przycisk.Location = new System.Drawing.Point(8, 223);
            this.tryb3_przycisk.Name = "tryb3_przycisk";
            this.tryb3_przycisk.Size = new System.Drawing.Size(120, 40);
            this.tryb3_przycisk.TabIndex = 3;
            this.tryb3_przycisk.Text = "Tryb kowbojski";
            this.tryb3_przycisk.UseVisualStyleBackColor = true;
            this.tryb3_przycisk.Click += new System.EventHandler(this.tryb3_przycisk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 237);
            this.label2.MaximumSize = new System.Drawing.Size(333, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tryb ten polega na jednoczesnym zapaleniu się diod nad każdą tarczą. Zadaniem str" +
    "zelca jest jak najszybciej trafić do każdej z tarcz.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 152);
            this.label3.MaximumSize = new System.Drawing.Size(333, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tryb ten polega na oddaniu, jak największej ilości trafień w tarcze, nad którymi " +
    "losowo będzie zapalać się dioda. Maksymalne opóźnienie strzału wynosi 0,5 sekund" +
    "y.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 64);
            this.label4.MaximumSize = new System.Drawing.Size(333, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 52);
            this.label4.TabIndex = 6;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_main_menu
            // 
            this.back_main_menu.Location = new System.Drawing.Point(552, 12);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(120, 40);
            this.back_main_menu.TabIndex = 13;
            this.back_main_menu.Text = "Powrót do menu";
            this.back_main_menu.UseVisualStyleBackColor = true;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // refleks_button
            // 
            this.refleks_button.Location = new System.Drawing.Point(8, 312);
            this.refleks_button.Name = "refleks_button";
            this.refleks_button.Size = new System.Drawing.Size(120, 40);
            this.refleks_button.TabIndex = 3;
            this.refleks_button.Text = "Tryb refleks";
            this.refleks_button.UseVisualStyleBackColor = true;
            this.refleks_button.Click += new System.EventHandler(this.refleks_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 313);
            this.label5.MaximumSize = new System.Drawing.Size(333, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tryb ten polega na jak najszybszym trafieniu do tarczy, nad którą włączona jest d" +
    "ioda sygnalizująca. Światło diody pojawia się losowo, a czas jego trwania to 2,5" +
    "s-3s-3,5s-4s-4,5s.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 409);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Baza danych";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "Wyloguj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refleks_button);
            this.Controls.Add(this.back_main_menu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tryb3_przycisk);
            this.Controls.Add(this.tryb2_przycisk);
            this.Controls.Add(this.tryb1_przycisk);
            this.Controls.Add(this.label1);
            this.Name = "start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tryb1_przycisk;
        private System.Windows.Forms.Button tryb2_przycisk;
        private System.Windows.Forms.Button tryb3_przycisk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back_main_menu;
        private System.Windows.Forms.Button refleks_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button1;
    }
}