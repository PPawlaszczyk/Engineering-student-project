namespace ShootingRange
{
    partial class DBGunsView
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
            this.txbModel = new System.Windows.Forms.TextBox();
            this.txbType = new System.Windows.Forms.TextBox();
            this.txbPowerSource = new System.Windows.Forms.TextBox();
            this.txbCapacity = new System.Windows.Forms.TextBox();
            this.txbFPS = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPowerSource = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblFPS = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbxModels = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbModel
            // 
            this.txbModel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbModel.Location = new System.Drawing.Point(386, 131);
            this.txbModel.MaxLength = 35;
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(226, 20);
            this.txbModel.TabIndex = 8;
            this.txbModel.TextChanged += new System.EventHandler(this.txbModel_TextChanged);
            // 
            // txbType
            // 
            this.txbType.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbType.Location = new System.Drawing.Point(386, 169);
            this.txbType.MaxLength = 35;
            this.txbType.Name = "txbType";
            this.txbType.Size = new System.Drawing.Size(226, 20);
            this.txbType.TabIndex = 9;
            this.txbType.TextChanged += new System.EventHandler(this.txbType_TextChanged);
            // 
            // txbPowerSource
            // 
            this.txbPowerSource.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPowerSource.Location = new System.Drawing.Point(386, 209);
            this.txbPowerSource.MaxLength = 35;
            this.txbPowerSource.Name = "txbPowerSource";
            this.txbPowerSource.Size = new System.Drawing.Size(226, 20);
            this.txbPowerSource.TabIndex = 10;
            this.txbPowerSource.TextChanged += new System.EventHandler(this.txbPowerSource_TextChanged);
            // 
            // txbCapacity
            // 
            this.txbCapacity.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbCapacity.Location = new System.Drawing.Point(386, 246);
            this.txbCapacity.MaxLength = 5;
            this.txbCapacity.Name = "txbCapacity";
            this.txbCapacity.Size = new System.Drawing.Size(44, 20);
            this.txbCapacity.TabIndex = 11;
            this.txbCapacity.TextChanged += new System.EventHandler(this.txbCapacity_TextChanged);
            // 
            // txbFPS
            // 
            this.txbFPS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbFPS.Location = new System.Drawing.Point(386, 287);
            this.txbFPS.MaxLength = 5;
            this.txbFPS.Name = "txbFPS";
            this.txbFPS.Size = new System.Drawing.Size(44, 20);
            this.txbFPS.TabIndex = 12;
            this.txbFPS.TextChanged += new System.EventHandler(this.txbFPS_TextChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(250, 134);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(62, 13);
            this.lblModel.TabIndex = 13;
            this.lblModel.Text = "Model broni";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(250, 172);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(28, 13);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "Typ ";
            // 
            // lblPowerSource
            // 
            this.lblPowerSource.AutoSize = true;
            this.lblPowerSource.Location = new System.Drawing.Point(251, 209);
            this.lblPowerSource.Name = "lblPowerSource";
            this.lblPowerSource.Size = new System.Drawing.Size(39, 13);
            this.lblPowerSource.TabIndex = 15;
            this.lblPowerSource.Text = "Napęd";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(250, 249);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(116, 13);
            this.lblCapacity.TabIndex = 16;
            this.lblCapacity.Text = "Pojemność magazynka";
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(251, 290);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(122, 13);
            this.lblFPS.TabIndex = 17;
            this.lblFPS.Text = "Prędkość wylotowa FPS";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(12, 9);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(69, 13);
            this.lblGun.TabIndex = 18;
            this.lblGun.Text = "Wybierz broń";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(492, 267);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(120, 40);
            this.btnModify.TabIndex = 19;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.modyfikuj_przycisk_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(492, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(120, 40);
            this.btnMenu.TabIndex = 26;
            this.btnMenu.Text = "Powrót do menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(194, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 30);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbxModels
            // 
            this.lbxModels.FormattingEnabled = true;
            this.lbxModels.Location = new System.Drawing.Point(12, 51);
            this.lbxModels.Name = "lbxModels";
            this.lbxModels.Size = new System.Drawing.Size(232, 368);
            this.lbxModels.TabIndex = 28;
            this.lbxModels.SelectedIndexChanged += new System.EventHandler(this.lbxModels_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 425);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 30);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(492, 415);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "Wyloguj";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbSearch.Location = new System.Drawing.Point(12, 30);
            this.txbSearch.MaxLength = 35;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(232, 22);
            this.txbSearch.TabIndex = 31;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // DBGunsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxModels);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.lblFPS);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblPowerSource);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txbFPS);
            this.Controls.Add(this.txbCapacity);
            this.Controls.Add(this.txbPowerSource);
            this.Controls.Add(this.txbType);
            this.Controls.Add(this.txbModel);
            this.Name = "DBGunsView";
            this.Text = "Modyfikuj broń";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.TextBox txbType;
        private System.Windows.Forms.TextBox txbPowerSource;
        private System.Windows.Forms.TextBox txbCapacity;
        private System.Windows.Forms.TextBox txbFPS;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPowerSource;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbxModels;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txbSearch;
    }
}