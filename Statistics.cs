using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroport_Application
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AeroportDataSet.CompagniesVolsStat' table. You can move, or remove it, as needed.
            this.compagniesVolsTableAdapter.Fill(this.AeroportDataSet.CompagniesVolsStat, DateTime.Today.AddDays(1));
         
            // TODO: This line of code loads data into the 'AeroportDataSet.ArriveesStat' table. You can move, or remove it, as needed.
            this.arriveesStatTableAdapter.Fill(this.AeroportDataSet.ArriveesStat,DateTime.Today.AddDays(1));
            // TODO: This line of code loads data into the 'AeroportDataSet.DepartsStat' table. You can move, or remove it, as needed.
            this.DepartsStatTableAdapter.Fill(this.AeroportDataSet.DepartsStat,DateTime.Today.AddDays(1));

            this.reportViewer1.RefreshReport();
            
        }
    }
}
