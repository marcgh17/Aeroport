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
    public partial class Checkout : Form
    {
        int volID;
        int idPassager;
        int passagerTotal;
        string codeavion;
        int nbPassagerB;
        int nbPassagerE;
        public Checkout(int volID)
        {
            InitializeComponent();
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
            NumeroVolLabel.Text = "Numéro du vol:" + " " + idt.Rows[0]["Numero_VolProgramme"].ToString() + "    " + Convert.ToDateTime(idt.Rows[0]["Date_Depart_Vol"].ToString()).ToShortDateString();
            PassagerDataGridView.Enabled = true;
            PassagerDataGridView.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                InformationPassagerPanel.Visible = false;
                PourcentagePassagerLabel.Visible = false;
                PassagerDataGridView.Enabled = false;
                SearchPanel.Enabled = false;
            }
            codeavion = idt.Rows[0]["Code_Avion"].ToString();
            InfoAvionEtTypeTableAdapter iata = new InfoAvionEtTypeTableAdapter();
            DataTable iadt = iata.GetDataByCodeAvion(codeavion);
            nbPassagerB = Convert.ToInt32(iadt.Rows[0]["Places_B"].ToString());
            nbPassagerE = Convert.ToInt32(iadt.Rows[0]["Places_E"].ToString());
            passagerTotal = nbPassagerB + nbPassagerE;
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
            pta.UpdateCheckOutByIDPassager("CO", DateTime.Now, idPassager);
            /* dt = pta.GetDataByIDVol(volID);
             PassagerDataGridView.Enabled = true;
             PassagerDataGridView.DataSource = dt;
             Pour ne pas enlever le search, letat fafiche changeraa et au reload prochain tout ira bien */

            PassagerDataGridView.SelectedRows[0].Cells["Etat"].Value = "Checked-out";
            UpdateStatistics();
            PassagerDataGridView.Rows[0].Selected = false;
            PassagerDataGridView.Rows[rowindex].Selected = true;
            PassaagerSelectedChanged(this, EventArgs.Empty);
        }
        protected void UpdateStatistics()
        {
            PassagerTableAdapter pta = new PassagerTableAdapter();
            int nbtotal = Convert.ToInt32(pta.CountPassengersByVolID(volID));
            int nbnci = Convert.ToInt32(pta.CountPassengerByEtatAndVolID("CO", volID));
            PourcentagePassagerLabel.Text = "Passagers Checked-Out: " + (nbnci).ToString() + "/" + nbtotal.ToString();
        }
        private void PassaagerSelectedChanged(object sender, EventArgs e)
        {
            //CheckOutCheckBox.Checked = false;
            SaveEtatButton.Enabled = false;
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
                if (etat == "AB") EtatLabel.Text = "Absent";
                if (etat == "CI") EtatLabel.Text = "Checked-in";
                if (etat == "CO") EtatLabel.Text = "Checked-out";
                if (etat == "BO") EtatLabel.Text = "En Bord";
                DateReservationLabel.Text = dt.Rows[0]["Date_Reservation_Passager"].ToString();

                BoardingPanel.Enabled = true;
                NonBoardingPanel.Enabled = false;
                DateCheckOutLabel.Text = "--";
                SaveEtatButton.Enabled = false;
                if (etat == "BO")
                {
                    BoardingPanel.Enabled = true;
                    NonBoardingPanel.Enabled = true;
                    SaveEtatButton.Enabled = true;

                }
                if (etat == "CO") DateCheckOutLabel.Text = dt.Rows[0]["Date_Check_Out_Passsager"].ToString();
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
        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            var item = (MyListViewItem)PlaceComboBox.SelectedItem;
            if (item != null)
            {

                string key = item.getKey();
                PassagerTableAdapter pta = new PassagerTableAdapter();
                System.Data.DataTable dtp = null;
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.AeroportConnectionString);
                cn.Open();
                string search = SearchTextBox.Text;
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
                    s_cmd = "SELECT * FROM PASSAGER Where ID_VOL=" + volID + " AND (Nom_Passager LIKE '%" + search + "%' OR Prenom_Passager LIKE '%" + search + "%'  OR Num_Passeport_Passager LIKE '%" + search + "%' )";
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

        private void RevoirToutButton_Click(object sender, System.EventArgs e)
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

        private void PlaceComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
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
     
    }
}
