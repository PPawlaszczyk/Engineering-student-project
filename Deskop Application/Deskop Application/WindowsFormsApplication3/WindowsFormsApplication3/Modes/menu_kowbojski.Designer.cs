namespace ShootingRange
{
    partial class menu_kowbojski
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
            this.components = new System.ComponentModel.Container();
            this.back_main_menu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.start_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wyniki = new System.Windows.Forms.Button();
            this.czas_strzelania = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_main_menu
            // 
            this.back_main_menu.Location = new System.Drawing.Point(687, 12);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(105, 62);
            this.back_main_menu.TabIndex = 13;
            this.back_main_menu.Text = "COFNIJ DO MENU GŁÓWNEGO";
            this.back_main_menu.UseVisualStyleBackColor = true;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(480, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 300);
            this.dataGridView1.TabIndex = 14;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(195, 119);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(187, 50);
            this.start_button.TabIndex = 15;
            this.start_button.Text = "START button";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(-1, 339);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timer.Location = new System.Drawing.Point(200, 194);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(0, 36);
            this.timer.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Wybierz broń";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nazwa strzelajacego";
            // 
            // wyniki
            // 
            this.wyniki.Location = new System.Drawing.Point(195, 294);
            this.wyniki.Name = "wyniki";
            this.wyniki.Size = new System.Drawing.Size(187, 45);
            this.wyniki.TabIndex = 22;
            this.wyniki.Text = "Zobacz wyniki";
            this.wyniki.UseVisualStyleBackColor = true;
            this.wyniki.Visible = false;
            // 
            // czas_strzelania
            // 
            this.czas_strzelania.AutoSize = true;
            this.czas_strzelania.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas_strzelania.Location = new System.Drawing.Point(209, 389);
            this.czas_strzelania.Name = "czas_strzelania";
            this.czas_strzelania.Size = new System.Drawing.Size(0, 36);
            this.czas_strzelania.TabIndex = 23;
            this.czas_strzelania.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menu_kowbojski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 503);
            this.Controls.Add(this.czas_strzelania);
            this.Controls.Add(this.wyniki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_main_menu);
            this.Name = "menu_kowbojski";
            this.Text = "TRYB KOWBOJSKI";
            this.Load += new System.EventHandler(this.menu_kowbojski_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_main_menu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button wyniki;
        private System.Windows.Forms.Label czas_strzelania;
        private System.Windows.Forms.Timer timer2;
    }
}