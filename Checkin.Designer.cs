namespace Aeroport_Application
{
    partial class Checkin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PassagerDataGridView = new System.Windows.Forms.DataGridView();
            this.InformationPassagerPanel = new System.Windows.Forms.Panel();
            this.NonCheckedinPanel = new System.Windows.Forms.Panel();
            this.PoidsMaxPassagerLabel = new System.Windows.Forms.Label();
            this.PoidsMaxLabel = new System.Windows.Forms.Label();
            this.PoidsValiseTextBox = new System.Windows.Forms.TextBox();
            this.NombreValiseTextBox = new System.Windows.Forms.TextBox();
            this.SaveEtatButton = new System.Windows.Forms.Button();
            this.CheckInCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DateReservationLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EtatLabel = new System.Windows.Forms.Label();
            this.EmplacementLabel = new System.Windows.Forms.Label();
            this.NationnaliteLabel = new System.Windows.Forms.Label();
            this.NumeroPassportLabel = new System.Windows.Forms.Label();
            this.SexeLabel = new System.Windows.Forms.Label();
            this.DateNaissanceLabel = new System.Windows.Forms.Label();
            this.NomPrenomLabel = new System.Windows.Forms.Label();
            this.CheckedinPanel = new System.Windows.Forms.Panel();
            this.PoidsValiseLabel = new System.Windows.Forms.Label();
            this.NombreValiseLabel = new System.Windows.Forms.Label();
            this.DateCheckedinLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroVolLabel = new System.Windows.Forms.Label();
            this.ExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CapaciteMaxTotaleLabel = new System.Windows.Forms.Label();
            this.CapaciteCumuleeLabel = new System.Windows.Forms.Label();
            this.PourcentagePassagerLabel = new System.Windows.Forms.Label();
            this.PourcentageValiseLabel = new System.Windows.Forms.Label();
            this.NbReservationLabel = new System.Windows.Forms.Label();
            this.TableStats = new System.Windows.Forms.TableLayoutPanel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.PlaceComboBox = new System.Windows.Forms.ComboBox();
            this.RevoirToutButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.compagnieTableAdapter1 = new Aeroport_Application.AeroportDataSetTableAdapters.CompagnieTableAdapter();
            this.ID_Passager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passeport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtatHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PassagerDataGridView)).BeginInit();
            this.InformationPassagerPanel.SuspendLayout();
            this.NonCheckedinPanel.SuspendLayout();
            this.CheckedinPanel.SuspendLayout();
            this.TableStats.SuspendLayout();
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
            this.ID_Passager,
            this.Nom,
            this.Prenom,
            this.Passeport,
            this.Etat,
            this.EtatHidden});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PassagerDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PassagerDataGridView.EnableHeadersVisualStyles = false;
            this.PassagerDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.PassagerDataGridView.Location = new System.Drawing.Point(12, 265);
            this.PassagerDataGridView.Name = "PassagerDataGridView";
            this.PassagerDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PassagerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PassagerDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.PassagerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.PassagerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PassagerDataGridView.Size = new System.Drawing.Size(488, 229);
            this.PassagerDataGridView.TabIndex = 27;
            this.PassagerDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);
            this.PassagerDataGridView.SelectionChanged += new System.EventHandler(this.PassaagerSelectedChanged);
            // 
            // InformationPassagerPanel
            // 
            this.InformationPassagerPanel.Controls.Add(this.NonCheckedinPanel);
            this.InformationPassagerPanel.Controls.Add(this.DateReservationLabel);
            this.InformationPassagerPanel.Controls.Add(this.label8);
            this.InformationPassagerPanel.Controls.Add(this.EtatLabel);
            this.InformationPassagerPanel.Controls.Add(this.EmplacementLabel);
            this.InformationPassagerPanel.Controls.Add(this.NationnaliteLabel);
            this.InformationPassagerPanel.Controls.Add(this.NumeroPassportLabel);
            this.InformationPassagerPanel.Controls.Add(this.SexeLabel);
            this.InformationPassagerPanel.Controls.Add(this.DateNaissanceLabel);
            this.InformationPassagerPanel.Controls.Add(this.NomPrenomLabel);
            this.InformationPassagerPanel.Controls.Add(this.CheckedinPanel);
            this.InformationPassagerPanel.Controls.Add(this.label7);
            this.InformationPassagerPanel.Controls.Add(this.label6);
            this.InformationPassagerPanel.Controls.Add(this.label5);
            this.InformationPassagerPanel.Controls.Add(this.label4);
            this.InformationPassagerPanel.Controls.Add(this.label3);
            this.InformationPassagerPanel.Controls.Add(this.label2);
            this.InformationPassagerPanel.Controls.Add(this.label1);
            this.InformationPassagerPanel.Location = new System.Drawing.Point(538, 60);
            this.InformationPassagerPanel.Name = "InformationPassagerPanel";
            this.InformationPassagerPanel.Size = new System.Drawing.Size(434, 434);
            this.InformationPassagerPanel.TabIndex = 30;
            this.InformationPassagerPanel.Visible = false;
            // 
            // NonCheckedinPanel
            // 
            this.NonCheckedinPanel.Controls.Add(this.PoidsMaxPassagerLabel);
            this.NonCheckedinPanel.Controls.Add(this.PoidsMaxLabel);
            this.NonCheckedinPanel.Controls.Add(this.PoidsValiseTextBox);
            this.NonCheckedinPanel.Controls.Add(this.NombreValiseTextBox);
            this.NonCheckedinPanel.Controls.Add(this.SaveEtatButton);
            this.NonCheckedinPanel.Controls.Add(this.CheckInCheckBox);
            this.NonCheckedinPanel.Controls.Add(this.label13);
            this.NonCheckedinPanel.Controls.Add(this.label14);
            this.NonCheckedinPanel.Enabled = false;
            this.NonCheckedinPanel.Location = new System.Drawing.Point(4, 314);
            this.NonCheckedinPanel.Name = "NonCheckedinPanel";
            this.NonCheckedinPanel.Size = new System.Drawing.Size(427, 109);
            this.NonCheckedinPanel.TabIndex = 10;
            // 
            // PoidsMaxPassagerLabel
            // 
            this.PoidsMaxPassagerLabel.AutoSize = true;
            this.PoidsMaxPassagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoidsMaxPassagerLabel.ForeColor = System.Drawing.Color.Red;
            this.PoidsMaxPassagerLabel.Location = new System.Drawing.Point(253, 63);
            this.PoidsMaxPassagerLabel.Name = "PoidsMaxPassagerLabel";
            this.PoidsMaxPassagerLabel.Size = new System.Drawing.Size(11, 15);
            this.PoidsMaxPassagerLabel.TabIndex = 16;
            this.PoidsMaxPassagerLabel.Text = ".";
            // 
            // PoidsMaxLabel
            // 
            this.PoidsMaxLabel.AutoSize = true;
            this.PoidsMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoidsMaxLabel.Location = new System.Drawing.Point(253, 63);
            this.PoidsMaxLabel.Name = "PoidsMaxLabel";
            this.PoidsMaxLabel.Size = new System.Drawing.Size(0, 16);
            this.PoidsMaxLabel.TabIndex = 15;
            // 
            // PoidsValiseTextBox
            // 
            this.PoidsValiseTextBox.Enabled = false;
            this.PoidsValiseTextBox.Location = new System.Drawing.Point(147, 61);
            this.PoidsValiseTextBox.Name = "PoidsValiseTextBox";
            this.PoidsValiseTextBox.Size = new System.Drawing.Size(100, 20);
            this.PoidsValiseTextBox.TabIndex = 13;
            this.PoidsValiseTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // NombreValiseTextBox
            // 
            this.NombreValiseTextBox.Enabled = false;
            this.NombreValiseTextBox.Location = new System.Drawing.Point(147, 37);
            this.NombreValiseTextBox.Name = "NombreValiseTextBox";
            this.NombreValiseTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreValiseTextBox.TabIndex = 12;
            this.NombreValiseTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // SaveEtatButton
            // 
            this.SaveEtatButton.Enabled = false;
            this.SaveEtatButton.Location = new System.Drawing.Point(18, 82);
            this.SaveEtatButton.Name = "SaveEtatButton";
            this.SaveEtatButton.Size = new System.Drawing.Size(75, 23);
            this.SaveEtatButton.TabIndex = 14;
            this.SaveEtatButton.Text = "Enregistrer Modifications";
            this.SaveEtatButton.UseVisualStyleBackColor = true;
            this.SaveEtatButton.Click += new System.EventHandler(this.SaveEtatButton_Click);
            // 
            // CheckInCheckBox
            // 
            this.CheckInCheckBox.AutoSize = true;
            this.CheckInCheckBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.CheckInCheckBox.Location = new System.Drawing.Point(18, 13);
            this.CheckInCheckBox.Name = "CheckInCheckBox";
            this.CheckInCheckBox.Size = new System.Drawing.Size(80, 22);
            this.CheckInCheckBox.TabIndex = 10;
            this.CheckInCheckBox.Text = "Check-in";
            this.CheckInCheckBox.UseVisualStyleBackColor = true;
            this.CheckInCheckBox.CheckedChanged += new System.EventHandler(this.CheckInCheckBox_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label13.Location = new System.Drawing.Point(15, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Poids valises:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label14.Location = new System.Drawing.Point(15, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 18);
            this.label14.TabIndex = 8;
            this.label14.Text = "Nombre valises:";
            // 
            // DateReservationLabel
            // 
            this.DateReservationLabel.AutoSize = true;
            this.DateReservationLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateReservationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.DateReservationLabel.Location = new System.Drawing.Point(187, 211);
            this.DateReservationLabel.Name = "DateReservationLabel";
            this.DateReservationLabel.Size = new System.Drawing.Size(110, 18);
            this.DateReservationLabel.TabIndex = 21;
            this.DateReservationLabel.Text = "Date reservation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label8.Location = new System.Drawing.Point(17, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date réservation:";
            // 
            // EtatLabel
            // 
            this.EtatLabel.AutoSize = true;
            this.EtatLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.EtatLabel.Location = new System.Drawing.Point(187, 180);
            this.EtatLabel.Name = "EtatLabel";
            this.EtatLabel.Size = new System.Drawing.Size(32, 18);
            this.EtatLabel.TabIndex = 18;
            this.EtatLabel.Text = "Etat";
            // 
            // EmplacementLabel
            // 
            this.EmplacementLabel.AutoSize = true;
            this.EmplacementLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmplacementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.EmplacementLabel.Location = new System.Drawing.Point(187, 151);
            this.EmplacementLabel.Name = "EmplacementLabel";
            this.EmplacementLabel.Size = new System.Drawing.Size(93, 18);
            this.EmplacementLabel.TabIndex = 17;
            this.EmplacementLabel.Text = "Emplacement";
            // 
            // NationnaliteLabel
            // 
            this.NationnaliteLabel.AutoSize = true;
            this.NationnaliteLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationnaliteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.NationnaliteLabel.Location = new System.Drawing.Point(187, 122);
            this.NationnaliteLabel.Name = "NationnaliteLabel";
            this.NationnaliteLabel.Size = new System.Drawing.Size(85, 18);
            this.NationnaliteLabel.TabIndex = 16;
            this.NationnaliteLabel.Text = "Nationnalite";
            // 
            // NumeroPassportLabel
            // 
            this.NumeroPassportLabel.AutoSize = true;
            this.NumeroPassportLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroPassportLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.NumeroPassportLabel.Location = new System.Drawing.Point(187, 94);
            this.NumeroPassportLabel.Name = "NumeroPassportLabel";
            this.NumeroPassportLabel.Size = new System.Drawing.Size(78, 18);
            this.NumeroPassportLabel.TabIndex = 15;
            this.NumeroPassportLabel.Text = "N. Passport";
            // 
            // SexeLabel
            // 
            this.SexeLabel.AutoSize = true;
            this.SexeLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.SexeLabel.Location = new System.Drawing.Point(187, 66);
            this.SexeLabel.Name = "SexeLabel";
            this.SexeLabel.Size = new System.Drawing.Size(38, 18);
            this.SexeLabel.TabIndex = 14;
            this.SexeLabel.Text = "Sexe";
            // 
            // DateNaissanceLabel
            // 
            this.DateNaissanceLabel.AutoSize = true;
            this.DateNaissanceLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNaissanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.DateNaissanceLabel.Location = new System.Drawing.Point(187, 38);
            this.DateNaissanceLabel.Name = "DateNaissanceLabel";
            this.DateNaissanceLabel.Size = new System.Drawing.Size(121, 18);
            this.DateNaissanceLabel.TabIndex = 13;
            this.DateNaissanceLabel.Text = "Date de Naissance";
            // 
            // NomPrenomLabel
            // 
            this.NomPrenomLabel.AutoSize = true;
            this.NomPrenomLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomPrenomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.NomPrenomLabel.Location = new System.Drawing.Point(187, 9);
            this.NomPrenomLabel.Name = "NomPrenomLabel";
            this.NomPrenomLabel.Size = new System.Drawing.Size(94, 18);
            this.NomPrenomLabel.TabIndex = 12;
            this.NomPrenomLabel.Text = "Nom, Prenom";
            // 
            // CheckedinPanel
            // 
            this.CheckedinPanel.Controls.Add(this.PoidsValiseLabel);
            this.CheckedinPanel.Controls.Add(this.NombreValiseLabel);
            this.CheckedinPanel.Controls.Add(this.DateCheckedinLabel);
            this.CheckedinPanel.Controls.Add(this.label12);
            this.CheckedinPanel.Controls.Add(this.label11);
            this.CheckedinPanel.Controls.Add(this.label10);
            this.CheckedinPanel.Enabled = false;
            this.CheckedinPanel.Location = new System.Drawing.Point(5, 238);
            this.CheckedinPanel.Name = "CheckedinPanel";
            this.CheckedinPanel.Size = new System.Drawing.Size(426, 80);
            this.CheckedinPanel.TabIndex = 9;
            // 
            // PoidsValiseLabel
            // 
            this.PoidsValiseLabel.AutoSize = true;
            this.PoidsValiseLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoidsValiseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.PoidsValiseLabel.Location = new System.Drawing.Point(182, 54);
            this.PoidsValiseLabel.Name = "PoidsValiseLabel";
            this.PoidsValiseLabel.Size = new System.Drawing.Size(87, 18);
            this.PoidsValiseLabel.TabIndex = 12;
            this.PoidsValiseLabel.Text = "Poids valises";
            // 
            // NombreValiseLabel
            // 
            this.NombreValiseLabel.AutoSize = true;
            this.NombreValiseLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreValiseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.NombreValiseLabel.Location = new System.Drawing.Point(182, 31);
            this.NombreValiseLabel.Name = "NombreValiseLabel";
            this.NombreValiseLabel.Size = new System.Drawing.Size(104, 18);
            this.NombreValiseLabel.TabIndex = 11;
            this.NombreValiseLabel.Text = "Nombre valises";
            // 
            // DateCheckedinLabel
            // 
            this.DateCheckedinLabel.AutoSize = true;
            this.DateCheckedinLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCheckedinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.DateCheckedinLabel.Location = new System.Drawing.Point(182, 4);
            this.DateCheckedinLabel.Name = "DateCheckedinLabel";
            this.DateCheckedinLabel.Size = new System.Drawing.Size(110, 18);
            this.DateCheckedinLabel.TabIndex = 10;
            this.DateCheckedinLabel.Text = "Date Checked-in";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label12.Location = new System.Drawing.Point(13, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "Poids valises:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label11.Location = new System.Drawing.Point(13, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Nombre valises:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label10.Location = new System.Drawing.Point(12, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Date Checked-in:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label7.Location = new System.Drawing.Point(15, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Etat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label6.Location = new System.Drawing.Point(15, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Emplacement:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(14, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nationnalité:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label4.Location = new System.Drawing.Point(14, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "N. Passport:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de Naissance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom, Prénom:";
            // 
            // NumeroVolLabel
            // 
            this.NumeroVolLabel.AutoSize = true;
            this.NumeroVolLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroVolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.NumeroVolLabel.Location = new System.Drawing.Point(12, 14);
            this.NumeroVolLabel.Name = "NumeroVolLabel";
            this.NumeroVolLabel.Size = new System.Drawing.Size(57, 23);
            this.NumeroVolLabel.TabIndex = 11;
            this.NumeroVolLabel.Text = "N. Vol";
            // 
            // ExcelFileDialog
            // 
            this.ExcelFileDialog.FileName = "openFileDialog1";
            // 
            // CapaciteMaxTotaleLabel
            // 
            this.CapaciteMaxTotaleLabel.AutoSize = true;
            this.CapaciteMaxTotaleLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapaciteMaxTotaleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.CapaciteMaxTotaleLabel.Location = new System.Drawing.Point(3, 0);
            this.CapaciteMaxTotaleLabel.Name = "CapaciteMaxTotaleLabel";
            this.CapaciteMaxTotaleLabel.Size = new System.Drawing.Size(101, 18);
            this.CapaciteMaxTotaleLabel.TabIndex = 32;
            this.CapaciteMaxTotaleLabel.Text = "Capacité totale";
            // 
            // CapaciteCumuleeLabel
            // 
            this.CapaciteCumuleeLabel.AutoSize = true;
            this.CapaciteCumuleeLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapaciteCumuleeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.CapaciteCumuleeLabel.Location = new System.Drawing.Point(3, 25);
            this.CapaciteCumuleeLabel.Name = "CapaciteCumuleeLabel";
            this.CapaciteCumuleeLabel.Size = new System.Drawing.Size(118, 18);
            this.CapaciteCumuleeLabel.TabIndex = 33;
            this.CapaciteCumuleeLabel.Text = "Capacité cumulée";
            // 
            // PourcentagePassagerLabel
            // 
            this.PourcentagePassagerLabel.AutoSize = true;
            this.PourcentagePassagerLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PourcentagePassagerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.PourcentagePassagerLabel.Location = new System.Drawing.Point(3, 98);
            this.PourcentagePassagerLabel.Name = "PourcentagePassagerLabel";
            this.PourcentagePassagerLabel.Size = new System.Drawing.Size(135, 18);
            this.PourcentagePassagerLabel.TabIndex = 34;
            this.PourcentagePassagerLabel.Text = "Passager Checked-in";
            // 
            // PourcentageValiseLabel
            // 
            this.PourcentageValiseLabel.AutoSize = true;
            this.PourcentageValiseLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PourcentageValiseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.PourcentageValiseLabel.Location = new System.Drawing.Point(3, 50);
            this.PourcentageValiseLabel.Name = "PourcentageValiseLabel";
            this.PourcentageValiseLabel.Size = new System.Drawing.Size(131, 18);
            this.PourcentageValiseLabel.TabIndex = 35;
            this.PourcentageValiseLabel.Text = "Pourcentage valises";
            // 
            // NbReservationLabel
            // 
            this.NbReservationLabel.AutoSize = true;
            this.NbReservationLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbReservationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.NbReservationLabel.Location = new System.Drawing.Point(3, 74);
            this.NbReservationLabel.Name = "NbReservationLabel";
            this.NbReservationLabel.Size = new System.Drawing.Size(114, 18);
            this.NbReservationLabel.TabIndex = 36;
            this.NbReservationLabel.Text = "Places Reservees";
            // 
            // TableStats
            // 
            this.TableStats.ColumnCount = 1;
            this.TableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableStats.Controls.Add(this.CapaciteMaxTotaleLabel, 0, 0);
            this.TableStats.Controls.Add(this.PourcentagePassagerLabel, 0, 4);
            this.TableStats.Controls.Add(this.NbReservationLabel, 0, 3);
            this.TableStats.Controls.Add(this.CapaciteCumuleeLabel, 0, 1);
            this.TableStats.Controls.Add(this.PourcentageValiseLabel, 0, 2);
            this.TableStats.Location = new System.Drawing.Point(16, 66);
            this.TableStats.Name = "TableStats";
            this.TableStats.RowCount = 5;
            this.TableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableStats.Size = new System.Drawing.Size(253, 122);
            this.TableStats.TabIndex = 37;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.PlaceComboBox);
            this.SearchPanel.Controls.Add(this.RevoirToutButton);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Location = new System.Drawing.Point(12, 219);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(488, 40);
            this.SearchPanel.TabIndex = 38;
            // 
            // PlaceComboBox
            // 
            this.PlaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaceComboBox.FormattingEnabled = true;
            this.PlaceComboBox.Location = new System.Drawing.Point(353, 12);
            this.PlaceComboBox.Name = "PlaceComboBox";
            this.PlaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.PlaceComboBox.TabIndex = 37;
            this.PlaceComboBox.SelectedIndexChanged += new System.EventHandler(this.PlaceComboBox_SelectedIndexChanged);
            // 
            // RevoirToutButton
            // 
            this.RevoirToutButton.Location = new System.Drawing.Point(202, 9);
            this.RevoirToutButton.Name = "RevoirToutButton";
            this.RevoirToutButton.Size = new System.Drawing.Size(145, 23);
            this.RevoirToutButton.TabIndex = 36;
            this.RevoirToutButton.Text = "Revoir tous les passaagers";
            this.RevoirToutButton.UseVisualStyleBackColor = true;
            this.RevoirToutButton.Click += new System.EventHandler(this.RevoirToutButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(121, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 35;
            this.SearchButton.Text = "Rechercher";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(3, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(103, 20);
            this.SearchTextBox.TabIndex = 34;
            // 
            // compagnieTableAdapter1
            // 
            this.compagnieTableAdapter1.ClearBeforeFill = true;
            // 
            // ID_Passager
            // 
            this.ID_Passager.DataPropertyName = "ID_Passager";
            this.ID_Passager.HeaderText = "ID";
            this.ID_Passager.Name = "ID_Passager";
            this.ID_Passager.Visible = false;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom_Passager";
            this.Nom.FillWeight = 63.69712F;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom_Passager";
            this.Prenom.FillWeight = 63.69712F;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            // 
            // Passeport
            // 
            this.Passeport.DataPropertyName = "Num_Passeport_Passager";
            this.Passeport.HeaderText = "N Passeport";
            this.Passeport.Name = "Passeport";
            // 
            // Etat
            // 
            this.Etat.HeaderText = "Etat";
            this.Etat.Name = "Etat";
            // 
            // EtatHidden
            // 
            this.EtatHidden.DataPropertyName = "Etat_Passager";
            this.EtatHidden.FillWeight = 63.69712F;
            this.EtatHidden.HeaderText = "";
            this.EtatHidden.Name = "EtatHidden";
            this.EtatHidden.Visible = false;
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 503);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.TableStats);
            this.Controls.Add(this.InformationPassagerPanel);
            this.Controls.Add(this.PassagerDataGridView);
            this.Controls.Add(this.NumeroVolLabel);
            this.Name = "Checkin";
            this.Text = "Passagers";
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            ((System.ComponentModel.ISupportInitialize)(this.PassagerDataGridView)).EndInit();
            this.InformationPassagerPanel.ResumeLayout(false);
            this.InformationPassagerPanel.PerformLayout();
            this.NonCheckedinPanel.ResumeLayout(false);
            this.NonCheckedinPanel.PerformLayout();
            this.CheckedinPanel.ResumeLayout(false);
            this.CheckedinPanel.PerformLayout();
            this.TableStats.ResumeLayout(false);
            this.TableStats.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PassagerDataGridView;
        private System.Windows.Forms.Panel InformationPassagerPanel;
        private AeroportDataSetTableAdapters.CompagnieTableAdapter compagnieTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EtatLabel;
        private System.Windows.Forms.Label EmplacementLabel;
        private System.Windows.Forms.Label NationnaliteLabel;
        private System.Windows.Forms.Label NumeroPassportLabel;
        private System.Windows.Forms.Label SexeLabel;
        private System.Windows.Forms.Label DateNaissanceLabel;
        private System.Windows.Forms.Label NomPrenomLabel;
        private System.Windows.Forms.Label NumeroVolLabel;
        private System.Windows.Forms.Panel NonCheckedinPanel;
        private System.Windows.Forms.TextBox PoidsValiseTextBox;
        private System.Windows.Forms.TextBox NombreValiseTextBox;
        private System.Windows.Forms.CheckBox CheckInCheckBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel CheckedinPanel;
        private System.Windows.Forms.Label PoidsValiseLabel;
        private System.Windows.Forms.Label NombreValiseLabel;
        private System.Windows.Forms.Label DateCheckedinLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SaveEtatButton;
        private System.Windows.Forms.Label DateReservationLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog ExcelFileDialog;
        private System.Windows.Forms.Label PoidsMaxLabel;
        private System.Windows.Forms.Label PoidsMaxPassagerLabel;
        private System.Windows.Forms.Label CapaciteMaxTotaleLabel;
        private System.Windows.Forms.Label CapaciteCumuleeLabel;
        private System.Windows.Forms.Label PourcentagePassagerLabel;
        private System.Windows.Forms.Label PourcentageValiseLabel;
        private System.Windows.Forms.Label NbReservationLabel;
        private System.Windows.Forms.TableLayoutPanel TableStats;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.ComboBox PlaceComboBox;
        private System.Windows.Forms.Button RevoirToutButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Passager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passeport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtatHidden;

    }
}