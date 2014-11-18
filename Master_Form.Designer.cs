namespace Aeroport_Application
{
    partial class Master_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master_Form));
            this.masterPanel = new System.Windows.Forms.Panel();
            this.l1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerUneEquipeDeMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmesDeVolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demandesDeVolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.labetActualTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.HoraireToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.pickDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatisticsListView = new System.Windows.Forms.ListView();
            this.toolStripButtonPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Horaire = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // masterPanel
            // 
            this.masterPanel.BackColor = System.Drawing.Color.Transparent;
            this.masterPanel.Controls.Add(this.l1);
            this.masterPanel.Controls.Add(this.toolStrip1);
            this.masterPanel.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.masterPanel, "masterPanel");
            this.masterPanel.Name = "masterPanel";
            // 
            // l1
            // 
            resources.ApplyResources(this.l1, "l1");
            this.l1.Name = "l1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrevious,
            this.toolStripButtonNext});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ShowItemToolTips = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerUneEquipeDeMaintenanceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // creerUneEquipeDeMaintenanceToolStripMenuItem
            // 
            this.creerUneEquipeDeMaintenanceToolStripMenuItem.Name = "creerUneEquipeDeMaintenanceToolStripMenuItem";
            resources.ApplyResources(this.creerUneEquipeDeMaintenanceToolStripMenuItem, "creerUneEquipeDeMaintenanceToolStripMenuItem");
            this.creerUneEquipeDeMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.creerUneEquipeDeMaintenanceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnelMaintenanceToolStripMenuItem,
            this.programmesDeVolsToolStripMenuItem,
            this.demandesDeVolsToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.websiteToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // personnelMaintenanceToolStripMenuItem
            // 
            this.personnelMaintenanceToolStripMenuItem.Name = "personnelMaintenanceToolStripMenuItem";
            resources.ApplyResources(this.personnelMaintenanceToolStripMenuItem, "personnelMaintenanceToolStripMenuItem");
            this.personnelMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.personnelMaintenanceToolStripMenuItem_Click);
            // 
            // programmesDeVolsToolStripMenuItem
            // 
            this.programmesDeVolsToolStripMenuItem.Name = "programmesDeVolsToolStripMenuItem";
            resources.ApplyResources(this.programmesDeVolsToolStripMenuItem, "programmesDeVolsToolStripMenuItem");
            this.programmesDeVolsToolStripMenuItem.Click += new System.EventHandler(this.programmesDeVolsToolStripMenuItem_Click);
            // 
            // demandesDeVolsToolStripMenuItem
            // 
            this.demandesDeVolsToolStripMenuItem.Name = "demandesDeVolsToolStripMenuItem";
            resources.ApplyResources(this.demandesDeVolsToolStripMenuItem, "demandesDeVolsToolStripMenuItem");
            this.demandesDeVolsToolStripMenuItem.Click += new System.EventHandler(this.demandesDeVolsToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            resources.ApplyResources(this.statisticsToolStripMenuItem, "statisticsToolStripMenuItem");
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            resources.ApplyResources(this.websiteToolStripMenuItem, "websiteToolStripMenuItem");
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.WebsiteView);
            // 
            // MainTabControl
            // 
            this.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            resources.ApplyResources(this.MainTabControl, "MainTabControl");
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MainTabControl_DrawItem);
            this.MainTabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // labetActualTime
            // 
            resources.ApplyResources(this.labetActualTime, "labetActualTime");
            this.labetActualTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.labetActualTime.Name = "labetActualTime";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.monthCalendar, "monthCalendar");
            this.monthCalendar.Name = "monthCalendar";
            this.HoraireToolTip.SetToolTip(this.monthCalendar, resources.GetString("monthCalendar.ToolTip"));
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDateSelected);
            // 
            // pickDateLabel
            // 
            resources.ApplyResources(this.pickDateLabel, "pickDateLabel");
            this.pickDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(126)))));
            this.pickDateLabel.Name = "pickDateLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.label1.Name = "label1";
            // 
            // StatisticsListView
            // 
            this.StatisticsListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("StatisticsListView.Groups"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("StatisticsListView.Groups1")))});
            resources.ApplyResources(this.StatisticsListView, "StatisticsListView");
            this.StatisticsListView.Name = "StatisticsListView";
            this.StatisticsListView.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripButtonPrevious
            // 
            this.toolStripButtonPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButtonPrevious, "toolStripButtonPrevious");
            this.toolStripButtonPrevious.Name = "toolStripButtonPrevious";
            this.toolStripButtonPrevious.Click += new System.EventHandler(this.toolStripButtonPrevious_Click);
            // 
            // toolStripButtonNext
            // 
            this.toolStripButtonNext.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButtonNext, "toolStripButtonNext");
            this.toolStripButtonNext.Name = "toolStripButtonNext";
            this.toolStripButtonNext.Click += new System.EventHandler(this.toolStripButtonNext_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Horaire
            // 
            this.Horaire.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.Horaire, "Horaire");
            this.Horaire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Horaire.Name = "Horaire";
            this.HoraireToolTip.SetToolTip(this.Horaire, resources.GetString("Horaire.ToolTip"));
            this.Horaire.UseVisualStyleBackColor = false;
            this.Horaire.Click += new System.EventHandler(this.Horaire_Click);
            // 
            // pictureBoxLogo
            // 
            resources.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.TabStop = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterRapportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // consulterRapportToolStripMenuItem
            // 
            this.consulterRapportToolStripMenuItem.Name = "consulterRapportToolStripMenuItem";
            resources.ApplyResources(this.consulterRapportToolStripMenuItem, "consulterRapportToolStripMenuItem");
            this.consulterRapportToolStripMenuItem.Click += new System.EventHandler(this.consulterRapportToolStripMenuItem_Click);
            // 
            // Master_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.StatisticsListView);
            this.Controls.Add(this.pickDateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.labetActualTime);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.Horaire);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.masterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Master_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.masterPanel.ResumeLayout(false);
            this.masterPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel masterPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrevious;
        private System.Windows.Forms.ToolStripButton toolStripButtonNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Horaire;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labetActualTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip HoraireToolTip;
        public System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demandesDeVolsToolStripMenuItem;
        public System.Windows.Forms.Label pickDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListView StatisticsListView;
        private System.Windows.Forms.ToolStripMenuItem personnelMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerUneEquipeDeMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmesDeVolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterRapportToolStripMenuItem;
    }
}

