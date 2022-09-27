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
    public partial class ABMCPaisForm : Form
    {
        public ABMCPaisForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HabilitarEdicion(bool v)
        {
            lblNombre.Visible= v;
            lblRank.Visible= v;
            lblReg.Visible= v;
            txtNombre.Visible = v;
            TxtRanking.Visible=v;
            cmbBoxRegion.Visible= v;
            btnGuardar.Visible = v;
            btnCancelar.Visible = v;
        }

            private void btnAgregarPais_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
