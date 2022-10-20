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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

       
        

        private void btnCrearPartido_Click(object sender, EventArgs e)
        {
        
        }

        private void btnVerDetallePartido_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCargarDetallePartido_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGestionPais_Click(object sender, EventArgs e)
        {

        }


        private void ToolStipUsuario_Click(object sender, EventArgs e)
        {
            ABMCUsrsForm abmcUsr = new ABMCUsrsForm();
            abmcUsr.Show();
        }

        private void ToolStipPais_Click(object sender, EventArgs e)
        {
            ABMCPaisForm abmcPais = new ABMCPaisForm();
            abmcPais.Show();
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCJugsForm abmcJugs = new ABMCJugsForm();
            abmcJugs.Show();
        }

        private void arbitrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCArbForm abmcArb = new ABMCArbForm();
            abmcArb.Show();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            ABMCPartForm abmcPart = new ABMCPartForm();
            abmcPart.Show();
        }

        private void jugadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteListadoJugadores reporteJug = new ReporteListadoJugadores();
            reporteJug.ShowDialog();
        }
    }
}
