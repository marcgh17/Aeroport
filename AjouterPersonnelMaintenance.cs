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
    public partial class AjouterPersonnelMaintenance : Form
    {
        int pid;
        public AjouterPersonnelMaintenance()
        {
            InitializeComponent();
            OperationsListView.View = View.SmallIcon;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            OperationTableAdapter ota = new OperationTableAdapter();
            DataTable odt = ota.GetData();
            for (int i = 0; i < odt.Rows.Count; ++i)
            {
                ListViewItem li = new MyListViewItem(odt.Rows[i]["Nom_Operation"].ToString(), OperationsListView.Groups[0], odt.Rows[i]["Code_Operation"].ToString());
               OperationsListView.Items.Add(li);

            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {

            string nom = NomTextBox.Text;
            string prenom = PrenomTextBox.Text;
            Personnel_MaintenanceTableAdapter pta = new Personnel_MaintenanceTableAdapter();
            pta.Insert(prenom,nom,Convert.ToDateTime(dateNaissancePicker.Value),Convert.ToDateTime(DateEmbauchePicker.Value),"D");
            DataTable pdt = pta.GetLastEntryByFullInfo(prenom, nom,dateNaissancePicker.Value.ToString(),DateEmbauchePicker.Value.ToString());
           pid = Convert.ToInt32(pdt.Rows[0]["ID_PersonnelM"].ToString());
            SpecialisationTableAdapter sta = new SpecialisationTableAdapter();
            for(int i=0;i<OperationsListView.Items.Count;++i)
            {
               if( OperationsListView.Items[i].Checked)
               {

                   string key = ((MyListViewItem)OperationsListView.Items[i]).getKey();
                   int opid = Convert.ToInt32(key);
                   sta.Insert(pid, opid);

               } 


            }

            MessageBox.Show("Employé ajouté avec succès", "Succès", MessageBoxButtons.OK);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TextBoxesChanged(object sender, EventArgs e)
        {
            
            if (NomTextBox.Text == "" || PrenomTextBox.Text == "") ConfirmButton.Enabled = false;
            else ConfirmButton.Enabled = true;
        }

        public int getID()
        {

            return pid;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
