using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using Aeroport_Application.AeroportDataSetTableAdapters;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace Aeroport_Application
{
  
    public partial class ListePassagers : Form
    {
        int idvol;
        string file;
        string direction;
        public ListePassagers(int idvol)
        {
            InitializeComponent();
            PassagerDataGridView.AutoGenerateColumns = false;
            PlaceComboBox.DisplayMember = "Text";
            PlaceComboBox.ValueMember = "key";

            PlaceComboBox.Items.Add(new MyListViewItem("T", "Tout"));
            PlaceComboBox.Items.Add(new MyListViewItem("B", "Buisness"));
            PlaceComboBox.Items.Add(new MyListViewItem("E", "Economy"));
            PlaceComboBox.SelectedIndex = 0;



            this.idvol = idvol;
            InformationsVolsTableAdapter ita = new InformationsVolsTableAdapter();
            PassagerTableAdapter pta = new PassagerTableAdapter();
            System.Data.DataTable dtv;
            System.Data.DataTable dtp;
            dtv = ita.GetDataByIdVol(idvol);
            LabelNumVol.Text = "Numéro Vol : "+dtv.Rows[0]["Code_Compagnie"].ToString() + dtv.Rows[0]["Numero_VolProgramme"].ToString() + "                         Date du vol : " + Convert.ToDateTime(dtv.Rows[0]["Date_Depart_Vol"].ToString()).ToShortDateString();
            PassagerDataGridView.AutoGenerateColumns = false;
            if (dtv.Rows[0]["Code_Ville_Source"].ToString() == "PAR") direction = "D";
            else direction = "A";
            string coderef = dtv.Rows[0]["Code_Reference"].ToString();
            if (coderef =="")
            {
                dtp = pta.GetDataByIDVol(idvol);
                if (dtp.Rows.Count==0)
                {
                    UploadPassagerButton.Enabled = true;
                    PassagerDataGridView.Enabled = false;
                    LabelRemarque.Text = " Liste Vide";
                    SearchPanel.Enabled = false;
                    SupprimerPassagerButton.Enabled = false;

                }

                else
                {

                    PassagerDataGridView.Enabled = true;
                    PassagerDataGridView.DataSource = dtp;
                    etatpassagergrid();
                    UploadPassagerButton.Enabled = false;
                    LabelRemarque.Text = " Liste des passagers";
                    SearchPanel.Enabled = true;
                    SupprimerPassagerButton.Enabled = true;
                }
            }

            else
            {
                LabelRemarque.Text = " Liste Supprimée, Code Référence : " + dtv.Rows[0]["Code_Reference"].ToString();
                UploadPassagerButton.Enabled = false;
                PassagerDataGridView.Enabled = false;
                SearchPanel.Enabled = false;
                SupprimerPassagerButton.Enabled = false;

            }

        }

        private void UploadPassagerButton_Click(object sender, EventArgs e)
        {

            DialogResult result = ExcelFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                 DialogResult result2 = MessageBox.Show("êtes-vous sûr de vouloir importer la liste du fichier choisi?", "Importer Liste", MessageBoxButtons.OKCancel);
                 if (result2 == DialogResult.OK)
                 {
                     file = ExcelFileDialog.FileName;
                     PassagerTableAdapter pta = new PassagerTableAdapter();
                     Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                     Workbook wb = excel.Workbooks.Open(file);
                     string currentSheet = "Sheet1";
                     Worksheet excelWorksheet = (Worksheet)wb.Worksheets.get_Item(currentSheet);
                     Range last = excelWorksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell, Type.Missing);
                     Range range = excelWorksheet.get_Range("A1", last);
                     int lastUsedRow = last.Row + 1;
                     for (int i = 3; i < lastUsedRow; ++i)
                     {
                         if(direction=="D") pta.Insert(excelWorksheet.Cells[i, 1].Value.ToString(), excelWorksheet.Cells[i, 2].Value.ToString(), Convert.ToDateTime(excelWorksheet.Cells[i, 3].Value.ToString()), excelWorksheet.Cells[i, 4].Value.ToString(), excelWorksheet.Cells[i, 5].Value.ToString(), excelWorksheet.Cells[i, 6].Value.ToString(), excelWorksheet.Cells[i, 7].Value.ToString(), "AB", Convert.ToDateTime(excelWorksheet.Cells[i, 8].Value.ToString()), null, null, null, null, null,idvol);
                         else pta.Insert(excelWorksheet.Cells[i, 1].Value.ToString(), excelWorksheet.Cells[i, 2].Value.ToString(), Convert.ToDateTime(excelWorksheet.Cells[i, 3].Value.ToString()), excelWorksheet.Cells[i, 4].Value.ToString(), excelWorksheet.Cells[i, 5].Value.ToString(), excelWorksheet.Cells[i, 6].Value.ToString(), excelWorksheet.Cells[i, 7].Value.ToString(), "BO", Convert.ToDateTime(excelWorksheet.Cells[i, 8].Value.ToString()), null, null, null, null, null, idvol);
                     }
                     wb.Close(true);
                     excel.Quit();
                     System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheet);
                     System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

                    
                    
                     System.Data.DataTable dtp;
                     dtp = pta.GetDataByIDVol(idvol);
                     if (dtp.Rows.Count == 0)
                     {
                         UploadPassagerButton.Enabled = true;
                         PassagerDataGridView.Enabled = false;
                         LabelRemarque.Text = " Liste Vide";
                         SearchPanel.Enabled = false;

                     }

                     else
                     {

                         PassagerDataGridView.Enabled = true;
                         PassagerDataGridView.DataSource = dtp;
                         etatpassagergrid();
                         UploadPassagerButton.Enabled = false;
                         SupprimerPassagerButton.Enabled = true;
                         LabelRemarque.Text = " Liste des passagers";
                         SearchPanel.Enabled = true;
                     }

                 }
            }
        }


        private void etatpassagergrid()
        {

            for (int i = 0; i < PassagerDataGridView.Rows.Count; ++i)
            {

                string sexe = PassagerDataGridView.Rows[i].Cells["Sexe_Passager"].Value.ToString();
                string etat = PassagerDataGridView.Rows[i].Cells["Etat_Passager"].Value.ToString();
                if (sexe == "F") PassagerDataGridView.Rows[i].Cells["Sexe_Passager"].Value = "Femme";
                if (sexe == "H") PassagerDataGridView.Rows[i].Cells["Sexe_Passager"].Value = "Homme";
                if (etat == "AB") PassagerDataGridView.Rows[i].Cells["Etat_Passager"].Value = "Absent";
                if (etat == "CI") PassagerDataGridView.Rows[i].Cells["Etat_Passager"].Value = "Checked-In";
                if (etat == "BO") PassagerDataGridView.Rows[i].Cells["Etat_Passager"].Value = "En Bord";
                if (etat == "CO") PassagerDataGridView.Rows[i].Cells["Etat_Passager"].Value = "Checked-Out";

            }
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





                       s_cmd = "SELECT * FROM PASSAGER Where ID_VOL=" + idvol + " AND Emplacement_Passager LIKE 'B%' AND  (Nom_Passager LIKE '%" + search + "%' OR Prenom_Passager LIKE '%" + search + "%'  OR Num_Passeport_Passager LIKE '%" + search + "%' )";


                       SqlCommand cmd = new SqlCommand(s_cmd, cn);
                       DataSet ds = new DataSet();
                       SqlDataAdapter da = new SqlDataAdapter(cmd); //methode de select avec methode classique de query
                       da.Fill(ds);
                       PassagerDataGridView.DataSource = ds;
                       dtp = ds.Tables[0];

                       
                   }
                   if (key == "E")
                   {
                       s_cmd = "SELECT * FROM PASSAGER Where ID_VOL=" + idvol + " AND Emplacement_Passager LIKE 'E%' AND (Nom_Passager LIKE '%" + search + "%' OR Prenom_Passager LIKE '%" + search + "%'  OR Num_Passeport_Passager LIKE '%" + search + "%' )";


                       SqlCommand cmd = new SqlCommand(s_cmd, cn);
                       DataSet ds = new DataSet();
                       SqlDataAdapter da = new SqlDataAdapter(cmd); //methode de select avec methode classique de query
                       da.Fill(ds);
                       dtp = ds.Tables[0];
 

                   }
                   if (key == "T")
                   {
                       s_cmd = "SELECT * FROM PASSAGER Where ID_VOL="+idvol+" AND (Nom_Passager LIKE '%" + search + "%' OR Prenom_Passager LIKE '%" + search + "%'  OR Num_Passeport_Passager LIKE '%" + search + "%' )"  ;


                       SqlCommand cmd = new SqlCommand(s_cmd, cn);
                       DataSet ds = new DataSet();
                       SqlDataAdapter da = new SqlDataAdapter(cmd); //methode de select avec methode classique de query
                       da.Fill(ds);
                       dtp = ds.Tables[0];


                   }
                   PassagerDataGridView.DataSource = dtp;
                   etatpassagergrid();
                   cn.Close();

               }
        }

       
        private void PlaceSelectedChanged(object sender, EventArgs e)
        {
            //string value =PlaceComboBox.SelectedItem.ToString();
            var item = (MyListViewItem)PlaceComboBox.SelectedItem;
            if (item != null)
            {

                string key = item.getKey();
                PassagerTableAdapter pta = new PassagerTableAdapter();
                System.Data.DataTable dtp=null;
                if (key == "B") dtp = pta.GetDataByVolIDAndPlace(idvol, "B%");
                if (key == "E") dtp = pta.GetDataByVolIDAndPlace(idvol, "E%");
                if (key == "T") dtp=pta.GetDataByIDVol(idvol);
                PassagerDataGridView.DataSource = dtp;
                etatpassagergrid();
            }
      

            
        }

        private void Revoir_Click(object sender, EventArgs e)
        {
            //string value =PlaceComboBox.SelectedItem.ToString();
            var item = (MyListViewItem)PlaceComboBox.SelectedItem;
            if (item != null)
            {

                string key = item.getKey();
                PassagerTableAdapter pta = new PassagerTableAdapter();
                System.Data.DataTable dtp = null;
                if (key == "B") dtp = pta.GetDataByVolIDAndPlace(idvol, "B%");
                if (key == "E") dtp = pta.GetDataByVolIDAndPlace(idvol, "E%");
                if (key == "T") dtp = pta.GetDataByIDVol(idvol);
                PassagerDataGridView.DataSource = dtp;
                SearchTextBox.Text = "";
                etatpassagergrid();
            }
        }

       

        private void Supprimer_Click(object sender, EventArgs e)
        {

            using (ChoisirCode myForm = new ChoisirCode())
            {


                DialogResult dr = myForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string code = myForm.GetCode();
                    if (code != "")
                    {


                        VolTableAdapter vta = new VolTableAdapter();
                        System.Data.DataTable dt = vta.GetDataByCodeReference(code);
                        if (dt.Rows.Count == 0)
                        {
                            vta.UpdateCodeReferenceByVolID(myForm.GetCode(), idvol);
                            PassagerTableAdapter pta = new PassagerTableAdapter();
                            pta.DeleteByVolID(idvol);
                            LabelRemarque.Text = " Liste Supprimée, Code Référence :" +code;
                            UploadPassagerButton.Enabled = false;
                            PassagerDataGridView.Enabled = false;
                            SearchPanel.Enabled = false;
                            SupprimerPassagerButton.Enabled = false;
                            PassagerDataGridView.DataSource = null;

                            
                        }

                        else
                        {

                            MessageBox.Show("Le Code Référence existe déjà!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }

                    }
                }
                else
                {
                    // ...
                }
            }
            }
        }



}
