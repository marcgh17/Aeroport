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
    public partial class PersonnelMaintenance : Form
    {
   
        public PersonnelMaintenance()
        {
            InitializeComponent();
            InfolistView.View=View.Tile;
            PersonnelMDataGridView.AutoGenerateColumns = false;
            Equipe_MaintenanceTableAdapter eta = new Equipe_MaintenanceTableAdapter();
            DataTable edt= eta.GetData();
            EquipeComboBox.DisplayMember = "Text";
            EquipeComboBox.ValueMember = "key";
              EquipeComboBox.Items.Add(new MyListViewItem("T", "Tout"));
             for (int i=0;i<edt.Rows.Count;++i)
             {
            EquipeComboBox.Items.Add( new MyListViewItem(edt.Rows[i]["ID_EquipeM"].ToString(),edt.Rows[i]["Numero_EquipeM"].ToString()));
             }
            
            


            OperationTableAdapter ota = new OperationTableAdapter();
            DataTable odt = ota.GetData();
             SpecialisationComboBox.DisplayMember = "Text";
             SpecialisationComboBox.ValueMember = "key";
             SpecialisationComboBox.Items.Add(new MyListViewItem("T", "Tout"));
            for (int i = 0; i < odt.Rows.Count; ++i)
            {
                SpecialisationComboBox.Items.Add(new MyListViewItem(odt.Rows[i]["Code_Operation"].ToString(), odt.Rows[i]["Nom_Operation"].ToString()));
            }
            EquipeComboBox.SelectedIndex = 0;
            SpecialisationComboBox.SelectedIndex = 0;

            Personnel_MaintenanceTableAdapter pta = new Personnel_MaintenanceTableAdapter();
            DataTable mdt = pta.GetData();
            PersonnelMDataGridView.DataSource = mdt;
         

        }

        private void EquipeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string equ = ((MyListViewItem)(EquipeComboBox.SelectedItem)).getKey();
            string op = "";
             if (SpecialisationComboBox.SelectedItem==null)
            {
                op = "T";
            }
             else
             {
                op = ((MyListViewItem)(SpecialisationComboBox.SelectedItem)).getKey();

             }

            if(op=="T" && equ=="T")
            {
                Personnel_MaintenanceTableAdapter pta = new Personnel_MaintenanceTableAdapter();
                DataTable mdt = pta.GetData();
                PersonnelMDataGridView.DataSource = mdt;
            }

            if(op=="T" && equ!="T")
            {
                InfoPersonnelEquipeMaintenanceTableAdapter pta = new InfoPersonnelEquipeMaintenanceTableAdapter();
                DataTable mdt = pta.GetDataByIDEquipeM(Convert.ToInt32(equ));
                PersonnelMDataGridView.DataSource = mdt;
            }

            if (op != "T" && equ == "T")
            {
                InfoPersonnelSpecialisationTableAdapter pta = new InfoPersonnelSpecialisationTableAdapter();
                DataTable mdt = pta.GetDataByCodeOperation(Convert.ToInt32(op));
                PersonnelMDataGridView.DataSource = mdt;
            }

            if (op != "T" && equ != "T")
            {
                InfoPersonnelEquipeMaintenanceTableAdapter pta = new InfoPersonnelEquipeMaintenanceTableAdapter();
                DataTable mdt = pta.GetDataByIDEquipeM(Convert.ToInt32(equ));
                DataTable fmdt = mdt.Clone();
                fmdt.Clear();
                SpecialisationTableAdapter sta = new SpecialisationTableAdapter();
                for (int i = 0; i < mdt.Rows.Count; ++i)
                {
                    int pid = Convert.ToInt32(mdt.Rows[i]["ID_PersonnelM"].ToString()); ;
                    DataTable x = sta.GetDataByCodeOperationAndIDPersonnelM(pid, Convert.ToInt32(op));
                    if (x.Rows.Count > 0)
                    { fmdt.ImportRow(mdt.Rows[i]); }
                }
                PersonnelMDataGridView.DataSource = fmdt;


            }




          






           
        }

        private void SpecialisationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string equ = ((MyListViewItem)(EquipeComboBox.SelectedItem)).getKey();
            string op = ((MyListViewItem)(SpecialisationComboBox.SelectedItem)).getKey();
            if (op == "T" && equ == "T")
            {
                Personnel_MaintenanceTableAdapter pta = new Personnel_MaintenanceTableAdapter();
                DataTable mdt = pta.GetData();
                PersonnelMDataGridView.DataSource = mdt;
            }

            if (op == "T" && equ != "T")
            {
                InfoPersonnelEquipeMaintenanceTableAdapter pta = new InfoPersonnelEquipeMaintenanceTableAdapter();
                DataTable mdt = pta.GetDataByIDEquipeM(Convert.ToInt32(equ));
                PersonnelMDataGridView.DataSource = mdt;
            }

                    if (op != "T" && equ == "T")
                    {
                        InfoPersonnelSpecialisationTableAdapter pta = new InfoPersonnelSpecialisationTableAdapter();
                        DataTable mdt = pta.GetDataByCodeOperation(Convert.ToInt32(op));
                        PersonnelMDataGridView.DataSource = mdt;
                    }

              if (op != "T" && equ != "T")
            {
                InfoPersonnelEquipeMaintenanceTableAdapter pta = new InfoPersonnelEquipeMaintenanceTableAdapter();
                DataTable mdt = pta.GetDataByIDEquipeM(Convert.ToInt32(equ));
                DataTable fmdt= mdt.Clone();
                  fmdt.Clear();
                  SpecialisationTableAdapter sta = new SpecialisationTableAdapter();
                  for (int i = 0; i < mdt.Rows.Count;++i )
                  {
                      int pid = Convert.ToInt32(mdt.Rows[i]["ID_PersonnelM"].ToString()); ;
                      DataTable x= sta.GetDataByCodeOperationAndIDPersonnelM(pid,Convert.ToInt32(op));
                      if(x.Rows.Count>0)
                      { fmdt.ImportRow(mdt.Rows[i]); }
                  }
                  PersonnelMDataGridView.DataSource = fmdt;


            }


        }

        private void AjouterButton_Click(object sender, EventArgs e)
        {

            using (AjouterPersonnelMaintenance myForm = new AjouterPersonnelMaintenance())
            {


                DialogResult dr = myForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    SpecialisationComboBox.SelectedItem = 0;
                    EquipeComboBox.SelectedItem = 0;
                    SpecialisationComboBox_SelectedIndexChanged(this, EventArgs.Empty);
                    int newpid= myForm.getID();
                    for (int i=0;i<PersonnelMDataGridView.Rows.Count;++i)
                    {
                        int pid = Convert.ToInt32(PersonnelMDataGridView.Rows[i].Cells["ID_PersonnelM"].Value);
                        
                        if (pid == newpid) PersonnelMDataGridView.Rows[i].Selected=true;
                        else PersonnelMDataGridView.Rows[i].Selected = false;


                    }
                }

            }
        }

        private void EmploteChanged(object sender, EventArgs e)
        {
            InfolistView.Items.Clear();
            int pid;
            if (PersonnelMDataGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = PersonnelMDataGridView.SelectedRows[0];
                pid = Convert.ToInt32(selectedRow.Cells["ID_PersonnelM"].Value);
                NomPrenomLabel.Text = selectedRow.Cells["Nom"].Value.ToString() + " " + selectedRow.Cells["Prenom"].Value.ToString();
                Personnel_MaintenanceTableAdapter pta = new Personnel_MaintenanceTableAdapter();
                DataTable ptt = pta.GetDataByIDPersonnelM(pid);
                string etat = ptt.Rows[0]["Etat_Actuel_PersonnelM"].ToString();
                if (etat== "D") DisponibiliteLabel.Text = "Employé Disponible";
                if (etat=="O") DisponibiliteLabel.Text = "Employé Occupé";
                SpecialisationTableAdapter sta = new SpecialisationTableAdapter();
                DataTable sdt = sta.GetDataByIDPersonnelM(pid);
                for (int i = 0; i < sdt.Rows.Count; ++i)
                {

                    OperationTableAdapter ota = new OperationTableAdapter();
                    DataTable odt = ota.GetDataByCodeOperation(Convert.ToInt32(sdt.Rows[i]["Code_Operation"].ToString()));
                    ListViewItem li = new MyListViewItem(odt.Rows[0]["Nom_Operation"].ToString(), InfolistView.Groups[0], sdt.Rows[i]["Code_Operation"].ToString());
                    InfolistView.Items.Add(li);

                }

                InfoPersonnelEquipeMaintenanceTableAdapter ipta = new InfoPersonnelEquipeMaintenanceTableAdapter();
                DataTable ipdt = ipta.GetDataByIDPersonnelM(pid);
                for (int j = 0; j < ipdt.Rows.Count; ++j)
                {
                    ListViewItem li = new MyListViewItem(ipdt.Rows[j]["ID_EquipeM"].ToString(), InfolistView.Groups[1], ipdt.Rows[j]["Numero_EquipeM"].ToString());
                    InfolistView.Items.Add(li);

                }

            }
        }

        private void ModifiyButton_Click(object sender, EventArgs e)
        {
            if(PersonnelMDataGridView.SelectedRows.Count>0)
            {

                int pid = Convert.ToInt32(PersonnelMDataGridView.Rows[PersonnelMDataGridView.SelectedRows[0].Index].Cells["ID_PersonnelM"].Value);
                using (ModifierPersonnelMaintenance myForm = new ModifierPersonnelMaintenance(pid))
                {


                    DialogResult dr = myForm.ShowDialog();
                    if (dr == DialogResult.OK)
                    
                    {
                        SpecialisationComboBox.SelectedItem = 0;
                        EquipeComboBox.SelectedItem = 0;
                        SpecialisationComboBox_SelectedIndexChanged(this, EventArgs.Empty);
                        
                        for (int i = 0; i < PersonnelMDataGridView.Rows.Count; ++i)
                        {
                            int cpid = Convert.ToInt32(PersonnelMDataGridView.Rows[i].Cells["ID_PersonnelM"].Value);

                            if (cpid == pid) PersonnelMDataGridView.Rows[i].Selected = true;
                            else PersonnelMDataGridView.Rows[i].Selected = false;


                        }
                    }

                }
            }
        }
    }
}
