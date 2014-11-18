using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Aeroport_Application.AeroportDataSetTableAdapters;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace Aeroport_Application
{
    public partial class Checkin : Form
    {
        int volID;

        int idPassager;
        double capaciteParPassager;
        double chargeMax;
        double chargeCumulee;
        int passagerNonCheckedin;
        int passagerTotal;
        string codeavion;
        int nbPassagerB ;
        int nbPassagerE;

        public Checkin(int volID)
        {
            InitializeComponent();
            chargeCumulee = 0;
            PassagerDataGridView.AutoGenerateColumns = false;
            this.volID = volID;
            PlaceComboBox.DisplayMember = "Text";
            PlaceComboBox.ValueMember = "key";

            PlaceComboBox.Items.Add(new MyListViewItem("T", "Tout"));
            PlaceComboBox.Items.Add(new MyListViewItem("B", "Buisness"));
            PlaceComboBox.Items.Add(new MyListViewItem("E", "Economy"));
            PlaceComboBox.SelectedIndex = 0;
            InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
            System.Data.DataTable idt = ita.GetDataByIdVol(volID);
            PassagerTableAdapter ta = new PassagerTableAdapter();
            System.Data.DataTable dt = ta.GetDataByIDVol(volID);
            NumeroVolLabel.Text ="Numéro du vol:"+" "+ idt.Rows[0]["Numero_VolProgramme"].ToString()+"    " +Convert.ToDateTime( idt.Rows[0]["Date_Depart_Vol"].ToString()).ToShortDateString();
            PassagerDataGridView.Enabled = true;
            PassagerDataGridView.DataSource = dt;
            if(dt.Rows.Count==0)
            {
                PassagerDataGridView.Enabled = false;
                SearchPanel.Enabled = false;
            }
            PoidsMaxLabel.Visible = false;
            codeavion = idt.Rows[0]["Code_Avion"].ToString();
            InfoAvionEtTypeTableAdapter iata = new InfoAvionEtTypeTableAdapter();
            DataTable iadt = iata.GetDataByCodeAvion(codeavion);
            capaciteParPassager = Convert.ToInt32(iadt.Rows[0]["Charge_Max"].ToString());
            PoidsMaxPassagerLabel.Text = "Poids maximal permis: " + capaciteParPassager.ToString();
            nbPassagerB = Convert.ToInt32(iadt.Rows[0]["Places_B"].ToString());
            nbPassagerE = Convert.ToInt32(iadt.Rows[0]["Places_E"].ToString());
            passagerTotal = nbPassagerB + nbPassagerE;
            chargeMax = passagerTotal * capaciteParPassager;
            CapaciteMaxTotaleLabel.Text = "Charge Maximale: " + chargeMax.ToString() +" Kg"; 
            UpdateStatistics();
          
            
            

            
        }
        private void DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AdjustEtat();

        }
        private void SaveEtatButton_Click(object sender, EventArgs e)
        {
            int rowindex = PassagerDataGridView.SelectedRows[0].Index;
            PassagerTableAdapter pta = new PassagerTableAdapter();
         
            DataTable dt;
            
            if (Convert.ToDouble(PoidsValiseTextBox.Text) > capaciteParPassager) MessageBox.Show("Vous avez dépassé votre limite!", "Attention!", MessageBoxButtons.OK);
            else
            {
                pta.UpdatePassagerInfoByPassagerID("CI", DateTime.Now, Convert.ToInt32(NombreValiseTextBox.Text), Convert.ToInt32(PoidsValiseTextBox.Text), idPassager);

               /* dt = pta.GetDataByIDVol(volID);
                PassagerDataGridView.Enabled = true;
                PassagerDataGridView.DataSource = dt;
                Pour ne pas enlever le search, letat fafiche changeraa et au reload prochain tout ira bien */

                PassagerDataGridView.SelectedRows[0].Cells["Etat"].Value = "Checked-in";
                PoidsValiseTextBox.Text = "";
                NombreValiseTextBox.Text = ""; 
                UpdateStatistics();
                PassagerDataGridView.Rows[0].Selected = false;
                PassagerDataGridView.Rows[rowindex].Selected = true;
                PassaagerSelectedChanged(this, EventArgs.Empty);
                BoardingPass form = new BoardingPass(idPassager);
                form.Show();
                Bitmap bmp = new Bitmap(form.Width, form.Height);
                form.DrawToBitmap(bmp, new Rectangle (0, 0, form.Width + 50, form.Height));
                bmp.Save("../../images/BoardingPasses/"+ idPassager.ToString()+ PassagerDataGridView.SelectedRows[0].Cells["Nom"].Value.ToString()+ PassagerDataGridView.SelectedRows[0].Cells["Prenom"].Value.ToString()+".bmp");
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                form.ShowMenu();
                //form.Close();
            }


          
        }

    

        
        private void PassaagerSelectedChanged(object sender, EventArgs e)
        {
            CheckInCheckBox.Checked = false;
            SaveEtatButton.Enabled = false;
            PoidsValiseTextBox.Enabled = false;
            NombreValiseTextBox.Enabled = false;
            label13.Enabled = false;
            label14.Enabled = false;

            InformationPassagerPanel.Visible = true;
            int a = 0;

            if (PassagerDataGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = PassagerDataGridView.SelectedRows[0];
                a = Convert.ToInt32(selectedRow.Cells["ID_Passager"].Value);


                PassagerTableAdapter ta = new PassagerTableAdapter();
                System.Data.DataTable dt = ta.GetDataByIDPassager(a);
                idPassager = Convert.ToInt32(dt.Rows[0]["ID_Passager"].ToString());
                NomPrenomLabel.Text = dt.Rows[0]["Nom_Passager"].ToString() + " " + dt.Rows[0]["Prenom_Passager"].ToString();
                DateNaissanceLabel.Text = Convert.ToDateTime(dt.Rows[0]["Date_Naissance_Passager"].ToString()).ToShortDateString();
                string sexe = dt.Rows[0]["Sexe_Passager"].ToString();
                if (sexe == "F") SexeLabel.Text = "Femme";
                if (sexe == "H") SexeLabel.Text = "Homme";
                NumeroPassportLabel.Text = dt.Rows[0]["Num_Passeport_Passager"].ToString();
                NationnaliteLabel.Text = dt.Rows[0]["Nationalite_Passager"].ToString();
                EmplacementLabel.Text = dt.Rows[0]["Emplacement_Passager"].ToString();
                string etat = dt.Rows[0]["Etat_Passager"].ToString();
                if(etat=="AB")  EtatLabel.Text = "Absent";
                if (etat == "CI") EtatLabel.Text = "Checked-in";
                if (etat == "CO") EtatLabel.Text = "Checked-out";
                if (etat == "BO") EtatLabel.Text = "En Bord";
                DateReservationLabel.Text = dt.Rows[0]["Date_Reservation_Passager"].ToString();
                
                if(etat=="AB")
                {
                    CheckedinPanel.Enabled = false;
                    NonCheckedinPanel.Enabled = true;
                    DateCheckedinLabel.Text = "";
                    NombreValiseLabel.Text = "";
                    PoidsValiseLabel.Text = "";
                }
                else
                {
                    CheckedinPanel.Enabled = true;
                    NonCheckedinPanel.Enabled = false;
                    DateCheckedinLabel.Text = dt.Rows[0]["Date_Check_In_Passager"].ToString();
                    NombreValiseLabel.Text = dt.Rows[0]["Nombre_Valise_Passager"].ToString();
                    PoidsValiseLabel.Text = dt.Rows[0]["Poids_Valise_Passager"].ToString();
                }
            }
        }

        private void CheckInCheckBox_CheckedChanged(object sender, EventArgs e)
        
        {
            if (CheckInCheckBox.Checked)
            {
                label13.Enabled = true;
                label14.Enabled = true;

                NombreValiseTextBox.Enabled = true;
                PoidsValiseTextBox.Enabled = true;
            }
            else
            {

                label13.Enabled = false;
                label14.Enabled = false;

                NombreValiseTextBox.Enabled = false;
                PoidsValiseTextBox.Enabled = false;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (PoidsValiseTextBox.Text == "" || NombreValiseTextBox.Text == "") SaveEtatButton.Enabled = false;
            else SaveEtatButton.Enabled = true;
        }

        protected  void UpdateStatistics()
        {
            PassagerTableAdapter pta = new PassagerTableAdapter();
            chargeCumulee = Convert.ToDouble(pta.SumValises(volID));
            CapaciteCumuleeLabel.Text = "Charge cumulée: " + chargeCumulee.ToString() + "Kg";
            passagerNonCheckedin = Convert.ToInt32(pta.CountPassengerByEtatAndVolID("AB", volID).ToString());
            double poidsrestant=((chargeMax - chargeCumulee) / chargeMax) * 100;
            PourcentageValiseLabel.Text = "Poids restant: "+ poidsrestant.ToString("0.00")+"%";
            int nbtotal = Convert.ToInt32(pta.CountPassengersByVolID(volID));
            int nbnci = Convert.ToInt32(pta.CountPassengerByEtatAndVolID("AB", volID));

            PourcentagePassagerLabel.Text = "Passagers Checked In: " + (nbtotal - nbnci).ToString() + "/" + nbtotal.ToString();
            NbReservationLabel.Text = "Places Reservées: " + nbtotal.ToString() + "/" + passagerTotal.ToString();




        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
              var item = (MyListViewItem)PlaceComboBox.SelectedItem;
               if (item != null)
               {

                   string key = item.getKey();
                   PassagerTableAdapter pta = new PassagerTableAdapter();
                   System.Data.DataTable dtp = null;
                   SqlConnection cn = new SqlConnection(Properties.Settings.Default.AeroportConnectionString);
                   cn.Open();
                   string search= SearchTextBox.Text;
                   string s_cmd = "";
                   if (key == "B")
                   {





                       s_cmd = "SELECT * FROM PASSAGER Where ID_VOL=" + volID + " AND Emplacement_Passager LIKE 'B%' AND  (Nom_Passager LIKE '%" + search + "%' OR Prenom_Passager LIKE '%" + search + "%'  OR Num_Passeport_Passager LIKE '%" + search + "%' )";


                       SqlCommand cmd = new SqlCommand(s_cmd, cn);
                       DataSet ds = new DataSet();
                       SqlDataAdapter da = new SqlDataAdapter(cmd); //methode de select avec methode classique de query
                       da.Fill(ds);
                       PassagerDataGridView.DataSource = ds;
                       dtp = ds.Tables[0];

                       
                   }
                   if (key == "E")
                   {
                       s_cmd = "SELECT * FROM PASSAGER Where ID_VOL=" + volID + " AND Emplacement_Passager LIKE 'E%' AND (Nom_Passager LIKE '%" + search + "%' OR Prenom_Passager LIKE '%" + search + "%'  OR Num_Passeport_Passager LIKE '%" + search + "%' )";


                       SqlCommand cmd = new SqlCommand(s_cmd, cn);
                       DataSet ds = new DataSet();
                       SqlDataAdapter da = new SqlDataAdapter(cmd); //methode de select avec methode classique de query
                       da.Fill(ds);
                       dtp = ds.Tables[0];
 

                   }
                   if (key == "T")
                   {
                       s_cmd = "SELECT * FROM PASSAGER Where ID_VOL="+volID+" AND (Nom_Passager LIKE '%" + search + "%' OR Prenom_Passager LIKE '%" + search + "%'  OR Num_Passeport_Passager LIKE '%" + search + "%' )"  ;


                       SqlCommand cmd = new SqlCommand(s_cmd, cn);
                       DataSet ds = new DataSet();
                       SqlDataAdapter da = new SqlDataAdapter(cmd); //methode de select avec methode classique de query
                       da.Fill(ds);
                       dtp = ds.Tables[0];


                   }
                   PassagerDataGridView.DataSource = dtp;
                   AdjustEtat();
                   cn.Close();
               }

        }

        private void RevoirToutButton_Click(object sender, EventArgs e)
        {
            var item = (MyListViewItem)PlaceComboBox.SelectedItem;
            if (item != null)
            {

                string key = item.getKey();
                PassagerTableAdapter pta = new PassagerTableAdapter();
                System.Data.DataTable dtp = null;
                if (key == "B") dtp = pta.GetDataByVolIDAndPlace(volID, "B%");
                if (key == "E") dtp = pta.GetDataByVolIDAndPlace(volID, "E%");
                if (key == "T") dtp = pta.GetDataByIDVol(volID);
                PassagerDataGridView.DataSource = dtp;
                SearchTextBox.Text = "";
                AdjustEtat();
            }
        }

        private void PlaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (MyListViewItem)PlaceComboBox.SelectedItem;
            if (item != null)
            {

                string key = item.getKey();
                PassagerTableAdapter pta = new PassagerTableAdapter();
                System.Data.DataTable dtp = null;
                if (key == "B") dtp = pta.GetDataByVolIDAndPlace(volID, "B%");
                if (key == "E") dtp = pta.GetDataByVolIDAndPlace(volID, "E%");
                if (key == "T") dtp = pta.GetDataByIDVol(volID);
                PassagerDataGridView.DataSource = dtp;
                SearchTextBox.Text = "";
                AdjustEtat();
            }
        }


        protected void AdjustEtat()
        {
            for (int i = 0; i < PassagerDataGridView.Rows.Count; ++i)
            {
                string etat = PassagerDataGridView.Rows[i].Cells["EtatHidden"].Value.ToString();
                if (etat == "AB") PassagerDataGridView.Rows[i].Cells["Etat"].Value = "Absent";
                if (etat == "CI") PassagerDataGridView.Rows[i].Cells["Etat"].Value = "Checked-in";
                if (etat == "CO") PassagerDataGridView.Rows[i].Cells["Etat"].Value = "Checked-out";
                if (etat == "BO") PassagerDataGridView.Rows[i].Cells["Etat"].Value = "En Bord";
            }
        }


    }
}
