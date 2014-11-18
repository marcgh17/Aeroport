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
    public partial class Webtest : Form
    {
        public Webtest()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://localhost:18790/WelcomePage.aspx");
  
        }
    }
}
