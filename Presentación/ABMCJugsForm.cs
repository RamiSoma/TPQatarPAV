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
    public partial class ABMCJugsForm : Form
    {
        PaisService pais= new PaisService();
        TipoDocService tipoDoc = new TipoDocService();
        JugadorService jugador = new JugadorService();
        public ABMCJugsForm()
        {
            InitializeComponent();
            CargarCombo(cmbPaisFiltro, pais.traerTodos("",""));
            CargarCombo(cmbPaisMod, pais.traerTodos("", ""));
            
            HabilitarEdicion(false);
            HabilitarRestaurar(false);
        }

        private void HabilitarRestaurar(bool v)
        {
            btnCancelarRest.Visible = v;
            btnRestaurarSeleccion.Visible = v;
        }
        private void HabilitarABMC(bool v)
        {
            btnAgregar.Visible = v;
            btnEliminar.Visible = v;
            btnModificar.Visible = v;
            btnRestaurar.Visible = v;
            btnRestaurarSeleccion.Visible = !v;
            btnCancelarRest.Visible = !v;
            cmbFiltroTipoDoc.Visible = v;
            lblFiltroNroDoc.Visible = v;
            lblPaisFiltro.Visible = v;
            lblTipoDocFiltro.Visible = v;
            cmbPaisFiltro.Visible = v;
            txtFiltroDoc.Visible = v;
            btnBuscar.Visible = v;
            btnLimpiar.Visible = v;

        }
        private void HabilitarEdicion(bool v)
        {
            lblApeJug.Visible = v;
            lblNomJug.Visible = v;
            lblTipoDocRes.Visible = v;
            lblNroDocRes.Visible = v;
            lblPais.Visible = v;
            txtNombre.Visible = v;
            txtApeJug.Visible = v;
            cmbPaisMod.Visible= v;
            txtNumDoc.Visible = v;
            lblTipoDocFijo.Visible = v;
            btnGuardar.Visible = v;
            btnCancelar.Visible = v;
        }
        private void button3_Click(object sender, EventArgs e)
        { //Modificar Jugador
            HabilitarEdicion(true);
            HabilitarABMC(false);
            HabilitarRestaurar(false);
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["pais"],
                                tabla.Rows[i]["tipo_doc"],
                                tabla.Rows[i]["nro_doc"],
                                tabla.Rows[i]["goles"],
                                tabla.Rows[i]["asistencias"],
                                tabla.Rows[i]["tarjetas_amarillas"],
                                tabla.Rows[i]["tarjetas_rojas"]);
            }
        }
        private void ABMCArbForm_Load(object sender, EventArgs e)
        {

        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[0].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = 0;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dGridJug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
            HabilitarABMC(false);
            HabilitarRestaurar(false);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            HabilitarRestaurar(true);
            HabilitarEdicion(false);
            HabilitarABMC(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(false);
            HabilitarABMC(true);
            HabilitarRestaurar(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(false);
            HabilitarABMC(true);
            HabilitarRestaurar(false);
        }

        private void btnCancelarRest_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(false);
            HabilitarABMC(true);
            HabilitarRestaurar(false);
        }

        private void btnRestaurarSeleccion_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(false);
            HabilitarABMC(true);
            HabilitarRestaurar(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla(dGridJug, jugador.traerTodos(cmbPaisFiltro.Text));
        }
    }
}
