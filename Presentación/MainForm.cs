using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQatarPAVI.Presentación
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGestUsu_Click(object sender, EventArgs e)
        {
            ABMCUsrsForm abmcUsr = new ABMCUsrsForm();
            abmcUsr.Show();
        }
    }
}
