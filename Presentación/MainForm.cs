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
            btnCrearPartido.Visible = false;
            btnVerDetallePartido.Visible = false;
            btnCargarDetallePartido.Visible = false;
        }

        private void btnGestUsu_Click(object sender, EventArgs e)
        {
            ABMCUsrsForm abmcUsr = new ABMCUsrsForm();
            abmcUsr.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
