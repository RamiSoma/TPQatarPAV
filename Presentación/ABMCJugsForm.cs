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
using TPQatarPAVI.Datos.Interfaces;
using TPQatarPAVI.Entidades;

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
            CargarCombo(cmbTipoDoc, tipoDoc.traerTodos());
          
            HabilitarEdicion(false);
            HabilitarRestaurar(false);
            HabilitarBM(false);
        }
        private void HabilitarBM(bool v)
        {
            btnModificar.Visible = v;
            btnEliminar.Visible = v;
        }
        enum Modo
        {
            Alta,
            Modificacion
        }
        Modo modo;
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
            lblPaisFiltro.Visible = v;
            cmbPaisFiltro.Visible = v;
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
            cmbTipoDoc.Visible = v;
            lblTipoDocFijo.Visible = v;
            btnGuardar.Visible = v;
            btnCancelar.Visible = v;
        }
        private void CargarJugador()
        {
            txtNombre.Text = Convert.ToString(dGridJug.SelectedRows[0].Cells[0].Value);
            txtApeJug.Text = Convert.ToString(dGridJug.SelectedRows[0].Cells[1].Value);
            cmbPaisMod.Text = Convert.ToString(dGridJug.SelectedRows[0].Cells[2].Value);
            cmbTipoDoc.Text = Convert.ToString(dGridJug.SelectedRows[0].Cells[3].Value);
            txtNumDoc.Text = Convert.ToString(dGridJug.SelectedRows[0].Cells[4].Value);
        }
        private void button3_Click(object sender, EventArgs e)
        { //Modificar Jugador
            HabilitarEdicion(true);
            HabilitarABMC(false);
            HabilitarRestaurar(false);
            CargarJugador();
            modo = Modo.Modificacion;
            cmbTipoDoc.Enabled = false;
            txtNumDoc.Enabled = false;
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
                                tabla.Rows[i]["gol"],
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
            string tipo_doc= Convert.ToString(dGridJug.SelectedRows[0].Cells[3].Value);
            string nro_doc = Convert.ToString(dGridJug.SelectedRows[0].Cells[4].Value);
            DialogResult rta = MessageBox.Show("¿Estas seguro que deseas eliminar el Jugador seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rta == DialogResult.Yes)
            {
                jugador.eliminarjugador(tipo_doc,nro_doc);
                CargarGrilla(dGridJug, jugador.traerTodos(cmbPaisFiltro.Text));
            }
        }
        private void limpiarCampos(bool v)
        {
            txtNombre.Text = "";
            txtApeJug.Text = "";
            txtNumDoc.Text = "";
            txtNumDoc.Enabled = v;
            cmbTipoDoc.Enabled = v;
            cmbTipoDoc.SelectedIndex = 0;
            cmbPaisMod.SelectedIndex = 0;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarCampos(true);
            HabilitarEdicion(true);
            HabilitarABMC(false);
            HabilitarRestaurar(false);
            CargarCombo(cmbPaisMod, pais.traerTodos("",""));
            modo = Modo.Alta;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtNumDoc.Text);

                if (txtNombre.Text == "" || txtNumDoc.Text == "" || cmbPaisMod.Text == "" || txtApeJug.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (jugador.validar(lblTipoDocFijo.Text, txtNumDoc.Text))
                    {
                        MessageBox.Show("El jugador ingresado ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        HabilitarEdicion(false);
                        if (modo == Modo.Alta)
                        {
                            jugador.crearJugador(cmbTipoDoc.Text,txtNumDoc.Text,txtNombre.Text, txtApeJug.Text, cmbPaisMod.Text);

                        }
                        if (modo == Modo.Modificacion)
                        {
                            jugador.modificarJugador(cmbTipoDoc.Text, txtNumDoc.Text, txtNombre.Text,txtApeJug.Text,cmbPaisMod.Text);
                        }
                        CargarGrilla(dGridJug, jugador.traerTodos(cmbPaisFiltro.Text));
                        HabilitarEdicion(false);
                        HabilitarABMC(true);
                        HabilitarRestaurar(false);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El número de documento debe ser valor numérico...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            HabilitarRestaurar(true);
            HabilitarEdicion(false);
            HabilitarABMC(false);
            CargarGrilla(dGridJug, jugador.traerEliminados());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
            CargarGrilla(dGridJug, jugador.traerTodos(cmbPaisFiltro.Text));
        }

        private void btnRestaurarSeleccion_Click(object sender, EventArgs e)
        {
            string tipo_doc = Convert.ToString(dGridJug.SelectedRows[0].Cells[3].Value);
            string nro_doc = Convert.ToString(dGridJug.SelectedRows[0].Cells[4].Value);
            HabilitarEdicion(false);
            HabilitarABMC(true);
            HabilitarRestaurar(false);
            jugador.recuperarJugador(tipo_doc, nro_doc);
            CargarGrilla(dGridJug, jugador.traerTodos(cmbPaisFiltro.Text));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla(dGridJug, jugador.traerTodos(cmbPaisFiltro.Text));
            HabilitarBM(true);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dGridJug.Rows.Clear();
            HabilitarBM(false);
        }
    }
}
