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
    public partial class Arrivees : Form
    {
        int idVol;
        string radioButtonText;
        DateTime dtime;
        public Arrivees(DateTime dtime)
        {
            InitializeComponent();
            this.dtime = dtime;
            tabArriveeFct();
            PassagerReportDatagridView.AllowUserToAddRows = false;
            PassagerReportDatagridView.RowHeadersVisible = false;
            PassagerReportDatagridView.AutoGenerateColumns = false;
        }


        void tabArriveeFct()
        {
            labeldateChoisieArrivee.Text = dtime.ToLongDateString();
            InformationsVolsTableAdapter ta = new InformationsVolsTableAdapter();
            DataTable dt = ta.GetSpecificArrivals(dtime, dtime.AddDays(1), "PAR");
            ArriveeDatePickedDataGridView.AutoGenerateColumns = false;
            ArriveeDatePickedDataGridView.AllowUserToAddRows = false;
            ArriveeDatePickedDataGridView.RowHeadersVisible = false;
            ArriveeDatePickedDataGridView.DataSource = dt;
            etatGridArrivee();

        }



        void etatGridArrivee()
        {
            for (int i = 0; i < ArriveeDatePickedDataGridView.Rows.Count; ++i)
            {
                VilleTableAdapter vta = new VilleTableAdapter();
                DataTable vdt;
                string a = ArriveeDatePickedDataGridView.Rows[i].Cells["VilleA"].Value.ToString();
                vdt = vta.GetDataByCodeVille(a);
                ArriveeDatePickedDataGridView.Rows[i].Cells["VilleA"].Value = vdt.Rows[0]["Nom_Ville"];
                string etat = ArriveeDatePickedDataGridView.Rows[i].Cells["EtatA"].Value.ToString();
                if (etat == "EA") ArriveeDatePickedDataGridView.Rows[i].Cells["EtatA"].Value = "En attente";
                if (etat == "EV") ArriveeDatePickedDataGridView.Rows[i].Cells["EtatA"].Value = "En vol";
                if (etat == "CO") ArriveeDatePickedDataGridView.Rows[i].Cells["EtatA"].Value = "Checking-out";
                if (etat == "AC") ArriveeDatePickedDataGridView.Rows[i].Cells["EtatA"].Value = "Achevé";
                if (etat == "AN") ArriveeDatePickedDataGridView.Rows[i].Cells["EtatA"].Value = "Annulé";
            }
        }

        private void ArriveeDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < ArriveeDatePickedDataGridView.Rows.Count; ++i)
            {
                DateTime dtime = Convert.ToDateTime(ArriveeDatePickedDataGridView.Rows[i].Cells["DateA"].Value.ToString());
                double retard = Convert.ToDouble(ArriveeDatePickedDataGridView.Rows[i].Cells["RetardA"].Value.ToString());
                DateTime d2 = dtime.AddMinutes(retard);
                ArriveeDatePickedDataGridView.Rows[i].Cells["HeurePrevueA"].Value = d2;
            }
        }
        private void ChangerEtatButton_Click(object sender, EventArgs e)
        {
            bool cont=true;
            int rowindex = ArriveeDatePickedDataGridView.SelectedRows[0].Index;
            VolTableAdapter ta = new VolTableAdapter();
            DialogResult result = MessageBox.Show("êtes-vous sûr de vouloir changer l'état du vol?", "Changer Etat d'un vol", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                
                ta.UpdateEtatVolByVolID(radioButtonText, idVol);
                if (radioButtonText == "EV") ta.UpdateDateDepartEvByVolID(DateTime.Now, idVol);
                if (radioButtonText == "CO") ta.UpdateDateArriveeEvByVolID(DateTime.Now, idVol);
                if (radioButtonText == "AC")
                {

                    PassagerTableAdapter pta = new PassagerTableAdapter();
                    DataTable dt = pta.GetDataByIDVolAndEtatPassager("CO", idVol);
                    DataTable dt2 = pta.GetDataByIDVol(idVol);
                    int passagerco = dt.Rows.Count;
                    int passsagertotal = dt2.Rows.Count;
                    if(passagerco!=passsagertotal)
                    {
                        MessageBox.Show("Des passagers n'ont pas encore achevé leur check-out!", "Attention!", MessageBoxButtons.OK);
                        cont = false;
                        CheckOutButton_Click(this, EventArgs.Empty);

                    }
                }
                if (cont == true)
                {
                    tabArriveeFct();// reload gridview
                    ArriveeDatePickedDataGridView.Rows[0].Selected = false;
                    ArriveeDatePickedDataGridView.Rows[rowindex].Selected = true;
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
            if (ArriveeDatePickedDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ArriveeDatePickedDataGridView.SelectedRows[0];
                idVol = Convert.ToInt32(selectedRow.Cells["ID_Vol"].Value.ToString());
                a = selectedRow.Cells["EtatA"].Value.ToString();
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
                    selectedRow.Cells["EtatA"].Value = "En attente";
                    // enable les composants
                    panelChangerEtat.Enabled = true;
                    labelEtat.Enabled = true;
                    ChangerEtatButton.Enabled = true;
                    MaintenanceButton.Enabled = false;
                    RapportDuVolButton.Enabled = false;
                    RapportDesPassagerButton.Enabled = false;
                    CheckOutButton.Enabled = false;
                    panelChangerRetard.Enabled = true;
                    //radio Button valeurs
                    NextEtatRadioButton.Enabled = true;
                    PreviousEtatRadioButton.Enabled = false;
                    NextEtatRadioButton.Text = "En vol";
                    NextEtatRadioButton.Tag = "EV";
                    PreviousEtatRadioButton.Text = "Etat precedent";

                }
                if (a == "EV")
                {
                    selectedRow.Cells["EtatA"].Value = "En vol";
                    // enable les composants
                    panelChangerEtat.Enabled = true;
                    labelEtat.Enabled = true;
                    ChangerEtatButton.Enabled = true;
                    MaintenanceButton.Enabled = false;
                    RapportDuVolButton.Enabled = false;
                    RapportDesPassagerButton.Enabled = false;
                    CheckOutButton.Enabled = false;
                    panelChangerRetard.Enabled = true;
                    //radio Button valeurs
                    NextEtatRadioButton.Enabled = true;
                    PreviousEtatRadioButton.Enabled = true;
                    PreviousEtatRadioButton.Text = "En attente";
                    PreviousEtatRadioButton.Tag = "EA";
                    NextEtatRadioButton.Text = "Checking-out";
                    NextEtatRadioButton.Tag = "CO";
                }
                if (a == "CO")
                {
                    selectedRow.Cells["EtatA"].Value = "Checking-Out";
                    // enable les composants
                    panelChangerEtat.Enabled = true;
                    labelEtat.Enabled = true;
                    ChangerEtatButton.Enabled = true;
                    MaintenanceButton.Enabled = false;
                    RapportDuVolButton.Enabled = false;
                    RapportDesPassagerButton.Enabled = false;
                    CheckOutButton.Enabled = true;
                    panelChangerRetard.Enabled = false;
                    //radio Button valeurs
                    NextEtatRadioButton.Enabled = true;
                    PreviousEtatRadioButton.Enabled = true;
                    PreviousEtatRadioButton.Text = "En vol";
                    PreviousEtatRadioButton.Tag = "EV";
                    NextEtatRadioButton.Text = "Achevé";
                    NextEtatRadioButton.Tag = "AC";
                }
                if (a == "AC")
                {
                    selectedRow.Cells["EtatA"].Value = "Achevé";
                    // enable les composants
                    panelChangerEtat.Enabled = true;
                    labelEtat.Enabled = true;
                    ChangerEtatButton.Enabled = true;
                    MaintenanceButton.Enabled = true;
                    RapportDuVolButton.Enabled = false;
                    RapportDesPassagerButton.Enabled = true;
                    CheckOutButton.Enabled = false;
                    panelChangerRetard.Enabled = true;
                    //radio Button valeurs
                    NextEtatRadioButton.Enabled = false;
                    PreviousEtatRadioButton.Enabled = true;
                    PreviousEtatRadioButton.Text = "Checking-out";
                    PreviousEtatRadioButton.Tag = "CO";
                    NextEtatRadioButton.Text = "Etat suivant";


                }
                if (a == "AN")
                { selectedRow.Cells["EtatA"].Value = "Annulé";
                    // enable les composants
                    panelChangerEtat.Enabled = true;
                    labelEtat.Enabled = true;
                    ChangerEtatButton.Enabled = true;
                    MaintenanceButton.Enabled = false;
                    RapportDuVolButton.Enabled = false;
                    RapportDesPassagerButton.Enabled = false;
                    CheckOutButton.Enabled = false;
                    panelChangerRetard.Enabled = false;


                    //radio Button valeurs
                    NextEtatRadioButton.Text = "Etat suivant";
                    PreviousEtatRadioButton.Text = "Etat precedent";
                    NextEtatRadioButton.Enabled = false;
                    PreviousEtatRadioButton.Enabled = false;
                }

                RadioButton_CheckedChanged(this, EventArgs.Empty);
                Rapport_VolTableAdapter rvta = new Rapport_VolTableAdapter();
                DataTable rvdt = rvta.GetDataByVolID(idVol);
                if (rvdt.Rows.Count == 0) RapportDuVolButton.Enabled = false;
                else RapportDuVolButton.Enabled = true;

                Rapport_MaintenanceTableAdapter rta = new Rapport_MaintenanceTableAdapter();
                DataTable rdt = rta.GetDataByIDVol(idVol);
                if (rdt.Rows.Count > 0)
                { SauvegarderRapportMButton.Enabled = true; }
                else { SauvegarderRapportMButton.Enabled = false; }
            }
        }

        private void SaveRetardButton_Click(object sender, EventArgs e)
        {
            int rowindex = ArriveeDatePickedDataGridView.SelectedRows[0].Index;
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
                        if (radio.Tag == "A") ta.UpdateRetardByVolID((-1)*retard, idVol);

                    }
                }
            }
            tabArriveeFct();// reload gridview
            ArriveeDatePickedDataGridView.Rows[0].Selected = false;
            ArriveeDatePickedDataGridView.Rows[rowindex].Selected = true;
            RadioButton_CheckedChanged(this, EventArgs.Empty);

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
                    Excelap.Cells[1, 1] = "Numero Vol";
                    Excelap.Cells[1, 1].Font.Bold = true;

                    Excelap.Cells[1, 2] = dtv.Rows[0]["Code_Compagnie"].ToString() + " " + dtv.Rows[0]["Numero_VolProgramme"].ToString();
                    Excelap.Cells[1, 2].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    Excelap.Cells[1, 2].Font.Bold = true;
                    Excelap.Cells[1, 4] = "Date Vol";
                    Excelap.Cells[1, 4].Font.Bold = true;
                    Excelap.Cells[1, 5] = Convert.ToDateTime(dtv.Rows[0]["Date_Arrivee_Vol"].ToString()).ToLongDateString();
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

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            Master_Form mf = this.ParentForm as Master_Form;
            InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
            System.Data.DataTable idt = ita.GetDataByIdVol(idVol);
            if (idt.Rows.Count > 0)
            {
                string tabitle = "Check-out " + idt.Rows[0]["Code_Compagnie"].ToString() + idt.Rows[0]["Numero_VolProgramme"].ToString();
                // adding checkin page
                string key = "CKOUT" + idVol.ToString();
                TabPage test = mf.MainTabControl.TabPages[key];
                if (test == null)
                {
                    Checkout ck = new Checkout(idVol);
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
        }

        private void RapportDuVolButton_Click(object sender, EventArgs e)
        {


             InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
            System.Data.DataTable dtv;
            dtv = ita.GetDataByIdVol(idVol);
              string filename = "Rapport de vol" + dtv.Rows[0]["Code_Compagnie"].ToString() + dtv.Rows[0]["Numero_VolProgramme"].ToString();
            WordSaveFileDialog.InitialDirectory = "C:";
            WordSaveFileDialog.Title = filename;
            WordSaveFileDialog.FileName = filename;
            WordSaveFileDialog.Filter = "Word Files (2003)|*.doc|Word Files (2007)|*.docx";
            if (WordSaveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                object oMissing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
                Microsoft.Office.Interop.Word.Application a = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc = a.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                Microsoft.Office.Interop.Word.Paragraph oParatitle;
                Microsoft.Office.Interop.Word.Paragraph oParaarr;
                Microsoft.Office.Interop.Word.Paragraph oParacompagnie;
                Microsoft.Office.Interop.Word.Paragraph oParaavion;
                Microsoft.Office.Interop.Word.Paragraph oParavillesource;
                Microsoft.Office.Interop.Word.Paragraph oParavilledestination;
                Microsoft.Office.Interop.Word.Paragraph oParatext;
                Microsoft.Office.Interop.Word.Paragraph oParacaptain;
                Microsoft.Office.Interop.Word.Paragraph oParadate;

                string captain;
                string vol;
                DateTime daterapport;
                DateTime datearriveeeventuelle;
                string avion;
                string compagnie;
                string rapporttext;
                int codeequipevol;
                string villesource;
                string villedestination;
                InformationsVolsTableAdapter vta= new InformationsVolsTableAdapter();
                DataTable vdt=  vta.GetDataByIdVol(idVol);
                vol = vdt.Rows[0]["Code_Compagnie"].ToString() + " " + vdt.Rows[0]["Numero_VolProgramme"].ToString();
                CompagnieTableAdapter cta = new CompagnieTableAdapter();
                DataTable cdt = cta.GetDataByCode(vdt.Rows[0]["Code_Compagnie"].ToString());
                compagnie = cdt.Rows[0]["Nom_Compagnie"].ToString();
                datearriveeeventuelle = Convert.ToDateTime(vdt.Rows[0]["Date_Arrivee_Eventuelle_Vol"].ToString());
                Rapport_VolTableAdapter rta = new Rapport_VolTableAdapter();
                DataTable rdt = rta.GetDataByVolID(idVol);
                rapporttext = rdt.Rows[0]["Texte_RapportV"].ToString();
                daterapport = Convert.ToDateTime(rdt.Rows[0]["Date_RapportV"].ToString());
                string codeavion = vdt.Rows[0]["Code_Avion"].ToString();
                InfoAvionEtTypeTableAdapter aita = new InfoAvionEtTypeTableAdapter();
                DataTable idt = aita.GetDataByCodeAvion(codeavion);
                avion = idt.Rows[0]["Nom_Type"].ToString() + "( " + codeavion + " )";
                codeequipevol = Convert.ToInt32(vdt.Rows[0]["Code_EquipeV"].ToString());

                InfosMembresEquipeVolTableAdapter imta = new InfosMembresEquipeVolTableAdapter();
                DataTable mdt = imta.GetDataByEquipeVIDAndRole(codeequipevol, "P");
              
                VilleTableAdapter vita = new VilleTableAdapter();
                DataTable sdt;
                DataTable ddt;
                sdt = vita.GetDataByCodeVille(vdt.Rows[0]["Code_Ville_Source"].ToString());
                ddt = vita.GetDataByCodeVille(vdt.Rows[0]["Code_Ville_Destination"].ToString());
                villesource= sdt.Rows[0]["Nom_Ville"].ToString();
                villedestination= ddt.Rows[0]["Nom_Ville"].ToString();
              
               //Title
                oParatitle = doc.Content.Paragraphs.Add(ref oMissing);

                oParatitle.Range.Text = "Rapport de Vol " + vol.ToString();
                oParatitle.Range.Font.Size = 24;
                oParatitle.Range.Font.Bold = 2;
                oParatitle.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.\
                oParatitle.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oParatitle.Range.InsertParagraphAfter();

               //Date D'arrivee
                oParaarr = doc.Content.Paragraphs.Add(ref oMissing);
                oParaarr.Range.Text = " Date et heure d' arrivée: ";
                int al = oParaarr.Range.Text.Length;
                oParaarr.Range.InsertAfter(datearriveeeventuelle.ToString("MM/dd/yyyy H:mm"));
                oParaarr.Range.Font.Size = 13;
                oParaarr.Range.Font.Bold = 0;
                object oStart = oParaarr.Range.Start + al - 1;
                object oEnd = oParaarr.Range.Start + oParaarr.Range.Text.Length;

                Microsoft.Office.Interop.Word.Range rBold = doc.Range(ref oStart, ref oEnd);
                rBold.Bold = 1;
                oParaarr.Format.SpaceAfter = 2;
                oParaarr.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                oParaarr.Range.InsertParagraphAfter();

                
                
                
                
                
                
                
                
                
                
                //Compagnie
                oParacompagnie = doc.Content.Paragraphs.Add(ref oMissing);
                oParacompagnie.Range.Text = " Compagnie: ";
                al = oParacompagnie.Range.Text.Length;
                oParacompagnie.Range.InsertAfter(compagnie);
                oParacompagnie.Range.Font.Size = 13;
                oParacompagnie.Range.Font.Bold = 0;
                oStart = oParacompagnie.Range.Start + al - 1;
                oEnd = oParacompagnie.Range.Start + oParacompagnie.Range.Text.Length;

                rBold = doc.Range(ref oStart, ref oEnd);
                rBold.Bold = 1;
                oParacompagnie.Format.SpaceAfter = 2;
                oParacompagnie.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                oParacompagnie.Range.InsertParagraphAfter();


                //Ville Source
                oParavillesource = doc.Content.Paragraphs.Add(ref oMissing);
                oParavillesource.Range.Text = "Ville de départ: ";
                al = oParavillesource.Range.Text.Length;
                oParavillesource.Range.InsertAfter(villesource);
                oParavillesource.Range.Font.Size = 13;
                oParavillesource.Range.Font.Bold = 0;
                oStart = oParavillesource.Range.Start + al - 1;
                oEnd = oParavillesource.Range.Start + oParavillesource.Range.Text.Length;
                 rBold = doc.Range(ref oStart, ref oEnd);
                rBold.Bold = 1;
                oParavillesource.Format.SpaceAfter = 2;
                oParavillesource.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                oParavillesource.Range.InsertParagraphAfter();



                //Ville Destination
                oParavilledestination = doc.Content.Paragraphs.Add(ref oMissing);
                oParavilledestination.Range.Text = "Ville d'arrivée: ";
                al = oParavilledestination.Range.Text.Length;
                oParavilledestination.Range.InsertAfter(villedestination);
                oParavilledestination.Range.Font.Size = 13;
                oParavilledestination.Range.Font.Bold = 0;
                oStart = oParavilledestination.Range.Start + al - 1;
                oEnd = oParavilledestination.Range.Start + oParavilledestination.Range.Text.Length;
                rBold = doc.Range(ref oStart, ref oEnd);
                rBold.Bold = 1;
                oParavilledestination.Format.SpaceAfter = 2;
                oParavilledestination.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                oParavilledestination.Range.InsertParagraphAfter();

                //Avion
                oParaavion = doc.Content.Paragraphs.Add(ref oMissing);
                oParaavion.Range.Text ="Avion: ";
                al = oParaavion.Range.Text.Length;
                oParaavion.Range.InsertAfter(avion);
                oParaavion.Range.Font.Size = 13;
                oParaavion.Range.Font.Bold = 0;
                oStart = oParaavion.Range.Start + al-1;
                oEnd = oParaavion.Range.Start + oParaavion.Range.Text.Length;

               rBold = doc.Range(ref oStart, ref oEnd); 
                rBold.Bold = 1;
                oParaavion.Format.SpaceAfter = 15;
                oParaavion.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                oParaavion.Range.InsertParagraphAfter();


                //Text
                oParatext = doc.Content.Paragraphs.Add(ref oMissing);
                oParatext.Range.Text = rapporttext;
                oParatext.Range.Font.Size = 13;
                oParatext.Range.Font.Bold = 0;
                oParatext.Format.SpaceAfter = 15;
                oParatext.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                oParatext.Range.InsertParagraphAfter();
                   
                //Captain Name
                for(int i=0;i<mdt.Rows.Count;++i)
                {
            
                captain = mdt.Rows[i]["Prenom_PersonnelV"].ToString() + " " + mdt.Rows[i]["Nom_PersonnelV"].ToString();
                oParacaptain = doc.Content.Paragraphs.Add(ref oMissing);
                oParacaptain.Range.Text = captain;
                oParacaptain.Range.Font.Size = 13;
                oParacaptain.Range.Font.Bold = 1;
                oParacaptain.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                oParacaptain.Format.SpaceAfter = 2;
                if (i == mdt.Rows.Count - 1) oParacaptain.Format.SpaceAfter = 10;
                oParacaptain.Range.InsertParagraphAfter();
                }

                //Date
                oParadate = doc.Content.Paragraphs.Add(ref oMissing);
                oParadate.Range.Text = "Date: " + daterapport.ToShortDateString();
                oParadate.Range.Font.Size = 13;
                oParadate.Range.Font.Bold = 1;
                oParadate.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;

                doc.SaveAs(WordSaveFileDialog.FileName.ToString());
                doc.Close();
                MessageBox.Show("Rapport du vol "+ vol + " sauvegardé avec succès!","Succès", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

                            Maintenance iv = new Maintenance(idVol, "A");
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
            InfoPersonnelEquipeMaintenanceTableAdapter ieta = new InfoPersonnelEquipeMaintenanceTableAdapter();
            DataTable mdt = ieta.GetDataByIDEquipeM(equipem);
            for (int j = 0; j < mdt.Rows.Count; ++j)
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
                RapportDeMaintenance r = new RapportDeMaintenance(idVol, "A", MaintenanceSaveDialog.FileName.ToString());
                MessageBox.Show("Rapport de maintenance du vol " + dtv.Rows[0]["Code_Compagnie"].ToString() + " " + dtv.Rows[0]["Numero_VolProgramme"].ToString() + " sauvegarde avec succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                System.Diagnostics.Process.Start(MaintenanceSaveDialog.FileName);
            }
        }
    }
}
