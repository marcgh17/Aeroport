namespace Aeroport_Application
{
    partial class PersonnelMaintenance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Specialisations", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Equipes de maintenance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PersonnelMDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.EquipeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpecialisationComboBox = new System.Windows.Forms.ComboBox();
            this.labeltitle = new System.Windows.Forms.Label();
            this.AjouterButton = new System.Windows.Forms.Button();
            this.Infopanel = new System.Windows.Forms.Panel();
            this.InfolistView = new System.Windows.Forms.ListView();
            this.NomPrenomLabel = new System.Windows.Forms.Label();
            this.ModifiyButton = new System.Windows.Forms.Button();
            this.DisponibiliteLabel = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtatM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PersonnelM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEmbauche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PersonnelMDataGridView)).BeginInit();
            this.Infopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonnelMDataGridView
            // 
            this.PersonnelMDataGridView.AllowUserToAddRows = false;
            this.PersonnelMDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.NullValue = "--";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.PersonnelMDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PersonnelMDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonnelMDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonnelMDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PersonnelMDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PersonnelMDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PersonnelMDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.PersonnelMDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.NullValue = "--";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonnelMDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PersonnelMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonnelMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.EtatM,
            this.ID_PersonnelM,
            this.Prenom,
            this.DateNaissance,
            this.DateEmbauche});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PersonnelMDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.PersonnelMDataGridView.EnableHeadersVisualStyles = false;
            this.PersonnelMDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.PersonnelMDataGridView.Location = new System.Drawing.Point(12, 116);
            this.PersonnelMDataGridView.Name = "PersonnelMDataGridView";
            this.PersonnelMDataGridView.ReadOnly = true;
            this.PersonnelMDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonnelMDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PersonnelMDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.PersonnelMDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.PersonnelMDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonnelMDataGridView.Size = new System.Drawing.Size(577, 313);
            this.PersonnelMDataGridView.TabIndex = 29;
            this.PersonnelMDataGridView.SelectionChanged += new System.EventHandler(this.EmploteChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Choisir une équipe :";
            // 
            // EquipeComboBox
            // 
            this.EquipeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EquipeComboBox.FormattingEnabled = true;
            this.EquipeComboBox.Location = new System.Drawing.Point(156, 85);
            this.EquipeComboBox.Name = "EquipeComboBox";
            this.EquipeComboBox.Size = new System.Drawing.Size(73, 21);
            this.EquipeComboBox.TabIndex = 38;
            this.EquipeComboBox.SelectedIndexChanged += new System.EventHandler(this.EquipeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(287, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Choisir une specialisation: ";
            // 
            // SpecialisationComboBox
            // 
            this.SpecialisationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecialisationComboBox.FormattingEnabled = true;
            this.SpecialisationComboBox.Location = new System.Drawing.Point(467, 86);
            this.SpecialisationComboBox.Name = "SpecialisationComboBox";
            this.SpecialisationComboBox.Size = new System.Drawing.Size(122, 21);
            this.SpecialisationComboBox.TabIndex = 40;
            this.SpecialisationComboBox.SelectedIndexChanged += new System.EventHandler(this.SpecialisationComboBox_SelectedIndexChanged);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.labeltitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeltitle.Location = new System.Drawing.Point(12, 31);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(217, 26);
            this.labeltitle.TabIndex = 41;
            this.labeltitle.Text = "Personnel Maintenance";
            // 
            // AjouterButton
            // 
            this.AjouterButton.Location = new System.Drawing.Point(452, 435);
            this.AjouterButton.Name = "AjouterButton";
            this.AjouterButton.Size = new System.Drawing.Size(119, 23);
            this.AjouterButton.TabIndex = 42;
            this.AjouterButton.Text = "Ajouter un employé";
            this.AjouterButton.UseVisualStyleBackColor = true;
            this.AjouterButton.Click += new System.EventHandler(this.AjouterButton_Click);
            // 
            // Infopanel
            // 
            this.Infopanel.Controls.Add(this.InfolistView);
            this.Infopanel.Location = new System.Drawing.Point(612, 116);
            this.Infopanel.Name = "Infopanel";
            this.Infopanel.Size = new System.Drawing.Size(360, 313);
            this.Infopanel.TabIndex = 43;
            // 
            // InfolistView
            // 
            listViewGroup1.Header = "Specialisations";
            listViewGroup1.Name = "Specialisations";
            listViewGroup2.Header = "Equipes de maintenance";
            listViewGroup2.Name = "Equipes";
            this.InfolistView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.InfolistView.Location = new System.Drawing.Point(16, 3);
            this.InfolistView.Name = "InfolistView";
            this.InfolistView.Size = new System.Drawing.Size(324, 307);
            this.InfolistView.TabIndex = 0;
            this.InfolistView.UseCompatibleStateImageBehavior = false;
            // 
            // NomPrenomLabel
            // 
            this.NomPrenomLabel.AutoSize = true;
            this.NomPrenomLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomPrenomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.NomPrenomLabel.Location = new System.Drawing.Point(740, 88);
            this.NomPrenomLabel.Name = "NomPrenomLabel";
            this.NomPrenomLabel.Size = new System.Drawing.Size(94, 18);
            this.NomPrenomLabel.TabIndex = 44;
            this.NomPrenomLabel.Text = "Nom, Prenom";
            // 
            // ModifiyButton
            // 
            this.ModifiyButton.Location = new System.Drawing.Point(829, 435);
            this.ModifiyButton.Name = "ModifiyButton";
            this.ModifiyButton.Size = new System.Drawing.Size(123, 23);
            this.ModifiyButton.TabIndex = 45;
            this.ModifiyButton.Text = "Modifier Employé";
            this.ModifiyButton.UseVisualStyleBackColor = true;
            this.ModifiyButton.Click += new System.EventHandler(this.ModifiyButton_Click);
            // 
            // DisponibiliteLabel
            // 
            this.DisponibiliteLabel.AutoSize = true;
            this.DisponibiliteLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisponibiliteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.DisponibiliteLabel.Location = new System.Drawing.Point(673, 436);
            this.DisponibiliteLabel.Name = "DisponibiliteLabel";
            this.DisponibiliteLabel.Size = new System.Drawing.Size(91, 19);
            this.DisponibiliteLabel.TabIndex = 46;
            this.DisponibiliteLabel.Text = "Disponibilte";
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom_PersonnelM";
            this.Nom.FillWeight = 69.8627F;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // EtatM
            // 
            this.EtatM.DataPropertyName = "Etat_Actuel_PersonnelM";
            this.EtatM.HeaderText = "EtatM";
            this.EtatM.Name = "EtatM";
            this.EtatM.ReadOnly = true;
            this.EtatM.Visible = false;
            // 
            // ID_PersonnelM
            // 
            this.ID_PersonnelM.DataPropertyName = "ID_PersonnelM";
            this.ID_PersonnelM.HeaderText = "ID";
            this.ID_PersonnelM.Name = "ID_PersonnelM";
            this.ID_PersonnelM.ReadOnly = true;
            this.ID_PersonnelM.Visible = false;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom_PersonnelM";
            this.Prenom.FillWeight = 69.8627F;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // DateNaissance
            // 
            this.DateNaissance.DataPropertyName = "Date_Naissance_PersonnelM";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DateNaissance.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateNaissance.FillWeight = 109.6795F;
            this.DateNaissance.HeaderText = "Date Naissance";
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.ReadOnly = true;
            // 
            // DateEmbauche
            // 
            this.DateEmbauche.DataPropertyName = "Date_Embauche_PersonnelM";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.DateEmbauche.DefaultCellStyle = dataGridViewCellStyle4;
            this.DateEmbauche.FillWeight = 109.6795F;
            this.DateEmbauche.HeaderText = "Date Embauche";
            this.DateEmbauche.Name = "DateEmbauche";
            this.DateEmbauche.ReadOnly = true;
            // 
            // PersonnelMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 502);
            this.Controls.Add(this.DisponibiliteLabel);
            this.Controls.Add(this.ModifiyButton);
            this.Controls.Add(this.NomPrenomLabel);
            this.Controls.Add(this.Infopanel);
            this.Controls.Add(this.AjouterButton);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.SpecialisationComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EquipeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonnelMDataGridView);
            this.Name = "PersonnelMaintenance";
            this.Text = "PersonnelMaintenance";
            ((System.ComponentModel.ISupportInitialize)(this.PersonnelMDataGridView)).EndInit();
            this.Infopanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonnelMDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EquipeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SpecialisationComboBox;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Button AjouterButton;
        private System.Windows.Forms.Panel Infopanel;
        private System.Windows.Forms.ListView InfolistView;
        private System.Windows.Forms.Label NomPrenomLabel;
        private System.Windows.Forms.Button ModifiyButton;
        private System.Windows.Forms.Label DisponibiliteLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtatM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PersonnelM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEmbauche;
    }
}