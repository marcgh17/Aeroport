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
using System.Web;


namespace Aeroport_Application
{
    public partial class Horaire_Form : Form
    {
        public Horaire_Form()
        {
            InitializeComponent();
            labetActualTime.Text = DateTime.Now.ToShortTimeString();
           
            timerDirection.Interval = 5000;
            timerDirection.Start();
            //style
            //horaireDataGridView.Columns["Date"].DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 192);
            InformationsVolsTableAdapter ta = new InformationsVolsTableAdapter();
            DataTable dt = ta.GetSpecificArrivals(DateTime.Now.AddHours(-8),DateTime.Now.AddHours(8),"PAR");            
            horaireDataGridView.AutoGenerateColumns = false;
            horaireDataGridView.AllowUserToAddRows = false;
            horaireDataGridView.RowHeadersVisible = false;
            labelDirection.Text = "Arrivées Régionaux";
            horaireDataGridView.Columns["HeureEventuelle"].HeaderText = "Arrivé à";
            horaireDataGridView.DataSource = dt;
           
            etatGrid();
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        { 
            if (sender == timerDirection)
            {
                labetActualTime.Text = DateTime.Now.ToShortTimeString();
                InformationsVolsTableAdapter ta = new InformationsVolsTableAdapter();
                if (labelDirection.Text == "Départs Régionaux")
                {
                    labelDirection.Text = "Arrivées Régionaux";
                    DataTable dt = ta.GetSpecificArrivals(DateTime.Now.AddHours(-8), DateTime.Now.AddHours(8), "PAR"); 
                    horaireDataGridView.Columns["Ville"].DataPropertyName = "Code_Ville_Source";
                    horaireDataGridView.Columns["HeureEventuelle"].DataPropertyName = "Date_Arrivee_Eventuelle_Vol";
                    horaireDataGridView.Columns["Date"].DataPropertyName = "Date_Arrivee_Vol";
                    horaireDataGridView.Columns["HeureEventuelle"].HeaderText = "Arrivé à";
                    horaireDataGridView.DataSource = dt;
                    

                }
                else if (labelDirection.Text == "Arrivées Régionaux")
                {
                    labelDirection.Text = "Départs Régionaux";
                    DataTable dt = ta.GetSpecificDepartures(DateTime.Now.AddHours(-8), DateTime.Now.AddHours(8), "PAR"); 
                    horaireDataGridView.Columns["Ville"].DataPropertyName = "Code_Ville_Destination";
                    horaireDataGridView.Columns["Date"].DataPropertyName = "Date_Depart_Vol";
                    horaireDataGridView.Columns["HeureEventuelle"].DataPropertyName = "Date_Depart_Eventuelle_Vol";
                    horaireDataGridView.Columns["HeureEventuelle"].HeaderText = "Décollé a";
                    horaireDataGridView.DataSource = dt;
                   
                    
                }
                
                etatGrid();
            }
        }
       
        void etatGrid()
        {
            for (int i = 0; i < horaireDataGridView.Rows.Count; ++i)
            {
                VilleTableAdapter vta = new VilleTableAdapter();
                DataTable vdt;
                string a = horaireDataGridView.Rows[i].Cells["Ville"].Value.ToString();
                vdt = vta.GetDataByCodeVille(a);
                horaireDataGridView.Rows[i].Cells["Ville"].Value = vdt.Rows[0]["Nom_Ville"];
                string etat = horaireDataGridView.Rows[i].Cells["Etat_Vol"].Value.ToString();
                if (etat == "CI") horaireDataGridView.Rows[i].Cells["Etat_Vol"].Value = "Checking-in";
                if (etat == "CO") horaireDataGridView.Rows[i].Cells["Etat_Vol"].Value = "Checking-out";
                if (etat == "BO") horaireDataGridView.Rows[i].Cells["Etat_Vol"].Value = "Boarding";
                if (etat == "EV") horaireDataGridView.Rows[i].Cells["Etat_Vol"].Value = "En vol";
                if (etat == "AN") horaireDataGridView.Rows[i].Cells["Etat_Vol"].Value = "Annulé";
                if (etat == "AC") horaireDataGridView.Rows[i].Cells["Etat_Vol"].Value = "Achevé";
                if (etat == "EA") horaireDataGridView.Rows[i].Cells["Etat_Vol"].Value = "En attente";
                if (etat == "DP") horaireDataGridView.Rows[i].Cells["Etat_Vol"].Value = "Decollé";


           
                
            }
        }

        private void DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
             for (int i = 0; i < horaireDataGridView.Rows.Count; ++i) { 
               DateTime dtime = Convert.ToDateTime(horaireDataGridView.Rows[i].Cells["Date"].Value.ToString());
               double retard = Convert.ToDouble(horaireDataGridView.Rows[i].Cells["Retard"].Value.ToString());
               DateTime d2 = dtime.AddMinutes(retard);
               horaireDataGridView.Rows[i].Cells["Heureprevue"].Value = d2;
             }

        }

        private void CellFormating(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == horaireDataGridView.Columns["Logo_Compagnie"].Index)
            {
                string logourl = horaireDataGridView.Rows[e.RowIndex].Cells["LogoUrL"].Value.ToString();
                logourl = "../.." + logourl.Substring(1, logourl.Length - 1);
                e.Value = (Image.FromFile(logourl)).GetThumbnailImage(150,25,null,IntPtr.Zero);

            }



            if (e.RowIndex > -1 && e.ColumnIndex == horaireDataGridView.Columns["Red_Circle"].Index)
            {
                e.Value = (Image.FromFile("../../images/black_circle.png"));

                if (labelDirection.Text == "Arrivées Régionaux")
                {
                  

                    if (horaireDataGridView.Rows[e.RowIndex].Cells["Etat_Vol"].Value.ToString() == "Checking-out") e.Value = (Image.FromFile("../../images/red_circle.png").GetThumbnailImage(30,30,null,IntPtr.Zero));
                    if (horaireDataGridView.Rows[e.RowIndex].Cells["Etat_Vol"].Value.ToString() == "En vol") e.Value = (Image.FromFile("../../images/black_circle.png"));
                    if (horaireDataGridView.Rows[e.RowIndex].Cells["Etat_Vol"].Value.ToString() == "Achevé") e.Value = (Image.FromFile("../../images/red_circle.png").GetThumbnailImage(30, 30, null, IntPtr.Zero));
                    if (horaireDataGridView.Rows[e.RowIndex].Cells["Etat_Vol"].Value.ToString() == "Annulé") e.Value = (Image.FromFile("../../images/black_circle.png"));
                    if (horaireDataGridView.Rows[e.RowIndex].Cells["Etat_Vol"].Value.ToString() == "En attente") e.Value = (Image.FromFile("../../images/black_circle.png"));
                }

                if (labelDirection.Text == "Départs Régionaux")
                {

                    if (horaireDataGridView.Rows[e.RowIndex].Cells["Etat_Vol"].Value.ToString() == "Checking-in") e.Value = (Image.FromFile("../../images/black_circle.png"));
                    if (horaireDataGridView.Rows[e.RowIndex].Cells["Etat_Vol"].Value.ToString() == "Decollé") e.Value = (Image.FromFile("../../images/red_circle.png").GetThumbnailImage(30, 30, null, IntPtr.Zero));
                    if (horaireDataGridView.Rows[e.RowIndex].Cells["Etat_Vol"].Value.ToString() == "Boarding") e.Value = (Image.FromFile("../../images/black_circle.png"));
                    if (horaireDataGridView.Rows[e.RowIndex].Cells["Etat_Vol"].Value.ToString() == "Annulé") e.Value = (Image.FromFile("../../images/black_circle.png"));
                    if (horaireDataGridView.Rows[e.RowIndex].Cells["Etat_Vol"].Value.ToString() == "En attente") e.Value = (Image.FromFile("../../images/black_circle.png"));
                }

                
            }

           
            {





            }

        }
        
    }
}
