namespace ShootingRange
{
    partial class menu_szybkostrzelny
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
            this.back_main_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_main_menu
            // 
            this.back_main_menu.Location = new System.Drawing.Point(321, 12);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(105, 62);
            this.back_main_menu.TabIndex = 13;
            this.back_main_menu.Text = "COFNIJ DO MENU GŁÓWNEGO";
            this.back_main_menu.UseVisualStyleBackColor = true;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // menu_szybkostrzelny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 418);
            this.Controls.Add(this.back_main_menu);
            this.Name = "menu_szybkostrzelny";
            this.Text = "TRYB SZYBKOSTRZELNY";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_main_menu;
    }
}