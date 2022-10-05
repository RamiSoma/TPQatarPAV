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

            CargarCombo(cmbPaisFiltro, pais.traerTodos("", ""), true);
            CargarCombo(cmbPaisMod, pais.traerTodos("",""), false);
            CargarCombo(cmbTipoDoc, tipoDoc.traerTodos(), false);
            HabilitarEdicion(false);
            HabilitarRestaurar(false);
        }
        private void CargarCombo(ComboBox combo, DataTable tabla, bool esFiltro)
        {
            if (esFiltro)
            {
                DataRow row = tabla.NewRow();
                row[tabla.Columns[0].ColumnName] = "Todos";
                tabla.Rows.InsertAt(row, 0);
            };
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[0].ColumnName;
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
            btnLimpiar.Visible = v;
            btnBuscar.Visible = v;
            txtNombreFiltro.Visible = v;
            lblNombreFiltro.Visible = v;
        }


        private void HabilitarEdicion(bool v)
        {
            lblNomArb.Visible = v;
            cmbTipoDoc.Visible = v;
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
        private void HabilitarBusq(bool v)
        {
            lblNombreFiltro.Visible = v;
            txtNombreFiltro.Visible = v;
            lblPaisFiltro.Visible = v;
            cmbPaisFiltro.Visible = v;
            btnBuscar.Visible = v;
            btnLimpiar.Visible = v;
        }
        public void limpiarCampos()
        {
            cmbPaisMod.SelectedIndex = 0;
            txtNombre.Text = "";
            txtApeArb.Text = "";
            cmbTipoDoc.Visible = true;
            txtNumDoc.Text = "";
        }
        private void CargarUsr()
        {
            txtNombre.Text = Convert.ToString(dGridArb.SelectedRows[0].Cells[0].Value);
            txtApeArb.Text = Convert.ToString(dGridArb.SelectedRows[0].Cells[1].Value);
            cmbPaisMod.Text = Convert.ToString(dGridArb.SelectedRows[0].Cells[2].Value);
            cmbTipoDoc.Text = Convert.ToString(dGridArb.SelectedRows[0].Cells[3].Value);
            txtNumDoc.Text = Convert.ToString(dGridArb.SelectedRows[0].Cells[4].Value);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
            CargarUsr();
            modo = Modo.Modificacion;
            cmbTipoDoc.Enabled = false;
            txtNumDoc.Enabled = false;
        }

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla(dGridArb, arb.traerFiltrado(txtNombreFiltro.Text, cmbPaisFiltro.Text));
        }
        private void limpiarCampos(bool v)
        {
            txtNombre.Text = "";
            txtApeArb.Text = "";
            txtNumDoc.Text = "";
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            limpiarCampos(true);
            HabilitarEdicion(true);
            HabilitarBusq(false);
            limpiarCampos();
            modo = Modo.Alta;
        }

        private void cmbPaisMod_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtNumDoc.Text);
                if (txtNombre.Text == "" || txtNumDoc.Text == "" || txtApeArb.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (modo == Modo.Alta)
                    {
                        //limpiarCombos();
                        arb.crearArbitro(txtNombre.Text, txtApeArb.Text, cmbPaisMod.Text, cmbTipoDoc.Text, txtNumDoc.Text);
                    }
                    if (modo == Modo.Modificacion)
                    {
                        arb.modificarArbitro(txtNombre.Text, txtApeArb.Text, cmbPaisMod.Text, cmbTipoDoc.Text, txtNumDoc.Text);
                    }
                    cmbTipoDoc.Enabled = true;
                    txtNumDoc.Enabled = true;
                    HabilitarBusq(true);
                    HabilitarEdicion(false);
                    CargarGrilla(dGridArb, arb.traerFiltrado(txtNombreFiltro.Text, cmbPaisFiltro.Text));
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("El número de documento debe ser valor numérico...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarBusq(true);
            HabilitarEdicion(false);
            cmbTipoDoc.Enabled = true;
            txtNumDoc.Enabled = true;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            string tipo_doc = Convert.ToString(dGridArb.SelectedRows[0].Cells[3].Value);
            string nro_doc = Convert.ToString(dGridArb.SelectedRows[0].Cells[4].Value);
            DialogResult rta = MessageBox.Show("¿Estas seguro que deseas eliminar el Arbitro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rta == DialogResult.Yes)
            {
                arb.eliminarArb(tipo_doc, nro_doc);
                CargarGrilla(dGridArb, arb.traerFiltrado(txtNombreFiltro.Text, cmbPaisFiltro.Text));
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            HabilitarRestaurar(true);
            HabilitarEdicion(false);
            HabilitarABMC(false);
            CargarGrilla(dGridArb, arb.traerEliminados());
        }

        private void btnRestaurarSeleccion_Click(object sender, EventArgs e)
        {
            string tipo_doc = Convert.ToString(dGridArb.SelectedRows[0].Cells[3].Value);
            string nro_doc = Convert.ToString(dGridArb.SelectedRows[0].Cells[4].Value);
            arb.restaurarArb(tipo_doc, nro_doc);
            HabilitarRestaurar(false);
            HabilitarABMC(true);
            CargarGrilla(dGridArb, arb.traerFiltrado(txtNombreFiltro.Text, cmbPaisFiltro.Text));
        }

        private void btnCancelarRest_Click(object sender, EventArgs e)
        {
            HabilitarRestaurar(false);
            HabilitarABMC(true);
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNombreFiltro.Text = "";
            dGridArb.DataSource = null;
            dGridArb.Rows.Clear();
        }
    }
}

