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
    public partial class ChoisirCode : Form
    {
        public ChoisirCode()
        {
            InitializeComponent();
        }

        public string GetCode()
        {

            return CodeTextBox.Text;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
