﻿namespace Aeroport_Application
{
    partial class AjouterPersonnelMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterPersonnelMaintenance));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Operations", System.Windows.Forms.HorizontalAlignment.Left);
            this.Label1 = new System.Windows.Forms.Label();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.PrenomTextBox = new System.Windows.Forms.TextBox();
            this.dateNaissancePicker = new System.Windows.Forms.DateTimePicker();
            this.DateEmbauchePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.OperationsListView = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.Label1.Location = new System.Drawing.Point(12, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(299, 23);
            this.Label1.TabIndex = 40;
            this.Label1.Text = "Ajouter un employé de maintenance";
            // 
            // NomTextBox
            // 
            this.NomTextBox.Location = new System.Drawing.Point(146, 80);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(186, 20);
            this.NomTextBox.TabIndex = 41;
            this.NomTextBox.TextChanged += new System.EventHandler(this.TextBoxesChanged);
            // 
            // PrenomTextBox
            // 
            this.PrenomTextBox.Location = new System.Drawing.Point(146, 116);
            this.PrenomTextBox.Name = "PrenomTextBox";
            this.PrenomTextBox.Size = new System.Drawing.Size(186, 20);
            this.PrenomTextBox.TabIndex = 42;
            this.PrenomTextBox.TextChanged += new System.EventHandler(this.TextBoxesChanged);
            // 
            // dateNaissancePicker
            // 
            this.dateNaissancePicker.Location = new System.Drawing.Point(146, 156);
            this.dateNaissancePicker.Name = "dateNaissancePicker";
            this.dateNaissancePicker.Size = new System.Drawing.Size(186, 20);
            this.dateNaissancePicker.TabIndex = 43;
            // 
            // DateEmbauchePicker
            // 
            this.DateEmbauchePicker.Location = new System.Drawing.Point(146, 194);
            this.DateEmbauchePicker.Name = "DateEmbauchePicker";
            this.DateEmbauchePicker.Size = new System.Drawing.Size(186, 20);
            this.DateEmbauchePicker.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Prénom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Date de naissance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(13, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Date d\'embauche:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Image = ((System.Drawing.Image)(resources.GetObject("ConfirmButton.Image")));
            this.ConfirmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfirmButton.Location = new System.Drawing.Point(229, 220);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(103, 36);
            this.ConfirmButton.TabIndex = 49;
            this.ConfirmButton.Text = "Confirmer";
            this.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // OperationsListView
            // 
            this.OperationsListView.CheckBoxes = true;
            this.OperationsListView.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationsListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            listViewGroup1.Header = "Operations";
            listViewGroup1.Name = "Operations";
            this.OperationsListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.OperationsListView.Location = new System.Drawing.Point(398, 79);
            this.OperationsListView.Name = "OperationsListView";
            this.OperationsListView.Size = new System.Drawing.Size(200, 177);
            this.OperationsListView.TabIndex = 50;
            this.OperationsListView.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // AjouterPersonnelMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 297);
            this.Controls.Add(this.OperationsListView);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateEmbauchePicker);
            this.Controls.Add(this.dateNaissancePicker);
            this.Controls.Add(this.PrenomTextBox);
            this.Controls.Add(this.NomTextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AjouterPersonnelMaintenance";
            this.Text = "AjouterPersonnelMaintenance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.TextBox PrenomTextBox;
        private System.Windows.Forms.DateTimePicker dateNaissancePicker;
        private System.Windows.Forms.DateTimePicker DateEmbauchePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ListView OperationsListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}