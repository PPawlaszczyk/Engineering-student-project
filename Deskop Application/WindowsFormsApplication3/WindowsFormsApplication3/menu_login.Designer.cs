namespace WindowsFormsApplication3
{
    partial class menu_login
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_haslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loguj = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.back_main_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(36, 69);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(156, 20);
            this.textBox_login.TabIndex = 0;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_haslo
            // 
            this.textBox_haslo.Location = new System.Drawing.Point(36, 125);
            this.textBox_haslo.Name = "textBox_haslo";
            this.textBox_haslo.Size = new System.Drawing.Size(156, 20);
            this.textBox_haslo.TabIndex = 1;
            this.textBox_haslo.TextChanged += new System.EventHandler(this.textBox_haslo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HASŁO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loguj
            // 
            this.loguj.Location = new System.Drawing.Point(36, 181);
            this.loguj.Name = "loguj";
            this.loguj.Size = new System.Drawing.Size(156, 69);
            this.loguj.TabIndex = 4;
            this.loguj.Text = "Loguj";
            this.loguj.UseVisualStyleBackColor = true;
            this.loguj.Click += new System.EventHandler(this.loguj_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(163, 282);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(163, 34);
            this.reset.TabIndex = 5;
            this.reset.Text = "Resetuj hasło";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // back_main_menu
            // 
            this.back_main_menu.Location = new System.Drawing.Point(221, 12);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(105, 62);
            this.back_main_menu.TabIndex = 13;
            this.back_main_menu.Text = "COFNIJ DO MENU GŁÓWNEGO";
            this.back_main_menu.UseVisualStyleBackColor = true;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // menu_login
            // 
            this.AcceptButton = this.loguj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(348, 328);
            this.Controls.Add(this.back_main_menu);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.loguj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_haslo);
            this.Controls.Add(this.textBox_login);
            this.Name = "menu_login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.menu_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_haslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loguj;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button back_main_menu;
    }
}