namespace Aeroport_Application
{
    partial class CreerEquipeMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreerEquipeMaintenance));
            this.LabelNumVol = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.PersonnelMListView = new System.Windows.Forms.ListView();
            this.NewEquipeListView = new System.Windows.Forms.ListView();
            this.ConfirmerButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ConfirmerEquipeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNumVol
            // 
            this.LabelNumVol.AutoSize = true;
            this.LabelNumVol.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumVol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.LabelNumVol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNumVol.Location = new System.Drawing.Point(12, 24);
            this.LabelNumVol.Name = "LabelNumVol";
            this.LabelNumVol.Size = new System.Drawing.Size(388, 23);
            this.LabelNumVol.TabIndex = 31;
            this.LabelNumVol.Text = "Création d\'une nouvelle équipe de maintenance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label6.Location = new System.Drawing.Point(13, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Choisir le type de maintenance:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(199, 56);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(80, 21);
            this.TypeComboBox.TabIndex = 46;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(604, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Choisir le numéro de l\'équipe:";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(782, 60);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumeroTextBox.TabIndex = 48;
            // 
            // PersonnelMListView
            // 
            this.PersonnelMListView.Location = new System.Drawing.Point(16, 103);
            this.PersonnelMListView.Name = "PersonnelMListView";
            this.PersonnelMListView.Size = new System.Drawing.Size(344, 292);
            this.PersonnelMListView.TabIndex = 49;
            this.PersonnelMListView.UseCompatibleStateImageBehavior = false;
            // 
            // NewEquipeListView
            // 
            this.NewEquipeListView.Location = new System.Drawing.Point(601, 103);
            this.NewEquipeListView.Name = "NewEquipeListView";
            this.NewEquipeListView.Size = new System.Drawing.Size(352, 292);
            this.NewEquipeListView.TabIndex = 50;
            this.NewEquipeListView.UseCompatibleStateImageBehavior = false;
            // 
            // ConfirmerButton
            // 
            this.ConfirmerButton.Location = new System.Drawing.Point(285, 54);
            this.ConfirmerButton.Name = "ConfirmerButton";
            this.ConfirmerButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmerButton.TabIndex = 51;
            this.ConfirmerButton.Text = "Confirmer";
            this.ConfirmerButton.UseVisualStyleBackColor = true;
            this.ConfirmerButton.Click += new System.EventHandler(this.ConfirmerButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.Location = new System.Drawing.Point(419, 221);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(60, 60);
            this.RemoveButton.TabIndex = 52;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(485, 221);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 60);
            this.AddButton.TabIndex = 53;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ConfirmerEquipeButton
            // 
            this.ConfirmerEquipeButton.Location = new System.Drawing.Point(392, 324);
            this.ConfirmerEquipeButton.Name = "ConfirmerEquipeButton";
            this.ConfirmerEquipeButton.Size = new System.Drawing.Size(183, 23);
            this.ConfirmerEquipeButton.TabIndex = 54;
            this.ConfirmerEquipeButton.Text = "Confirmer Equipe";
            this.ConfirmerEquipeButton.UseVisualStyleBackColor = true;
            this.ConfirmerEquipeButton.Click += new System.EventHandler(this.ConfirmerEquipeButton_Click);
            // 
            // CreerEquipeMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 502);
            this.Controls.Add(this.ConfirmerEquipeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ConfirmerButton);
            this.Controls.Add(this.NewEquipeListView);
            this.Controls.Add(this.PersonnelMListView);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelNumVol);
            this.Name = "CreerEquipeMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreerEquipeMaintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNumVol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.ListView PersonnelMListView;
        private System.Windows.Forms.ListView NewEquipeListView;
        private System.Windows.Forms.Button ConfirmerButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ConfirmerEquipeButton;
    }
}