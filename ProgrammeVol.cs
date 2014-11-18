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

namespace Aeroport_Application
{ 
    public partial class ProgrammeVol : Form
    {
        string dir;
        int equipm = 0;
        public ProgrammeVol()
        {
            InitializeComponent();
            VolDataGridView.AutoGenerateColumns = false;

            CompagnieComboBox.DisplayMember = "Text";
            CompagnieComboBox.ValueMember = "key";



            EquipeMcomboBox.DisplayMember = "Text";
            EquipeMcomboBox.ValueMember = "key";
            CompagnieTableAdapter cta = new CompagnieTableAdapter();
            DataTable cdt = cta.GetData();
            CompagnieComboBox.Items.Add(new MyListViewItem("T", "Tout"));

            for (int i = 0; i < cdt.Rows.Count; ++i)
            {
                CompagnieComboBox.Items.Add(new MyListViewItem(cdt.Rows[i]["Code_Compagnie"].ToString(), cdt.Rows[i]["Nom_Compagnie"].ToString()));

            }
            CompagnieComboBox.SelectedIndex = 0;













        }


        private void VolSelectedChanged(object sender, EventArgs e)
        {

            if (VolDataGridView.SelectedRows.Count > 0)
            {
                InformationVolPanel.Visible = true;
                DataGridViewRow selectedRow = VolDataGridView.SelectedRows[0];
                int a = Convert.ToInt32(selectedRow.Cells["ID_VolProgramme"].Value);
                Vol_ProgrammeTableAdapter vta = new Vol_ProgrammeTableAdapter();
                DataTable vdt = vta.GetDataByVolProgrammeID(a);

                NumeroVolLabel.Text = vdt.Rows[0]["Code_Compagnie"].ToString() + " " + vdt.Rows[0]["Numero_VolProgramme"].ToString();
                DureeLabel.Text = vdt.Rows[0]["Duree_VolProgramme"].ToString() + " minutes";
                CompagnieTableAdapter cta = new CompagnieTableAdapter();
                DataTable cdt = cta.GetDataByCode(vdt.Rows[0]["Code_Compagnie"].ToString());
                CompanieLabel.Text = cdt.Rows[0]["Nom_Compagnie"].ToString();
                if (vdt.Rows[0]["Code_Ville_Source"].ToString() == "PAR")
                {
                    dir = "D";
                    ComboBoxEquipeVolLoad("D");   
                    DirectionLabel.Text = " Départ";
                    HourLabel.Text = "Heure de départ";
                    UDateHourLabel.Text = "Date de départ";
                }
                if (vdt.Rows[0]["Code_Ville_Destination"].ToString() == "PAR")
                {
                    dir = "A";
                    ComboBoxEquipeVolLoad("A");
                    DirectionLabel.Text = " Arrivée";
                    HourLabel.Text = "Heure d'arrivée";
                    UDateHourLabel.Text = "Date d'arrivée";
                }

                string codeavion = vdt.Rows[0]["Code_Avion"].ToString();
                InfoAvionEtTypeTableAdapter ita = new InfoAvionEtTypeTableAdapter();
                DataTable idt = ita.GetDataByCodeAvion(codeavion);
                AvionLabel.Text = idt.Rows[0]["Nom_Type"].ToString() + "( " + codeavion + " )";
                int codeequipe = Convert.ToInt32(vdt.Rows[0]["Code_EquipeV"].ToString());
                Equipe_VolTableAdapter eta = new Equipe_VolTableAdapter();
                DataTable edt = eta.GetDataByEquipeID(codeequipe);
                EquipeLabel.Text = edt.Rows[0]["Numero_EquipeV"].ToString();
                int idequipm = Convert.ToInt32(vdt.Rows[0]["Code_EquipeM"].ToString());
                for (int j = 0; j < EquipeMcomboBox.Items.Count;++j )
                {
                    int key = Convert.ToInt32(((MyListViewItem)(EquipeMcomboBox.Items[j])).getKey());
                    if (key == idequipm)
                    {
                        EquipeMcomboBox.SelectedIndex = j;
                        break;
                    }
                }

                if (vdt.Rows[0]["Periodicite_VolProgramme"].ToString() == "U")
                {
                    PeriodiciteLabel.Text = " Occurence unique";
                    ProgrammePanel.Visible = false;
                    DWMPanel.Visible = false;
                    UPanel.Visible = true;
                    UPanel.BringToFront();
                    string datedebut = vdt.Rows[0]["Date_Debut_VolProgramme"].ToString();
                    string datefin = vdt.Rows[0]["Date_Fin_VolProgramme"].ToString();
                    UDateHourValueLabel.Text = datedebut;
                }
                else if (vdt.Rows[0]["Periodicite_VolProgramme"].ToString() == "D")
                {
                    PeriodiciteLabel.Text = "Chaque jour";
                    ProgrammePanel.Visible = false;
                    UPanel.Visible = false;
                    DWMPanel.Visible = true;
                    DWMPanel.BringToFront();
                    string datedebut = vdt.Rows[0]["Date_Debut_VolProgramme"].ToString();
                    string datefin = vdt.Rows[0]["Date_Fin_VolProgramme"].ToString();
                    HourValueLabel.Text = Convert.ToDateTime(datedebut).ToShortTimeString();
                    PeriodeDWMLabel.Text = Convert.ToDateTime(datedebut).ToShortDateString() + " - " + Convert.ToDateTime(datefin).ToShortDateString();
                }
                else if (vdt.Rows[0]["Periodicite_VolProgramme"].ToString() == "W")
                {
                    PeriodiciteLabel.Text = " Chaque semaine";
                    ProgrammePanel.Visible = false;
                    UPanel.Visible = false;
                    DWMPanel.Visible = true;
                    DWMPanel.BringToFront();
                    string datedebut = vdt.Rows[0]["Date_Debut_VolProgramme"].ToString();
                    string datefin = vdt.Rows[0]["Date_Fin_VolProgramme"].ToString();
                    HourValueLabel.Text = Convert.ToDateTime(datedebut).ToShortTimeString();
                    PeriodeDWMLabel.Text = Convert.ToDateTime(datedebut).ToShortDateString() + " - " + Convert.ToDateTime(datefin).ToShortDateString();

                }
                else if (vdt.Rows[0]["Periodicite_VolProgramme"].ToString() == "M")
                {
                    PeriodiciteLabel.Text = " Chaque mois";
                    ProgrammePanel.Visible = false;
                    UPanel.Visible = false;
                    DWMPanel.Visible = true;
                    DWMPanel.BringToFront();
                    string datedebut = vdt.Rows[0]["Date_Debut_VolProgramme"].ToString();
                    string datefin = vdt.Rows[0]["Date_Fin_VolProgramme"].ToString();
                    HourValueLabel.Text = Convert.ToDateTime(datedebut).ToShortTimeString();
                    PeriodeDWMLabel.Text = Convert.ToDateTime(datedebut).ToShortDateString() + " - " + Convert.ToDateTime(datefin).ToShortDateString();
                }
                else if (vdt.Rows[0]["Periodicite_VolProgramme"].ToString() == "H")
                {
                    PeriodiciteLabel.Text = " Programme hebdomadaire";
                    ProgrammePanel.Visible = true;
                    UPanel.Visible = false;
                    ProgrammePanel.BringToFront();
                    DWMPanel.Visible = false;
                    string datedebut = vdt.Rows[0]["Date_Debut_VolProgramme"].ToString();
                    string datefin = vdt.Rows[0]["Date_Fin_VolProgramme"].ToString();
                    PeriodeHLLabel.Text = Convert.ToDateTime(datedebut).ToShortDateString() + " - " + Convert.ToDateTime(datefin).ToShortDateString();
                    InitialiizeProgrammeText();
                    AfficheProgramme(a);

                }

            }

        }


        private void DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AdjustGrid();

        }

        protected void AdjustGrid()
        {
            VilleTableAdapter vta = new VilleTableAdapter();
            DataTable sdt;
            DataTable ddt;
            for (int i = 0; i < VolDataGridView.Rows.Count; ++i)
            {
                string codesrc = VolDataGridView.Rows[i].Cells["CodeDepart"].Value.ToString();
                string codearr = VolDataGridView.Rows[i].Cells["CodeArrivee"].Value.ToString();

                sdt = vta.GetDataByCodeVille(codesrc);
                ddt = vta.GetDataByCodeVille(codearr);
                VolDataGridView.Rows[i].Cells["Ville_Depart"].Value = sdt.Rows[0]["Nom_Ville"].ToString();
                VolDataGridView.Rows[i].Cells["Ville_Arrivee"].Value = ddt.Rows[0]["Nom_Ville"].ToString();

            }
        }

        private void CompagnieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var item = (MyListViewItem)CompagnieComboBox.SelectedItem;
            if (item != null)
            {

                string key = item.getKey();
                Vol_ProgrammeTableAdapter vta = new Vol_ProgrammeTableAdapter();
                DataTable dt;
                if (key == "T") dt = vta.GetDataByEtat("Y");
                else dt = vta.GetDataByEtatAndCompagnie("Y", key);
                VolDataGridView.DataSource = dt;
            }
        }

        protected void InitialiizeProgrammeText()
        {
            LundiLabel.Text = "--";
            MardiLabel.Text = "--";
            MercrediLabel.Text = "--";
            JeudiLabel.Text = "--";
            VendrediLabel.Text = "--";
            SamediLabel.Text = "--";
            DimancheLabel.Text = "--";
        }

        protected void AfficheProgramme(int volpid)
        {

            ProgrammeTableAdapter pta = new ProgrammeTableAdapter();
            DataTable dt = pta.GetDataByCodeVolProgramme(volpid);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                if (dt.Rows[i]["Jour_Programme"].ToString() == "1") LundiLabel.Text = Convert.ToDateTime(dt.Rows[i]["Date_Depart_Programme"].ToString()).ToShortTimeString();
                if (dt.Rows[i]["Jour_Programme"].ToString() == "2") MardiLabel.Text = Convert.ToDateTime(dt.Rows[i]["Date_Depart_Programme"].ToString()).ToShortTimeString();
                if (dt.Rows[i]["Jour_Programme"].ToString() == "3") MercrediLabel.Text = Convert.ToDateTime(dt.Rows[i]["Date_Depart_Programme"].ToString()).ToShortTimeString();
                if (dt.Rows[i]["Jour_Programme"].ToString() == "4") JeudiLabel.Text = Convert.ToDateTime(dt.Rows[i]["Date_Depart_Programme"].ToString()).ToShortTimeString();
                if (dt.Rows[i]["Jour_Programme"].ToString() == "5") VendrediLabel.Text = Convert.ToDateTime(dt.Rows[i]["Date_Depart_Programme"].ToString()).ToShortTimeString();
                if (dt.Rows[i]["Jour_Programme"].ToString() == "6") SamediLabel.Text = Convert.ToDateTime(dt.Rows[i]["Date_Depart_Programme"].ToString()).ToShortTimeString();
                if (dt.Rows[i]["Jour_Programme"].ToString() == "7") DimancheLabel.Text = Convert.ToDateTime(dt.Rows[i]["Date_Depart_Programme"].ToString()).ToShortTimeString();
            }

        }

        protected void ComboBoxEquipeVolLoad(string Direction)
        {
            Equipe_MaintenanceTableAdapter eta = new Equipe_MaintenanceTableAdapter();
            EquipeMcomboBox.Items.Clear();
            DataTable edt = eta.GetDataByTypeEquipe(Direction);
            for (int i = 0; i < edt.Rows.Count; ++i)
            {
                EquipeMcomboBox.Items.Add(new MyListViewItem(edt.Rows[i]["ID_EquipeM"].ToString(), edt.Rows[i]["Numero_EquipeM"].ToString()));

            }
            if (EquipeMcomboBox.Items.Count > 0)
                EquipeMcomboBox.SelectedIndex = 0;

        }

        private void ConfirmerButton_Click(object sender, EventArgs e)
        {
            if (VolDataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("êtes-vous sûr de vouloir modifier l'equipe de maintenance de tous les occurences du futur", "Changer Equipe de Maintenance", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = VolDataGridView.SelectedRows[0];
                    int idVol = Convert.ToInt32(selectedRow.Cells["ID_VolProgramme"].Value);
                    Vol_ProgrammeTableAdapter vta = new Vol_ProgrammeTableAdapter();
                    DataTable vdt = vta.GetDataByVolProgrammeID(idVol);
                    InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
                    DataTable idt = null;

                    if (dir == "D")
                    {
                        idt = ita.GetRemainingDepartures(idVol, "PAR", DateTime.Today);

                    }

                    if (dir == "A")
                    {
                        idt = ita.GetRemainingArrivals(idVol, "PAR", DateTime.Today);

                    }
                    VolTableAdapter vvta = new VolTableAdapter();

                    for (int i = 0; i < idt.Rows.Count; ++i)
                    {
                        int idocc = Convert.ToInt32(idt.Rows[i]["ID_Vol"].ToString());
                        vvta.UpdateCodeEquipeMByVolID(equipm, idocc);

                    }
                    vta.UpdateEquipeMByIDVolProgramme(equipm, idVol);
                    MessageBox.Show("Equipe de maintenance changée avec succes");
                }
            }
        }

        private void VoirPersonnelButton_Click(object sender, EventArgs e)
        {

            if (equipm != 0)
            {
                InfoPersonnelMaintenance ipm = new InfoPersonnelMaintenance(equipm, dir);
                ipm.Show();
            }
        }
        private void EquipeMcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = ((MyListViewItem)EquipeMcomboBox.SelectedItem).getKey();
            equipm = (Convert.ToInt32(key));
        }


        private void CreezUneNouvelleEquipe_Click(object sender, EventArgs e)
        {
            using (CreerEquipeMaintenance myForm = new CreerEquipeMaintenance(dir))
            {


                DialogResult dr = myForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Equipe_MaintenanceTableAdapter eta = new Equipe_MaintenanceTableAdapter();
                    EquipeMcomboBox.Items.Clear();
                    DataTable edt = eta.GetDataByTypeEquipe(myForm.getDirection());
                    for (int i = 0; i < edt.Rows.Count; ++i)
                    {
                        EquipeMcomboBox.Items.Add(new MyListViewItem(edt.Rows[i]["ID_EquipeM"].ToString(), edt.Rows[i]["Numero_EquipeM"].ToString()));

                    }
                    EquipeMcomboBox.SelectedIndex = 0;
                }
            }
        }
    }
}
