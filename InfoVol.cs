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
    
    public partial class InfoVol : Form
    {
        
        int idVol;
        string direction;
        int equipeV;
        int equipeM;
        int equm;
        
        public InfoVol(int idVol)
        {
            InitializeComponent();

            EquipeMcomboBox.DisplayMember = "Text";
            EquipeMcomboBox.ValueMember = "key";
            this.idVol = idVol;
            InformationsVolsTableAdapter ta = new InformationsVolsTableAdapter();
            DataTable dt = ta.GetDataByIdVol(idVol);
           
            CompagnieLabel.Text = dt.Rows[0]["Nom_Compagnie"].ToString();
            string avion= dt.Rows[0]["Code_Avion"].ToString();
            InfoAvionEtTypeTableAdapter ata=new InfoAvionEtTypeTableAdapter();
            DataTable adt=ata.GetDataByCodeAvion(avion);
            AvionLabel.Text = adt.Rows[0]["Nom_Type"].ToString() + " ( " + dt.Rows[0]["Code_Avion"].ToString()+ " )";
            string codeVsource = dt.Rows[0]["Code_Ville_Source"].ToString();
            if (codeVsource == "PAR") direction = "D";
            string codeVdestination = dt.Rows[0]["Code_Ville_Destination"].ToString();
            if (codeVdestination == "PAR") direction = "A";
            VilleTableAdapter vta=new VilleTableAdapter();
            DataTable vdt1=vta.GetDataByCodeVille(codeVsource);
            DataTable vdt2=vta.GetDataByCodeVille(codeVdestination);

            VilleArriveeLabel.Text= vdt1.Rows[0]["Nom_Ville"].ToString();
            VilleDepartLabel.Text=vdt2.Rows[0]["Nom_Ville"].ToString();
            string ce = dt.Rows[0]["Code_EquipeM"].ToString();
            equipeM = Convert.ToInt32(ce);
            equm = equipeM;
            Equipe_MaintenanceTableAdapter Mta = new Equipe_MaintenanceTableAdapter();
            DataTable mdt = Mta.GetDataByEquipeCode(equipeM);
            EquipeMaintenanceLabel.Text = mdt.Rows[0]["Numero_EquipeM"].ToString();
            equipeV = Convert.ToInt32(dt.Rows[0]["Code_EquipeV"].ToString());
            Equipe_VolTableAdapter evta = new Equipe_VolTableAdapter();
            DataTable evdt = evta.GetDataByEquipeID(equipeV);
            EquipeVolLabel.Text = evdt.Rows[0]["Numero_EquipeV"].ToString();
            ComboBoxEquipeVolLoad(direction);
            for (int j = 0; j < EquipeMcomboBox.Items.Count; ++j)
            {
                int key = Convert.ToInt32(((MyListViewItem)(EquipeMcomboBox.Items[j])).getKey());
                if (key == equipeM)
                {
                    EquipeMcomboBox.SelectedIndex = j;
                    EquipeMcomboBox_SelectedIndexChanged(this, EventArgs.Empty);
                    break;
                }
            }

            if (direction == "D")
            {
                DateTextLabel.Text = "Date et heure départ";
                DateLabel.Text = dt.Rows[0]["Date_Depart_Vol"].ToString();
                DateEventuelleTextLabel.Text="Date et heure eventuelles départ";
                DateEvLabel.Text = dt.Rows[0]["Date_Depart_Eventuelle_Vol"].ToString();
                if (DateEvLabel.Text == "") DateEvLabel.Text = "--";
                DatePrevueTextLabel.Text = "Date et heure prévues départ";

                DateTime dateprevue = Convert.ToDateTime(dt.Rows[0]["Date_Depart_Vol"].ToString()).AddMinutes(Convert.ToInt32(dt.Rows[0]["Retard_Vol"].ToString()));
                DatePrevueLabel.Text =dateprevue.ToString();
            
                
            }
            if (direction == "A")
            {
                DateTextLabel.Text = "Date et heure arrivée";
                DateLabel.Text = dt.Rows[0]["Date_Arrivee_Vol"].ToString();
                DateEventuelleTextLabel.Text = "Date et heure eventuelles arrivée";
                DateEvLabel.Text = dt.Rows[0]["Date_Arrivee_Eventuelle_Vol"].ToString();
                if (DateEvLabel.Text == "") DateEvLabel.Text = "--";
                DatePrevueTextLabel.Text = "Date et heure prévues arrivée";
                DateTime dateprevue = Convert.ToDateTime(dt.Rows[0]["Date_Arrivee_Vol"].ToString()).AddMinutes(Convert.ToInt32(dt.Rows[0]["Retard_Vol"].ToString()));
                DatePrevueLabel.Text =dateprevue.ToString();
            }

            labelNumVolDate.Text = dt.Rows[0]["Code_Compagnie"].ToString() + dt.Rows[0]["Numero_VolProgramme"].ToString() + "   -   " +(Convert.ToDateTime(DateLabel.Text)).ToShortDateString();
            listViewItems();
            compagnieLogo();
         

        }
        void listViewItems()
        {
            InfosMembresEquipeVolTableAdapter ta = new InfosMembresEquipeVolTableAdapter();
            DataTable hdt = ta.GetDataByEquipeVIDAndRole(equipeV, "H");
            DataTable sdt = ta.GetDataByEquipeVIDAndRole(equipeV, "S");
            DataTable pdt = ta.GetDataByEquipeVIDAndRole(equipeV, "P");
            
            for (int i=0;i<hdt.Rows.Count;++i)
            {
                ListViewItem li = new MyListViewItem(hdt.Rows[i]["Nom_PersonnelV"].ToString()+"  "+hdt.Rows[i]["Prenom_PersonnelV"].ToString(), EquipeVolListView.Groups[1],hdt.Rows[i]["ID_PersonnelV"].ToString());             
                EquipeVolListView.Items.Add(li);
              
            }
            for (int i = 0; i < sdt.Rows.Count; ++i)
            {
                ListViewItem li = new MyListViewItem(sdt.Rows[i]["Nom_PersonnelV"].ToString()+"  "+sdt.Rows[i]["Prenom_PersonnelV"].ToString(), EquipeVolListView.Groups[2],sdt.Rows[i]["ID_PersonnelV"].ToString());               
                EquipeVolListView.Items.Add(li);
               
            }
            for (int i = 0; i < pdt.Rows.Count; ++i)
            {
                 ListViewItem li = new MyListViewItem(pdt.Rows[i]["Nom_PersonnelV"].ToString()+"  "+pdt.Rows[i]["Prenom_PersonnelV"].ToString(), EquipeVolListView.Groups[0],pdt.Rows[i]["ID_PersonnelV"].ToString());               
                EquipeVolListView.Items.Add(li);                
            }
            
            
            EquipeVolListView.View = View.Tile;
        }
        void compagnieLogo()
        {
            InformationsVolsTableAdapter ta = new InformationsVolsTableAdapter();
            DataTable dt = ta.GetDataByIdVol(idVol);

            string logourl = dt.Rows[0]["Logo_Compagnie"].ToString();
            logourl = "../.." + logourl.Substring(1, logourl.Length - 1);
            CompagnieLogoPictureBox.Image = (Image.FromFile(logourl)).GetThumbnailImage(150, 25, null, IntPtr.Zero);
        }

        private void PersonnelMaintenanceButton_Click(object sender, EventArgs e)
        {
            InfoPersonnelMaintenance pm = new InfoPersonnelMaintenance(equipeM, direction);
            pm.Text = labelNumVolDate.Text;
            pm.Show();
    

        }

        private void EquipeVolListView_DoubleClick(object sender, EventArgs e)
        {
            MyListViewItem li = (MyListViewItem)EquipeVolListView.SelectedItems[0];
            string key = li.getKey();
            InfoPersonnelVol ipv = new InfoPersonnelVol(Convert.ToInt32(key));
            ipv.Show();

           
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
           
           VolTableAdapter vvta= new VolTableAdapter();
                DialogResult result = MessageBox.Show("êtes-vous sûr de vouloir modifier l'equipe de maintenance de ce vol", "Changer Equipe de Maintenance", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                  
                        vvta.UpdateCodeEquipeMByVolID(equm,idVol);
                        equipeM = equm;
                        Equipe_MaintenanceTableAdapter Mta = new Equipe_MaintenanceTableAdapter();
                        DataTable mdt = Mta.GetDataByEquipeCode(equipeM);
                        EquipeMaintenanceLabel.Text = mdt.Rows[0]["Numero_EquipeM"].ToString();
                  
                }
            }
        

        private void VoirPersonnelButton_Click(object sender, EventArgs e)
        {

            if (equipeM!= 0)
            {
                InfoPersonnelMaintenance ipm = new InfoPersonnelMaintenance(equm, direction);
                ipm.Show();
            }
        }
        private void EquipeMcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = ((MyListViewItem)EquipeMcomboBox.SelectedItem).getKey();
            equm = (Convert.ToInt32(key));
            Equipe_MaintenanceTableAdapter ta = new Equipe_MaintenanceTableAdapter();
            DataTable dt = ta.GetDataByEquipeCode(equm);
            string etat = dt.Rows[0]["Etat_Actuel_EquipeM"].ToString();
            if (etat == "D") DisponibiliteLabel.Text = "Disponible";
            if (etat == "O") DisponibiliteLabel.Text = "Occupée";
        }


        private void CreezUneNouvelleEquipe_Click(object sender, EventArgs e)
        {
            using (CreerEquipeMaintenance myForm = new CreerEquipeMaintenance(direction))
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
