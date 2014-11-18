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
    public partial class PassagersPerdus : Form
    {
        public PassagersPerdus(int idVol)
        {
            InitializeComponent();
            PassagerDataGridView.AutoGenerateColumns = false;
            PassagerTableAdapter pta = new PassagerTableAdapter();
            DataTable pdt = pta.GetDataByIDVolAndEtatPassager("CI", idVol);
            PassagerDataGridView.DataSource = pdt;
            for (int i = 0; i < PassagerDataGridView.Rows.Count; ++i)
            {

                string sexe = PassagerDataGridView.Rows[i].Cells["Sexe"].Value.ToString();
                if (sexe == "F") PassagerDataGridView.Rows[i].Cells["Sexe"].Value = "Femme";
                if (sexe == "H") PassagerDataGridView.Rows[i].Cells["Sexe"].Value = "Homme";
            }
        }

        private void AttendreButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void IgnorerButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
