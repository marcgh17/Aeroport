namespace Aeroport_Application
{
    partial class Horaire_Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.horaireDataGridView = new System.Windows.Forms.DataGridView();
            this.Red_Circle = new System.Windows.Forms.DataGridViewImageColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logo_Compagnie = new System.Windows.Forms.DataGridViewImageColumn();
            this.LogoUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Compagnie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_VolProgramme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat_Vol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heureprevue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeureEventuelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDirection = new System.Windows.Forms.Label();
            this.labetActualTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerDirection = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.horaireDataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // horaireDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.horaireDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.horaireDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horaireDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.horaireDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.horaireDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.horaireDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.horaireDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.NullValue = "--";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.horaireDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.horaireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.horaireDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Red_Circle,
            this.Date,
            this.Logo_Compagnie,
            this.LogoUrl,
            this.Nom_Compagnie,
            this.Numero_VolProgramme,
            this.Etat_Vol,
            this.Ville,
            this.Heureprevue,
            this.HeureEventuelle,
            this.Retard});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.horaireDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.horaireDataGridView.EnableHeadersVisualStyles = false;
            this.horaireDataGridView.GridColor = System.Drawing.Color.Black;
            this.horaireDataGridView.Location = new System.Drawing.Point(5, 120);
            this.horaireDataGridView.Name = "horaireDataGridView";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.horaireDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.horaireDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.horaireDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.horaireDataGridView.Size = new System.Drawing.Size(1346, 613);
            this.horaireDataGridView.TabIndex = 0;
            this.horaireDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CellFormating);
            this.horaireDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);
            // 
            // Red_Circle
            // 
            this.Red_Circle.HeaderText = "";
            this.Red_Circle.MinimumWidth = 50;
            this.Red_Circle.Name = "Red_Circle";
            this.Red_Circle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Red_Circle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Red_Circle.Width = 50;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date_Arrivee_Vol";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle3;
            this.Date.FillWeight = 64.03958F;
            this.Date.HeaderText = "Heure";
            this.Date.MinimumWidth = 150;
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // Logo_Compagnie
            // 
            this.Logo_Compagnie.HeaderText = "Logo";
            this.Logo_Compagnie.MinimumWidth = 180;
            this.Logo_Compagnie.Name = "Logo_Compagnie";
            this.Logo_Compagnie.Width = 180;
            // 
            // LogoUrl
            // 
            this.LogoUrl.DataPropertyName = "Logo_Compagnie";
            this.LogoUrl.HeaderText = "";
            this.LogoUrl.Name = "LogoUrl";
            this.LogoUrl.Visible = false;
            this.LogoUrl.Width = 40;
            // 
            // Nom_Compagnie
            // 
            this.Nom_Compagnie.DataPropertyName = "Nom_Compagnie";
            this.Nom_Compagnie.HeaderText = "Compagnie";
            this.Nom_Compagnie.MinimumWidth = 220;
            this.Nom_Compagnie.Name = "Nom_Compagnie";
            this.Nom_Compagnie.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nom_Compagnie.Width = 220;
            // 
            // Numero_VolProgramme
            // 
            this.Numero_VolProgramme.DataPropertyName = "Numero_VolProgramme";
            this.Numero_VolProgramme.FillWeight = 64.03958F;
            this.Numero_VolProgramme.HeaderText = "Vol";
            this.Numero_VolProgramme.Name = "Numero_VolProgramme";
            this.Numero_VolProgramme.Width = 89;
            // 
            // Etat_Vol
            // 
            this.Etat_Vol.DataPropertyName = "Etat_Vol";
            this.Etat_Vol.FillWeight = 64.03958F;
            this.Etat_Vol.HeaderText = "Etat";
            this.Etat_Vol.MinimumWidth = 190;
            this.Etat_Vol.Name = "Etat_Vol";
            this.Etat_Vol.Width = 190;
            // 
            // Ville
            // 
            this.Ville.DataPropertyName = "Code_Ville_Source";
            this.Ville.FillWeight = 64.03958F;
            this.Ville.HeaderText = "Ville";
            this.Ville.MinimumWidth = 190;
            this.Ville.Name = "Ville";
            this.Ville.Width = 190;
            // 
            // Heureprevue
            // 
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.Heureprevue.DefaultCellStyle = dataGridViewCellStyle4;
            this.Heureprevue.FillWeight = 106.3318F;
            this.Heureprevue.HeaderText = "Prévue à";
            this.Heureprevue.Name = "Heureprevue";
            this.Heureprevue.Width = 149;
            // 
            // HeureEventuelle
            // 
            this.HeureEventuelle.DataPropertyName = "Date_Arrivee_Eventuelle_Vol";
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = "--";
            this.HeureEventuelle.DefaultCellStyle = dataGridViewCellStyle5;
            this.HeureEventuelle.HeaderText = "Heure Eventuelle";
            this.HeureEventuelle.Name = "HeureEventuelle";
            this.HeureEventuelle.Width = 216;
            // 
            // Retard
            // 
            this.Retard.DataPropertyName = "Retard_Vol";
            this.Retard.FillWeight = 1F;
            this.Retard.HeaderText = "Retard";
            this.Retard.Name = "Retard";
            this.Retard.Visible = false;
            this.Retard.Width = 125;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ShowItemToolTips = true;
            this.menuStrip.Size = new System.Drawing.Size(1354, 24);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelDirection);
            this.panel1.Controls.Add(this.labetActualTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 99);
            this.panel1.TabIndex = 20;
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDirection.Location = new System.Drawing.Point(577, 25);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(235, 29);
            this.labelDirection.TabIndex = 23;
            this.labelDirection.Text = "Départs Régionaux";
            // 
            // labetActualTime
            // 
            this.labetActualTime.AutoSize = true;
            this.labetActualTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labetActualTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.labetActualTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labetActualTime.Location = new System.Drawing.Point(1241, 0);
            this.labetActualTime.Name = "labetActualTime";
            this.labetActualTime.Size = new System.Drawing.Size(28, 25);
            this.labetActualTime.TabIndex = 22;
            this.labetActualTime.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(553, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Aéroport régional de Paris";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // timerDirection
            // 
            this.timerDirection.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Horaire_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.horaireDataGridView);
            this.Name = "Horaire_Form";
            this.Text = "Horaire du vol";
            ((System.ComponentModel.ISupportInitialize)(this.horaireDataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView horaireDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Label labetActualTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerDirection;
        private System.Windows.Forms.DataGridViewImageColumn Red_Circle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewImageColumn Logo_Compagnie;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogoUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Compagnie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_VolProgramme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat_Vol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heureprevue;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeureEventuelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retard;
    }
}