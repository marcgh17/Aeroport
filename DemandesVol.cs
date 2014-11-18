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
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Aeroport_Application
{
    public partial class DemandesVol : Form
    {
        string dir;
        int equipm=0;
        public DemandesVol()
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
                else  if (vdt.Rows[0]["Periodicite_VolProgramme"].ToString() == "M")
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
               
                sdt= vta.GetDataByCodeVille(codesrc);
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
                if (key == "T") dt = vta.GetDataByEtat("N");
                else dt = vta.GetDataByEtatAndCompagnie("N", key);
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

        private void RefuseButton_Click(object sender, EventArgs e)
        {
                  DataGridViewRow selectedRow = VolDataGridView.SelectedRows[0];
            int a = Convert.ToInt32(selectedRow.Cells["ID_VolProgramme"].Value);
            DialogResult result = MessageBox.Show("êtes-vous sûr de vouloir refuser le vol", "Refut d'un vol", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Vol_ProgrammeTableAdapter vta = new Vol_ProgrammeTableAdapter();
                vta.DeleteVolProgramme(a);
                InformationVolPanel.Visible = false;
                VolDataGridView.Rows.RemoveAt(VolDataGridView.SelectedRows[0].Index);

            }

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("êtes-vous sûr de vouloir accepter le vol", "Accepter un vol", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {

                int numocc = 0;
                DataGridViewRow selectedRow = VolDataGridView.SelectedRows[0];
                int a = Convert.ToInt32(selectedRow.Cells["ID_VolProgramme"].Value);
                Vol_ProgrammeTableAdapter ta = new Vol_ProgrammeTableAdapter();
                DataTable dt = ta.GetDataByVolProgrammeID(a);
                string typeperiodicite = dt.Rows[0]["Periodicite_VolProgramme"].ToString();
                DateTime debut = Convert.ToDateTime(dt.Rows[0]["Date_Debut_VolProgramme"].ToString());
                DateTime fin = Convert.ToDateTime(dt.Rows[0]["Date_Fin_VolProgramme"].ToString());
                int dureevol = Convert.ToInt32(dt.Rows[0]["Duree_VolProgramme"].ToString());
                string villesource = dt.Rows[0]["Code_Ville_Source"].ToString();
                string villedestination = dt.Rows[0]["Code_Ville_Destination"].ToString();
                string codeavion = dt.Rows[0]["Code_Avion"].ToString();
                int numequipe = Convert.ToInt32(dt.Rows[0]["Code_EquipeV"].ToString());
                string compagnie = dt.Rows[0]["Code_Compagnie"].ToString();
                VolTableAdapter vta = new VolTableAdapter();

                if (villesource == "PAR")
                {
                    if (typeperiodicite == "U")
                    {

                        vta.Insert(debut, fin, null, null, "EA", 0, null, a, codeavion, numequipe, equipm);

                        numocc = 1;
                    }
                    if (typeperiodicite == "D")
                    {
                        DateTime dt2 = debut;
                        while (dt2 <= fin)
                        {
                            vta.Insert(dt2, dt2.AddMinutes(dureevol), null, null, "EA", 0, null, a, codeavion, numequipe, equipm);
                            dt2 = dt2.AddDays(1);
                            numocc++;
                        }


                    }
                    if (typeperiodicite == "W")
                    {
                        DateTime dt2 = debut;
                        while (dt2 <= fin)
                        {
                            vta.Insert(dt2, dt2.AddMinutes(dureevol), null, null, "EA", 0, null, a, codeavion, numequipe, equipm);
                            dt2 = dt2.AddDays(7);
                            numocc++;

                        }

                    }
                    if (typeperiodicite == "M")
                    {
                        DateTime dt2 = debut;
                        while (dt2 <= fin)
                        {
                            vta.Insert(dt2, dt2.AddMinutes(dureevol), null, null, "EA", 0, null, a, codeavion, numequipe, equipm);
                            dt2 = dt2.AddMonths(1);
                            numocc++;
                        }

                    }
                    if (typeperiodicite == "H")
                    {

                        ProgrammeTableAdapter pta = new ProgrammeTableAdapter();
                        DataTable dtj = pta.GetDataByCodeVolProgramme(a);
                        bool[] jours = new bool[7];
                        for (int i = 0; i < 7; ++i)
                        {
                            jours[i] = false;

                        }
                        TimeSpan[] time = new TimeSpan[7];
                        for (int i = 0; i < dtj.Rows.Count; ++i)
                        {
                            jours[Convert.ToInt32(dtj.Rows[i]["Jour_Programme"].ToString()) - 1] = true;
                            time[Convert.ToInt32(dtj.Rows[i]["Jour_Programme"].ToString()) - 1] = TimeSpan.Parse(dtj.Rows[i]["Date_Depart_Programme"].ToString());

                        }

                        DateTime dt2 = debut;
                        int j = Convert.ToInt32(dt2.DayOfWeek);
                        if (j == 0) j = 7;
                        while (dt2 <= fin)
                        {

                            if (jours[j - 1] == true)
                            {
                                DateTime mydt = dt2.Add(time[j - 1]);
                                vta.Insert(mydt, mydt.AddMinutes(dureevol), null, null, "EA", 0, null, a, codeavion, numequipe, equipm);
                                numocc++;


                            }
                            dt2 = dt2.AddDays(1);
                            j = (j + 1) % 7;
                            if (j == 0) j = 7;

                        }


                    }
                }
                else
                {

                    if (typeperiodicite == "U")
                    {

                        vta.Insert(debut, fin, null, null, "EA", 0, null, a, codeavion, numequipe, equipm);
                        numocc++;

                    }
                    if (typeperiodicite == "D")
                    {
                        DateTime dt2 = debut;
                        while (dt2 <= fin)
                        {
                            vta.Insert(dt2.AddMinutes(-1 * dureevol), dt2, null, null, "EA", 0, null, a, codeavion, numequipe, equipm);
                            dt2 = dt2.AddDays(1);
                            numocc++;
                        }


                    }
                    if (typeperiodicite == "W")
                    {
                        DateTime dt2 = debut;
                        while (dt2 <= fin)
                        {
                            vta.Insert(dt2.AddMinutes(-1 * dureevol), dt2, null, null, "EA", 0, null, a, codeavion, numequipe, equipm);
                            dt2 = dt2.AddDays(7);
                            numocc++;
                        }


                    }
                    if (typeperiodicite == "M")
                    {
                        DateTime dt2 = debut;
                        while (dt2 <= fin)
                        {
                            vta.Insert(dt2.AddMinutes(-1 * dureevol), dt2, null, null, "EA", 0, null, a, codeavion, numequipe, equipm);
                            dt2 = dt2.AddMonths(1);
                            numocc++;
                        }

                    }
                    if (typeperiodicite == "H")
                    {
                        ProgrammeTableAdapter pta = new ProgrammeTableAdapter();
                        DataTable dtj = pta.GetDataByCodeVolProgramme(a);
                        bool[] jours = new bool[7];
                        for (int i = 0; i < 7; ++i)
                        {
                            jours[i] = false;

                        }
                        TimeSpan[] time = new TimeSpan[7];
                        for (int i = 0; i < dtj.Rows.Count; ++i)
                        {
                            jours[Convert.ToInt32(dtj.Rows[i]["Jour_Programme"].ToString()) - 1] = true;
                            time[Convert.ToInt32(dtj.Rows[i]["Jour_Programme"].ToString()) - 1] = TimeSpan.Parse(dtj.Rows[i]["Date_Depart_Programme"].ToString());

                        }


                        DateTime dt2 = debut;
                        int j = Convert.ToInt32(dt2.DayOfWeek);
                        if (j == 0) j = 7;
                        while (dt2 <= fin)
                        {

                            if (jours[j - 1] == true)
                            {
                                DateTime mydt = dt2.Add(time[j - 1]);
                                vta.Insert(mydt.AddMinutes(-1 * dureevol), mydt, null, null, "EA", 0, null, a, codeavion, numequipe, equipm);
                                numocc++;

                            }
                            dt2 = dt2.AddDays(1);
                            j = (j + 1) % 7;
                            if (j == 0) j = 7;

                        }

                    }

                }
                ta.UpdateEtatByVolProgrammeID("Y", a);
                ta.UpdateEquipeMByIDVolProgramme(equipm, a);
                VolDataGridView.Rows.RemoveAt(VolDataGridView.SelectedRows[0].Index);
                ProgrammePanel.Visible = false;
                DWMPanel.Visible = false;
                MessageBox.Show("Nombre d'occurences generées avec succès: " + numocc.ToString(), "Succès", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                UPanel.Visible = false;
                InformationVolPanel.Visible = false;
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
            if(EquipeMcomboBox.Items.Count>0)
            EquipeMcomboBox.SelectedIndex = 0;

        }

        private void VoirPersonnel_Click(object sender, EventArgs e)
        {

            if (equipm!=0)
            {
                InfoPersonnelMaintenance ipm = new InfoPersonnelMaintenance(equipm, dir);
                ipm.Show();
            }
        }
        

        private void EquipeMcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = ((MyListViewItem)EquipeMcomboBox.SelectedItem).getKey();
            equipm =(Convert.ToInt32(key));
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
        
         