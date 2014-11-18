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
    public partial class ModifierPersonnelMaintenance : Form
    {
        int PersonnelID;
        public ModifierPersonnelMaintenance(int pid)
        {
            InitializeComponent();
            PersonnelID=pid;
            OperationsListView.View = View.SmallIcon;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
            Personnel_MaintenanceTableAdapter pta = new Personnel_MaintenanceTableAdapter();
            DataTable pdt = pta.GetDataByIDPersonnelM(PersonnelID);
            string nom = pdt.Rows[0]["Nom_PersonnelM"].ToString();
            string prenom = pdt.Rows[0]["Prenom_PersonnelM"].ToString();
            string datenaissance = pdt.Rows[0]["Date_Naissance_PersonnelM"].ToString();
            string dateembauche = pdt.Rows[0]["Date_Embauche_PersonnelM"].ToString();
            NomTextBox.Text = nom;
            PrenomTextBox.Text = prenom;
            dateNaissancePicker.Value = Convert.ToDateTime(datenaissance);
            DateEmbauchePicker.Value = Convert.ToDateTime(dateembauche);

            SpecialisationTableAdapter sta = new SpecialisationTableAdapter();
            DataTable sdt;
            OperationTableAdapter ota = new OperationTableAdapter();
            DataTable odt = ota.GetData();
            for (int i = 0; i < odt.Rows.Count; ++i)
            {
                int codeop= Convert.ToInt32(odt.Rows[i]["Code_Operation"].ToString());
                ListViewItem li = new MyListViewItem(odt.Rows[i]["Nom_Operation"].ToString(), OperationsListView.Groups[0], odt.Rows[i]["Code_Operation"].ToString());
                OperationsListView.Items.Add(li);
                sdt=sta.GetDataByCodeOperationAndIDPersonnelM(PersonnelID,codeop);
                if (sdt.Rows.Count>0)
                    li.Checked=true;


            }


        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Personnel_MaintenanceTableAdapter pta = new Personnel_MaintenanceTableAdapter();
            pta.UpdateEmploye(PrenomTextBox.Text,NomTextBox.Text,dateNaissancePicker.Value.ToString(),DateEmbauchePicker.Value.ToString(),PersonnelID);
            SpecialisationTableAdapter sta = new SpecialisationTableAdapter();
            sta.DeleteByPersonnelID(PersonnelID);
            for (int i = 0; i < OperationsListView.Items.Count; ++i)
            {
                if (OperationsListView.Items[i].Checked)
                {

                    string key = ((MyListViewItem)OperationsListView.Items[i]).getKey();
                    int opid = Convert.ToInt32(key);
                    sta.Insert(PersonnelID, opid);

                }


            }

            MessageBox.Show("Employé modifié avec succès", "Succès", MessageBoxButtons.OK);
            DialogResult = DialogResult.OK;
            Close(); 


        }
        public int getID()
        {
            return PersonnelID;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
