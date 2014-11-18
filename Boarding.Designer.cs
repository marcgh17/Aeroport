namespace Aeroport_Application
{
    partial class Boarding
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
            this.NomPrenomLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroVolLabel = new System.Windows.Forms.Label();
            this.BoardingPanel = new System.Windows.Forms.Panel();
            this.DateBoardingLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.PlaceComboBox = new System.Windows.Forms.ComboBox();
            this.RevoirToutButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.PassagerDataGridView = new System.Windows.Forms.DataGridView();
            this.InformationPassagerPanel = new System.Windows.Forms.Panel();
            this.NonBoardingPanel = new System.Windows.Forms.Panel();
            this.PoidsMaxLabel = new System.Windows.Forms.Label();
            this.SaveEtatButton = new System.Windows.Forms.Button();
            this.DateReservationLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EtatLabel = new System.Windows.Forms.Label();
            this.EmplacementLabel = new System.Windows.Forms.Label();
            this.NationnaliteLabel = new System.Windows.Forms.Label();
            this.NumeroPassportLabel = new System.Windows.Forms.Label();
            this.SexeLabel = new System.Windows.Forms.Label();
            this.DateNaissanceLabel = new System.Windows.Forms.Label();
            this.PourcentagePassagerLabel = new System.Windows.Forms.Label();
            this.compagnieTableAdapter1 = new Aeroport_Application.AeroportDataSetTableAdapters.CompagnieTableAdapter();
            this.ID_Passager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtatHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoardingPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassagerDataGridView)).BeginInit();
            this.InformationPassagerPanel.SuspendLayout();
            this.NonBoardingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomPrenomLabel
            // 
            this.NomPrenomLabel.AutoSize = true;
            this.NomPrenomLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomPrenomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.NomPrenomLabel.Location = new System.Drawing.Point(171, 9);
            this.NomPrenomLabel.Name = "NomPrenomLabel";
            this.NomPrenomLabel.Size = new System.Drawing.Size(94, 18);
            this.NomPrenomLabel.TabIndex = 12;
            this.NomPrenomLabel.Text = "Nom, Prenom";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(126, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 35;
            this.SearchButton.Text = "Rechercher";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label7.Location = new System.Drawing.Point(20, 180);
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
            this.label6.Location = new System.Drawing.Point(20, 151);
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
            this.label5.Location = new System.Drawing.Point(19, 122);
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
            this.label4.Location = new System.Drawing.Point(19, 94);
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
            this.label3.Location = new System.Drawing.Point(19, 66);
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
            this.label2.Location = new System.Drawing.Point(19, 38);
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
            this.label1.Location = new System.Drawing.Point(19, 9);
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
            this.NumeroVolLabel.Location = new System.Drawing.Point(17, 11);
            this.NumeroVolLabel.Name = "NumeroVolLabel";
            this.NumeroVolLabel.Size = new System.Drawing.Size(57, 23);
            this.NumeroVolLabel.TabIndex = 39;
            this.NumeroVolLabel.Text = "N. Vol";
            // 
            // BoardingPanel
            // 
            this.BoardingPanel.Controls.Add(this.DateBoardingLabel);
            this.BoardingPanel.Controls.Add(this.label10);
            this.BoardingPanel.Location = new System.Drawing.Point(10, 278);
            this.BoardingPanel.Name = "BoardingPanel";
            this.BoardingPanel.Size = new System.Drawing.Size(426, 33);
            this.BoardingPanel.TabIndex = 9;
            // 
            // DateBoardingLabel
            // 
            this.DateBoardingLabel.AutoSize = true;
            this.DateBoardingLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBoardingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.DateBoardingLabel.Location = new System.Drawing.Point(161, 4);
            this.DateBoardingLabel.Name = "DateBoardingLabel";
            this.DateBoardingLabel.Size = new System.Drawing.Size(95, 18);
            this.DateBoardingLabel.TabIndex = 10;
            this.DateBoardingLabel.Text = "Date boarding";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label10.Location = new System.Drawing.Point(17, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Date boarding:";
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
            this.SearchPanel.Location = new System.Drawing.Point(17, 46);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(488, 40);
            this.SearchPanel.TabIndex = 43;
            // 
            // PlaceComboBox
            // 
            this.PlaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaceComboBox.FormattingEnabled = true;
            this.PlaceComboBox.Location = new System.Drawing.Point(358, 12);
            this.PlaceComboBox.Name = "PlaceComboBox";
            this.PlaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.PlaceComboBox.TabIndex = 37;
            this.PlaceComboBox.SelectedIndexChanged += new System.EventHandler(this.PlaceComboBox_SelectedIndexChanged);
            // 
            // RevoirToutButton
            // 
            this.RevoirToutButton.Location = new System.Drawing.Point(207, 9);
            this.RevoirToutButton.Name = "RevoirToutButton";
            this.RevoirToutButton.Size = new System.Drawing.Size(145, 23);
            this.RevoirToutButton.TabIndex = 36;
            this.RevoirToutButton.Text = "Revoir tous les passaagers";
            this.RevoirToutButton.UseVisualStyleBackColor = true;
            this.RevoirToutButton.Click += new System.EventHandler(this.RevoirToutButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(8, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(103, 20);
            this.SearchTextBox.TabIndex = 34;
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
            this.PassagerDataGridView.Location = new System.Drawing.Point(17, 92);
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
            this.PassagerDataGridView.Size = new System.Drawing.Size(488, 399);
            this.PassagerDataGridView.TabIndex = 40;
            this.PassagerDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);
            this.PassagerDataGridView.SelectionChanged += new System.EventHandler(this.PassaagerSelectedChanged);
            // 
            // InformationPassagerPanel
            // 
            this.InformationPassagerPanel.Controls.Add(this.NonBoardingPanel);
            this.InformationPassagerPanel.Controls.Add(this.DateReservationLabel);
            this.InformationPassagerPanel.Controls.Add(this.label8);
            this.InformationPassagerPanel.Controls.Add(this.EtatLabel);
            this.InformationPassagerPanel.Controls.Add(this.EmplacementLabel);
            this.InformationPassagerPanel.Controls.Add(this.NationnaliteLabel);
            this.InformationPassagerPanel.Controls.Add(this.NumeroPassportLabel);
            this.InformationPassagerPanel.Controls.Add(this.SexeLabel);
            this.InformationPassagerPanel.Controls.Add(this.DateNaissanceLabel);
            this.InformationPassagerPanel.Controls.Add(this.NomPrenomLabel);
            this.InformationPassagerPanel.Controls.Add(this.BoardingPanel);
            this.InformationPassagerPanel.Controls.Add(this.label7);
            this.InformationPassagerPanel.Controls.Add(this.label6);
            this.InformationPassagerPanel.Controls.Add(this.label5);
            this.InformationPassagerPanel.Controls.Add(this.label4);
            this.InformationPassagerPanel.Controls.Add(this.label3);
            this.InformationPassagerPanel.Controls.Add(this.label2);
            this.InformationPassagerPanel.Controls.Add(this.label1);
            this.InformationPassagerPanel.Location = new System.Drawing.Point(535, 91);
            this.InformationPassagerPanel.Name = "InformationPassagerPanel";
            this.InformationPassagerPanel.Size = new System.Drawing.Size(434, 324);
            this.InformationPassagerPanel.TabIndex = 41;
            // 
            // NonBoardingPanel
            // 
            this.NonBoardingPanel.Controls.Add(this.PoidsMaxLabel);
            this.NonBoardingPanel.Controls.Add(this.SaveEtatButton);
            this.NonBoardingPanel.Enabled = false;
            this.NonBoardingPanel.Location = new System.Drawing.Point(10, 235);
            this.NonBoardingPanel.Name = "NonBoardingPanel";
            this.NonBoardingPanel.Size = new System.Drawing.Size(426, 36);
            this.NonBoardingPanel.TabIndex = 11;
            // 
            // PoidsMaxLabel
            // 
            this.PoidsMaxLabel.AutoSize = true;
            this.PoidsMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoidsMaxLabel.Location = new System.Drawing.Point(258, 63);
            this.PoidsMaxLabel.Name = "PoidsMaxLabel";
            this.PoidsMaxLabel.Size = new System.Drawing.Size(0, 16);
            this.PoidsMaxLabel.TabIndex = 15;
            // 
            // SaveEtatButton
            // 
            this.SaveEtatButton.Enabled = false;
            this.SaveEtatButton.Location = new System.Drawing.Point(15, 7);
            this.SaveEtatButton.Name = "SaveEtatButton";
            this.SaveEtatButton.Size = new System.Drawing.Size(75, 23);
            this.SaveEtatButton.TabIndex = 14;
            this.SaveEtatButton.Text = "Boarded";
            this.SaveEtatButton.UseVisualStyleBackColor = true;
            this.SaveEtatButton.Click += new System.EventHandler(this.SaveEtatButton_Click);
            // 
            // DateReservationLabel
            // 
            this.DateReservationLabel.AutoSize = true;
            this.DateReservationLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateReservationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.DateReservationLabel.Location = new System.Drawing.Point(171, 211);
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
            this.label8.Location = new System.Drawing.Point(22, 211);
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
            this.EtatLabel.Location = new System.Drawing.Point(171, 180);
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
            this.EmplacementLabel.Location = new System.Drawing.Point(171, 151);
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
            this.NationnaliteLabel.Location = new System.Drawing.Point(171, 122);
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
            this.NumeroPassportLabel.Location = new System.Drawing.Point(171, 94);
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
            this.SexeLabel.Location = new System.Drawing.Point(171, 66);
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
            this.DateNaissanceLabel.Location = new System.Drawing.Point(171, 38);
            this.DateNaissanceLabel.Name = "DateNaissanceLabel";
            this.DateNaissanceLabel.Size = new System.Drawing.Size(121, 18);
            this.DateNaissanceLabel.TabIndex = 13;
            this.DateNaissanceLabel.Text = "Date de Naissance";
            // 
            // PourcentagePassagerLabel
            // 
            this.PourcentagePassagerLabel.AutoSize = true;
            this.PourcentagePassagerLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PourcentagePassagerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.PourcentagePassagerLabel.Location = new System.Drawing.Point(545, 58);
            this.PourcentagePassagerLabel.Name = "PourcentagePassagerLabel";
            this.PourcentagePassagerLabel.Size = new System.Drawing.Size(119, 18);
            this.PourcentagePassagerLabel.TabIndex = 44;
            this.PourcentagePassagerLabel.Text = "Passagers en bord";
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
            // Boarding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 503);
            this.Controls.Add(this.PourcentagePassagerLabel);
            this.Controls.Add(this.NumeroVolLabel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.PassagerDataGridView);
            this.Controls.Add(this.InformationPassagerPanel);
            this.Name = "Boarding";
            this.Text = "Boarding";
            this.BoardingPanel.ResumeLayout(false);
            this.BoardingPanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassagerDataGridView)).EndInit();
            this.InformationPassagerPanel.ResumeLayout(false);
            this.InformationPassagerPanel.PerformLayout();
            this.NonBoardingPanel.ResumeLayout(false);
            this.NonBoardingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomPrenomLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumeroVolLabel;
        private System.Windows.Forms.Panel BoardingPanel;
        private System.Windows.Forms.Label DateBoardingLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog ExcelFileDialog;
        private AeroportDataSetTableAdapters.CompagnieTableAdapter compagnieTableAdapter1;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.ComboBox PlaceComboBox;
        private System.Windows.Forms.Button RevoirToutButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView PassagerDataGridView;
        private System.Windows.Forms.Panel InformationPassagerPanel;
        private System.Windows.Forms.Label DateReservationLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EtatLabel;
        private System.Windows.Forms.Label EmplacementLabel;
        private System.Windows.Forms.Label NationnaliteLabel;
        private System.Windows.Forms.Label NumeroPassportLabel;
        private System.Windows.Forms.Label SexeLabel;
        private System.Windows.Forms.Label DateNaissanceLabel;
        private System.Windows.Forms.Label PourcentagePassagerLabel;
        private System.Windows.Forms.Panel NonBoardingPanel;
        private System.Windows.Forms.Label PoidsMaxLabel;
        private System.Windows.Forms.Button SaveEtatButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Passager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtatHidden;

    }
}