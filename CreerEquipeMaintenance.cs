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
    
    public partial class CreerEquipeMaintenance : Form
    {
        string dir;
        DataTable newteam;
        public CreerEquipeMaintenance(string direction )
        {
            InitializeComponent();
            newteam = new DataTable();
            TypeComboBox.Items.Add(new MyListViewItem("D", "Départ"));
            TypeComboBox.Items.Add(new MyListViewItem("A", "Arriveé"));
            TypeComboBox.DisplayMember = "Text";
            TypeComboBox.ValueMember = "key";
            AddButton.Enabled = false;
            RemoveButton.Enabled = false;
            DataColumn d1=new DataColumn("ID_PersonnelM");
            DataColumn d2 = new DataColumn("Nom_PersonnelM");
            DataColumn d3 = new DataColumn("Prenom_PersonnelM");
            newteam.Columns.Add(d1);
            newteam.Columns.Add(d2);
            newteam.Columns.Add(d3);
            if (direction == null)
            {
                PersonnelMListView.Enabled = false;
                NewEquipeListView.Enabled = false;
            }
            else
            {
                dir = direction;
                if (dir == "D") TypeComboBox.SelectedIndex = 0;
                if (dir == "A") TypeComboBox.SelectedIndex = 1;
                TypeComboBox.Enabled = false;
                ConfirmerButton.Enabled = false;

                AddButton.Enabled = true;
                RemoveButton.Enabled = true;
            }
           
          


       
            PersonnelMListView.View = View.Tile;
            NewEquipeListView.View = View.Tile;
            
        }


        protected void FillPersonnel()
        {
            
            Personnel_MaintenanceTableAdapter ta = new Personnel_MaintenanceTableAdapter();
            DataTable dt = ta.GetData();
            OperationTableAdapter ota = new OperationTableAdapter();
            DataTable odt;
            SpecialisationTableAdapter sta = new SpecialisationTableAdapter();
            DataTable sd;

           
            if (dir == "A")
            {
                odt = ota.GetDataByTypeOperation("A");
                for (int i = 0; i < odt.Rows.Count; ++i)
                {
                    int codeop = Convert.ToInt32(odt.Rows[i]["Code_Operation"].ToString());
                    ListViewGroup lg = new ListViewGroup(odt.Rows[i]["Nom_Operation"].ToString());
                    PersonnelMListView.Groups.Add(lg);
                    for (int j = 0;j < dt.Rows.Count;++j )
                    {
                        int codeper= Convert.ToInt32(dt.Rows[j]["ID_PersonnelM"].ToString());
                        sd=sta.GetDataByCodeOperationAndIDPersonnelM(codeper,codeop);
                        if (sd.Rows.Count>0)
                        {
                            ListViewItem li = new MyListViewItem(dt.Rows[j]["Nom_PersonnelM"].ToString() + "  " + dt.Rows[j]["Prenom_PersonnelM"].ToString(), PersonnelMListView.Groups[i], codeper.ToString());
                            PersonnelMListView.Items.Add(li);
                        }

                    }
                  

                }
            }
            if (dir == "D")
            {
                odt = ota.GetDataByTypeOperation("D");
                int l = odt.Rows.Count;
                for (int i = 0; i < odt.Rows.Count; ++i)
                {
                    int codeop = Convert.ToInt32(odt.Rows[i]["Code_Operation"].ToString());
                    ListViewGroup lg = new ListViewGroup(odt.Rows[i]["Nom_Operation"].ToString());
                    PersonnelMListView.Groups.Add(lg);
                    for (int j = 0; j < dt.Rows.Count; ++j)
                    {
                        int codeper = Convert.ToInt32(dt.Rows[j]["ID_PersonnelM"].ToString());
                        sd = sta.GetDataByCodeOperationAndIDPersonnelM(codeper, codeop);
                        if (sd.Rows.Count > 0)
                        {
                            ListViewItem li = new MyListViewItem(dt.Rows[j]["Nom_PersonnelM"].ToString() + "  " + dt.Rows[j]["Prenom_PersonnelM"].ToString(), PersonnelMListView.Groups[i], codeper.ToString());
                            PersonnelMListView.Items.Add(li);
                        }

                    }


                }
            }
            
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonnelMListView.Items.Clear();
            PersonnelMListView.Groups.Clear();
            FillPersonnel();
        }

        private void ConfirmerButton_Click(object sender, EventArgs e)
        {

            TypeComboBox.Enabled = false;
            ConfirmerButton.Enabled = false;
            dir = ((MyListViewItem)TypeComboBox.SelectedItem).getKey();
            PersonnelMListView.Enabled = true;
            NewEquipeListView.Enabled = true;
            RemoveButton.Enabled = true;
            AddButton.Enabled = true;
            PersonnelMListView.Items.Clear();
            PersonnelMListView.Groups.Clear();
            FillPersonnel();


        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (NewEquipeListView.SelectedItems.Count>0)
            {

                int idpers = Convert.ToInt32(((MyListViewItem)(NewEquipeListView.SelectedItems[0])).getKey());
                for (int i = 0; i < newteam.Rows.Count; ++i)
                {
                    if (newteam.Rows[i]["ID_PersonnelM"].ToString() == idpers.ToString())
                    {
                        newteam.Rows.RemoveAt(i);
                        i = i - 1;
                        for (int j = 0; j < PersonnelMListView.Items.Count; ++j)


                            if (((MyListViewItem)(PersonnelMListView.Items[j])).getKey() == idpers.ToString())
                            {
                                PersonnelMListView.Items[j].ForeColor = Color.Black;
                            }
                    }

                }
                UpdateNewTeam();
            }
                }
    
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(PersonnelMListView.SelectedItems.Count>0)
            {
                if (PersonnelMListView.SelectedItems[0].ForeColor != Color.Red)
                {
                    int idpers = Convert.ToInt32(((MyListViewItem)(PersonnelMListView.SelectedItems[0])).getKey());
                    PersonnelMListView.SelectedItems[0].ForeColor = Color.Red;
                    for (int i=0;i<PersonnelMListView.Items.Count;++i)
                    {
                        int idpers2=Convert.ToInt32(((MyListViewItem)(PersonnelMListView.Items[i])).getKey());
                        if (idpers2 == idpers) PersonnelMListView.Items[i].ForeColor = Color.Red;
                    }
                    Personnel_MaintenanceTableAdapter pta = new Personnel_MaintenanceTableAdapter();
                    DataTable pdt = pta.GetDataByIDPersonnelM(idpers);
                    string nom = pdt.Rows[0]["Nom_PersonnelM"].ToString();
                    string prenom = pdt.Rows[0]["Prenom_PersonnelM"].ToString();
                    DataRow dr = newteam.NewRow();

                    dr["ID_PersonnelM"] = idpers.ToString();
                    dr["Nom_PersonnelM"] = nom.ToString();
                    dr["Prenom_PersonnelM"] = prenom.ToString();
                    newteam.Rows.Add(dr);
                    UpdateNewTeam();
                }


            }
        }

        protected void UpdateNewTeam()
    {
            DataTable dt = newteam;
            NewEquipeListView.Items.Clear();
            NewEquipeListView.Groups.Clear();
            OperationTableAdapter ota = new OperationTableAdapter();
            DataTable odt;
            SpecialisationTableAdapter sta = new SpecialisationTableAdapter();
            DataTable sd;

           
            if (dir == "A")
            {
                odt = ota.GetDataByTypeOperation("A");
                for (int i = 0; i < odt.Rows.Count; ++i)
                {
                    int codeop = Convert.ToInt32(odt.Rows[i]["Code_Operation"].ToString());
                    ListViewGroup lg = new ListViewGroup(odt.Rows[i]["Nom_Operation"].ToString());
                    NewEquipeListView.Groups.Add(lg);
                    for (int j = 0;j < dt.Rows.Count;++j )
                    {
                        int codeper= Convert.ToInt32(dt.Rows[j]["ID_PersonnelM"].ToString());
                        sd=sta.GetDataByCodeOperationAndIDPersonnelM(codeper,codeop);
                        if (sd.Rows.Count>0)
                        {
                            ListViewItem li = new MyListViewItem(dt.Rows[j]["Nom_PersonnelM"].ToString() + "  " + dt.Rows[j]["Prenom_PersonnelM"].ToString(), NewEquipeListView.Groups[i], codeper.ToString());
                            NewEquipeListView.Items.Add(li);
                        }

                    }
                  

                }
            }
            if (dir == "D")
            {
                odt = ota.GetDataByTypeOperation("D");
                int l = odt.Rows.Count;
                for (int i = 0; i < odt.Rows.Count; ++i)
                {
                    int codeop = Convert.ToInt32(odt.Rows[i]["Code_Operation"].ToString());
                    ListViewGroup lg = new ListViewGroup(odt.Rows[i]["Nom_Operation"].ToString());
                    NewEquipeListView.Groups.Add(lg);
                    for (int j = 0; j < dt.Rows.Count; ++j)
                    {
                        int codeper = Convert.ToInt32(dt.Rows[j]["ID_PersonnelM"].ToString());
                        sd = sta.GetDataByCodeOperationAndIDPersonnelM(codeper, codeop);
                        if (sd.Rows.Count > 0)
                        {
                            ListViewItem li = new MyListViewItem(dt.Rows[j]["Nom_PersonnelM"].ToString() + "  " + dt.Rows[j]["Prenom_PersonnelM"].ToString(), NewEquipeListView.Groups[i], codeper.ToString());
                            NewEquipeListView.Items.Add(li);
                        }

                    }


                }
            }

    }

        private void ConfirmerEquipeButton_Click(object sender, EventArgs e)
        {
            if (NumeroTextBox.Text=="")
            {
                MessageBox.Show("Veuillez choisir le numéro de l'équipe", " Attention", MessageBoxButtons.OK);
            }

            else
            {

                string num = NumeroTextBox.Text;
                Equipe_MaintenanceTableAdapter eta = new Equipe_MaintenanceTableAdapter();
                DataTable edt = eta.GetDataByNumeroEquipe(num);
                if(edt.Rows.Count>0)
                {
                    MessageBox.Show("Veuillez choisir un autre numéro d'équipe", " Numéro équipe existe déja!", MessageBoxButtons.OK);
                }

                else
                {

                    eta.Insert(num, dir, "D");
                    DataTable edt2 = eta.GetDataByNumeroEquipe(num);
                    int codeequ = Convert.ToInt32(edt2.Rows[0]["ID_EquipeM"].ToString());
                    MembreMTableAdapter mta = new MembreMTableAdapter();
                    for (int i=0;i<newteam.Rows.Count;++i)
                    {
                        mta.Insert(Convert.ToInt32(newteam.Rows[i]["ID_PersonnelM"].ToString()), codeequ);
                    }
                    MessageBox.Show("Equipe créée avec succès!", "Succès!", MessageBoxButtons.OK);
                    DialogResult = DialogResult.OK;
                    {
                        Master_Form mf = (Master_Form)Application.OpenForms.OfType<Master_Form>().ElementAt(0);
                        TabPage test = mf.MainTabControl.TabPages["CEM"];
                        if (test!=null)
                        {
                            test.Dispose();
                        }
                        
                    }
                    Close();
                }
            }
        }


        public string getDirection()
        {
            return dir;
        }
    }
}
