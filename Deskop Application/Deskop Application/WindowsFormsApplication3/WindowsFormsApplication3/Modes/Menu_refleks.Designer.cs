namespace ShootingRange
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
            this.btnScores = new System.Windows.Forms.Button();
            this.lblShooterName = new System.Windows.Forms.Label();
            this.tbxGun = new System.Windows.Forms.ComboBox();
            this.lblGun = new System.Windows.Forms.Label();
            this.txbShooterName = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Label();
            this.mthCal = new System.Windows.Forms.MonthCalendar();
            this.btnStart = new System.Windows.Forms.Button();
            this.dtgvTopScores = new System.Windows.Forms.DataGridView();
            this.port_com = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTopScores = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTopScores)).BeginInit();
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
            // btnScores
            // 
            this.btnScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnScores.Location = new System.Drawing.Point(12, 147);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(120, 40);
            this.btnScores.TabIndex = 33;
            this.btnScores.Text = "Zobacz wyniki";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.wyniki_Click);
            // 
            // lblShooterName
            // 
            this.lblShooterName.AutoSize = true;
            this.lblShooterName.BackColor = System.Drawing.SystemColors.Control;
            this.lblShooterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblShooterName.Location = new System.Drawing.Point(12, 26);
            this.lblShooterName.Name = "lblShooterName";
            this.lblShooterName.Size = new System.Drawing.Size(105, 13);
            this.lblShooterName.TabIndex = 32;
            this.lblShooterName.Text = "Nazwa strzelajacego";
            // 
            // tbxGun
            // 
            this.tbxGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxGun.FormattingEnabled = true;
            this.tbxGun.Location = new System.Drawing.Point(230, 42);
            this.tbxGun.Name = "tbxGun";
            this.tbxGun.Size = new System.Drawing.Size(187, 21);
            this.tbxGun.TabIndex = 31;
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.BackColor = System.Drawing.SystemColors.Control;
            this.lblGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblGun.Location = new System.Drawing.Point(227, 26);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(69, 13);
            this.lblGun.TabIndex = 30;
            this.lblGun.Text = "Wybierz broń";
            // 
            // txbShooterName
            // 
            this.txbShooterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbShooterName.Location = new System.Drawing.Point(15, 43);
            this.txbShooterName.Name = "txbShooterName";
            this.txbShooterName.Size = new System.Drawing.Size(197, 20);
            this.txbShooterName.TabIndex = 29;
            this.txbShooterName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // mthCal
            // 
            this.mthCal.Location = new System.Drawing.Point(8, 393);
            this.mthCal.MaxSelectionCount = 1;
            this.mthCal.Name = "mthCal";
            this.mthCal.TabIndex = 27;
            this.mthCal.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnStart.Location = new System.Drawing.Point(15, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 40);
            this.btnStart.TabIndex = 26;
            this.btnStart.Text = "START SHOOTING";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.start_button_Click);
            // 
            // dtgvTopScores
            // 
            this.dtgvTopScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvTopScores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvTopScores.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dtgvTopScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTopScores.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvTopScores.Location = new System.Drawing.Point(215, 147);
            this.dtgvTopScores.Name = "dtgvTopScores";
            this.dtgvTopScores.ReadOnly = true;
            this.dtgvTopScores.RowHeadersVisible = false;
            this.dtgvTopScores.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgvTopScores.Size = new System.Drawing.Size(607, 234);
            this.dtgvTopScores.TabIndex = 4;
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
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnStop.Location = new System.Drawing.Point(12, 330);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 40);
            this.btnStop.TabIndex = 35;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // lblTopScores
            // 
            this.lblTopScores.AutoSize = true;
            this.lblTopScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTopScores.Location = new System.Drawing.Point(370, 103);
            this.lblTopScores.Name = "lblTopScores";
            this.lblTopScores.Size = new System.Drawing.Size(285, 31);
            this.lblTopScores.TabIndex = 36;
            this.lblTopScores.Text = "TOP 10 STRZELCÓW";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(702, 509);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 37;
            this.btnLogout.Text = "Wyloguj";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(702, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(120, 40);
            this.btnMenu.TabIndex = 38;
            this.btnMenu.Text = "Powrót do menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Menu_refleks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblTopScores);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.czas_strzelania);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.lblShooterName);
            this.Controls.Add(this.tbxGun);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.txbShooterName);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.mthCal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dtgvTopScores);
            this.Name = "Menu_refleks";
            this.Text = "Menu_refleks";
            this.Load += new System.EventHandler(this.Menu_refleks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTopScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label czas_strzelania;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Label lblShooterName;
        private System.Windows.Forms.ComboBox tbxGun;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.TextBox txbShooterName;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.MonthCalendar mthCal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dtgvTopScores;
        private System.IO.Ports.SerialPort port_com;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTopScores;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMenu;
    }
}