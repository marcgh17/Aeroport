namespace Aeroport_Application
{
    partial class Maintenance
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
            this.IDVolLabel = new System.Windows.Forms.Label();
            this.DirectionVolLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.EquipeMaintenanceLabel = new System.Windows.Forms.Label();
            this.AnnuleCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // IDVolLabel
            // 
            this.IDVolLabel.AutoSize = true;
            this.IDVolLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDVolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.IDVolLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IDVolLabel.Location = new System.Drawing.Point(12, 33);
            this.IDVolLabel.Name = "IDVolLabel";
            this.IDVolLabel.Size = new System.Drawing.Size(56, 23);
            this.IDVolLabel.TabIndex = 30;
            this.IDVolLabel.Text = "ID Vol";
            // 
            // DirectionVolLabel
            // 
            this.DirectionVolLabel.AutoSize = true;
            this.DirectionVolLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectionVolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.DirectionVolLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DirectionVolLabel.Location = new System.Drawing.Point(12, 59);
            this.DirectionVolLabel.Name = "DirectionVolLabel";
            this.DirectionVolLabel.Size = new System.Drawing.Size(112, 23);
            this.DirectionVolLabel.TabIndex = 31;
            this.DirectionVolLabel.Text = "Direction Vol";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.10101F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.89899F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(-2, 119);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(974, 306);
            this.tableLayoutPanel.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Image = global::Aeroport_Application.Properties.Resources.RapportIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(797, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 33;
            this.button1.Text = "Confirmer Rapport";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonsToolTip.SetToolTip(this.button1, "Creer le Rapport de maintenance");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EquipeMaintenanceLabel
            // 
            this.EquipeMaintenanceLabel.AutoSize = true;
            this.EquipeMaintenanceLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipeMaintenanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.EquipeMaintenanceLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EquipeMaintenanceLabel.Location = new System.Drawing.Point(12, 87);
            this.EquipeMaintenanceLabel.Name = "EquipeMaintenanceLabel";
            this.EquipeMaintenanceLabel.Size = new System.Drawing.Size(106, 23);
            this.EquipeMaintenanceLabel.TabIndex = 35;
            this.EquipeMaintenanceLabel.Text = "Num Equipe";
            // 
            // AnnuleCheckBox
            // 
            this.AnnuleCheckBox.AutoSize = true;
            this.AnnuleCheckBox.Location = new System.Drawing.Point(812, 63);
            this.AnnuleCheckBox.Name = "AnnuleCheckBox";
            this.AnnuleCheckBox.Size = new System.Drawing.Size(91, 17);
            this.AnnuleCheckBox.TabIndex = 36;
            this.AnnuleCheckBox.Text = "Annuler le Vol";
            this.AnnuleCheckBox.UseVisualStyleBackColor = true;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 502);
            this.Controls.Add(this.AnnuleCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EquipeMaintenanceLabel);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.DirectionVolLabel);
            this.Controls.Add(this.IDVolLabel);
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDVolLabel;
        private System.Windows.Forms.Label DirectionVolLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip ButtonsToolTip;
        private System.Windows.Forms.Label EquipeMaintenanceLabel;
        private System.Windows.Forms.CheckBox AnnuleCheckBox;
    }
}