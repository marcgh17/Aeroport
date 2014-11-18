namespace Aeroport_Application
{
    partial class InfoPersonnelVol
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonnelDeVolLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.DateNaissanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.CompagnieLabel = new System.Windows.Forms.Label();
            this.CompagnieLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxRole = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateEmbaucheLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompagnieLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRole)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ShowItemToolTips = true;
            this.menuStrip.Size = new System.Drawing.Size(318, 24);
            this.menuStrip.TabIndex = 19;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fileToolStripMenuItem.Text = "Fichier";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Quitter";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // PersonnelDeVolLabel
            // 
            this.PersonnelDeVolLabel.AutoSize = true;
            this.PersonnelDeVolLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonnelDeVolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.PersonnelDeVolLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PersonnelDeVolLabel.Location = new System.Drawing.Point(78, 51);
            this.PersonnelDeVolLabel.Name = "PersonnelDeVolLabel";
            this.PersonnelDeVolLabel.Size = new System.Drawing.Size(128, 21);
            this.PersonnelDeVolLabel.TabIndex = 31;
            this.PersonnelDeVolLabel.Text = "Personnel de vol";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label.Location = new System.Drawing.Point(12, 98);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(123, 18);
            this.label.TabIndex = 32;
            this.label.Text = "Date de naissance:";
            // 
            // DateNaissanceLabel
            // 
            this.DateNaissanceLabel.AutoSize = true;
            this.DateNaissanceLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNaissanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.DateNaissanceLabel.Location = new System.Drawing.Point(141, 98);
            this.DateNaissanceLabel.Name = "DateNaissanceLabel";
            this.DateNaissanceLabel.Size = new System.Drawing.Size(119, 18);
            this.DateNaissanceLabel.TabIndex = 33;
            this.DateNaissanceLabel.Text = "Date de naissance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Rôle:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.RoleLabel.Location = new System.Drawing.Point(141, 134);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(36, 18);
            this.RoleLabel.TabIndex = 35;
            this.RoleLabel.Text = "Rôle";
            // 
            // CompagnieLabel
            // 
            this.CompagnieLabel.AutoSize = true;
            this.CompagnieLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompagnieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.CompagnieLabel.Location = new System.Drawing.Point(201, 210);
            this.CompagnieLabel.Name = "CompagnieLabel";
            this.CompagnieLabel.Size = new System.Drawing.Size(78, 18);
            this.CompagnieLabel.TabIndex = 36;
            this.CompagnieLabel.Text = "Compagnie";
            // 
            // CompagnieLogoPictureBox
            // 
            this.CompagnieLogoPictureBox.Location = new System.Drawing.Point(15, 199);
            this.CompagnieLogoPictureBox.Name = "CompagnieLogoPictureBox";
            this.CompagnieLogoPictureBox.Size = new System.Drawing.Size(180, 45);
            this.CompagnieLogoPictureBox.TabIndex = 56;
            this.CompagnieLogoPictureBox.TabStop = false;
            // 
            // pictureBoxRole
            // 
            this.pictureBoxRole.Location = new System.Drawing.Point(12, 30);
            this.pictureBoxRole.Name = "pictureBoxRole";
            this.pictureBoxRole.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxRole.TabIndex = 57;
            this.pictureBoxRole.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Date d\'embauche:";
            // 
            // DateEmbaucheLabel
            // 
            this.DateEmbaucheLabel.AutoSize = true;
            this.DateEmbaucheLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEmbaucheLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.DateEmbaucheLabel.Location = new System.Drawing.Point(141, 168);
            this.DateEmbaucheLabel.Name = "DateEmbaucheLabel";
            this.DateEmbaucheLabel.Size = new System.Drawing.Size(116, 18);
            this.DateEmbaucheLabel.TabIndex = 59;
            this.DateEmbaucheLabel.Text = "Date d\'embauche";
            // 
            // InfoPersonnelVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 252);
            this.Controls.Add(this.DateEmbaucheLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxRole);
            this.Controls.Add(this.CompagnieLogoPictureBox);
            this.Controls.Add(this.CompagnieLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateNaissanceLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PersonnelDeVolLabel);
            this.Controls.Add(this.menuStrip);
            this.Name = "InfoPersonnelVol";
            this.Text = "InfoPersonnelVol";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompagnieLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label PersonnelDeVolLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label DateNaissanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label CompagnieLabel;
        private System.Windows.Forms.PictureBox CompagnieLogoPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateEmbaucheLabel;

    }
}