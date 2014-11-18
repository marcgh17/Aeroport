namespace Aeroport_Application
{
    partial class Statistics
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DepartsStatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AeroportDataSet = new Aeroport_Application.AeroportDataSet();
            this.arriveesStatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DepartsStatTableAdapter = new Aeroport_Application.AeroportDataSetTableAdapters.DepartsStatTableAdapter();
            this.arriveesStatTableAdapter = new Aeroport_Application.AeroportDataSetTableAdapters.ArriveesStatTableAdapter();
            this.compagniesVolsStatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compagniesVolsTableAdapter = new Aeroport_Application.AeroportDataSetTableAdapters.CompagniesVolsTableAdapter();
            this.compagniesVolsStatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DepartsStatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AeroportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arriveesStatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagniesVolsStatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagniesVolsStatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartsStatBindingSource
            // 
            this.DepartsStatBindingSource.DataMember = "DepartsStat";
            this.DepartsStatBindingSource.DataSource = this.AeroportDataSet;
            // 
            // AeroportDataSet
            // 
            this.AeroportDataSet.DataSetName = "AeroportDataSet";
            this.AeroportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arriveesStatBindingSource
            // 
            this.arriveesStatBindingSource.DataMember = "ArriveesStat";
            this.arriveesStatBindingSource.DataSource = this.AeroportDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DepartsStat";
            reportDataSource1.Value = this.DepartsStatBindingSource;
            reportDataSource2.Name = "ArriveesStat";
            reportDataSource2.Value = this.arriveesStatBindingSource;
            reportDataSource3.Name = "CompagniesVolsStat";
            reportDataSource3.Value = this.compagniesVolsStatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aeroport_Application.Statistics.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(183, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(632, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // DepartsStatTableAdapter
            // 
            this.DepartsStatTableAdapter.ClearBeforeFill = true;
            // 
            // arriveesStatTableAdapter
            // 
            this.arriveesStatTableAdapter.ClearBeforeFill = true;
            // 
            // compagniesVolsStatBindingSource
            // 
            this.compagniesVolsStatBindingSource.DataMember = "CompagniesVolsStat";
            this.compagniesVolsStatBindingSource.DataSource = this.AeroportDataSet;
            // 
            // compagniesVolsTableAdapter
            // 
            this.compagniesVolsTableAdapter.ClearBeforeFill = true;
            // 
            // compagniesVolsStatBindingSource1
            // 
            this.compagniesVolsStatBindingSource1.DataMember = "CompagniesVolsStat";
            this.compagniesVolsStatBindingSource1.DataSource = this.AeroportDataSet;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 502);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartsStatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AeroportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arriveesStatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagniesVolsStatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagniesVolsStatBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DepartsStatBindingSource;
        private AeroportDataSet AeroportDataSet;
        private AeroportDataSetTableAdapters.DepartsStatTableAdapter DepartsStatTableAdapter;
        private System.Windows.Forms.BindingSource arriveesStatBindingSource;
        private AeroportDataSetTableAdapters.ArriveesStatTableAdapter arriveesStatTableAdapter;
        private System.Windows.Forms.BindingSource compagniesVolsStatBindingSource1;
        private System.Windows.Forms.BindingSource compagniesVolsStatBindingSource;
        private AeroportDataSetTableAdapters.CompagniesVolsTableAdapter compagniesVolsTableAdapter;

 
    }
}