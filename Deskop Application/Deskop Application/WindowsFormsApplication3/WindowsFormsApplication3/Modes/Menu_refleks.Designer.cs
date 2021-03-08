namespace WindowsFormsApplication3
{
    partial class Menu_refleks
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
            this.czas_strzelania = new System.Windows.Forms.Label();
            this.Score_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.weapon_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShooterName_textbox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.start_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back_main_menu = new System.Windows.Forms.Button();
            this.port_com = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Stop_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // czas_strzelania
            // 
            this.czas_strzelania.AutoSize = true;
            this.czas_strzelania.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas_strzelania.Location = new System.Drawing.Point(204, 393);
            this.czas_strzelania.Name = "czas_strzelania";
            this.czas_strzelania.Size = new System.Drawing.Size(0, 36);
            this.czas_strzelania.TabIndex = 34;
            this.czas_strzelania.Visible = false;
            // 
            // Score_button
            // 
            this.Score_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score_button.Location = new System.Drawing.Point(422, 137);
            this.Score_button.Name = "Score_button";
            this.Score_button.Size = new System.Drawing.Size(187, 45);
            this.Score_button.TabIndex = 33;
            this.Score_button.Text = "Zobacz wyniki";
            this.Score_button.UseVisualStyleBackColor = true;
            this.Score_button.Click += new System.EventHandler(this.wyniki_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nazwa strzelajacego";
            // 
            // weapon_combobox
            // 
            this.weapon_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weapon_combobox.FormattingEnabled = true;
            this.weapon_combobox.Location = new System.Drawing.Point(230, 60);
            this.weapon_combobox.Name = "weapon_combobox";
            this.weapon_combobox.Size = new System.Drawing.Size(187, 26);
            this.weapon_combobox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(226, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Wybierz broń";
            // 
            // ShooterName_textbox
            // 
            this.ShooterName_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShooterName_textbox.Location = new System.Drawing.Point(8, 62);
            this.ShooterName_textbox.Name = "ShooterName_textbox";
            this.ShooterName_textbox.Size = new System.Drawing.Size(197, 24);
            this.ShooterName_textbox.TabIndex = 29;
            this.ShooterName_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timer.Location = new System.Drawing.Point(195, 198);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(0, 36);
            this.timer.TabIndex = 28;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 403);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.Visible = false;
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_button.Location = new System.Drawing.Point(18, 137);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(187, 50);
            this.start_button.TabIndex = 26;
            this.start_button.Text = "START SHOOTING";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(221, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(607, 223);
            this.dataGridView1.TabIndex = 4;
            // 
            // back_main_menu
            // 
            this.back_main_menu.Location = new System.Drawing.Point(723, 12);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(105, 62);
            this.back_main_menu.TabIndex = 24;
            this.back_main_menu.Text = "COFNIJ DO MENU GŁÓWNEGO";
            this.back_main_menu.UseVisualStyleBackColor = true;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // port_com
            // 
            this.port_com.PortName = "COM4";
            this.port_com.ReadBufferSize = 2;
            this.port_com.ReadTimeout = 20;
            this.port_com.WriteBufferSize = 2;
            this.port_com.WriteTimeout = 200;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Stop_button
            // 
            this.Stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stop_button.Location = new System.Drawing.Point(18, 326);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(187, 46);
            this.Stop_button.TabIndex = 35;
            this.Stop_button.Text = "STOP";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(376, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "TOP 10 STRZELCÓW";
            // 
            // Menu_refleks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.tlo;
            this.ClientSize = new System.Drawing.Size(840, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.czas_strzelania);
            this.Controls.Add(this.Score_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weapon_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShooterName_textbox);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_main_menu);
            this.Name = "Menu_refleks";
            this.Text = "Menu_refleks";
            this.Load += new System.EventHandler(this.Menu_refleks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label czas_strzelania;
        private System.Windows.Forms.Button Score_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox weapon_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ShooterName_textbox;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back_main_menu;
        private System.IO.Ports.SerialPort port_com;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Label label3;
    }
}