namespace ShootingRange
{
    partial class EditView
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
            this.btnModifyDB = new System.Windows.Forms.Button();
            this.btnModifyUsers = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifyDB
            // 
            this.btnModifyDB.Location = new System.Drawing.Point(104, 122);
            this.btnModifyDB.Name = "btnModifyDB";
            this.btnModifyDB.Size = new System.Drawing.Size(120, 40);
            this.btnModifyDB.TabIndex = 2;
            this.btnModifyDB.Text = "Modyfikuj/Usuń broń";
            this.btnModifyDB.UseVisualStyleBackColor = true;
            this.btnModifyDB.Click += new System.EventHandler(this.modyfikuj_bron_Click);
            // 
            // btnModifyUsers
            // 
            this.btnModifyUsers.Location = new System.Drawing.Point(104, 193);
            this.btnModifyUsers.Name = "btnModifyUsers";
            this.btnModifyUsers.Size = new System.Drawing.Size(120, 40);
            this.btnModifyUsers.TabIndex = 3;
            this.btnModifyUsers.Text = "Dodaj/Usuń użytkownika";
            this.btnModifyUsers.UseVisualStyleBackColor = true;
            this.btnModifyUsers.Click += new System.EventHandler(this.zmien_haslo_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(202, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(120, 40);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "Powrót do menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // EditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnModifyUsers);
            this.Controls.Add(this.btnModifyDB);
            this.Name = "EditView";
            this.Text = "Menu Edycji";
            this.Load += new System.EventHandler(this.edytuj_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModifyDB;
        private System.Windows.Forms.Button btnModifyUsers;
        private System.Windows.Forms.Button btnMenu;
    }
}