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
        private void CargarCombo(ComboBox combo, DataTable tabla, bool esFiltro)
        {
            if (esFiltro)
            {
                DataRow row = tabla.NewRow();
                row[tabla.Columns[0].ColumnName]="Todos";
                tabla.Rows.InsertAt(row,0);
            };
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
            lblGrupoFiltro.Visible = v;
            cmbGrupoFiltro.Visible = v;
            lblRondaFiltro.Visible = v;
            cmbRondaFiltro.Visible = v;
        }
        private void habilitarAM(bool v)
        {
            lblId.Visible = v;
            lblIdMostrar.Visible = v;
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
        private void habilitarRest(bool v)
        {
            btnRestaurarSeleccion.Visible = v;
            btnCancelarRest.Visible = v;
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id"],
                                tabla.Rows[i]["ronda"],
                                tabla.Rows[i]["pais_1"],
                                tabla.Rows[i]["pais_2"],
                                tabla.Rows[i]["nombreArbitro"],
                                tabla.Rows[i]["estadio"],
                                tabla.Rows[i]["grupo"]);
            }
        }
        private void CargarPartido()
        {
            lblIdMostrar.Text = Convert.ToString(dGridPartido.SelectedRows[0].Cells[0].Value);
            cmbRonda.Text = Convert.ToString(dGridPartido.SelectedRows[0].Cells[1].Value);
            cmbPaisLocal.Text = Convert.ToString(dGridPartido.SelectedRows[0].Cells[2].Value);
            cmbPaisVisitante.Text = Convert.ToString(dGridPartido.SelectedRows[0].Cells[3].Value);
            cmbArb.Text = Convert.ToString(dGridPartido.SelectedRows[0].Cells[4].Value);
            cmbEstadio.Text = Convert.ToString(dGridPartido.SelectedRows[0].Cells[5].Value);
            cmbGrupo.Text = Convert.ToString(dGridPartido.SelectedRows[0].Cells[6].Value);
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpiarCombos()
        {
            CargarCombo(cmbRonda, rnd.traerTodos(), false);
            CargarCombo(cmbGrupo, grupo.traerTodos(), false);
            CargarCombo(cmbPaisLocal, pais.traerPorGrupo(cmbGrupo.Text), false);
            CargarCombo(cmbPaisVisitante, pais.traerPorGrupo(cmbGrupo.Text), false);
            CargarCombo(cmbArb, arb.traerTodos(), false);
            CargarCombo(cmbEstadio, est.traerTodos(), false);
            CargarCombo(cmbEstadioFiltro, est.traerTodos(), true);
            CargarCombo(cmbRondaFiltro, rnd.traerTodos(), false);
            CargarCombo(cmbPaisFiltro, pais.traerPorGrupo(cmbGrupoFiltro.Text), true);
            CargarCombo(cmbGrupoFiltro, grupo.traerTodos(), false); // si se pasa a true da error
        }

        private void ABMCPartForm_Load(object sender, EventArgs e)
        {
            habilitarAM(false);
            habilitarRest(false);
            limpiarCombos();
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
                CargarCombo(cmbPaisVisitante, pais.traerPorGrupo(cmbGrupo.Text), false);
            }
            else
            {
                CargarCombo(cmbPaisLocal, pais.traerTodos("",""), false);
                CargarCombo(cmbPaisVisitante, pais.traerTodos("", ""), false);
                cmbGrupo.Visible = false;
                lblTxtGrupo.Visible = false;
            };
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarAM(true);
            habilitarBusq(false);
            modo = Modo.Modificacion;
            CargarPartido();
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
                limpiarCombos();
                part.crearPartido(cmbPaisLocal.Text, cmbPaisVisitante.Text,cmbRonda.Text,cmbGrupo.Text,cmbEstadio.Text, cmbArb.Text);
                
            }
            if (modo == Modo.Modificacion)
            {
                part.modificarPartido(lblIdMostrar.Text,cmbPaisLocal.Text, cmbPaisVisitante.Text, cmbRonda.Text, cmbGrupo.Text, cmbEstadio.Text, cmbArb.Text);
            }
            habilitarAM(false);
            habilitarBusq(true);
            CargarGrilla(dGridPartido, part.buscarPartidos(cmbRondaFiltro.Text, cmbGrupoFiltro.Text, cmbEstadioFiltro.Text, cmbPaisFiltro.Text));
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCombo(cmbPaisLocal, pais.traerPorGrupo(cmbGrupo.Text), false);
            CargarCombo(cmbPaisVisitante, pais.traerPorGrupo(cmbGrupo.Text), false);
        }

        private void cmbPaisFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCombo(cmbPaisFiltro, pais.traerPorGrupo(cmbGrupoFiltro.Text), true);
        }

        private void cmbGrupoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRondaFiltro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbRondaFiltro.Text == "Fase de Grupo")
            {
                lblGrupoFiltro.Visible = true;
                cmbGrupoFiltro.Visible = true;
                CargarCombo(cmbPaisFiltro, pais.traerPorGrupo(cmbGrupoFiltro.Text), true);
            }
            else
            {
                lblGrupoFiltro.Visible = false;
                cmbGrupoFiltro.Visible = false;
                CargarCombo(cmbPaisFiltro, pais.traerTodos("",""), true);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla(dGridPartido, part.buscarPartidos(cmbRondaFiltro.Text, cmbGrupoFiltro.Text, cmbEstadioFiltro.Text,cmbPaisFiltro.Text));
        }

        private void cmbPaisFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idPartido = Convert.ToString(dGridPartido.SelectedRows[0].Cells[0].Value);
            DialogResult rta = MessageBox.Show("¿Estas seguro que deseas eliminar el partido seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rta == DialogResult.Yes)
            {
                part.eliminarPartido(idPartido);
                CargarGrilla(dGridPartido, part.buscarPartidos(cmbRondaFiltro.Text, cmbGrupoFiltro.Text, cmbEstadioFiltro.Text, cmbPaisFiltro.Text));
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            CargarGrilla(dGridPartido, part.traerEliminados());
            habilitarAM(false);
            habilitarBusq(false);
            habilitarRest(true);
        }

        private void btnRestaurarSeleccion_Click(object sender, EventArgs e)
        {
            habilitarRest(false);
            habilitarBusq(true);
            string idPartido = Convert.ToString(dGridPartido.SelectedRows[0].Cells[0].Value);
            part.recuperarPartido(idPartido);
            CargarGrilla(dGridPartido, part.buscarPartidos(cmbRondaFiltro.Text, cmbGrupoFiltro.Text, cmbEstadioFiltro.Text, cmbPaisFiltro.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dGridPartido.Rows.Clear();
        }

        private void btnCancelarRest_Click(object sender, EventArgs e)
        {
            CargarGrilla(dGridPartido, part.buscarPartidos(cmbRondaFiltro.Text, cmbGrupoFiltro.Text, cmbEstadioFiltro.Text, cmbPaisFiltro.Text));
        }
    }
    
}
