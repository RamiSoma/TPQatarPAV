using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPQatarPAVI.CapaServicios;

namespace TPQatarPAVI.Presentación
{
    public partial class ABMCPartForm : Form
    {
        RondaService rnd = new RondaService();
        GrupoService grupo = new GrupoService();
        PaisService pais = new PaisService();
        ArbitroService arb = new ArbitroService();
        EstadioService est = new EstadioService();
        PartidoService part = new PartidoService();
        enum Modo
        {
            Alta,
            Modificacion
        }
        Modo modo;
        public ABMCPartForm()
        {
            InitializeComponent();
            
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[0].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = 0;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void habilitarBusq(bool v)
        {
            lblEstadioFIltro.Visible = v;
            cmbEstadioFiltro.Visible = v;
            lblPaisFiltro.Visible = v;
            cmbPaisFiltro.Visible = v;
            btnBuscar.Visible = v;
            btnLimpiar.Visible = v;
        }
        private void habilitarAM(bool v)
        {
            lblId.Visible = v;
            lblRonda.Visible = v;
            cmbRonda.Visible = v;
            lblLocal.Visible = v;
            cmbPaisLocal.Visible = v;
            cmbPaisVisitante.Visible = v;
            lblVisitante.Visible = v;
            lblArb.Visible = v;
            cmbArb.Visible = v;
            lblEstadio.Visible = v;
            cmbEstadio.Visible = v;
            btnCancelar.Visible = v;
            btnGuardar.Visible = v;
            cmbGrupo.Visible = v;
            lblTxtGrupo.Visible = v;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ABMCPartForm_Load(object sender, EventArgs e)
        {
            habilitarAM(false);
            CargarCombo(cmbRonda, rnd.traerTodos());
            CargarCombo(cmbGrupo, grupo.traerTodos());
            CargarCombo(cmbPaisLocal, pais.traerPorGrupo(cmbGrupo.Text));
            CargarCombo(cmbPaisVisitante, pais.traerPorGrupo(cmbGrupo.Text));
            CargarCombo(cmbArb, arb.traerTodos());
            CargarCombo(cmbEstadio, est.traerTodos());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            habilitarAM(true);
            habilitarBusq(false);
            modo = Modo.Alta;
        }

        private void cmbRonda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRonda.Text == "Fase de Grupo")
            {
                cmbGrupo.Visible = true;
                lblTxtGrupo.Visible = true;
            }
            else
            {
                cmbGrupo.Visible = false;
                lblTxtGrupo.Visible = false;
            };
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarAM(true);
            habilitarBusq(false);
            modo = Modo.Modificacion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarAM(false);
            habilitarBusq(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(modo == Modo.Alta)
            {
                /*part.crearPartido();*/
            }
            else
            {

            }
            habilitarAM(true);
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCombo(cmbPaisLocal, pais.traerPorGrupo(cmbGrupo.Text));
            CargarCombo(cmbPaisVisitante, pais.traerPorGrupo(cmbGrupo.Text));
        }
    }
}
