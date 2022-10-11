using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPQatarPAVI.CapaServicios;
using TPQatarPAVI.Entidades;

namespace TPQatarPAVI.Presentación
{
    public partial class ABMCPaisForm : Form
    {
        PaisService pais = new PaisService();
        ContinenteService continente = new ContinenteService();
        GrupoService grupo = new GrupoService();
        enum Modo
        {
            Alta,
            Modificacion
        }
        Modo modo;

        public ABMCPaisForm()
        {
            InitializeComponent();
            HabilitarBM(false);
        }
        private void HabilitarBM (bool v)
        {
            btnModificarPais.Visible = v;
            btnEliminarPais.Visible = v;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["continente"],
                                tabla.Rows[i]["ranking_fifa"],
                                tabla.Rows[i]["id_Grupo"]);
            }
        }
        private void HabilitarRestaurar(bool v)
        {
            btnCancelarRest.Visible = v;
            btnRestaurarSeleccion.Visible = v;
        }
        private void HabilitarABMC(bool v)
        {
            btnAgregarPais.Visible = v;
            btnEliminarPais.Visible = v;
            btnModificarPais.Visible = v;
            btnRestaurar.Visible = v;
            btnRestaurarSeleccion.Visible = !v;
            btnCancelarRest.Visible = !v;
            lblNomFiltro.Visible = v;
            txtFiltroNombre.Visible = v;
            cmbContinenteFiltro.Visible = v;
            btnBuscarPrfl.Visible = v;
            btnLimpiarFiltro.Visible = v;
            lblContFiltro.Visible = v;
        
        }
        private void HabilitarEdicion(bool v)
        {
            lblNombre.Visible= v;
            lblRank.Visible= v;
            lblReg.Visible= v;
            txtNombre.Visible = v;
            txtRanking.Visible=v;
            cmbBoxContinente.Visible= v;
            btnGuardar.Visible = v;
            btnCancelar.Visible = v;
            lblGrupo.Visible= v;
            cmbBoxGrupo.Visible= v;
        }
        private void limpiarEdicion(bool v)
        {
            txtNombre.Text = "";
            txtRanking.Text = "";
            txtNombre.Enabled= v;
            
        }

        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            limpiarEdicion(true);
            HabilitarEdicion(true);
            CargarCombo(cmbBoxGrupo, grupo.traerTodos()); //cargar combo grupos
            modo = Modo.Alta;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //btnBuscarFiltro
        {
            CargarGrilla(dGridPaises, pais.traerTodos(txtFiltroNombre.Text, cmbContinenteFiltro.Text));
            HabilitarBM(true);
        }

        private void ABMCPaisForm_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbContinenteFiltro, continente.traerTodos());
            CargarCombo(cmbBoxContinente, continente.traerTodos());
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

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Limpiar el combobox
        {
            dGridPaises.DataSource = null;
            dGridPaises.Rows.Clear();
            txtFiltroNombre.Text = "";
            HabilitarBM(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtRanking.Text);

                if (txtNombre.Text == "" || txtRanking.Text == "" || cmbBoxContinente.Text == "" || cmbBoxGrupo.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (pais.validar(txtNombre.Text,txtRanking.Text))
                    {
                        MessageBox.Show("El país ingresado ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        HabilitarEdicion(false);
                        if (modo == Modo.Alta)
                        {
                            

                            pais.crearPais(txtNombre.Text, txtRanking.Text, cmbBoxContinente.Text, cmbBoxGrupo.Text);
                        }
                        if (modo == Modo.Modificacion)
                        {
                            pais.modificarPais(txtNombre.Text, cmbBoxContinente.Text, txtRanking.Text, cmbBoxGrupo.Text);
                        }
                        CargarGrilla(dGridPaises, pais.traerTodos(txtFiltroNombre.Text, cmbContinenteFiltro.Text));
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El ranking fifa debe ser valor numérico...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtRanking_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarPais_Click(object sender, EventArgs e)
        {
            string idPais = Convert.ToString(dGridPaises.SelectedRows[0].Cells[0].Value);
            DialogResult rta = MessageBox.Show("¿Estas seguro que deseas eliminar el pais seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rta == DialogResult.Yes)
            {
                pais.eliminarUsr(idPais);
                CargarGrilla(dGridPaises, pais.traerTodos(txtFiltroNombre.Text, cmbContinenteFiltro.Text));
            }
        }
        private void CargarPais()
        {
            txtNombre.Text = Convert.ToString(dGridPaises.SelectedRows[0].Cells[0].Value);
            cmbBoxContinente.Text = Convert.ToString(dGridPaises.SelectedRows[0].Cells[1].Value);
            txtRanking.Text = Convert.ToString(dGridPaises.SelectedRows[0].Cells[2].Value);
            cmbBoxGrupo.Text = Convert.ToString(dGridPaises.SelectedRows[0].Cells[3].Value);
        }

        private void btnModificarPais_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
            CargarPais();
            modo = Modo.Modificacion;
            txtNombre.Enabled = false;
        }

       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(false);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            CargarGrilla(dGridPaises, pais.traerEliminados());
            HabilitarABMC(false);
            HabilitarRestaurar(true);
            HabilitarEdicion(false);
        }

        private void btnRestaurarSeleccion_Click(object sender, EventArgs e)
        {

            HabilitarABMC(true);
            HabilitarRestaurar(false);
            HabilitarEdicion(false);
            CargarPais();
            pais.recuperarPais(txtNombre.Text);
            CargarGrilla(dGridPaises, pais.traerTodos(txtFiltroNombre.Text, cmbContinenteFiltro.Text));
        }

        private void btnCancelarRest_Click(object sender, EventArgs e)
        {
            HabilitarABMC(true);
            HabilitarRestaurar(false);
            CargarPais();
            pais.recuperarPais(txtNombre.Text);
            CargarGrilla(dGridPaises, pais.traerTodos(txtFiltroNombre.Text, cmbContinenteFiltro.Text));
        }
    }
}
