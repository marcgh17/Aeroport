using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aeroport_Application.AeroportDataSetTableAdapters;
using System.Globalization;


namespace Aeroport_Application
{
    
    public partial class Master_Form : Form
    {
        string[] pictures = { "slide1.jpg", "slide2.jpg","slide3.jpg" };
        int i = 1;
        Image picture1;
        
        public Master_Form()
        {

            InitializeComponent();
            // Logo
            
            Image image = Image.FromFile("../../images/logo_aeroports_de_paris.gif");	  
	        pictureBoxLogo.Image = image;
            pictureBoxLogo.Height = image.Height;
            pictureBoxLogo.Width = image.Width;

            //Statistics

            StatisticsListView.View = View.Tile;
            UpdateStatistics();
            DateTime dt =Convert.ToDateTime( DateTime.Now.ToShortDateString());
            picture1 = Image.FromFile("../../images/slider/" + pictures[i]);
            pictureBox1.Image = picture1;
            MainTabControl.TabPages.Add("Dep", "Départs");
            TabPage td = MainTabControl.TabPages["Dep"];
            MainTabControl.TabPages.Add("Arr", "Arrivées");
            TabPage ta = MainTabControl.TabPages["Arr"];
            //Panel p1 = new Panel();
            //Panel p2 = new Panel();
            Departs d= new Departs(dt);
            Arrivees a= new Arrivees(dt);
            d.TopLevel = false;
            d.AutoScroll = true;
            d.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            d.Visible = true;
            a.TopLevel = false;
            a.AutoScroll = true;
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            a.Visible = true;
            td.Controls.Add(d);
            ta.Controls.Add(a);
           
            // actual time
            timer.Interval = 1000;
            timer.Start();
            labetActualTime.Text = DateTime.Now.ToShortTimeString();
            pickDateLabel.Text = DateTime.Now.ToShortDateString();
            
            // bouton panneau
            Horaire.TabStop = false;
            Horaire.FlatStyle = FlatStyle.Flat;
            Horaire.FlatAppearance.BorderSize = 0;

            
        }

        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            i++;
            if (pictures.Length == i)
            {
                i = 0;
            }
            picture1 = Image.FromFile("../../images/slider/" + pictures[i]);
            pictureBox1.Image = picture1;
        }

        private void toolStripButtonPrevious_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = pictures.Length;
            }
            i--;

            picture1 = Image.FromFile("../../images/slider/" + pictures[i]);
            pictureBox1.Image = picture1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Horaire_Click(object sender, EventArgs e)
        {
            Horaire_Form newform = new Horaire_Form();
            newform.Show();
        }

      

     

      
        private void CalendarDateSelected(object sender, DateRangeEventArgs e)
        {

            // label to save the picked date           
            pickDateLabel.Text = e.Start.ToShortDateString();
            DateTime dt = Convert.ToDateTime(e.Start.ToShortDateString());
            dt = Convert.ToDateTime(dt.ToShortDateString());
            

           // destroying open forms
            if (MainTabControl.TabPages["Dep"]!=null)
            MainTabControl.TabPages["Dep"].Dispose();
            if (MainTabControl.TabPages["Arr"] != null)
            MainTabControl.TabPages["Arr"].Dispose();

            //Adding the new forms

           
            MainTabControl.TabPages.Add("Dep", "Départs");
            TabPage td = MainTabControl.TabPages["Dep"];
            MainTabControl.TabPages.Add("Arr", "Arrivées");
            TabPage ta = MainTabControl.TabPages["Arr"];
            Departs d = new Departs(dt);
            Arrivees a = new Arrivees(dt);
            d.TopLevel = false;
            d.AutoScroll = true;
            d.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            d.Visible = true;
            a.TopLevel = false;
            a.AutoScroll = true;
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            a.Visible = true;
            td.Controls.Add(d);
            ta.Controls.Add(a);
            MainTabControl.SelectedTab = (td);
          
          
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labetActualTime.Text = DateTime.Now.ToShortTimeString();
            UpdateStatistics();
        }

        private void Horaire_MouseHover(object sender, EventArgs e)
        {
            Horaire.BackColor = Color.FromArgb(215,228,242);
        }

        private void MainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == MainTabControl.SelectedIndex)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                // e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.Bounds);
                e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
                e.Graphics.DrawString(MainTabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);

            }
            else
            {
                e.Graphics.DrawString("x", e.Font, Brushes.Gray, e.Bounds.Right - 15, e.Bounds.Top + 4);
                e.Graphics.DrawString(MainTabControl.TabPages[e.Index].Text, e.Font, Brushes.Gray, e.Bounds.Left + 12, e.Bounds.Top + 4);
            }
            e.DrawFocusRectangle();
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.MainTabControl.TabPages.Count; i++)
            {
                Rectangle r = MainTabControl.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Etes vous sûr de vouloir fermer cete fenetre?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                         TabPage ta = MainTabControl.TabPages[MainTabControl.SelectedIndex];
                        string key=ta.Name;
                        string type = key.Substring(0, 3);
                        if (type=="MNT")
                        {
                            MessageBox.Show("La maintenance sera annulée", "Attention!", MessageBoxButtons.OK);
                            string vol = key.Substring(3, key.Length - 3);
                            int v = Convert.ToInt32(vol);
                            ChangerEtats(v, "D");

                        }
                        this.MainTabControl.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void WebsiteView(object sender, EventArgs e)
        {
            string key = "WEB";
            string tabitle = "Website";
            TabPage test = MainTabControl.TabPages[key];
            if (test == null)
            {

                Webtest p = new Webtest();
                MainTabControl.TabPages.Add(key, tabitle);
                TabPage ta = MainTabControl.TabPages[key];
                p.TopLevel = false;
                p.AutoScroll = true;
                p.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p.Visible = true;
                ta.Controls.Add(p);
                MainTabControl.SelectedTab = (ta);
            }
            else
            {
                MainTabControl.SelectedTab = (test);
            }

        }

        private void demandesDeVolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string key = "DDV";
            string tabitle = "Demandes";
            TabPage test = MainTabControl.TabPages[key];
            if (test == null)
            {

               DemandesVol p = new DemandesVol();
                MainTabControl.TabPages.Add(key, tabitle);
                TabPage ta = MainTabControl.TabPages[key];
                p.TopLevel = false;
                p.AutoScroll = true;
                p.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p.Visible = true;
                ta.Controls.Add(p);
                MainTabControl.SelectedTab = (ta);
            }
            else
            {
                MainTabControl.SelectedTab = (test);
            }

        }

        protected void UpdateStatistics()
        {
            InformationsVolsTableAdapter vta = new InformationsVolsTableAdapter();
            DataTable adt = vta.GetSpecificArrivals(DateTime.Today, DateTime.Today.AddDays(1), "PAR");
            DataTable ddt = vta.GetSpecificDepartures(DateTime.Today, DateTime.Today.AddDays(1), "PAR");

            int depcount = ddt.Rows.Count;
            int arrcount = adt.Rows.Count;
            int checkin=0;
            int checkout=0;
            int boarding=0;
            int decolle = 0;

            for(int i=0;i<depcount;++i)
            {

                if (ddt.Rows[i]["Etat_Vol"].ToString() == "CI") checkin++;
                if (ddt.Rows[i]["Etat_Vol"].ToString() == "BO") boarding++;
                if (ddt.Rows[i]["Etat_Vol"].ToString() == "DP") decolle++;
            }

            for (int i = 0; i < arrcount; ++i)
            {

                if (adt.Rows[i]["Etat_Vol"].ToString() == "CO") checkout++;
               
            }

            ListViewItem li1 = new ListViewItem( "Vols Checking-In: "+ checkin.ToString()+"/"+ depcount.ToString(),StatisticsListView.Groups[0]);
            ListViewItem li2 = new ListViewItem("Vols Boarding: " + boarding.ToString() + "/" + depcount.ToString(), StatisticsListView.Groups[0]);
            ListViewItem li3 = new ListViewItem("Vols Decollés: " + decolle.ToString() + "/" + depcount.ToString(), StatisticsListView.Groups[0]);
            ListViewItem li4 = new ListViewItem("Vols Checking-Out: " + checkout.ToString() + "/" + arrcount.ToString(), StatisticsListView.Groups[1]);
            StatisticsListView.Items.Clear();
            StatisticsListView.Items.Add(li1);
            StatisticsListView.Items.Add(li2);
            StatisticsListView.Items.Add(li3);
            StatisticsListView.Items.Add(li4);



        }

        private void personnelMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string key = "PM";
            string tabitle = "Staff Maintenance ";
            TabPage test = MainTabControl.TabPages[key];
            if (test == null)
            {

                PersonnelMaintenance p = new PersonnelMaintenance();
                MainTabControl.TabPages.Add(key, tabitle);
                TabPage ta = MainTabControl.TabPages[key];
                p.TopLevel = false;
                p.AutoScroll = true;
                p.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p.Visible = true;
                ta.Controls.Add(p);
                MainTabControl.SelectedTab = (ta);
            }
            else
            {
                MainTabControl.SelectedTab = (test);
            }

        }

        private void creerUneEquipeDeMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string key = "CEM";
            string tabitle = "Nouvelle Equipe ";
            TabPage test = MainTabControl.TabPages[key];
            if (test == null)
            {

                CreerEquipeMaintenance p = new CreerEquipeMaintenance(null);
                MainTabControl.TabPages.Add(key, tabitle);
                TabPage ta = MainTabControl.TabPages[key];
                p.TopLevel = false;
                p.AutoScroll = true;
                p.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p.Visible = true;
                ta.Controls.Add(p);
                MainTabControl.SelectedTab = (ta);
            }
            else
            {
                MainTabControl.SelectedTab = (test);
            }
        }

        private void programmesDeVolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
            string key = "PDV";
            string tabitle = "Programmes ";
            TabPage test = MainTabControl.TabPages[key];
            if (test == null)
            {
               
                ProgrammeVol p = new ProgrammeVol();
                MainTabControl.TabPages.Add(key, tabitle);
                TabPage ta = MainTabControl.TabPages[key];
                p.TopLevel = false;
                p.AutoScroll = true;
                p.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p.Visible = true;
                ta.Controls.Add(p);
                MainTabControl.SelectedTab = (ta);
            }
            else
            {
                MainTabControl.SelectedTab = (test);
            }
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string key = "STA";
            string tabitle = "Statistiques";
            TabPage test = MainTabControl.TabPages[key];
            if (test == null)
            {

                Statistics p = new Statistics();
                MainTabControl.TabPages.Add(key, tabitle);
                TabPage ta = MainTabControl.TabPages[key];
                p.TopLevel = false;
                p.AutoScroll = true;
                p.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p.Visible = true;
                ta.Controls.Add(p);
                MainTabControl.SelectedTab = (ta);
            }
            else
            {
                MainTabControl.SelectedTab = (test);
            }
        }

        public void ChangerEtats(int idv, string etat)
        {

            VolTableAdapter vta = new VolTableAdapter();
            DataTable vdt = vta.GetDataByVolID(idv);
            int equipem = Convert.ToInt32(vdt.Rows[0]["Code_EquipeM"].ToString());
            Equipe_MaintenanceTableAdapter eta = new Equipe_MaintenanceTableAdapter();
            eta.UpdateEtatEquipe(etat, equipem);
            InfoPersonnelEquipeMaintenanceTableAdapter ieta = new InfoPersonnelEquipeMaintenanceTableAdapter();
            DataTable mdt = ieta.GetDataByIDEquipeM(equipem);
            Personnel_MaintenanceTableAdapter pta = new Personnel_MaintenanceTableAdapter();
            for (int j = 0; j < mdt.Rows.Count; ++j)
            {
                int perid = Convert.ToInt32(mdt.Rows[j]["ID_PersonnelM"].ToString());
                pta.UpdateEmployeEtat(etat, perid);
            }
        }

        private void consulterRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory+"//Rapport.pdf");
            

            

        }

    }
}

