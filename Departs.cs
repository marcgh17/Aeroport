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
    public partial class Departs : Form
    {
        DateTime dtime;
        int idVol;
        string radioButtonText;

        public Departs(DateTime dtime)
        {
            InitializeComponent();
            this.dtime = dtime;
            //this.creator = creator;
            tabDepartFct();
            PassagerReportDatagridView.AllowUserToAddRows = false;
            PassagerReportDatagridView.RowHeadersVisible = false;
            PassagerReportDatagridView.AutoGenerateColumns = false;

        }
        void tabDepartFct()
        {

            InformationsVolsTableAdapter ta = new InformationsVolsTableAdapter();
            labelDateChoisieDepart.Text = dtime.ToLongDateString();
            DataTable dt = ta.GetSpecificDepartures(dtime, dtime.AddDays(1), "PAR");

            departDatePickedDataGridView.AutoGenerateColumns = false;
            departDatePickedDataGridView.AllowUserToAddRows = false;
            departDatePickedDataGridView.RowHeadersVisible = false;
            departDatePickedDataGridView.DataSource = dt;
            etatGridDepart();
        }
        void etatGridDepart()
        {
            for (int i = 0; i < departDatePickedDataGridView.Rows.Count; ++i)
            {
                VilleTableAdapter vta = new VilleTableAdapter();
                DataTable vdt;
                string a = departDatePickedDataGridView.Rows[i].Cells["VilleD"].Value.ToString();
                vdt = vta.GetDataByCodeVille(a);
                departDatePickedDataGridView.Rows[i].Cells["VilleD"].Value = vdt.Rows[0]["Nom_Ville"];
                string etat = departDatePickedDataGridView.Rows[i].Cells["EtatD"].Value.ToString();
                if (etat == "EA") departDatePickedDataGridView.Rows[i].Cells["EtatD"].Value = "En attente";
                if (etat == "CI") departDatePickedDataGridView.Rows[i].Cells["EtatD"].Value = "Checking-in";
                if (etat == "BO") departDatePickedDataGridView.Rows[i].Cells["EtatD"].Value = "Boarding";
                if (etat == "DP") departDatePickedDataGridView.Rows[i].Cells["EtatD"].Value = "Decollé";
                if (etat == "AN") departDatePickedDataGridView.Rows[i].Cells["EtatD"].Value = "Annulé";
            }
        }
        private void DepartDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < departDatePickedDataGridView.Rows.Count; ++i)
            {

                DateTime dtime = Convert.ToDateTime(departDatePickedDataGridView.Rows[i].Cells["DateD"].Value.ToString());
                double retard = Convert.ToDouble(departDatePickedDataGridView.Rows[i].Cells["RetardD"].Value.ToString());
                DateTime d2 = dtime.AddMinutes(retard);
                departDatePickedDataGridView.Rows[i].Cells["HeureprevueD"].Value = d2;
            }
        }



        private void ChangerEtatButton_Click(object sender, EventArgs e)
        {
            bool cont = true;
            int rowindex = departDatePickedDataGridView.SelectedRows[0].Index;
            VolTableAdapter ta = new VolTableAdapter();
            DataTable vdt = ta.GetDataByVolID(idVol);
            string etatac = vdt.Rows[0]["Etat_Vol"].ToString();
            if (radioButtonText == "BO")
            {
                Rapport_MaintenanceTableAdapter rta = new Rapport_MaintenanceTableAdapter();
                DataTable rdt = rta.GetDataByIDVol(idVol);
                if (rdt.Rows.Count == 0)
                {
                    MessageBox.Show("La maintenance n'est pas achevée! ", "Attention", MessageBoxButtons.OK);
                    cont = false;
                }
                else cont = true;
            }
            if (etatac == "BO" && radioButtonText == "DP")
            {
                int checkedin = 0;
                PassagerTableAdapter pta = new PassagerTableAdapter();
                checkedin = Convert.ToInt32(pta.CountPassengerByEtatAndVolID("CI", idVol).ToString());
                if (checkedin > 0)
                {
                    MessageBox.Show("Des passagers ont fait un check-in sans faire le boarding!", "Attention!", MessageBoxButtons.OK);
                    cont = false;
                    using (PassagersPerdus myForm = new PassagersPerdus(idVol))
                    {
                        DialogResult dr = myForm.ShowDialog();
                        if (dr == DialogResult.OK)
                        {
                            cont = true;
                        }
                    }
                }
            }


            if (cont == true)
            {
                DialogResult result = MessageBox.Show("êtes-vous sûr de vouloir changer l'état du vol?", "Changer Etat d'un vol", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (radioButtonText == "AN")
                    {
                        DialogResult r = MessageBox.Show("Voulez-vous créer un vol alternatif?", "Annuler Le vol", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {
                            using (VolAlternatif myForm = new VolAlternatif(idVol))
                            {
                                DialogResult dr = myForm.ShowDialog();
                            }
                        }
                    }
                    ta.UpdateEtatVolByVolID(radioButtonText, idVol);
                    if (radioButtonText == "DP") ta.UpdateDateDepartEvByVolID(DateTime.Now, idVol);
                    tabDepartFct();// reload gridview
                    departDatePickedDataGridView.Rows[0].Selected = false;
                    departDatePickedDataGridView.Rows[rowindex].Selected = true;
                    RadioButton_CheckedChanged(this, EventArgs.Empty);
                }
            }
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control objet in panelChangerEtat.Controls)
            {
                if (objet is RadioButton)
                {
                    RadioButton radio = objet as RadioButton;
                    if (radio.Checked) radioButtonText = radio.Tag.ToString();
                }
            }
        }
        private void selectedChanged(object sender, EventArgs e)
        {
            string a = null;
            if (departDatePickedDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = departDatePickedDataGridView.SelectedRows[0];
                idVol = Convert.ToInt32(selectedRow.Cells["ID_Vol"].Value.ToString());
                
                VolTableAdapter tva = new VolTableAdapter();
                DataTable dt = tva.GetDataByVolID(idVol);
                int retard = Convert.ToInt32(dt.Rows[0]["Retard_Vol"].ToString());
                if (retard > 0)
                {
                    textBoxRetard.Text = retard.ToString();
                    radioButtonR.Checked = true;
                    radioButtonA.Checked = false;
                }
                if (retard < 0)
                {
                    textBoxRetard.Text = (-1 * retard).ToString();
                    radioButtonR.Checked = false;
                    radioButtonA.Checked = true;
                }
                if (retard == 0)
                {
                    textBoxRetard.Text = "0";
                    radioButtonR.Checked = false;
                    radioButtonA.Checked = false;
                }

                a = dt.Rows[0]["Etat_Vol"].ToString();
            if (a == "EA")
            {
                // enable les composants
                selectedRow.Cells["EtatD"].Value = "En attente";
                panelChangerEtat.Enabled = true;
                labelEtat.Enabled = true;
                ChangerEtatButton.Enabled = true;
                MaintenanceButton.Enabled = true;
                BoardingButton.Enabled = false;
                RapportDesPassagerButton.Enabled = false;
                CheckInButton.Enabled = false;
                panelChangerRetard.Enabled = true;
                //radio Button valeurs
                NextEtatRadioButton.Enabled = true;
                PreviousEtatRadioButton.Enabled = false;
                NextEtatRadioButton.Text = "Checking-in";
                NextEtatRadioButton.Tag = "CI";
                PreviousEtatRadioButton.Text = "Etat precedent";
            }
            if (a == "CI")
            {
                selectedRow.Cells["EtatD"].Value = "Checking-In";
                // enable les composants
                panelChangerEtat.Enabled = true;
                labelEtat.Enabled = true;
                ChangerEtatButton.Enabled = true;
                MaintenanceButton.Enabled = true;
                BoardingButton.Enabled = false;
                RapportDesPassagerButton.Enabled = false;
                CheckInButton.Enabled = true;
                panelChangerRetard.Enabled = true;
                //radio Button valeurs
                NextEtatRadioButton.Enabled = true;
                PreviousEtatRadioButton.Enabled = true;
                PreviousEtatRadioButton.Text = "En attente";
                PreviousEtatRadioButton.Tag = "EA";
                NextEtatRadioButton.Text = "Boarding";
                NextEtatRadioButton.Tag = "BO";
            }
            if (a == "BO")
            {
                selectedRow.Cells["EtatD"].Value = "Boarding";
                // enable les composants
                panelChangerEtat.Enabled = true;
                labelEtat.Enabled = true;
                ChangerEtatButton.Enabled = true;
                MaintenanceButton.Enabled = false;
                BoardingButton.Enabled = true;
                RapportDesPassagerButton.Enabled = false;
                CheckInButton.Enabled = true;
                panelChangerRetard.Enabled = true;

                //radio Button valeurs
                NextEtatRadioButton.Enabled = true;
                PreviousEtatRadioButton.Enabled = true;
                PreviousEtatRadioButton.Text = "Checking-in";
                PreviousEtatRadioButton.Tag = "CI";
                NextEtatRadioButton.Text = "Decollé";
                NextEtatRadioButton.Tag = "DP";
            }
            if (a == "DP")
            {
                selectedRow.Cells["EtatD"].Value = "Décollé";
                // enable les composants
                panelChangerEtat.Enabled = true;
                labelEtat.Enabled = true;
                ChangerEtatButton.Enabled = true;
                MaintenanceButton.Enabled = false;
                BoardingButton.Enabled = false;
                RapportDesPassagerButton.Enabled = true;
                CheckInButton.Enabled = false;
                panelChangerRetard.Enabled = false;
                //radio Button valeurs
                NextEtatRadioButton.Enabled = false;
                PreviousEtatRadioButton.Enabled = true;
                PreviousEtatRadioButton.Text = "Boarding";
                PreviousEtatRadioButton.Tag = "BO";
                NextEtatRadioButton.Text = "Etat suivant";
            }
            if (a == "AN")
            {
                selectedRow.Cells["EtatD"].Value = "Annulé";
                // enable les composants
                panelChangerEtat.Enabled = false;
                labelEtat.Enabled = false;
                ChangerEtatButton.Enabled = false;
                MaintenanceButton.Enabled = false;
                BoardingButton.Enabled = false;
                RapportDesPassagerButton.Enabled = true;
                CheckInButton.Enabled = false;
                panelChangerRetard.Enabled = false;
                //radio Button valeurs
                NextEtatRadioButton.Text = "Etat suivant";
                PreviousEtatRadioButton.Text = "Etat précédent";
                NextEtatRadioButton.Enabled = false;
                PreviousEtatRadioButton.Enabled = false;
            }
            RadioButton_CheckedChanged(this, EventArgs.Empty);

            Rapport_MaintenanceTableAdapter rta = new Rapport_MaintenanceTableAdapter();
            DataTable rdt = rta.GetDataByIDVol(idVol);
            if(rdt.Rows.Count>0)
            { SauvegarderRapportMButton.Enabled = true; }
            else { SauvegarderRapportMButton.Enabled = false; }
            }

        }
        private void SaveRetardButton_Click(object sender, EventArgs e)
        {

            int rowindex = departDatePickedDataGridView.SelectedRows[0].Index;
            int retard = Convert.ToInt32(textBoxRetard.Text);
            VolTableAdapter ta = new VolTableAdapter();
            foreach (Control objet in panelChangerRetard.Controls)
            {
                if (objet is RadioButton)
                {
                    RadioButton radio = objet as RadioButton;
                    if (radio.Checked)
                    {
                        if (radio.Tag == "R") ta.UpdateRetardByVolID(retard, idVol);
                        if (radio.Tag == "A") ta.UpdateRetardByVolID((-1) * retard, idVol);
                    }
                }
            }
            tabDepartFct();// reload gridview
            departDatePickedDataGridView.Rows[0].Selected = false;
            departDatePickedDataGridView.Rows[rowindex].Selected = true;
            RadioButton_CheckedChanged(this, EventArgs.Empty);
        }
        private void CheckInButton_Click(object sender, EventArgs e)
        {


            Master_Form mf = this.ParentForm as Master_Form;
            InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
            System.Data.DataTable idt = ita.GetDataByIdVol(idVol);
            string tabitle = "Check-in " + idt.Rows[0]["Code_Compagnie"].ToString() + idt.Rows[0]["Numero_VolProgramme"].ToString();
            // adding checkin page
            string key = "CKIN" + idVol.ToString();
            TabPage test = mf.MainTabControl.TabPages[key];
            if (test == null)
            {
                Checkin ck = new Checkin(idVol);
                mf.MainTabControl.TabPages.Add(key, tabitle);
                TabPage ta = mf.MainTabControl.TabPages[key];
                ck.TopLevel = false;
                ck.AutoScroll = true;
                ck.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                ck.Visible = true;
                ta.Controls.Add(ck);
                mf.MainTabControl.SelectedTab = (ta);
            }
            else
            {
                mf.MainTabControl.SelectedTab = (test);
            }
        }
        private void ListePassagerButton_Click(object sender, EventArgs e)
        {
            Master_Form mf = this.ParentForm as Master_Form;
            InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
            System.Data.DataTable idt = ita.GetDataByIdVol(idVol);
            string tabitle = "Passagers " + idt.Rows[0]["Code_Compagnie"].ToString() + idt.Rows[0]["Numero_VolProgramme"].ToString();
            // adding checkin page
            string key = "PASS" + idVol.ToString();
            TabPage test = mf.MainTabControl.TabPages[key];
            if (test == null)
            {
                mf.MainTabControl.TabPages.Add(key, tabitle);
                ListePassagers p = new ListePassagers(idVol);
                TabPage td = mf.MainTabControl.TabPages[key];
                p.TopLevel = false;
                p.AutoScroll = true;
                p.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p.Visible = true;
                td.Controls.Add(p);
                mf.MainTabControl.SelectedTab = (td);
            }
            else
            {
                mf.MainTabControl.SelectedTab = (test);
            }

        }
        private void RapportDesPassagerButton_Click(object sender, EventArgs e)
        {

            InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
            PassagerTableAdapter pta = new PassagerTableAdapter();
            System.Data.DataTable dtv;
            System.Data.DataTable dtp;
            dtv = ita.GetDataByIdVol(idVol);
            dtp = pta.GetDataByIDVol(idVol);
            if (dtp.Rows.Count == 0)
            {
                MessageBox.Show("Liste Vide! Aucun rapport sauvegarde!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string filename = "RapportPassagers" + dtv.Rows[0]["Code_Compagnie"].ToString() + dtv.Rows[0]["Numero_VolProgramme"].ToString();
                ExcelSaveFileDialog.InitialDirectory = "C:";
                ExcelSaveFileDialog.Title = filename;
                ExcelSaveFileDialog.FileName = filename;
                ExcelSaveFileDialog.Filter = "Excel Files (2003)|*.xls|Excel Files (2007)|*.xls";
                if (ExcelSaveFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    Microsoft.Office.Interop.Excel.Application Excelap = new Microsoft.Office.Interop.Excel.Application();
                    Excelap.Application.Workbooks.Add(Type.Missing);
                    Excelap.Columns.ColumnWidth = 30;

                    PassagerReportDatagridView.DataSource = dtp;


                    PassagerGrid();
                    Excelap.Cells[1, 1] = "Numéro Vol";
                    Excelap.Cells[1, 1].Font.Bold = true;

                    Excelap.Cells[1, 2] = dtv.Rows[0]["Code_Compagnie"].ToString() + " " + dtv.Rows[0]["Numero_VolProgramme"].ToString();
                    Excelap.Cells[1, 2].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    Excelap.Cells[1, 2].Font.Bold = true;
                    Excelap.Cells[1, 4] = "Date Vol";
                    Excelap.Cells[1, 4].Font.Bold = true;
                    Excelap.Cells[1, 5] = Convert.ToDateTime(dtv.Rows[0]["Date_Depart_Vol"].ToString()).ToLongDateString();
                    Excelap.Cells[1, 5].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    Excelap.Cells[1, 5].Font.Bold = true;
                    for (int i = 1; i < PassagerReportDatagridView.Columns.Count + 1; ++i)
                    {
                        Excelap.Cells[3, i] = PassagerReportDatagridView.Columns[i - 1].HeaderText;
                        Excelap.Cells[3, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.SkyBlue);
                    }
                    for (int i = 0; i < PassagerReportDatagridView.Rows.Count; ++i)
                    {
                        for (int j = 0; j < PassagerReportDatagridView.Columns.Count; ++j)
                        {
                            if (PassagerReportDatagridView.Columns[j].Name == "DateNaissance" || PassagerReportDatagridView.Columns[j].Name == "DateReservation")
                            {
                                string date = PassagerReportDatagridView.Rows[i].Cells[j].Value.ToString();
                                DateTime dat = Convert.ToDateTime(date);
                                date = dat.ToShortDateString();
                                Excelap.Cells[i + 5, j + 1] = date;
                            }
                            Excelap.Cells[i + 5, j + 1] = PassagerReportDatagridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    Excelap.ActiveWorkbook.SaveCopyAs(ExcelSaveFileDialog.FileName.ToString());
                    Excelap.ActiveWorkbook.Saved = true;
                    Excelap.Quit();
                    MessageBox.Show("Rapport des passagers du vol " + dtv.Rows[0]["Code_Compagnie"].ToString() + " " + dtv.Rows[0]["Numero_VolProgramme"].ToString() + " sauvegarde avec succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        private void PassagerGrid()
        {
            for (int i = 0; i < PassagerReportDatagridView.Rows.Count; ++i)
            {
                string sexe = PassagerReportDatagridView.Rows[i].Cells["Sexe_Passager"].Value.ToString();
                string etat = PassagerReportDatagridView.Rows[i].Cells["Etat_Passager"].Value.ToString();
                if (sexe == "F") PassagerReportDatagridView.Rows[i].Cells["Sexe_Passager"].Value = "Femme";
                if (sexe == "H") PassagerReportDatagridView.Rows[i].Cells["Sexe_Passager"].Value = "Homme";
                if (etat == "AB") PassagerReportDatagridView.Rows[i].Cells["Etat_Passager"].Value = "Absent";
                if (etat == "CI") PassagerReportDatagridView.Rows[i].Cells["Etat_Passager"].Value = "Checked-In";
                if (etat == "BO") PassagerReportDatagridView.Rows[i].Cells["Etat_Passager"].Value = "En Bord";
                if (etat == "CO") PassagerReportDatagridView.Rows[i].Cells["Etat_Passager"].Value = "Checked-Out";
            }

        }
        private void BoardingButton_Click(object sender, EventArgs e)
        {

            Master_Form mf = this.ParentForm as Master_Form;
            InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
            System.Data.DataTable idt = ita.GetDataByIdVol(idVol);
            string tabitle = "Boarding " + idt.Rows[0]["Code_Compagnie"].ToString() + idt.Rows[0]["Numero_VolProgramme"].ToString();
            // adding checkin page
            string key = "BDIN" + idVol.ToString();
            TabPage test = mf.MainTabControl.TabPages[key];
            if (test == null)
            {
                Boarding ba = new Boarding(idVol);
                mf.MainTabControl.TabPages.Add(key, tabitle);
                TabPage ta = mf.MainTabControl.TabPages[key];
                ba.TopLevel = false;
                ba.AutoScroll = true;
                ba.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                ba.Visible = true;
                ta.Controls.Add(ba);
                mf.MainTabControl.SelectedTab = (ta);
            }
            else
            {
                mf.MainTabControl.SelectedTab = (test);
            }
        }

        private void InfoVol_Click(object sender, EventArgs e)
        {
            Master_Form mf = this.ParentForm as Master_Form;
            InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
            System.Data.DataTable idt = ita.GetDataByIdVol(idVol);
            string tabitle = "Info vol " + idt.Rows[0]["Code_Compagnie"].ToString() + idt.Rows[0]["Numero_VolProgramme"].ToString();
            // adding checkin page
            string key = "INFVOL" + idVol.ToString();
            TabPage test = mf.MainTabControl.TabPages[key];
            if (test == null)
            {
                InfoVol iv = new InfoVol(idVol);
                mf.MainTabControl.TabPages.Add(key, tabitle);
                TabPage ta = mf.MainTabControl.TabPages[key];
                iv.TopLevel = false;
                iv.AutoScroll = true;
                iv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                iv.Visible = true;
                ta.Controls.Add(iv);
                mf.MainTabControl.SelectedTab = (ta);
            }
            else
            {
                mf.MainTabControl.SelectedTab = (test);
            }
        }
        private void MaintenanceButton_Click(object sender, EventArgs e)
        {
            Master_Form mf = this.ParentForm as Master_Form;
            InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
            System.Data.DataTable idt = ita.GetDataByIdVol(idVol);
            string key = "MNT" + idVol.ToString();
            TabPage test = mf.MainTabControl.TabPages[key];
            if (test != null)
            {
                mf.MainTabControl.SelectedTab = (test);
            }
            else
            {
                Rapport_MaintenanceTableAdapter rta = new Rapport_MaintenanceTableAdapter();
                DataTable rdt = rta.GetDataByIDVol(idVol);
                if (rdt.Rows.Count > 0)
                {
                    MessageBox.Show("Maintenance déja effectuée", "Erreur", MessageBoxButtons.OK);
                }
                else
                {
                    string disponibilte = CheckDisponibilite(idVol);
                    if (disponibilte == "D")
                    {
                        DialogResult dr1 = MessageBox.Show("Etes vous sûr de vouloir commencer la maintenance?", "Début de maintenance", MessageBoxButtons.YesNo);
                        if (dr1 == DialogResult.Yes)
                        {
                            string tabitle = "Maintenance " + idt.Rows[0]["Code_Compagnie"].ToString() + idt.Rows[0]["Numero_VolProgramme"].ToString();
                            // adding checkin page

                            Maintenance iv = new Maintenance(idVol, "D");
                            mf.MainTabControl.TabPages.Add(key, tabitle);
                            TabPage ta = mf.MainTabControl.TabPages[key];
                            iv.TopLevel = false;
                            iv.AutoScroll = true;
                            iv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                            iv.Visible = true;
                            ta.Controls.Add(iv);
                            mf.MainTabControl.SelectedTab = (ta);
                        }

                    }

                    else if (disponibilte == "EO")
                    {
                        DialogResult dr = MessageBox.Show("L'équipe de maintenance est couramment occupée, voulez vous choisir une autre équipe?", "Equipe Occupée", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.OK)
                        {
                            InfoVol_Click(this, EventArgs.Empty);

                        }


                    }
                    else if (disponibilte == "MO")
                    {
                        DialogResult dr = MessageBox.Show("Un ou plusieurs membres de l'équipe de maintenance sont couramement occupés, voulez vous choisir une autre équipe?", "Membres Occupés", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.OK)
                        {
                            InfoVol_Click(this, EventArgs.Empty);

                        }


                    }
                }

            }
        }


        public string CheckDisponibilite(int idv)
        {


            VolTableAdapter vta = new VolTableAdapter();
            DataTable vdt = vta.GetDataByVolID(idv);
            int equipem = Convert.ToInt32(vdt.Rows[0]["Code_EquipeM"].ToString());
            Equipe_MaintenanceTableAdapter eta = new Equipe_MaintenanceTableAdapter();
            DataTable edt = eta.GetDataByEquipeCode(equipem);
            string etatequipe = edt.Rows[0]["Etat_Actuel_EquipeM"].ToString();
            if (etatequipe == "O") return "EO";
             InfoPersonnelEquipeMaintenanceTableAdapter ieta= new InfoPersonnelEquipeMaintenanceTableAdapter();
            DataTable mdt=ieta.GetDataByIDEquipeM(equipem);
            for(int j=0;j<mdt.Rows.Count;++j)
            {

                if (mdt.Rows[j]["Etat_Actuel_PersonnelM"].ToString() == "O") return "MO";
            }

            return "D";
        }

        private void SauvegarderRapportMButton_Click(object sender, EventArgs e)
        {
              InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
              System.Data.DataTable dtv;
              dtv = ita.GetDataByIdVol(idVol);
                string filename = "RapportMaintenance" + dtv.Rows[0]["Code_Compagnie"].ToString() + dtv.Rows[0]["Numero_VolProgramme"].ToString();
                MaintenanceSaveDialog.InitialDirectory = "C:";
                MaintenanceSaveDialog.Title = filename;
                MaintenanceSaveDialog.FileName = filename;
                MaintenanceSaveDialog.Filter = "PDF|*.pdf";
                if (MaintenanceSaveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    RapportDeMaintenance r = new RapportDeMaintenance(idVol, "D", MaintenanceSaveDialog.FileName.ToString());
                    MessageBox.Show("Rapport de maintenance du vol " + dtv.Rows[0]["Code_Compagnie"].ToString() + " " + dtv.Rows[0]["Numero_VolProgramme"].ToString() + " sauvegarde avec succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    System.Diagnostics.Process.Start(MaintenanceSaveDialog.FileName);
                    
                }
        }

    }
}