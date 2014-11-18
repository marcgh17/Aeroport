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
    public partial class InfoPersonnelMaintenance : Form
    {
        int eqID;
        string dir;
        public InfoPersonnelMaintenance(int eqID, string dir)
        {
            InitializeComponent();
            EquiepMListView.View = View.Tile;
            this.eqID = eqID;
            this.dir = dir;
            listeViewEquipe();
            Equipe_MaintenanceTableAdapter ta= new Equipe_MaintenanceTableAdapter();
            DataTable dt=ta.GetDataByEquipeCode(eqID);
            EquipeMLabel.Text = "N. equipe maintenance: "+dt.Rows[0]["Numero_EquipeM"].ToString();
            string etat = dt.Rows[0]["Etat_Actuel_EquipeM"].ToString();
            if (etat == "D") DisponibiliteLabel.Text = "Disponible";
            if (etat == "O") DisponibiliteLabel.Text = "Occupée";
            
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void listeViewEquipe()
        {
           
            OperationTableAdapter ota = new OperationTableAdapter();
            DataTable odt;
            InfoPersonnelEquipeMaintenanceTableAdapter mta = new InfoPersonnelEquipeMaintenanceTableAdapter();
            DataTable mdt = mta.GetDataByIDEquipeM(eqID);
            SpecialisationTableAdapter sta = new SpecialisationTableAdapter();
            DataTable sdt;
            int[] tab= new int[mdt.Rows.Count];
            for (int i = 0; i < mdt.Rows.Count; ++i)
            {
                tab[i] =Convert.ToInt32( mdt.Rows[i]["ID_PersonnelM"].ToString());
            }
            if (dir == "A")
            {
               odt = ota.GetDataByTypeOperation("A");
               for (int i = 0; i < odt.Rows.Count; ++i)
               {
                   ListViewGroup lg = new ListViewGroup(odt.Rows[i]["Nom_Operation"].ToString());
                   EquiepMListView.Groups.Add(lg);
                   for (int j = 0; j < mdt.Rows.Count; ++j)
                   {
                       sdt=sta.GetDataByIDPersonnelM(tab[j]);
                       for (int k = 0; k < sdt.Rows.Count; ++k)
                       {
                           if (sdt.Rows[k]["Code_Operation"].ToString() == odt.Rows[i]["Code_Operation"].ToString())
                           {
                               ListViewItem li = new MyListViewItem(mdt.Rows[j]["Nom_PersonnelM"].ToString() + "  " + mdt.Rows[j]["Prenom_PersonnelM"].ToString(), EquiepMListView.Groups[i], mdt.Rows[j]["ID_PersonnelM"].ToString());
                               EquiepMListView.Items.Add(li);
                           }
                       }
                      
                   }


               }
            }
            if (dir == "D")
            {
                odt = ota.GetDataByTypeOperation("D");
                for (int i = 0; i < odt.Rows.Count; ++i)
                {
                    ListViewGroup lg = new ListViewGroup(odt.Rows[i]["Nom_Operation"].ToString());
                    EquiepMListView.Groups.Add(lg);
                    for (int j = 0; j < mdt.Rows.Count; ++j)
                    {
                        sdt = sta.GetDataByIDPersonnelM(tab[j]);
                        for (int k = 0; k < sdt.Rows.Count; ++k)
                        {
                            if (sdt.Rows[k]["Code_Operation"].ToString() == odt.Rows[i]["Code_Operation"].ToString())
                            {
                                ListViewItem li = new MyListViewItem(mdt.Rows[j]["Nom_PersonnelM"].ToString() + "  " + mdt.Rows[j]["Prenom_PersonnelM"].ToString(), EquiepMListView.Groups[i], mdt.Rows[j]["ID_PersonnelM"].ToString());
                                EquiepMListView.Items.Add(li);
                            }
                        }
                           
                    }
                }            
            }
            
         
               
            
           
        }
    }
}
