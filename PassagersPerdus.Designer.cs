namespace Aeroport_Application
{
    partial class PassagersPerdus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassagersPerdus));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PassagerDataGridView = new System.Windows.Forms.DataGridView();
            this.PassagersLabel = new System.Windows.Forms.Label();
            this.AttendreButton = new System.Windows.Forms.Button();
            this.IgnorerButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Passager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passeport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCheckedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreValise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoidsValises = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PassagerDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PassagerDataGridView
            // 
            this.PassagerDataGridView.AllowUserToAddRows = false;
            this.PassagerDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.NullValue = "--";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.PassagerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PassagerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassagerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PassagerDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PassagerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PassagerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.PassagerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.NullValue = "--";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PassagerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PassagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassagerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.ID_Passager,
            this.Prenom,
            this.Sexe,
            this.Passeport,
            this.DateCheckedIn,
            this.NombreValise,
            this.PoidsValises});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PassagerDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.PassagerDataGridView.EnableHeadersVisualStyles = false;
            this.PassagerDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.PassagerDataGridView.Location = new System.Drawing.Point(12, 59);
            this.PassagerDataGridView.Name = "PassagerDataGridView";
            this.PassagerDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PassagerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PassagerDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.PassagerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.PassagerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PassagerDataGridView.Size = new System.Drawing.Size(877, 156);
            this.PassagerDataGridView.TabIndex = 28;
            // 
            // PassagersLabel
            // 
            this.PassagersLabel.AutoSize = true;
            this.PassagersLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassagersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.PassagersLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PassagersLabel.Location = new System.Drawing.Point(125, 25);
            this.PassagersLabel.Name = "PassagersLabel";
            this.PassagersLabel.Size = new System.Drawing.Size(617, 23);
            this.PassagersLabel.TabIndex = 36;
            this.PassagersLabel.Text = "Les passagers suivants ont effectué un check-in sans accomplir leur boarding:";
            // 
            // AttendreButton
            // 
            this.AttendreButton.Image = ((System.Drawing.Image)(resources.GetObject("AttendreButton.Image")));
            this.AttendreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttendreButton.Location = new System.Drawing.Point(457, 239);
            this.AttendreButton.Name = "AttendreButton";
            this.AttendreButton.Size = new System.Drawing.Size(88, 36);
            this.AttendreButton.TabIndex = 37;
            this.AttendreButton.Text = "Attendre";
            this.AttendreButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AttendreButton.UseVisualStyleBackColor = true;
            this.AttendreButton.Click += new System.EventHandler(this.AttendreButton_Click);
            // 
            // IgnorerButton
            // 
            this.IgnorerButton.Image = ((System.Drawing.Image)(resources.GetObject("IgnorerButton.Image")));
            this.IgnorerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IgnorerButton.Location = new System.Drawing.Point(352, 239);
            this.IgnorerButton.Name = "IgnorerButton";
            this.IgnorerButton.Size = new System.Drawing.Size(88, 36);
            this.IgnorerButton.TabIndex = 38;
            this.IgnorerButton.Text = "Ignorer";
            this.IgnorerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IgnorerButton.UseVisualStyleBackColor = true;
            this.IgnorerButton.Click += new System.EventHandler(this.IgnorerButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 39;
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
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom_Passager";
            this.Nom.FillWeight = 63.69712F;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Width = 130;
            // 
            // ID_Passager
            // 
            this.ID_Passager.DataPropertyName = "ID_Passager";
            this.ID_Passager.HeaderText = "ID";
            this.ID_Passager.Name = "ID_Passager";
            this.ID_Passager.Visible = false;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom_Passager";
            this.Prenom.FillWeight = 63.69712F;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.Width = 130;
            // 
            // Sexe
            // 
            this.Sexe.DataPropertyName = "Sexe_Passager";
            this.Sexe.HeaderText = "Sexe";
            this.Sexe.Name = "Sexe";
            this.Sexe.Width = 105;
            // 
            // Passeport
            // 
            this.Passeport.DataPropertyName = "Num_Passeport_Passager";
            this.Passeport.HeaderText = "N. Passeport";
            this.Passeport.Name = "Passeport";
            this.Passeport.Width = 140;
            // 
            // DateCheckedIn
            // 
            this.DateCheckedIn.DataPropertyName = "Date_Check_In_Passager";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.DateCheckedIn.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateCheckedIn.HeaderText = "Date Check-In";
            this.DateCheckedIn.Name = "DateCheckedIn";
            this.DateCheckedIn.Width = 170;
            // 
            // NombreValise
            // 
            this.NombreValise.DataPropertyName = "Nombre_Valise_Passager";
            this.NombreValise.HeaderText = "N.Valises";
            this.NombreValise.Name = "NombreValise";
            this.NombreValise.Width = 90;
            // 
            // PoidsValises
            // 
            this.PoidsValises.DataPropertyName = "Poids_Valise_Passager";
            this.PoidsValises.HeaderText = "Poids Valises (Kg)";
            this.PoidsValises.Name = "PoidsValises";
            this.PoidsValises.Width = 110;
            // 
            // PassagersPerdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 281);
            this.Controls.Add(this.IgnorerButton);
            this.Controls.Add(this.AttendreButton);
            this.Controls.Add(this.PassagersLabel);
            this.Controls.Add(this.PassagerDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PassagersPerdus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassagersPerdus";
            ((System.ComponentModel.ISupportInitialize)(this.PassagerDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PassagerDataGridView;
        private System.Windows.Forms.Label PassagersLabel;
        private System.Windows.Forms.Button AttendreButton;
        private System.Windows.Forms.Button IgnorerButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Passager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passeport;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCheckedIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreValise;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoidsValises;
    }
}