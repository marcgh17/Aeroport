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
    public partial class Maintenance : Form
    {
        int idVol;
        string dir;// determine le type du rapport
        int equipeM;
        Label[] l;
        TextBox[] t;
        TableLayoutPanel[] p;
        int N;
        public Maintenance(int idVol, string dir)
        {
            InitializeComponent();
            this.idVol = idVol;
            this.dir = dir;
            ChangerEtats(idVol,"O");
            
            VolTableAdapter ta= new VolTableAdapter();
            DataTable dt=ta.GetDataByVolID(idVol);
            Vol_ProgrammeTableAdapter vta = new Vol_ProgrammeTableAdapter();
            DataTable vdt = vta.GetDataByVolProgrammeID(Convert.ToInt32(dt.Rows[0]["ID_VolProgramme"].ToString()));
            equipeM =Convert.ToInt32(dt.Rows[0]["Code_EquipeM"].ToString());
            Equipe_MaintenanceTableAdapter eta = new Equipe_MaintenanceTableAdapter();
            DataTable edt = eta.GetDataByEquipeCode(equipeM);
            EquipeMaintenanceLabel.Text="Numéro équipe maintenance: "+ edt.Rows[0]["Numero_EquipeM"].ToString();
            
            string direction=null;
            if (dir == "A")
            {
                direction = "Arrivée";
                IDVolLabel.Text = "Maintenance du vol " + vdt.Rows[0]["Code_Compagnie"].ToString()+" " +vdt.Rows[0]["Numero_VolProgramme"].ToString() + "  "+Convert.ToDateTime(dt.Rows[0]["Date_Arrivee_Vol"].ToString()).ToShortDateString();
                AnnuleCheckBox.Visible = false;
            }
            if (dir == "D")
            {
                direction = "Départ";
                IDVolLabel.Text = "Maintenance du vol " + vdt.Rows[0]["Code_Compagnie"].ToString() + " " + vdt.Rows[0]["Numero_VolProgramme"].ToString() + "   " + Convert.ToDateTime(dt.Rows[0]["Date_Depart_Vol"].ToString()).ToShortDateString();
            }


            DirectionVolLabel.Text = "Direction: " + direction;
            operations();
        }

     
        void operations()
        {
            OperationTableAdapter ta = new OperationTableAdapter();
            DataTable dt = ta.GetDataByTypeOperation(dir);
            l = new Label[dt.Rows.Count];
            t = new TextBox[dt.Rows.Count];
            p = new TableLayoutPanel[dt.Rows.Count];
            N=dt.Rows.Count;
            int row = 0;
            int col=-1;
         //  tableLayoutPanel.RowCount = 2;
          // tableLayoutPanel.ColumnCount = 3;
           
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                
                l[i] = new Label();
                l[i].Text = dt.Rows[i]["Nom_Operation"].ToString();
                l[i].Font = new Font("Calibri", 12,FontStyle.Bold);
                l[i].AutoSize = true;
                l[i].ForeColor = Color.FromArgb(21, 49, 126);
                l[i].Name = dt.Rows[i]["Code_Operation"].ToString();
                p[i] = new TableLayoutPanel();
                p[i].ColumnCount = 1;
                p[i].Controls.Add(l[i], 0, 0);
                p[i].AutoSize = true;
                p[i].Padding = new System.Windows.Forms.Padding(5);
                
                
                
               
               
               if (dt.Rows[i]["Type_Reponse_Operation"].ToString() == "YN")
               {
                   p[i].RowCount = 4;
                   RadioButton O = new RadioButton();
                   O.Text = "Oui";
                   O.Tag = "Y";
                   O.Font = new Font("Calibri", 11);
                   O.ForeColor = Color.FromArgb(21, 49, 126);
                   p[i].Controls.Add(O, 0, 1);
                   RadioButton n = new RadioButton();
                   n.Text = "Non";
                   n.Tag = "N";
                   n.Font = new Font("Calibri", 11);
                   n.AutoSize = true;
                   n.ForeColor = Color.FromArgb(21, 49, 126);
                   p[i].Controls.Add(n, 0, 2);
                   p[i].Show();
                   t[i] = new TextBox();
                   t[i].Name = dt.Rows[i]["Code_Operation"].ToString();
                   t[i].Width =250;
                   t[i].Height=40;
                   t[i].Multiline = true;

                   t[i].Text = "Remarques Supplémentaires";
                  // t[i].Font = new Font("Calibri", 12);
                   
                   t[i].ForeColor = Color.FromArgb(21, 49, 126);
                   p[i].Controls.Add(t[i], 0, 3);
                 
               }
               if (dt.Rows[i]["Type_Reponse_Operation"].ToString() == "R")
               {
                   
                   p[i].RowCount = 6;
                  
                   RadioButton TB = new RadioButton();
                   TB.Text = "Très Bien";
                   TB.Tag = "TB";
                   TB.Font = new Font("Calibri", 11);
                   TB.AutoSize = true;
                   TB.ForeColor = Color.FromArgb(21, 49, 126);
                   p[i].Controls.Add(TB, 0, 1);
                   
                   RadioButton B = new RadioButton();
                   B.Text = "Bien";
                   B.Tag = "B";
                   B.Font = new Font("Calibri", 11);
                   B.AutoSize = true;
                   B.ForeColor = Color.FromArgb(21, 49, 126);
                   p[i].Controls.Add(B, 0, 2);

                   RadioButton P = new RadioButton();
                   P.Text = "Passable";
                   P.Tag = "P";
                   P.Font = new Font("Calibri", 11);
                   P.AutoSize = true;
                   P.ForeColor = Color.FromArgb(21, 49, 126);
                   p[i].Controls.Add(P, 0, 3);

                   RadioButton M = new RadioButton();
                   M.Text = "Mauvais";
                   M.Tag = "M";
                   M.Font = new Font("Calibri", 11);
                   M.AutoSize = true;
                   M.ForeColor = Color.FromArgb(21, 49, 126);
                   p[i].Controls.Add(M, 0, 4);
                   p[i].Show();
                   t[i] = new TextBox();
                   t[i].Name = dt.Rows[i]["Code_Operation"].ToString();
                   t[i].Text = "Remarques Supplémentaires";
                   t[i].Width = 250;
                   t[i].Height = 40;
                   t[i].Multiline = true;
                   
                   
                   t[i].ForeColor = Color.FromArgb(21, 49, 126);
                   p[i].Controls.Add(t[i], 0, 5);
               }
               tableLayoutPanel.Controls.Add(p[i], col, row);
              
             
              
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckValidity())
            {
                if(!AnnuleCheckBox.Checked)
                {
                    DialogResult dr= DialogResult.None;
                    if (dir == "D") { dr = MessageBox.Show("Etes vous sûr de vouloir confirmer le rapport et procéder avec le vol?", "Attention", MessageBoxButtons.YesNo); }
                    if (dir == "A") { dr = MessageBox.Show("Etes vous sûr de vouloir confirmer le rapport ?", "Attention", MessageBoxButtons.YesNo); }
                    if(dr==DialogResult.Yes)
                    { 
                Rapport_MaintenanceTableAdapter ta = new Rapport_MaintenanceTableAdapter();
                ta.Insert(DateTime.Now, dir, equipeM, idVol);
                DataTable dt = ta.GetLastInsertedByEquipeID(equipeM);
                int idrapport = Convert.ToInt32(dt.Rows[0]["ID_RapportM"].ToString());
                Resultat_RapportMTableAdapter rta = new Resultat_RapportMTableAdapter();

                for (int i = 0; i < N; ++i)
                {
                    foreach (Control objet in p[i].Controls)
                    {
                        if (objet is RadioButton)
                        {
                            RadioButton radio = objet as RadioButton;
                            if (radio.Checked)
                            {
                                if (radio.Tag == "Y")
                                {
                                    if (t[i].Text == "Remarques Supplementaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "Y", null);
                                    else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "Y", t[i].Text);
                                }
                                if (radio.Tag == "N")
                                {
                                    if (t[i].Text == "Remarques Supplémentaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "N", null);
                                    else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "N", t[i].Text);
                                }

                                if (radio.Tag == "TB")
                                {
                                    if (t[i].Text == "Remarques Supplémentaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "TB", null);
                                    else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "TB", t[i].Text);
                                }
                                if (radio.Tag == "B")
                                {
                                    if (t[i].Text == "Remarques Supplémentaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "B", null);
                                    else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "B", t[i].Text);
                                }
                                if (radio.Tag == "P")
                                {
                                    if (t[i].Text == "Remarques Supplémentaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "P", null);
                                    else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "P", t[i].Text);
                                }
                                if (radio.Tag == "M")
                                {
                                    if (t[i].Text == "Remarques Supplémentaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "M", null);
                                    else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "M", t[i].Text);
                                }
                            }

                        }
                        }
                    }

                


                MessageBox.Show("Rapport maintenance ajouté avec succès!", "Succès", MessageBoxButtons.OK);
                ChangerEtats(idVol, "D");
                this.Close();

                Master_Form mf = (Master_Form)Application.OpenForms.OfType<Master_Form>().ElementAt(0);
                TabPage test = mf.MainTabControl.TabPages["MNT" + idVol];
                test.Dispose();
                    }
            }
            
            else
                {
                    DialogResult dr = MessageBox.Show("Etes vous sûr de vouloir confirmer le rapport et annuler  le vol?", "Attention", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Rapport_MaintenanceTableAdapter ta = new Rapport_MaintenanceTableAdapter();
                        ta.Insert(DateTime.Now, dir, equipeM, idVol);
                        DataTable dt = ta.GetLastInsertedByEquipeID(equipeM);
                        int idrapport = Convert.ToInt32(dt.Rows[0]["ID_RapportM"].ToString());
                        Resultat_RapportMTableAdapter rta = new Resultat_RapportMTableAdapter();

                        for (int i = 0; i < N; ++i)
                        {
                            foreach (Control objet in p[i].Controls)
                            {
                                if (objet is RadioButton)
                                {
                                    RadioButton radio = objet as RadioButton;
                                    if (radio.Checked)
                                    {
                                        if (radio.Tag == "Y")
                                        {
                                            if (t[i].Text == "Remarques Supplementaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "Y", null);
                                            else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "Y", t[i].Text);
                                        }
                                        if (radio.Tag == "N")
                                        {
                                            if (t[i].Text == "Remarques Supplémentaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "N", null);
                                            else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "N", t[i].Text);
                                        }

                                        if (radio.Tag == "TB")
                                        {
                                            if (t[i].Text == "Remarques Supplémentaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "TB", null);
                                            else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "TB", t[i].Text);
                                        }
                                        if (radio.Tag == "B")
                                        {
                                            if (t[i].Text == "Remarques Supplémentaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "B", null);
                                            else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "B", t[i].Text);
                                        }
                                        if (radio.Tag == "P")
                                        {
                                            if (t[i].Text == "Remarques Supplémentaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "P", null);
                                            else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "P", t[i].Text);
                                        }
                                        if (radio.Tag == "M")
                                        {
                                            if (t[i].Text == "Remarques Supplémentaires") rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "M", null);
                                            else rta.Insert(idrapport, Convert.ToInt32(l[i].Name), "M", t[i].Text);
                                        }
                                    }

                                }
                            }
                        }




                        MessageBox.Show("Rapport maintenance ajouté avec succès!", "Succès", MessageBoxButtons.OK);
                        ChangerEtats(idVol, "D");
                        VolTableAdapter tab = new VolTableAdapter();
                        tab.UpdateEtatVolByVolID("AN", idVol);
                        //vol alternatif
                        DialogResult r = MessageBox.Show("Voulez-vous créer un vol alternatif?", "Annuler Le vol", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {
                            using (VolAlternatif myForm = new VolAlternatif(idVol))
                            {
                                DialogResult dr2 = myForm.ShowDialog();
                            }
                        }
                        
                        
                        this.Close();

                        Master_Form mf = (Master_Form)Application.OpenForms.OfType<Master_Form>().ElementAt(0);
                        TabPage test = mf.MainTabControl.TabPages["MNT" + idVol];
                        test.Dispose();
                    }
                }
               




                }
            else { MessageBox.Show("Veuillez remplir toutes les opérations", "Erreur", MessageBoxButtons.OK); }
          
        }

        protected bool CheckValidity()
        {

              for (int i = 0; i < N; ++i)
                {
                  bool valide =false;
                    foreach (Control objet in p[i].Controls)
                    {
                        if (objet is RadioButton)
                        {
                            RadioButton radio = objet as RadioButton;
                            if (radio.Checked) valide=true;
                        }
                    }
                  if(valide==false) return false;
              
              }
              return true;
        }
   
        public void ChangerEtats(int idv,string etat)
        {

            VolTableAdapter vta = new VolTableAdapter();
            DataTable vdt = vta.GetDataByVolID(idv);
            int equipem = Convert.ToInt32(vdt.Rows[0]["Code_EquipeM"].ToString());
            Equipe_MaintenanceTableAdapter eta = new Equipe_MaintenanceTableAdapter();
            eta.UpdateEtatEquipe(etat, equipem);
            InfoPersonnelEquipeMaintenanceTableAdapter ieta = new InfoPersonnelEquipeMaintenanceTableAdapter();
            DataTable mdt = ieta.GetDataByIDEquipeM(equipem);
            Personnel_MaintenanceTableAdapter pta= new Personnel_MaintenanceTableAdapter();
            for (int j = 0; j < mdt.Rows.Count; ++j)
            {
                int perid= Convert.ToInt32(mdt.Rows[j]["ID_PersonnelM"].ToString());
                pta.UpdateEmployeEtat(etat, perid);
            }
        }

    }
}
