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
    public partial class BoardingPass : Form
    {
        string docname;
        string imageurl;
        public BoardingPass(int pid)
        {
            InitializeComponent();
            menuStrip1.Visible = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.AutoSize = true;
            PassagerTableAdapter pta = new PassagerTableAdapter();
            VilleTableAdapter vta = new VilleTableAdapter();
            DataTable pdt = pta.GetDataByIDPassager(pid);
            int volID = Convert.ToInt32(pdt.Rows[0]["ID_VOL"].ToString());
            InformationsVolsTableAdapter ita =  new InformationsVolsTableAdapter();
            DataTable ivdt = ita.GetDataByIdVol(volID);
            string numerovol = ivdt.Rows[0]["Numero_VolProgramme"].ToString();
            string codevillesource = ivdt.Rows[0]["Code_Ville_Source"].ToString();
            string codevilledestination = ivdt.Rows[0]["Code_Ville_Destination"].ToString();
            DateTime heuredepart = Convert.ToDateTime(ivdt.Rows[0]["Date_Depart_Vol"].ToString());
            DateTime heurearrivee = Convert.ToDateTime(ivdt.Rows[0]["Date_Arrivee_Vol"].ToString());
            string codecompagnie =ivdt.Rows[0]["Code_Compagnie"].ToString();
            string logourl =ivdt.Rows[0]["Logo_Compagnie"].ToString();
            logourl = "../.." + logourl.Substring(1, logourl.Length - 1);
            string aeroportlogourl = "../../images/logo_aeroports_de_paris.gif";
            string firstname = pdt.Rows[0]["Prenom_Passager"].ToString();
            string lastname = pdt.Rows[0]["Nom_Passager"].ToString();
            string sexe = pdt.Rows[0]["Sexe_Passager"].ToString();
            if (sexe == "H") sexe = "MR";
            else sexe = "MS";
            string emplacement = pdt.Rows[0]["Emplacement_Passager"].ToString();
            DataTable vsrc = vta.GetDataByCodeVille(codevillesource);
            DataTable vdes = vta.GetDataByCodeVille(codevilledestination);
            string nomvillesource = vsrc.Rows[0]["Nom_Ville"].ToString();
            string nomvilledestination = vdes.Rows[0]["Nom_Ville"].ToString();
            string classe = "";
            if (emplacement.ElementAt(0)=='E') classe="Economy";
            if (emplacement.ElementAt(0) == 'B') classe = "Buisness";

            Image compagnielogo = Image.FromFile(logourl).GetThumbnailImage(150, 25, null, IntPtr.Zero);;
            Image aeroportlogo = Image.FromFile(aeroportlogourl).GetThumbnailImage(439, 45, null, IntPtr.Zero); ;
            CompagnieLogoPictureBox1.Image = compagnielogo;
            CompagnieLogoPictureBox2.Image = compagnielogo;
            AeroportLogoPictureBox.Image = aeroportlogo;
            NumVolLabel.Text = codecompagnie.ToUpper() + " " + numerovol.ToUpper();
            NumVolLabel2.Text = codecompagnie.ToUpper() + " " + numerovol.ToUpper();
            PassangerNameLabel.Text = lastname.ToUpper() + "\\" + firstname.ToUpper()+"  "+ sexe.ToUpper();
            PassengerNameLabel2.Text = lastname.ToUpper() + "\\" + firstname.ToUpper() + "  " + sexe.ToUpper();
            NomVilleSource.Text = nomvillesource.ToUpper();
            NomVilleDestination.Text = nomvilledestination.ToUpper();
            ClassPlaceLabel.Text = classe.ToUpper() + "\\" + emplacement.ToUpper();
            ClassPlaceLabel2.Text = classe.ToUpper() + "\\" + emplacement.ToUpper();
            HeureDepartLabel.Text = heuredepart.ToShortTimeString().ToUpper();
            HeureArriveeLabel.Text = heurearrivee.ToShortTimeString().ToUpper();
            CodeSrcDepartLabel.Text = codevillesource.ToUpper() + "\\" + heuredepart.ToShortTimeString().ToUpper();
            CodeDesArriveeLabel.Text = codevilledestination.ToUpper() + "\\" + heurearrivee.ToShortTimeString().ToUpper();

            docname= pid.ToString() + lastname + firstname;
            imageurl = "../../images/BoardingPasses/" +docname+".bmp";


        }


        public void ShowMenu()
        {

            menuStrip1.Visible = true;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = docname;
            printDocument1.Print();
        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image bp = Image.FromFile(imageurl);
            e.Graphics.DrawImage(bp, 0, 0);
        }
    }
}
