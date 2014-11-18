namespace Aeroport_Application
{
    partial class ListePassagers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListePassagers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PassagerDataGridView = new System.Windows.Forms.DataGridView();
            this.LabelNumVol = new System.Windows.Forms.Label();
            this.UploadPassagerButton = new System.Windows.Forms.Button();
            this.LabelRemarque = new System.Windows.Forms.Label();
            this.ExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.PlaceComboBox = new System.Windows.Forms.ComboBox();
            this.RevoirToutButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SupprimerPassagerButton = new System.Windows.Forms.Button();
            this.ButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Passager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe_Passager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationalite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Passeport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat_Passager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PassagerDataGridView)).BeginInit();
            this.SearchPanel.SuspendLayout();
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
            this.PassagerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.Sexe_Passager,
            this.DateNaissance,
            this.Nationalite,
            this.Numero_Passeport,
            this.Place,
            this.Etat_Passager,
            this.DateReservation});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PassagerDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.PassagerDataGridView.EnableHeadersVisualStyles = false;
            this.PassagerDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.PassagerDataGridView.Location = new System.Drawing.Point(16, 207);
            this.PassagerDataGridView.Name = "PassagerDataGridView";
            this.PassagerDataGridView.ReadOnly = true;
            this.PassagerDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PassagerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PassagerDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.PassagerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.PassagerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PassagerDataGridView.Size = new System.Drawing.Size(960, 270);
            this.PassagerDataGridView.TabIndex = 28;
            // 
            // LabelNumVol
            // 
            this.LabelNumVol.AutoSize = true;
            this.LabelNumVol.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumVol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.LabelNumVol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNumVol.Location = new System.Drawing.Point(20, 21);
            this.LabelNumVol.Name = "LabelNumVol";
            this.LabelNumVol.Size = new System.Drawing.Size(108, 23);
            this.LabelNumVol.TabIndex = 30;
            this.LabelNumVol.Text = "Date choisie";
            // 
            // UploadPassagerButton
            // 
            this.UploadPassagerButton.Enabled = false;
            this.UploadPassagerButton.Image = ((System.Drawing.Image)(resources.GetObject("UploadPassagerButton.Image")));
            this.UploadPassagerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UploadPassagerButton.Location = new System.Drawing.Point(759, 21);
            this.UploadPassagerButton.Name = "UploadPassagerButton";
            this.UploadPassagerButton.Size = new System.Drawing.Size(197, 51);
            this.UploadPassagerButton.TabIndex = 31;
            this.UploadPassagerButton.Text = "Importer la liste de passagers";
            this.UploadPassagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonToolTip.SetToolTip(this.UploadPassagerButton, "Importer d\'un fichier excel");
            this.UploadPassagerButton.UseVisualStyleBackColor = true;
            this.UploadPassagerButton.Click += new System.EventHandler(this.UploadPassagerButton_Click);
            // 
            // LabelRemarque
            // 
            this.LabelRemarque.AutoSize = true;
            this.LabelRemarque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRemarque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.LabelRemarque.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRemarque.Location = new System.Drawing.Point(20, 81);
            this.LabelRemarque.Name = "LabelRemarque";
            this.LabelRemarque.Size = new System.Drawing.Size(79, 19);
            this.LabelRemarque.TabIndex = 32;
            this.LabelRemarque.Text = "Remarque";
            // 
            // ExcelFileDialog
            // 
            this.ExcelFileDialog.FileName = "openFileDialog1";
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.PlaceComboBox);
            this.SearchPanel.Controls.Add(this.RevoirToutButton);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Controls.Add(this.label1);
            this.SearchPanel.Location = new System.Drawing.Point(17, 155);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(820, 46);
            this.SearchPanel.TabIndex = 33;
            // 
            // PlaceComboBox
            // 
            this.PlaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaceComboBox.FormattingEnabled = true;
            this.PlaceComboBox.Location = new System.Drawing.Point(679, 14);
            this.PlaceComboBox.Name = "PlaceComboBox";
            this.PlaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.PlaceComboBox.TabIndex = 37;
            this.PlaceComboBox.SelectedValueChanged += new System.EventHandler(this.PlaceSelectedChanged);
            // 
            // RevoirToutButton
            // 
            this.RevoirToutButton.Location = new System.Drawing.Point(518, 12);
            this.RevoirToutButton.Name = "RevoirToutButton";
            this.RevoirToutButton.Size = new System.Drawing.Size(145, 23);
            this.RevoirToutButton.TabIndex = 36;
            this.RevoirToutButton.Text = "Revoir tous les passaagers";
            this.RevoirToutButton.UseVisualStyleBackColor = true;
            this.RevoirToutButton.Click += new System.EventHandler(this.Revoir_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(426, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 35;
            this.SearchButton.Text = "Rechercher";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(182, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(224, 20);
            this.SearchTextBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Rechercher un passager :";
            // 
            // SupprimerPassagerButton
            // 
            this.SupprimerPassagerButton.Enabled = false;
            this.SupprimerPassagerButton.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerPassagerButton.Image")));
            this.SupprimerPassagerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SupprimerPassagerButton.Location = new System.Drawing.Point(759, 81);
            this.SupprimerPassagerButton.Name = "SupprimerPassagerButton";
            this.SupprimerPassagerButton.Size = new System.Drawing.Size(197, 51);
            this.SupprimerPassagerButton.TabIndex = 34;
            this.SupprimerPassagerButton.Text = "Supprimer la liste de passagers";
            this.SupprimerPassagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonToolTip.SetToolTip(this.SupprimerPassagerButton, "Supprimer la liste en ajoutant un code reference");
            this.SupprimerPassagerButton.UseVisualStyleBackColor = true;
            this.SupprimerPassagerButton.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom_Passager";
            this.Nom.FillWeight = 69.8627F;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // ID_Passager
            // 
            this.ID_Passager.DataPropertyName = "ID_Passager";
            this.ID_Passager.HeaderText = "ID";
            this.ID_Passager.Name = "ID_Passager";
            this.ID_Passager.ReadOnly = true;
            this.ID_Passager.Visible = false;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom_Passager";
            this.Prenom.FillWeight = 69.8627F;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Sexe_Passager
            // 
            this.Sexe_Passager.DataPropertyName = "Sexe_Passager";
            this.Sexe_Passager.FillWeight = 80.31384F;
            this.Sexe_Passager.HeaderText = "Sexe";
            this.Sexe_Passager.MinimumWidth = 20;
            this.Sexe_Passager.Name = "Sexe_Passager";
            this.Sexe_Passager.ReadOnly = true;
            // 
            // DateNaissance
            // 
            this.DateNaissance.DataPropertyName = "Date_Naissance_Passager";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DateNaissance.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateNaissance.FillWeight = 109.6795F;
            this.DateNaissance.HeaderText = "Date Naissance";
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.ReadOnly = true;
            // 
            // Nationalite
            // 
            this.Nationalite.DataPropertyName = "Nationalite_Passager";
            this.Nationalite.FillWeight = 109.6795F;
            this.Nationalite.HeaderText = "Nationalité";
            this.Nationalite.Name = "Nationalite";
            this.Nationalite.ReadOnly = true;
            // 
            // Numero_Passeport
            // 
            this.Numero_Passeport.DataPropertyName = "Num_Passeport_Passager";
            this.Numero_Passeport.FillWeight = 109.6795F;
            this.Numero_Passeport.HeaderText = "Passeport";
            this.Numero_Passeport.Name = "Numero_Passeport";
            this.Numero_Passeport.ReadOnly = true;
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Emplacement_Passager";
            this.Place.FillWeight = 62.47134F;
            this.Place.HeaderText = "Place";
            this.Place.MinimumWidth = 15;
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // Etat_Passager
            // 
            this.Etat_Passager.DataPropertyName = "Etat_Passager";
            this.Etat_Passager.FillWeight = 69.8627F;
            this.Etat_Passager.HeaderText = "Etat";
            this.Etat_Passager.Name = "Etat_Passager";
            this.Etat_Passager.ReadOnly = true;
            // 
            // DateReservation
            // 
            this.DateReservation.DataPropertyName = "Date_Reservation_Passager";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.DateReservation.DefaultCellStyle = dataGridViewCellStyle4;
            this.DateReservation.FillWeight = 109.6795F;
            this.DateReservation.HeaderText = "Date Réservation";
            this.DateReservation.Name = "DateReservation";
            this.DateReservation.ReadOnly = true;
            // 
            // ListePassagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 502);
            this.Controls.Add(this.SupprimerPassagerButton);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.LabelRemarque);
            this.Controls.Add(this.UploadPassagerButton);
            this.Controls.Add(this.LabelNumVol);
            this.Controls.Add(this.PassagerDataGridView);
            this.Name = "ListePassagers";
            this.Text = "ListePassagers";
            ((System.ComponentModel.ISupportInitialize)(this.PassagerDataGridView)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PassagerDataGridView;
        private System.Windows.Forms.Label LabelNumVol;
        private System.Windows.Forms.Button UploadPassagerButton;
        private System.Windows.Forms.Label LabelRemarque;
        private System.Windows.Forms.OpenFileDialog ExcelFileDialog;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.ComboBox PlaceComboBox;
        private System.Windows.Forms.Button RevoirToutButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SupprimerPassagerButton;
        private System.Windows.Forms.ToolTip ButtonToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Passager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe_Passager;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationalite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Passeport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat_Passager;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReservation;
    }
}