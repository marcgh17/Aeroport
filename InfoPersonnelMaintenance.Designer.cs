﻿namespace Aeroport_Application
{
    partial class InfoPersonnelMaintenance
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EquipeMLabel = new System.Windows.Forms.Label();
            this.EquiepMListView = new System.Windows.Forms.ListView();
            this.DisponibiliteLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Quitter";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // EquipeMLabel
            // 
            this.EquipeMLabel.AutoSize = true;
            this.EquipeMLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipeMLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.EquipeMLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EquipeMLabel.Location = new System.Drawing.Point(12, 35);
            this.EquipeMLabel.Name = "EquipeMLabel";
            this.EquipeMLabel.Size = new System.Drawing.Size(177, 23);
            this.EquipeMLabel.TabIndex = 35;
            this.EquipeMLabel.Text = "Equipe  Maintenance";
            // 
            // EquiepMListView
            // 
            this.EquiepMListView.Location = new System.Drawing.Point(16, 61);
            this.EquiepMListView.Name = "EquiepMListView";
            this.EquiepMListView.Size = new System.Drawing.Size(501, 292);
            this.EquiepMListView.TabIndex = 36;
            this.EquiepMListView.UseCompatibleStateImageBehavior = false;
            // 
            // DisponibiliteLabel
            // 
            this.DisponibiliteLabel.AutoSize = true;
            this.DisponibiliteLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisponibiliteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.DisponibiliteLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DisponibiliteLabel.Location = new System.Drawing.Point(340, 35);
            this.DisponibiliteLabel.Name = "DisponibiliteLabel";
            this.DisponibiliteLabel.Size = new System.Drawing.Size(112, 23);
            this.DisponibiliteLabel.TabIndex = 37;
            this.DisponibiliteLabel.Text = "Disponibilite";
            // 
            // InfoPersonnelMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 383);
            this.Controls.Add(this.DisponibiliteLabel);
            this.Controls.Add(this.EquiepMListView);
            this.Controls.Add(this.EquipeMLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InfoPersonnelMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoPersonnelMaintenance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label EquipeMLabel;
        private System.Windows.Forms.ListView EquiepMListView;
        private System.Windows.Forms.Label DisponibiliteLabel;
    }
}