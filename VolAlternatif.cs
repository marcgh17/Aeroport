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
    public partial class VolAlternatif : Form
    {
        int idVol;
        string villeS;
        string villeD;
        DateTime dateDepart;
        string codeAvion;
        string codeCompagnie;
        int duree;
        int volprog;
        int equipeV;
        int equipeM;

        public VolAlternatif(int idVol)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.idVol = idVol;
            InformationsVolsTableAdapter vta = new InformationsVolsTableAdapter();
            DataTable vdt = vta.GetDataByIdVol(idVol);
            dateDepart = Convert.ToDateTime(vdt.Rows[0]["Date_Depart_Vol"].ToString());
            codeAvion = vdt.Rows[0]["Code_Avion"].ToString();
            CompagnieLabel.Text = vdt.Rows[0]["Nom_Compagnie"].ToString();
            villeS = vdt.Rows[0]["Code_Ville_Source"].ToString();
            villeD = vdt.Rows[0]["Code_Ville_Destination"].ToString();
            equipeM = Convert.ToInt32(vdt.Rows[0]["Code_EquipeM"].ToString());
            equipeV = Convert.ToInt32(vdt.Rows[0]["Code_EquipeV"].ToString());
            duree=Convert.ToInt32(vdt.Rows[0]["Duree_VolProgramme"].ToString());
            volprog = Convert.ToInt32(vdt.Rows[0]["ID_VolProgramme"].ToString());
            VilleTableAdapter villeta = new VilleTableAdapter();
            DataTable sourcedt = villeta.GetDataByCodeVille(villeS);
            DataTable destdt = villeta.GetDataByCodeVille(villeD);
            VilleSourceLabel.Text = sourcedt.Rows[0]["Nom_Ville"].ToString();
            VilleDestinationLabel.Text = destdt.Rows[0]["Nom_Ville"].ToString();
            dateTimePicker1.Value = dateDepart;
            string logourl = vdt.Rows[0]["Logo_Compagnie"].ToString();
            logourl = "../.." + logourl.Substring(1, logourl.Length - 1);
            CompagnieLogoPictureBox.Image = (Image.FromFile(logourl)).GetThumbnailImage(150, 25, null, IntPtr.Zero);
            CompagnieLabel.Text = vdt.Rows[0]["Nom_Compagnie"].ToString();
            codeCompagnie = vdt.Rows[0]["Code_Compagnie"].ToString();
            AvionTableAdapter ta = new AvionTableAdapter();
            DataTable dt = ta.GetDataByCodeCompagnie(codeCompagnie);
            InfoAvionEtTypeTableAdapter ita = new InfoAvionEtTypeTableAdapter();
            AvionComboBox.DisplayMember = "Text";
            AvionComboBox.ValueMember = "key";
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                codeAvion = dt.Rows[i]["Code_Avion"].ToString();
                DataTable idt = ita.GetDataByCodeAvion(codeAvion);
                AvionComboBox.Items.Add(new MyListViewItem(codeAvion, idt.Rows[0]["Nom_Type"].ToString() + " ( " + codeAvion + " )"));
            }
            NumeroVolLabel.Text = "N. Vol: " + vdt.Rows[0]["Numero_VolProgramme"].ToString();
            AvionComboBox.SelectedIndex = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            VolTableAdapter ta = new VolTableAdapter();
            DateTime h = dateTimePicker1.Value;
            string av = ((MyListViewItem)AvionComboBox.SelectedItem).getKey();
            ta.Insert(h,h.AddMinutes(duree),null,null,"EA",0,null,volprog,av,equipeV,equipeM);
            if (TransfercheckBox.Checked == true)
            {

                PassagerTableAdapter pta = new PassagerTableAdapter();
                DataTable pdt = pta.GetDataByIDVol(idVol);
                int newvolid = Convert.ToInt32(ta.GetLastInsertedVolID());
                for (int i = 0; i < pdt.Rows.Count; ++i)
                {
                    int idpass=Convert.ToInt32(pdt.Rows[i]["ID_Passager"].ToString());
                    pta.UpdateVolID(newvolid, idpass);
                   
                }
                DialogResult dia = MessageBox.Show("Vous avez créé un nouveau vol et transferé " + pdt.Rows.Count.ToString() + " passagers!", "Nouveau Vol", MessageBoxButtons.OK);
                Close();

            }
            else
            {
                DialogResult dia = MessageBox.Show("Vous avez créé un nouveau vol!", "Nouveau Vol", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
