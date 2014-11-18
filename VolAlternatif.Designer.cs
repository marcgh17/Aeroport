namespace Aeroport_Application
{
    partial class VolAlternatif
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
            this.NumeroVolLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VilleSourceLabel = new System.Windows.Forms.Label();
            this.VilleDestinationLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CompagnieLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AvionLabel = new System.Windows.Forms.Label();
            this.AvionComboBox = new System.Windows.Forms.ComboBox();
            this.Button = new System.Windows.Forms.Button();
            this.CompagnieLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TransfercheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompagnieLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Quitter";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // NumeroVolLabel
            // 
            this.NumeroVolLabel.AutoSize = true;
            this.NumeroVolLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroVolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.NumeroVolLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NumeroVolLabel.Location = new System.Drawing.Point(12, 24);
            this.NumeroVolLabel.Name = "NumeroVolLabel";
            this.NumeroVolLabel.Size = new System.Drawing.Size(115, 26);
            this.NumeroVolLabel.TabIndex = 30;
            this.NumeroVolLabel.Text = "Numero Vol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(13, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ville Source";
            // 
            // VilleSourceLabel
            // 
            this.VilleSourceLabel.AutoSize = true;
            this.VilleSourceLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VilleSourceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.VilleSourceLabel.Location = new System.Drawing.Point(204, 123);
            this.VilleSourceLabel.Name = "VilleSourceLabel";
            this.VilleSourceLabel.Size = new System.Drawing.Size(91, 21);
            this.VilleSourceLabel.TabIndex = 32;
            this.VilleSourceLabel.Text = "Ville Source";
            // 
            // VilleDestinationLabel
            // 
            this.VilleDestinationLabel.AutoSize = true;
            this.VilleDestinationLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VilleDestinationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.VilleDestinationLabel.Location = new System.Drawing.Point(204, 164);
            this.VilleDestinationLabel.Name = "VilleDestinationLabel";
            this.VilleDestinationLabel.Size = new System.Drawing.Size(122, 21);
            this.VilleDestinationLabel.TabIndex = 34;
            this.VilleDestinationLabel.Text = "Ville Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ville Destination";
            // 
            // CompagnieLabel
            // 
            this.CompagnieLabel.AutoSize = true;
            this.CompagnieLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompagnieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.CompagnieLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompagnieLabel.Location = new System.Drawing.Point(204, 70);
            this.CompagnieLabel.Name = "CompagnieLabel";
            this.CompagnieLabel.Size = new System.Drawing.Size(98, 23);
            this.CompagnieLabel.TabIndex = 56;
            this.CompagnieLabel.Text = "Compagnie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(14, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Date Départ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy        HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // AvionLabel
            // 
            this.AvionLabel.AutoSize = true;
            this.AvionLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.AvionLabel.Location = new System.Drawing.Point(14, 251);
            this.AvionLabel.Name = "AvionLabel";
            this.AvionLabel.Size = new System.Drawing.Size(50, 21);
            this.AvionLabel.TabIndex = 61;
            this.AvionLabel.Text = "Avion";
            // 
            // AvionComboBox
            // 
            this.AvionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvionComboBox.FormattingEnabled = true;
            this.AvionComboBox.Location = new System.Drawing.Point(208, 251);
            this.AvionComboBox.Name = "AvionComboBox";
            this.AvionComboBox.Size = new System.Drawing.Size(200, 21);
            this.AvionComboBox.TabIndex = 62;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(278, 327);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(130, 23);
            this.Button.TabIndex = 63;
            this.Button.Text = "Ajouter le vol";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // CompagnieLogoPictureBox
            // 
            this.CompagnieLogoPictureBox.Location = new System.Drawing.Point(18, 59);
            this.CompagnieLogoPictureBox.Name = "CompagnieLogoPictureBox";
            this.CompagnieLogoPictureBox.Size = new System.Drawing.Size(180, 45);
            this.CompagnieLogoPictureBox.TabIndex = 57;
            this.CompagnieLogoPictureBox.TabStop = false;
            // 
            // TransfercheckBox
            // 
            this.TransfercheckBox.AutoSize = true;
            this.TransfercheckBox.Location = new System.Drawing.Point(229, 289);
            this.TransfercheckBox.Name = "TransfercheckBox";
            this.TransfercheckBox.Size = new System.Drawing.Size(179, 17);
            this.TransfercheckBox.TabIndex = 64;
            this.TransfercheckBox.Text = "Transferez la liste des passagers";
            this.TransfercheckBox.UseVisualStyleBackColor = true;
            // 
            // VolAlternatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 374);
            this.Controls.Add(this.TransfercheckBox);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.AvionComboBox);
            this.Controls.Add(this.AvionLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompagnieLogoPictureBox);
            this.Controls.Add(this.CompagnieLabel);
            this.Controls.Add(this.VilleDestinationLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VilleSourceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumeroVolLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VolAlternatif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VolAlternatif";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompagnieLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label NumeroVolLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VilleSourceLabel;
        private System.Windows.Forms.Label VilleDestinationLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox CompagnieLogoPictureBox;
        private System.Windows.Forms.Label CompagnieLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label AvionLabel;
        private System.Windows.Forms.ComboBox AvionComboBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.CheckBox TransfercheckBox;
    }
}