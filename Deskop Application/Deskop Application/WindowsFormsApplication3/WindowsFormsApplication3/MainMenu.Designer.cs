namespace WindowsFormsApplication3
{
    partial class menu
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
            this.reset = new System.Windows.Forms.Button();
            this.loguj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_haslo = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(202, 259);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(120, 40);
            this.reset.TabIndex = 19;
            this.reset.Text = "Resetuj hasło// Instrukcja";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // loguj
            // 
            this.loguj.Location = new System.Drawing.Point(117, 180);
            this.loguj.Name = "loguj";
            this.loguj.Size = new System.Drawing.Size(120, 40);
            this.loguj.TabIndex = 18;
            this.loguj.Text = "Loguj";
            this.loguj.UseVisualStyleBackColor = true;
            this.loguj.Click += new System.EventHandler(this.loguj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "HASŁO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "LOGIN";
            // 
            // textBox_haslo
            // 
            this.textBox_haslo.Location = new System.Drawing.Point(102, 138);
            this.textBox_haslo.Name = "textBox_haslo";
            this.textBox_haslo.Size = new System.Drawing.Size(156, 20);
            this.textBox_haslo.TabIndex = 15;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(102, 81);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(156, 20);
            this.textBox_login.TabIndex = 14;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.loguj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_haslo);
            this.Controls.Add(this.textBox_login);
            this.Name = "menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button loguj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_haslo;
        private System.Windows.Forms.TextBox textBox_login;
    }
}

