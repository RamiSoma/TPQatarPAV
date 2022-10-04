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
using TPQatarPAVI.Entidades;

namespace TPQatarPAVI.Presentación
{
    public partial class ABMCArbForm : Form
    {
        ArbitroService arb = new ArbitroService();
        PaisService pais = new PaisService();
        TipoDocService tipoDoc = new TipoDocService();
        enum Modo
        {
            Alta,
            Modificacion
        }
        Modo modo;

        public ABMCArbForm()
        {
            InitializeComponent();
            btnRestaurarSeleccion.Visible = false;
            btnCancelarRest.Visible = false;
        }



        private void ABMCArbForm_Load(object sender, EventArgs e)
        {

            CargarCombo(cmbPaisFiltro, pais.traerTodos("",""));
            CargarCombo(cmbPaisMod, pais.traerTodos("",""));
            HabilitarEdicion(false);
            HabilitarRestaurar(false);
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = 0;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
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
                                tabla.Rows[i]["Nro_Doc"]);
            }
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
            cmbPaisFiltro.Visible = v;
            lblPaisFiltro.Visible = v;
            lblFiltroIDArb.Visible = v;
            txtFiltroDoc.Visible = v;
            lblTipoDocFiltro.Visible = v;
            cmbFiltroTipoDoc.Visible = v;
            btnLimpiar.Visible = v;
            btnBuscar.Visible = v;
        }


        private void HabilitarEdicion(bool v)
        {
            lblNomArb.Visible = v;
            lblTipoDocFijo.Visible = v;
            txtNombre.Visible = v;
            lblApeArb.Visible = v;
            txtApeArb.Visible = v;
            lblPais.Visible = v;
            btnGuardar.Visible = v;
            btnCancelar.Visible = v;
            lblTipoDocMod.Visible = v;
            cmbPaisMod.Visible = v;
            lblNumDocMod.Visible = v;
            txtNumDoc.Visible = v;
        }
        private void CargarUsr()
        {
            txtNombre.Text = Convert.ToString(dGridArb.SelectedRows[0].Cells[0].Value);
            txtApeArb.Text = Convert.ToString(dGridArb.SelectedRows[0].Cells[1].Value);
            cmbPaisMod.Text = Convert.ToString(dGridArb.SelectedRows[0].Cells[2].Value);
            lblTipoDocFijo.Text = Convert.ToString(dGridArb.SelectedRows[0].Cells[3].Value);
            txtNumDoc.Text = Convert.ToString(dGridArb.SelectedRows[0].Cells[4].Value);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
            CargarUsr();
            modo = Modo.Modificacion;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
            cmbPaisMod.SelectedIndex = 0;
            txtNombre.Text = "";
            txtApeArb.Text = "";
            lblTipoDocFijo.Visible = true;
            txtNumDoc.Text = "";
            modo = Modo.Alta;
        }

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    CargarGrilla(dGridArb, arb.traerTodos(cmbPaisFiltro.Text, cmbFiltroTipoDoc.Text, txtFiltroDoc.Text));
        //}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dGridArb.DataSource = null;
            dGridArb.Rows.Clear();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

