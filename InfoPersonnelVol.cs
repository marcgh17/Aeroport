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
    public partial class InfoPersonnelVol : Form
    {
        int pid;
        public InfoPersonnelVol(int pid)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.pid = pid;
            Personnel_VolTableAdapter ta = new Personnel_VolTableAdapter();
            DataTable dt = ta.GetDataByIDPersonnelVol(pid);
            PersonnelDeVolLabel.Text = dt.Rows[0]["Nom_PersonnelV"].ToString() + "  " + dt.Rows[0]["Prenom_PersonnelV"].ToString();
            string role = dt.Rows[0]["Role_PersonnelV"].ToString();
            if (role == "P")
            {
                RoleLabel.Text = "Pilote";
                pictureBoxRole.Image = Image.FromFile("../../images/Icons/P.png");
            }
            if (role == "H")
            {
                RoleLabel.Text = "Hôtesse de l'air";
                pictureBoxRole.Image = Image.FromFile("../../images/Icons/H.png");
            }
            if (role == "S")
            {
                RoleLabel.Text = "Steward";
                pictureBoxRole.Image = Image.FromFile("../../images/Icons/S.png");
            }
            DateNaissanceLabel.Text = Convert.ToDateTime(dt.Rows[0]["Date_Naissannce_PersonnelV"].ToString()).ToShortDateString();
            DateEmbaucheLabel.Text = Convert.ToDateTime(dt.Rows[0]["Date_Embauche_PersonnelV"].ToString()).ToShortDateString();
            string codeComp = dt.Rows[0]["Code_Compagnie"].ToString();
            CompagnieTableAdapter cta = new CompagnieTableAdapter();
            DataTable cdt = cta.GetDataByCode(codeComp);

            string logourl = cdt.Rows[0]["Logo_Compagnie"].ToString();
            logourl = "../.." + logourl.Substring(1, logourl.Length - 1);
            CompagnieLogoPictureBox.Image = (Image.FromFile(logourl)).GetThumbnailImage(150, 25, null, IntPtr.Zero);
            CompagnieLabel.Text = cdt.Rows[0]["Nom_Compagnie"].ToString();
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
